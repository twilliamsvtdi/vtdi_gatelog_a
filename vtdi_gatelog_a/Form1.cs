using System;
using System.Windows.Forms;

namespace vtdi_gatelog_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
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
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void guestListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GateInOut gateInOut = new GateInOut();
            gateInOut.MdiParent = this;
            gateInOut.Show();
        }

        private void gateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void userLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{btn_clicked(sender)} Clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            logIn.MdiParent = this;
            logIn.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
