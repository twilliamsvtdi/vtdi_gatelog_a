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
    public partial class GateLogForm : Form
    {
        //Declaring database object global to the class, to make it accessible
        //for all functions of this class.
        private vtdi_gate_log_dbEntities1 ctx;

        //Alternatively
        //private vtdi_gate_log_dbEntities1 ctx = new vtdi_gate_log_dbEntities1();

        public GateLogForm()
        {
            InitializeComponent();
        }

        private void GateLogForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtdi_gate_log_dbDataSet.VehicleTypes' table. You can move, or remove it, as needed.
            this.vehicleTypesTableAdapter.Fill(this.vtdi_gate_log_dbDataSet.VehicleTypes);
            // TODO: This line of code loads data into the 'vtdi_gate_log_dbDataSet.ItemsToDeclare' table. You can move, or remove it, as needed.
            this.itemsToDeclareTableAdapter.Fill(this.vtdi_gate_log_dbDataSet.ItemsToDeclare);
            // TODO: This line of code loads data into the 'vtdi_gate_log_dbDataSet.PurposeOfVisit' table. You can move, or remove it, as needed.
            this.purposeOfVisitTableAdapter.Fill(this.vtdi_gate_log_dbDataSet.PurposeOfVisit);

            //Initializing the object of ctx for database access.
            ctx = new vtdi_gate_log_dbEntities1();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Get all values from the form interface. Store in variables for ease of use
            var fname = tbFirstName.Text;
            var lname = tbLastName.Text;
            var plateNum = tbPlateNumber.Text;
            var purpose = cbPurpose.SelectedValue;
            var item = cbItems.SelectedValue;
            var vehicleType = cbVehicleType.SelectedValue;
            var DateTimeIn = DateTime.Now;

            //Declare an object of the datatype that corresponds with the 
            //table that you are about to store data in
            GateInOut record = new GateInOut();
            //Alternatively: var record = new GateInOut();

            //Populate the fields in the object
            record.FirstName = fname;
            record.LastName = lname;
            record.PlateNumber = plateNum;
            record.PurposeId = (int)purpose;
            record.ItemId = Convert.ToInt32(item);
            record.VehicleTypeId = int.Parse(vehicleType.ToString());
            record.DateTimeIn = DateTimeIn;

            //Add the record (or object) to the the table and save changes
            ctx.GateInOuts.Add(record);
            ctx.SaveChanges();

            MessageBox.Show("Data Logged");
        }

        private void purposeOfVisitBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        

        private void cbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
