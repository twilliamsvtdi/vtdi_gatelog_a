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
                //Declaring a an object of Type Form1, which isthe parent of the login form
                var parent = (Form1)this.MdiParent;
                //Change the property in Form1 to true.
                parent.isLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
