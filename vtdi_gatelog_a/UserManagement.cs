using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtdi_gatelog_a
{
    public partial class UserManagement : Form
    {
        private vtdi_gate_log_dbEntities1 _dbContext;
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            try
            {
                _dbContext = new vtdi_gate_log_dbEntities1();

                //Populate the Gender Dropdown
                //Get The Genders from the database
                var genders = _dbContext.Genders.ToList();
                //Set the datasource of the combobox to the records
                //being retrieved from the database
                cbGenders.DataSource = genders;
                //Set the data member and value member to the values
                //that correspond with the columns coming back from 
                //our data source. 
                cbGenders.DisplayMember = "name";
                cbGenders.ValueMember = "id";

                //Populate The Grid View
                RefreshGridView();

                //Manually set the text you want for the column headers. You may want more user and reader friendly
                //headers than what you database column names may afford you.
                gvUsers.Columns["FirstName"].HeaderText = "First Name";
                gvUsers.Columns["LastName"].HeaderText = "Last Name";
                gvUsers.Columns["Name"].HeaderText = "Gender";
                gvUsers.Columns["Email"].HeaderText = "Email Address";
                gvUsers.Columns["Username"].HeaderText = "Username";

                //Hide columns that you do not want to display for users
                gvUsers.Columns[0].Visible = false;
                //Set the first row as selected by default
                gvUsers.Rows[0].Selected = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //try {...} catch {...} is how you handle exceptions. I t is always a good idea to wrap complex operations inside
            //this code block and monitor for any errors that might appear and prevent program crashes. 
            try
            {
                //Collect data from the form
                var fname = tbFirstName.Text;
                var lname = tbLastName.Text;
                var email = tbEmailAddress.Text;
                var username = tbUsername.Text;
                var gender = Convert.ToInt32(cbGenders.SelectedValue);

                var rand = new Random();
                //This is my random generation of a password. I am using the first letter of the given first name,
                //the last name and a random number generated between 1 and 100.
                //This password NEEDS TO BE ENCRYPTED!!!! We will cover that
                var password = $"{fname[0]}{lname}{rand.Next(0, 100)}";
                //Validate minimum data is collected, as well as any other validation that you may want to enforce.
                if (isFormInvalid())
                {
                    MessageBox.Show("Please validate all data before submission!");
                }
                //Do further validations to checck for username and email address
                else if (CheckEmail(email) || CheckUserName(username))
                {
                    MessageBox.Show("A user exists with this email/username!");
                }
                else
                {
                    var user = new User
                    {
                        FirstName = fname,
                        LastName = lname,
                        Email = email,
                        Username = username,
                        GenderId = gender,
                        Password = password,
                        DateCreated = DateTime.Now
                    };

                    _dbContext.Users.Add(user);
                    _dbContext.SaveChanges();
                    //Functions to Reset the fields to blank and reload all the data in the GridView
                    //The reload makes the changes appear near real-time.
                    RefreshGridView();
                    ResetForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There has been a fatal error: {ex.Message}");
            }
            

        }

        

        void ResetForm()
        {
            tbFirstName.Clear();
            tbLastName.Clear();
            tbEmailAddress.Clear();
            tbUsername.Clear();
            cbGenders.SelectedIndex = 0;
        }

        void RefreshGridView()
        {
            var users = _dbContext.Users.Select(q => new {
                q.Id,
                q.FirstName,
                q.LastName,
                q.Gender.Name,
                q.Email,
                q.Username
            }).ToList();
            gvUsers.DataSource = users;
            gvUsers.Refresh();
        }

        bool CheckEmail(string email)
        {
            var emailExists = _dbContext.Users.Any(q => q.Email.Trim() == email.Trim());
            return emailExists;
        }

        bool CheckUserName(string username)
        {
            var usernameExists = _dbContext.Users.Any(q => q.Username.Trim() == username.Trim());
            return usernameExists;
        }

        bool isFormInvalid()
        {
            return String.IsNullOrEmpty(tbEmailAddress.Text) || String.IsNullOrEmpty(tbUsername.Text) || cbGenders.SelectedItem == null ;
        }
    }
}
