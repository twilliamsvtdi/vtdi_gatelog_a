namespace vtdi_gatelog_a
{
    partial class GateLogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbVehicleType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlateNumber = new System.Windows.Forms.TextBox();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vtdi_gate_log_dbDataSet = new vtdi_gatelog_a.vtdi_gate_log_dbDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.purposeOfVisitTableAdapter = new vtdi_gatelog_a.vtdi_gate_log_dbDataSetTableAdapters.PurposeOfVisitTableAdapter();
            this.itemsToDeclareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsToDeclareTableAdapter = new vtdi_gatelog_a.vtdi_gate_log_dbDataSetTableAdapters.ItemsToDeclareTableAdapter();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypesTableAdapter = new vtdi_gatelog_a.vtdi_gate_log_dbDataSetTableAdapters.VehicleTypesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gate_log_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToDeclareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Items To Declare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Plate Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purpose of Visit";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(3, 71);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(135, 30);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(140, 30);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.05505F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.94495F));
            this.tableLayoutPanel1.Controls.Add(this.cbVehicleType, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbPlateNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbItems, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblLastName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPurpose, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.34437F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.65563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(545, 435);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbVehicleType
            // 
            this.cbVehicleType.DataSource = this.bindingSource2;
            this.cbVehicleType.DisplayMember = "Name";
            this.cbVehicleType.FormattingEnabled = true;
            this.cbVehicleType.Location = new System.Drawing.Point(254, 361);
            this.cbVehicleType.Name = "cbVehicleType";
            this.cbVehicleType.Size = new System.Drawing.Size(261, 24);
            this.cbVehicleType.TabIndex = 13;
            this.cbVehicleType.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Vehicle Type";
            // 
            // tbPlateNumber
            // 
            this.tbPlateNumber.Location = new System.Drawing.Point(254, 220);
            this.tbPlateNumber.Name = "tbPlateNumber";
            this.tbPlateNumber.Size = new System.Drawing.Size(261, 22);
            this.tbPlateNumber.TabIndex = 11;
            // 
            // cbItems
            // 
            this.cbItems.DataSource = this.itemsToDeclareBindingSource;
            this.cbItems.DisplayMember = "Name";
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(254, 294);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(261, 24);
            this.cbItems.TabIndex = 10;
            this.cbItems.ValueMember = "Id";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(254, 74);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(261, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(254, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(261, 22);
            this.tbFirstName.TabIndex = 6;
            // 
            // cbPurpose
            // 
            this.cbPurpose.DataSource = this.bindingSource1;
            this.cbPurpose.DisplayMember = "Name";
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Location = new System.Drawing.Point(254, 149);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(261, 24);
            this.cbPurpose.TabIndex = 8;
            this.cbPurpose.ValueMember = "Id";
            this.cbPurpose.SelectedIndexChanged += new System.EventHandler(this.cbPurpose_SelectedIndexChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Himalaya", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(12, 490);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(545, 69);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vtdi_gatelog_a.Properties.Resources.heart_logo;
            this.pictureBox1.Location = new System.Drawing.Point(571, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // vtdi_gate_log_dbDataSet
            // 
            this.vtdi_gate_log_dbDataSet.DataSetName = "vtdi_gate_log_dbDataSet";
            this.vtdi_gate_log_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "PurposeOfVisit";
            this.bindingSource1.DataSource = this.vtdi_gate_log_dbDataSet;
            // 
            // purposeOfVisitTableAdapter
            // 
            this.purposeOfVisitTableAdapter.ClearBeforeFill = true;
            // 
            // itemsToDeclareBindingSource
            // 
            this.itemsToDeclareBindingSource.DataMember = "ItemsToDeclare";
            this.itemsToDeclareBindingSource.DataSource = this.vtdi_gate_log_dbDataSet;
            // 
            // itemsToDeclareTableAdapter
            // 
            this.itemsToDeclareTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "VehicleTypes";
            this.bindingSource2.DataSource = this.vtdi_gate_log_dbDataSet;
            // 
            // vehicleTypesTableAdapter
            // 
            this.vehicleTypesTableAdapter.ClearBeforeFill = true;
            // 
            // GateLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 633);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GateLogForm";
            this.Text = "Gate Log Form";
            this.Load += new System.EventHandler(this.GateLogForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vtdi_gate_log_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsToDeclareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbPlateNumber;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox cbPurpose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbVehicleType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource vehicleTypesBindingSource;
        private System.Windows.Forms.BindingSource purposeOfVisitBindingSource;
        private vtdi_gate_log_dbDataSet vtdi_gate_log_dbDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private vtdi_gate_log_dbDataSetTableAdapters.PurposeOfVisitTableAdapter purposeOfVisitTableAdapter;
        private System.Windows.Forms.BindingSource itemsToDeclareBindingSource;
        private vtdi_gate_log_dbDataSetTableAdapters.ItemsToDeclareTableAdapter itemsToDeclareTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource2;
        private vtdi_gate_log_dbDataSetTableAdapters.VehicleTypesTableAdapter vehicleTypesTableAdapter;
    }
}