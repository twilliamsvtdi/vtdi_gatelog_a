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
