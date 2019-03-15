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
        //The name of this variable does not matter. 
        //Just be consistent in your project
        private vtdi_gate_log_dbEntities1 _dbContext;

        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            _dbContext = new vtdi_gate_log_dbEntities1();

            //Populate the Gender Dropdown
            //Get The Genders from the Genders table
            var genders = _dbContext.Genders.ToList();
            //Set the datasource of the combobox to the records
            //being retrieved from the database
            cbGenders.DataSource = genders;
            //Set the data member and value member to the values
            //that correspond with the columns coming back from 
            //our data source. 
            cbGenders.DisplayMember = "Name";
            cbGenders.ValueMember = "Id";

            //Populate The Grid View
            var gridViewData = _dbContext.Users
                .Select(q => new {
                        q.Id,
                        q.FirstName,
                        q.LastName,
                        q.Email,
                        q.Username,
                        q.Gender.Name
                }).ToList();

            gvUsers.DataSource = gridViewData;
            gvUsers.Columns[0].Visible = false;

        }
    }
}
