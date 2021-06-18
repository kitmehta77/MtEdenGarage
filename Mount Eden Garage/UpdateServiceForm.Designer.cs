
namespace Mount_Eden_Garage
{
    partial class UpdateServiceForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.nudServiceFee = new System.Windows.Forms.NumericUpDown();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.serviceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sERVICEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet = new Mount_Eden_Garage.MountEdenGarageDataSet();
            this.cUSTOMERVEHICLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLESERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter();
            this.sERVICEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.SERVICETableAdapter();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLESERVICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter();
            this.cUSTOMERVEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLESERVICEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERVEHICLEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(750, 576);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 40);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(502, 576);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(167, 40);
            this.btnUpdateService.TabIndex = 7;
            this.btnUpdateService.Text = "Update Service";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(629, 478);
            this.txtCustomerFirstName.MaxLength = 25;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.ReadOnly = true;
            this.txtCustomerFirstName.Size = new System.Drawing.Size(193, 32);
            this.txtCustomerFirstName.TabIndex = 6;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(628, 422);
            this.txtCustomerLastName.MaxLength = 25;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.ReadOnly = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(194, 32);
            this.txtCustomerLastName.TabIndex = 5;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Current",
            "Paid"});
            this.cboStatus.Location = new System.Drawing.Point(631, 351);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(116, 32);
            this.cboStatus.TabIndex = 4;
            // 
            // nudServiceFee
            // 
            this.nudServiceFee.DecimalPlaces = 2;
            this.nudServiceFee.Location = new System.Drawing.Point(629, 295);
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
            this.nudServiceFee.ReadOnly = true;
            this.nudServiceFee.Size = new System.Drawing.Size(84, 32);
            this.nudServiceFee.TabIndex = 3;
            this.nudServiceFee.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(628, 240);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(143, 32);
            this.dtpServiceDate.TabIndex = 2;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(628, 118);
            this.txtServiceDescription.MaxLength = 100;
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.Size = new System.Drawing.Size(326, 98);
            this.txtServiceDescription.TabIndex = 1;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(628, 69);
            this.txtServiceID.MaxLength = 8;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(55, 32);
            this.txtServiceID.TabIndex = 0;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(434, 425);
            this.lblCustomerLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(188, 24);
            this.lblCustomerLastName.TabIndex = 23;
            this.lblCustomerLastName.Text = "Customer Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(435, 481);
            this.lblCustomerFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(191, 24);
            this.lblCustomerFirstName.TabIndex = 22;
            this.lblCustomerFirstName.Text = "Customer First Name:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(555, 351);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status:";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.Location = new System.Drawing.Point(519, 297);
            this.lblServiceFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(107, 24);
            this.lblServiceFee.TabIndex = 20;
            this.lblServiceFee.Text = "Service Fee:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.Location = new System.Drawing.Point(509, 240);
            this.lblServiceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(117, 24);
            this.lblServiceDate.TabIndex = 19;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Location = new System.Drawing.Point(450, 126);
            this.lblServiceDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(172, 24);
            this.lblServiceDescription.TabIndex = 18;
            this.lblServiceDescription.Text = "Service Description:";
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Location = new System.Drawing.Point(527, 72);
            this.lblServiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(95, 24);
            this.lblServiceID.TabIndex = 17;
            this.lblServiceID.Text = "Service ID:";
            // 
            // dgvService
            // 
            this.dgvService.AllowUserToAddRows = false;
            this.dgvService.AllowUserToDeleteRows = false;
            this.dgvService.AllowUserToResizeRows = false;
            this.dgvService.AutoGenerateColumns = false;
            this.dgvService.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvService.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.VehicleID,
            this.serviceDescriptionDataGridViewTextBoxColumn});
            this.dgvService.DataSource = this.sERVICEBindingSource3;
            this.dgvService.Location = new System.Drawing.Point(52, 51);
            this.dgvService.Name = "dgvService";
            this.dgvService.ReadOnly = true;
            this.dgvService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvService.RowHeadersVisible = false;
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 24;
            this.dgvService.Size = new System.Drawing.Size(320, 565);
            this.dgvService.TabIndex = 33;
            this.dgvService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellContentClick);
            this.dgvService.Click += new System.EventHandler(this.dgvService_Click);
            // 
            // serviceIDDataGridViewTextBoxColumn
            // 
            this.serviceIDDataGridViewTextBoxColumn.DataPropertyName = "ServiceID";
            this.serviceIDDataGridViewTextBoxColumn.HeaderText = "Service ID";
            this.serviceIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceIDDataGridViewTextBoxColumn.Name = "serviceIDDataGridViewTextBoxColumn";
            this.serviceIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceIDDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
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
            // serviceDescriptionDataGridViewTextBoxColumn
            // 
            this.serviceDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ServiceDescription";
            this.serviceDescriptionDataGridViewTextBoxColumn.HeaderText = "Service Description";
            this.serviceDescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.serviceDescriptionDataGridViewTextBoxColumn.Name = "serviceDescriptionDataGridViewTextBoxColumn";
            this.serviceDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.serviceDescriptionDataGridViewTextBoxColumn.Width = 240;
            // 
            // sERVICEBindingSource3
            // 
            this.sERVICEBindingSource3.DataMember = "SERVICE";
            this.sERVICEBindingSource3.DataSource = this.mountEdenGarageDataSet;
            // 
            // mountEdenGarageDataSet
            // 
            this.mountEdenGarageDataSet.DataSetName = "MountEdenGarageDataSet";
            this.mountEdenGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERVEHICLEBindingSource1
            // 
            this.cUSTOMERVEHICLEBindingSource1.DataMember = "CUSTOMER_VEHICLE";
            this.cUSTOMERVEHICLEBindingSource1.DataSource = this.cUSTOMERBindingSource;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // vEHICLEBindingSource1
            // 
            this.vEHICLEBindingSource1.DataMember = "VEHICLE";
            this.vEHICLEBindingSource1.DataSource = this.mountEdenGarageDataSet;
            // 
            // vEHICLESERVICEBindingSource
            // 
            this.vEHICLESERVICEBindingSource.DataMember = "VEHICLE_SERVICE";
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // sERVICEBindingSource
            // 
            this.sERVICEBindingSource.DataMember = "SERVICE";
            this.sERVICEBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // sERVICETableAdapter
            // 
            this.sERVICETableAdapter.ClearBeforeFill = true;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // vEHICLESERVICEBindingSource1
            // 
            this.vEHICLESERVICEBindingSource1.DataMember = "VEHICLE_SERVICE";
            this.vEHICLESERVICEBindingSource1.DataSource = this.vEHICLEBindingSource;
            // 
            // cUSTOMERBindingSource1
            // 
            this.cUSTOMERBindingSource1.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource1.DataSource = this.mountEdenGarageDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // cUSTOMERVEHICLEBindingSource
            // 
            this.cUSTOMERVEHICLEBindingSource.DataMember = "CUSTOMER_VEHICLE";
            this.cUSTOMERVEHICLEBindingSource.DataSource = this.cUSTOMERBindingSource;
            // 
            // vEHICLESERVICEBindingSource2
            // 
            this.vEHICLESERVICEBindingSource2.DataMember = "VEHICLE_SERVICE";
            this.vEHICLESERVICEBindingSource2.DataSource = this.vEHICLEBindingSource1;
            // 
            // sERVICEBindingSource1
            // 
            this.sERVICEBindingSource1.DataMember = "SERVICE";
            this.sERVICEBindingSource1.DataSource = this.mountEdenGarageDataSet;
            // 
            // sERVICEBindingSource2
            // 
            this.sERVICEBindingSource2.DataMember = "SERVICE";
            this.sERVICEBindingSource2.DataSource = this.mountEdenGarageDataSet;
            // 
            // vEHICLEBindingSource2
            // 
            this.vEHICLEBindingSource2.DataMember = "VEHICLE";
            this.vEHICLEBindingSource2.DataSource = this.mountEdenGarageDataSet;
            // 
            // cUSTOMERVEHICLEBindingSource2
            // 
            this.cUSTOMERVEHICLEBindingSource2.DataMember = "CUSTOMER_VEHICLE";
            this.cUSTOMERVEHICLEBindingSource2.DataSource = this.cUSTOMERBindingSource;
            // 
            // vEHICLEBindingSource3
            // 
            this.vEHICLEBindingSource3.DataMember = "VEHICLE";
            this.vEHICLEBindingSource3.DataSource = this.mountEdenGarageDataSet;
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Location = new System.Drawing.Point(1104, 431);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.Size = new System.Drawing.Size(39, 123);
            this.dgvVehicle.TabIndex = 35;
            this.dgvVehicle.Visible = false;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(1104, 309);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(38, 113);
            this.dgvCustomer.TabIndex = 36;
            this.dgvCustomer.Visible = false;
            // 
            // UpdateServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(996, 661);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.dgvService);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateService);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.nudServiceFee);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateServiceForm";
            this.Load += new System.EventHandler(this.UpdateServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudServiceFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESERVICEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown nudServiceFee;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.DataGridView dgvService;
        private MountEdenGarageDataSet mountEdenGarageDataSet;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource1;
        private System.Windows.Forms.BindingSource vEHICLESERVICEBindingSource;
        private MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.BindingSource sERVICEBindingSource;
        private MountEdenGarageDataSetTableAdapters.SERVICETableAdapter sERVICETableAdapter;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private System.Windows.Forms.BindingSource vEHICLESERVICEBindingSource1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERVEHICLEBindingSource;
        private System.Windows.Forms.BindingSource vEHICLESERVICEBindingSource2;
        private System.Windows.Forms.BindingSource sERVICEBindingSource1;
        private System.Windows.Forms.BindingSource sERVICEBindingSource2;
        private System.Windows.Forms.BindingSource cUSTOMERVEHICLEBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource2;
        private System.Windows.Forms.BindingSource cUSTOMERVEHICLEBindingSource2;
        private System.Windows.Forms.BindingSource sERVICEBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource3;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private System.Windows.Forms.DataGridView dgvCustomer;
    }
}