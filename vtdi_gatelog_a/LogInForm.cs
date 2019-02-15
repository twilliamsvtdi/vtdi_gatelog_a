﻿using System;
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
            string username = tbUsername.Text;
            var password = tbPassword.Text;

            if (username != "admin" || password != "pass")
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {
                MessageBox.Show($"Welcome {username}");
                this.Close();
            }

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
