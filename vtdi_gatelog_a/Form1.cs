﻿using System;
using System.Windows.Forms;

namespace vtdi_gatelog_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Make sure you change back to false!
        public bool isLoggedIn = true;

        private string btn_clicked(object sender)
        {
            var ctrl = (ToolStripMenuItem)sender;
            return ctrl.Text;
        }

        private void logInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void userManagementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
            {
                UserManagement userManagement = new UserManagement();
                userManagement.MdiParent = this;
                userManagement.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn)
            {
                GateLogForm gateInOut = new GateLogForm();
                gateInOut.MdiParent = this;
                gateInOut.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isLoggedIn)
                MessageBox.Show($"{btn_clicked(sender)} Clicked");
            else
            {
                ShowLoginForm();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ShowLoginForm();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ShowLoginForm()
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }
    }
}
