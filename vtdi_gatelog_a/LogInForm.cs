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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // You can always use the variable types that 
            // you are familair with. (string, int, etc...)
            var username = tbUsername.Text;
            var password = tbPassword.Text;

            //Declaring an object of the database model
            var ctx = new vtdi_gate_log_dbEntities1();
            //Declare a variable to store the result of the query.
            //The code below checks the Users table in the database and returns
            // true or false for the condition in the lambda expression.
            var user = ctx.Users.Any(q => q.Username == username 
                && q.Password == password);

            //Check if a true value was returned from the user check and 
            //grant access. If false, then contrinue to restrict.
            if(user)
            {
                MessageBox.Show($"Welcome {username}");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }


            //if (username != "admin" || password != "pass")
            //{
            //    MessageBox.Show("Invalid Credentials");
            //}
            //else
            //{
            //    MessageBox.Show($"Welcome {username}");
            //    this.Close();
            //}

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
