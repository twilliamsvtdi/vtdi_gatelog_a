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
    public partial class GateInOut : Form
    {
        public GateInOut()
        {
            InitializeComponent();
        }


        private void lblItemToDeclare_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //DateTime.Now gets the current date time. 
            var recordDate = DateTime.Now;

            //Collecting values from the form and storing them in variables
            var firstname = tbFirstName.Text;
            var lastName = tbLastName.Text;
            var platenumber = tbPlateNumber.Text;
            var vehicleType = cbVehicle.SelectedItem.ToString();
            var purpose = cbPurpose.SelectedItem.ToString();
            var item = cbItemsToDeclare.SelectedItem.ToString();
            var comments = tbComments.Text;

            //Validating that the Text Box is not empty
            if (String.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Last Name is Required!");
            }
            else
            {
                MessageBox.Show($"First Name: {firstname}\r\n " +
                    $"Last Name: {lastName}\r\n" +
                    $"Plate Number: {platenumber}\r\n" +
                    $"Vehicle Type: {vehicleType}\r\n" +
                    $"Purpose: {purpose}\r\n" +
                    $"Item To Declare: {item}\r\n" +
                    $"Comments: {comments}\r\n");
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GateInOut_Load(object sender, EventArgs e)
        {

        }
    }
}
