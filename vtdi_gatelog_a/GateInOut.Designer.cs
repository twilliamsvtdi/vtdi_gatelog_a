namespace vtdi_gatelog_a
{
    partial class GateInOut
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbComments = new System.Windows.Forms.TextBox();
            this.cbVehicle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPlateNumber = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblItemToDeclare = new System.Windows.Forms.Label();
            this.cbItemsToDeclare = new System.Windows.Forms.ComboBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.cbPurpose = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblComments = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.33724F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.66276F));
            this.tableLayoutPanel1.Controls.Add(this.tbComments, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cbVehicle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbPlateNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblLName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFname, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPlateNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblItemToDeclare, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbItemsToDeclare, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPurpose, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbPurpose, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubmit, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblComments, 0, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 573);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbComments
            // 
            this.tbComments.Location = new System.Drawing.Point(243, 317);
            this.tbComments.Multiline = true;
            this.tbComments.Name = "tbComments";
            this.tbComments.Size = new System.Drawing.Size(436, 97);
            this.tbComments.TabIndex = 19;
            // 
            // cbVehicle
            // 
            this.cbVehicle.FormattingEnabled = true;
            this.cbVehicle.Items.AddRange(new object[] {
            "BMW",
            "Mercedes Benz",
            "Suzuki",
            "Toyota",
            "Nissan",
            "Other"});
            this.cbVehicle.Location = new System.Drawing.Point(243, 156);
            this.cbVehicle.Name = "cbVehicle";
            this.cbVehicle.Size = new System.Drawing.Size(436, 24);
            this.cbVehicle.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Vehicle Type";
            // 
            // tbPlateNumber
            // 
            this.tbPlateNumber.Location = new System.Drawing.Point(243, 108);
            this.tbPlateNumber.Name = "tbPlateNumber";
            this.tbPlateNumber.Size = new System.Drawing.Size(436, 22);
            this.tbPlateNumber.TabIndex = 8;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(243, 54);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(436, 22);
            this.tbLastName.TabIndex = 7;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(3, 51);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(105, 20);
            this.lblLName.TabIndex = 1;
            this.lblLName.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(3, 0);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(109, 20);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Perpetua Titling MT", 10F);
            this.lblPlateNumber.Location = new System.Drawing.Point(3, 105);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(137, 20);
            this.lblPlateNumber.TabIndex = 2;
            this.lblPlateNumber.Text = "Plate Number";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(243, 3);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(436, 22);
            this.tbFirstName.TabIndex = 6;
            // 
            // lblItemToDeclare
            // 
            this.lblItemToDeclare.AutoSize = true;
            this.lblItemToDeclare.Font = new System.Drawing.Font("Perpetua Titling MT", 10F);
            this.lblItemToDeclare.Location = new System.Drawing.Point(3, 258);
            this.lblItemToDeclare.Name = "lblItemToDeclare";
            this.lblItemToDeclare.Size = new System.Drawing.Size(162, 20);
            this.lblItemToDeclare.TabIndex = 12;
            this.lblItemToDeclare.Text = "Item To Declare";
            this.lblItemToDeclare.Click += new System.EventHandler(this.lblItemToDeclare_Click);
            // 
            // cbItemsToDeclare
            // 
            this.cbItemsToDeclare.FormattingEnabled = true;
            this.cbItemsToDeclare.Location = new System.Drawing.Point(243, 261);
            this.cbItemsToDeclare.Name = "cbItemsToDeclare";
            this.cbItemsToDeclare.Size = new System.Drawing.Size(436, 24);
            this.cbItemsToDeclare.TabIndex = 13;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Perpetua Titling MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurpose.Location = new System.Drawing.Point(3, 204);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(171, 20);
            this.lblPurpose.TabIndex = 3;
            this.lblPurpose.Text = "Purpose for Visit";
            // 
            // cbPurpose
            // 
            this.cbPurpose.FormattingEnabled = true;
            this.cbPurpose.Items.AddRange(new object[] {
            "Student",
            "Lecturer",
            "Office Admin",
            "General Staff",
            "Other"});
            this.cbPurpose.Location = new System.Drawing.Point(243, 207);
            this.cbPurpose.Name = "cbPurpose";
            this.cbPurpose.Size = new System.Drawing.Size(436, 24);
            this.cbPurpose.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 420);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(137, 75);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(243, 420);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 75);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Perpetua Titling MT", 10F);
            this.lblComments.Location = new System.Drawing.Point(3, 314);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(223, 20);
            this.lblComments.TabIndex = 18;
            this.lblComments.Text = "Additional Comments";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::vtdi_gatelog_a.Properties.Resources.heart_logo;
            this.pictureBox1.Location = new System.Drawing.Point(788, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // GateInOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GateInOut";
            this.Text = "Gate In Out Form";
            this.Load += new System.EventHandler(this.GateInOut_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblItemToDeclare;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbItemsToDeclare;
        private System.Windows.Forms.TextBox tbPlateNumber;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.ComboBox cbPurpose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbVehicle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}