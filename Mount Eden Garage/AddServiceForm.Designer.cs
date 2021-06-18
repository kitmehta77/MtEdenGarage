
namespace Mount_Eden_Garage
{
    partial class AddServiceForm
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
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet = new Mount_Eden_Garage.MountEdenGarageDataSet();
            this.cUSTOMERTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.cboMechFirstName = new System.Windows.Forms.ComboBox();
            this.cboMechLastName = new System.Windows.Forms.ComboBox();
            this.nudServiceFee = new System.Windows.Forms.NumericUpDown();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.cboMechanicId = new System.Windows.Forms.ComboBox();
            this.lblMechanic = new System.Windows.Forms.Label();
            this.lblVehicleDetails = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreditStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.mountEdenGarageDataSetBindingSource;
            // 
            // mountEdenGarageDataSetBindingSource
            // 
            this.mountEdenGarageDataSetBindingSource.DataSource = this.mountEdenGarageDataSet;
            this.mountEdenGarageDataSetBindingSource.Position = 0;
            // 
            // mountEdenGarageDataSet
            // 
            this.mountEdenGarageDataSet.DataSetName = "MountEdenGarageDataSet";
            this.mountEdenGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AutoGenerateColumns = false;
            this.dgvVehicle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicle.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVehicle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvVehicle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.plateNumber,
            this.VehicleID,
            this.make});
            this.dgvVehicle.DataSource = this.vEHICLEBindingSource;
            this.dgvVehicle.Location = new System.Drawing.Point(650, 138);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.Size = new System.Drawing.Size(310, 134);
            this.dgvVehicle.TabIndex = 3;
            // 
            // plateNumber
            // 
            this.plateNumber.DataPropertyName = "PlateNumber";
            this.plateNumber.HeaderText = "Plate Number";
            this.plateNumber.MinimumWidth = 6;
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.ReadOnly = true;
            // 
            // VehicleID
            // 
            this.VehicleID.DataPropertyName = "VehicleID";
            this.VehicleID.HeaderText = "VehicleID";
            this.VehicleID.MinimumWidth = 6;
            this.VehicleID.Name = "VehicleID";
            this.VehicleID.ReadOnly = true;
            this.VehicleID.Visible = false;
            // 
            // make
            // 
            this.make.DataPropertyName = "Make";
            this.make.HeaderText = "Make";
            this.make.MinimumWidth = 6;
            this.make.Name = "make";
            this.make.ReadOnly = true;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.mountEdenGarageDataSetBindingSource;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(653, 75);
            this.txtCustomerFirstName.MaxLength = 25;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.ReadOnly = true;
            this.txtCustomerFirstName.Size = new System.Drawing.Size(197, 32);
            this.txtCustomerFirstName.TabIndex = 2;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(653, 36);
            this.txtCustomerLastName.MaxLength = 25;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.ReadOnly = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(197, 32);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(538, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(539, 41);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 12;
            this.lblLastName.Text = "Last Name:";
            // 
            // cboMechFirstName
            // 
            this.cboMechFirstName.FormattingEnabled = true;
            this.cboMechFirstName.Location = new System.Drawing.Point(902, 294);
            this.cboMechFirstName.MaxLength = 30;
            this.cboMechFirstName.Name = "cboMechFirstName";
            this.cboMechFirstName.Size = new System.Drawing.Size(178, 32);
            this.cboMechFirstName.TabIndex = 6;
            // 
            // cboMechLastName
            // 
            this.cboMechLastName.FormattingEnabled = true;
            this.cboMechLastName.Location = new System.Drawing.Point(718, 294);
            this.cboMechLastName.MaxLength = 30;
            this.cboMechLastName.Name = "cboMechLastName";
            this.cboMechLastName.Size = new System.Drawing.Size(178, 32);
            this.cboMechLastName.TabIndex = 5;
            // 
            // nudServiceFee
            // 
            this.nudServiceFee.DecimalPlaces = 2;
            this.nudServiceFee.Location = new System.Drawing.Point(651, 375);
            this.nudServiceFee.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.nudServiceFee.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudServiceFee.Name = "nudServiceFee";
            this.nudServiceFee.Size = new System.Drawing.Size(128, 32);
            this.nudServiceFee.TabIndex = 8;
            this.nudServiceFee.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Location = new System.Drawing.Point(525, 377);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(107, 24);
            this.lblServiceFee.TabIndex = 17;
            this.lblServiceFee.Text = "Service Fee:";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(473, 423);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(172, 24);
            this.lblServiceDescription.TabIndex = 18;
            this.lblServiceDescription.Text = "Service Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(651, 420);
            this.txtDescription.MaxLength = 100;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(429, 90);
            this.txtDescription.TabIndex = 9;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(650, 342);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(129, 32);
            this.dtpServiceDate.TabIndex = 7;
            this.dtpServiceDate.Value = new System.DateTime(2021, 5, 5, 0, 0, 0, 0);
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(515, 341);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(117, 24);
            this.lblServiceDate.TabIndex = 16;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // cboMechanicId
            // 
            this.cboMechanicId.FormattingEnabled = true;
            this.cboMechanicId.Location = new System.Drawing.Point(650, 294);
            this.cboMechanicId.MaxLength = 3;
            this.cboMechanicId.Name = "cboMechanicId";
            this.cboMechanicId.Size = new System.Drawing.Size(62, 32);
            this.cboMechanicId.TabIndex = 4;
            // 
            // lblMechanic
            // 
            this.lblMechanic.AutoSize = true;
            this.lblMechanic.Location = new System.Drawing.Point(538, 297);
            this.lblMechanic.Name = "lblMechanic";
            this.lblMechanic.Size = new System.Drawing.Size(95, 24);
            this.lblMechanic.TabIndex = 15;
            this.lblMechanic.Text = "Mechanic:";
            // 
            // lblVehicleDetails
            // 
            this.lblVehicleDetails.AutoSize = true;
            this.lblVehicleDetails.Location = new System.Drawing.Point(502, 148);
            this.lblVehicleDetails.Name = "lblVehicleDetails";
            this.lblVehicleDetails.Size = new System.Drawing.Size(136, 24);
            this.lblVehicleDetails.TabIndex = 14;
            this.lblVehicleDetails.Text = "Vehicle Details:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(872, 529);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(155, 36);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(684, 529);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(155, 36);
            this.btnAddService.TabIndex = 10;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.lastName,
            this.firstName,
            this.CreditStatus});
            this.dgvCustomer.DataSource = this.cUSTOMERBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(34, 36);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(405, 529);
            this.dgvCustomer.TabIndex = 3;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "CustomerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "FirstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // CreditStatus
            // 
            this.CreditStatus.DataPropertyName = "CreditStatus";
            this.CreditStatus.HeaderText = "CreditStatus";
            this.CreditStatus.MinimumWidth = 6;
            this.CreditStatus.Name = "CreditStatus";
            this.CreditStatus.ReadOnly = true;
            this.CreditStatus.Visible = false;
            // 
            // AddServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1130, 609);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddService);
            this.Controls.Add(this.lblVehicleDetails);
            this.Controls.Add(this.cboMechFirstName);
            this.Controls.Add(this.cboMechLastName);
            this.Controls.Add(this.nudServiceFee);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.cboMechanicId);
            this.Controls.Add(this.lblMechanic);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.dgvCustomer);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Service";
            this.Load += new System.EventHandler(this.AddServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource mountEdenGarageDataSetBindingSource;
        private MountEdenGarageDataSet mountEdenGarageDataSet;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox cboMechFirstName;
        private System.Windows.Forms.ComboBox cboMechLastName;
        private System.Windows.Forms.NumericUpDown nudServiceFee;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.ComboBox cboMechanicId;
        private System.Windows.Forms.Label lblMechanic;
        private System.Windows.Forms.Label lblVehicleDetails;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn make;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreditStatus;
    }
}