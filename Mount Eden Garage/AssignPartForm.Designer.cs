
namespace Mount_Eden_Garage
{
    partial class AssignPartForm
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.serviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet4 = new Mount_Eden_Garage.MountEdenGarageDataSet4();
            this.sERVICETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSet4TableAdapters.SERVICETableAdapter();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.lblPartID = new System.Windows.Forms.Label();
            this.lblPartDescription = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAssignPart = new System.Windows.Forms.Button();
            this.Return = new System.Windows.Forms.Button();
            this.cboPartID = new System.Windows.Forms.ComboBox();
            this.cboPartDescription = new System.Windows.Forms.ComboBox();
            this.sERVICESERVICEPARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICEPARTTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSet4TableAdapters.SERVICEPARTTableAdapter();
            this.mountEdenGarageDataSet = new Mount_Eden_Garage.MountEdenGarageDataSet();
            this.pARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pARTTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.PARTTableAdapter();
            this.pARTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pARTSERVICEPARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICEPARTTableAdapter1 = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.SERVICEPARTTableAdapter();
            this.lstCurrentParts = new System.Windows.Forms.ListBox();
            this.lblAssignedParts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sERVICEPARTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESERVICEPARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTSERVICEPARTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEPARTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.AutoGenerateColumns = false;
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceID,
            this.serviceDescription,
            this.VehicleID});
            this.dgvService.DataSource = this.sERVICEBindingSource;
            this.dgvService.Location = new System.Drawing.Point(62, 38);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(289, 405);
            this.dgvService.TabIndex = 0;
            this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
            this.dgvService.Click += new System.EventHandler(this.dgvService_Click);
            // 
            // serviceID
            // 
            this.serviceID.DataPropertyName = "ServiceID";
            this.serviceID.HeaderText = "Service ID";
            this.serviceID.MinimumWidth = 6;
            this.serviceID.Name = "serviceID";
            this.serviceID.ReadOnly = true;
            this.serviceID.Width = 70;
            // 
            // serviceDescription
            // 
            this.serviceDescription.DataPropertyName = "ServiceDescription";
            this.serviceDescription.HeaderText = "Service Description";
            this.serviceDescription.MinimumWidth = 6;
            this.serviceDescription.Name = "serviceDescription";
            this.serviceDescription.ReadOnly = true;
            this.serviceDescription.Width = 220;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.MinimumWidth = 6;
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.Visible = false;
            this.VehicleID.Width = 125;
            // 
            // sERVICEBindingSource
            // 
            this.sERVICEBindingSource.DataMember = "SERVICE";
            this.sERVICEBindingSource.DataSource = this.mountEdenGarageDataSet4;
            // 
            // mountEdenGarageDataSet4
            // 
            this.mountEdenGarageDataSet4.DataSetName = "MountEdenGarageDataSet4";
            this.mountEdenGarageDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICETableAdapter
            // 
            this.sERVICETableAdapter.ClearBeforeFill = true;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(515, 47);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(95, 24);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Service ID:";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(438, 85);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(172, 24);
            this.lblServiceDescription.TabIndex = 2;
            this.lblServiceDescription.Text = "Service Description:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(493, 185);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(117, 24);
            this.lblServiceDate.TabIndex = 3;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(514, 272);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(96, 24);
            this.lblVehicleID.TabIndex = 4;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(480, 310);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(130, 24);
            this.lblPlateNumber.TabIndex = 5;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(620, 179);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(160, 32);
            this.dtpServiceDate.TabIndex = 3;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(620, 44);
            this.txtServiceID.MaxLength = 8;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(67, 32);
            this.txtServiceID.TabIndex = 1;
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(620, 264);
            this.txtVehicleID.MaxLength = 5;
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(67, 32);
            this.txtVehicleID.TabIndex = 4;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(620, 302);
            this.txtPlateNumber.MaxLength = 10;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.ReadOnly = true;
            this.txtPlateNumber.Size = new System.Drawing.Size(160, 32);
            this.txtPlateNumber.TabIndex = 5;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(620, 82);
            this.txtServiceDescription.MaxLength = 100;
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.ReadOnly = true;
            this.txtServiceDescription.Size = new System.Drawing.Size(309, 91);
            this.txtServiceDescription.TabIndex = 2;
            // 
            // lblPartID
            // 
            this.lblPartID.AutoSize = true;
            this.lblPartID.Location = new System.Drawing.Point(537, 406);
            this.lblPartID.Name = "lblPartID";
            this.lblPartID.Size = new System.Drawing.Size(71, 24);
            this.lblPartID.TabIndex = 11;
            this.lblPartID.Text = "Part ID:";
            // 
            // lblPartDescription
            // 
            this.lblPartDescription.AutoSize = true;
            this.lblPartDescription.Location = new System.Drawing.Point(460, 436);
            this.lblPartDescription.Name = "lblPartDescription";
            this.lblPartDescription.Size = new System.Drawing.Size(148, 24);
            this.lblPartDescription.TabIndex = 12;
            this.lblPartDescription.Text = "Part Description:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(521, 476);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(87, 24);
            this.lblQuantity.TabIndex = 13;
            this.lblQuantity.Text = "Quantity:";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(620, 474);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(87, 32);
            this.nudQuantity.TabIndex = 8;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAssignPart
            // 
            this.btnAssignPart.Location = new System.Drawing.Point(520, 592);
            this.btnAssignPart.Name = "btnAssignPart";
            this.btnAssignPart.Size = new System.Drawing.Size(165, 41);
            this.btnAssignPart.TabIndex = 9;
            this.btnAssignPart.Text = "Assign Part";
            this.btnAssignPart.UseVisualStyleBackColor = true;
            this.btnAssignPart.Click += new System.EventHandler(this.btnAssignPart_Click);
            // 
            // Return
            // 
            this.Return.Location = new System.Drawing.Point(719, 592);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(165, 41);
            this.Return.TabIndex = 10;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.Click += new System.EventHandler(this.Return_Click);
            // 
            // cboPartID
            // 
            this.cboPartID.FormattingEnabled = true;
            this.cboPartID.Location = new System.Drawing.Point(620, 398);
            this.cboPartID.MaxLength = 7;
            this.cboPartID.Name = "cboPartID";
            this.cboPartID.Size = new System.Drawing.Size(65, 32);
            this.cboPartID.TabIndex = 6;
            // 
            // cboPartDescription
            // 
            this.cboPartDescription.FormattingEnabled = true;
            this.cboPartDescription.Location = new System.Drawing.Point(620, 436);
            this.cboPartDescription.MaxLength = 50;
            this.cboPartDescription.Name = "cboPartDescription";
            this.cboPartDescription.Size = new System.Drawing.Size(307, 32);
            this.cboPartDescription.TabIndex = 7;
            // 
            // sERVICESERVICEPARTBindingSource
            // 
            this.sERVICESERVICEPARTBindingSource.DataMember = "SERVICESERVICEPART";
            this.sERVICESERVICEPARTBindingSource.DataSource = this.sERVICEBindingSource;
            // 
            // sERVICEPARTTableAdapter
            // 
            this.sERVICEPARTTableAdapter.ClearBeforeFill = true;
            // 
            // mountEdenGarageDataSet
            // 
            this.mountEdenGarageDataSet.DataSetName = "MountEdenGarageDataSet";
            this.mountEdenGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTBindingSource
            // 
            this.pARTBindingSource.DataMember = "PART";
            this.pARTBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // pARTTableAdapter
            // 
            this.pARTTableAdapter.ClearBeforeFill = true;
            // 
            // pARTBindingSource1
            // 
            this.pARTBindingSource1.DataMember = "PART";
            this.pARTBindingSource1.DataSource = this.mountEdenGarageDataSet;
            // 
            // pARTSERVICEPARTBindingSource
            // 
            this.pARTSERVICEPARTBindingSource.DataMember = "PART_SERVICEPART";
            this.pARTSERVICEPARTBindingSource.DataSource = this.pARTBindingSource;
            // 
            // sERVICEPARTTableAdapter1
            // 
            this.sERVICEPARTTableAdapter1.ClearBeforeFill = true;
            // 
            // lstCurrentParts
            // 
            this.lstCurrentParts.FormattingEnabled = true;
            this.lstCurrentParts.ItemHeight = 24;
            this.lstCurrentParts.Location = new System.Drawing.Point(62, 485);
            this.lstCurrentParts.Name = "lstCurrentParts";
            this.lstCurrentParts.Size = new System.Drawing.Size(371, 148);
            this.lstCurrentParts.TabIndex = 14;
            // 
            // lblAssignedParts
            // 
            this.lblAssignedParts.AutoSize = true;
            this.lblAssignedParts.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedParts.Location = new System.Drawing.Point(58, 452);
            this.lblAssignedParts.Name = "lblAssignedParts";
            this.lblAssignedParts.Size = new System.Drawing.Size(136, 24);
            this.lblAssignedParts.TabIndex = 15;
            this.lblAssignedParts.Text = "Assigned Parts:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Parts:";
            // 
            // sERVICEPARTBindingSource
            // 
            this.sERVICEPARTBindingSource.DataMember = "SERVICEPART";
            this.sERVICEPARTBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // AssignPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(984, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPartDescription);
            this.Controls.Add(this.cboPartID);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.lstCurrentParts);
            this.Controls.Add(this.lblAssignedParts);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.btnAssignPart);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPartDescription);
            this.Controls.Add(this.lblPartID);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceID);
            this.Controls.Add(this.dgvService);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Part";
            this.Load += new System.EventHandler(this.AssignPartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICESERVICEPARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTSERVICEPARTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEPARTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvService;
        private MountEdenGarageDataSet4 mountEdenGarageDataSet4;
        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private MountEdenGarageDataSet4TableAdapters.SERVICETableAdapter sERVICETableAdapter;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblPartID;
        private System.Windows.Forms.Label lblPartDescription;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAssignPart;
        private System.Windows.Forms.Button Return;
        private System.Windows.Forms.ComboBox cboPartID;
        private System.Windows.Forms.ComboBox cboPartDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.BindingSource sERVICESERVICEPARTBindingSource;
        private MountEdenGarageDataSet4TableAdapters.SERVICEPARTTableAdapter sERVICEPARTTableAdapter;
        private MountEdenGarageDataSet mountEdenGarageDataSet;
        private System.Windows.Forms.BindingSource pARTBindingSource;
        private MountEdenGarageDataSetTableAdapters.PARTTableAdapter pARTTableAdapter;
        private System.Windows.Forms.BindingSource pARTBindingSource1;
        private System.Windows.Forms.BindingSource pARTSERVICEPARTBindingSource;
        private MountEdenGarageDataSetTableAdapters.SERVICEPARTTableAdapter sERVICEPARTTableAdapter1;
        private System.Windows.Forms.ListBox lstCurrentParts;
        private System.Windows.Forms.Label lblAssignedParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sERVICEPARTBindingSource;
    }
}