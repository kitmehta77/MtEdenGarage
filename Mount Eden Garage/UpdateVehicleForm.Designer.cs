
namespace Mount_Eden_Garage
{
    partial class UpdateVehicleForm
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
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.dtpManDate = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dgvVehicle = new System.Windows.Forms.DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet = new Mount_Eden_Garage.MountEdenGarageDataSet();
            this.vEHICLETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cUSTOMERVEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(496, 50);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(96, 24);
            this.lblVehicleID.TabIndex = 1;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(462, 116);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(130, 24);
            this.lblPlateNumber.TabIndex = 2;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(532, 163);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(60, 24);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(523, 213);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(69, 24);
            this.lblModel.TabIndex = 4;
            this.lblModel.Text = "Model:";
            // 
            // lblManDate
            // 
            this.lblManDate.AutoSize = true;
            this.lblManDate.Location = new System.Drawing.Point(403, 277);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(189, 24);
            this.lblManDate.TabIndex = 5;
            this.lblManDate.Text = "Date of Manufacture:";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(598, 47);
            this.txtVehicleID.MaxLength = 5;
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(45, 32);
            this.txtVehicleID.TabIndex = 1;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(598, 116);
            this.txtPlateNumber.MaxLength = 10;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.Size = new System.Drawing.Size(117, 32);
            this.txtPlateNumber.TabIndex = 2;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(598, 160);
            this.txtMake.MaxLength = 30;
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(232, 32);
            this.txtMake.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(598, 205);
            this.txtModel.MaxLength = 30;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(232, 32);
            this.txtModel.TabIndex = 4;
            // 
            // dtpManDate
            // 
            this.dtpManDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManDate.Location = new System.Drawing.Point(598, 275);
            this.dtpManDate.Name = "dtpManDate";
            this.dtpManDate.Size = new System.Drawing.Size(136, 32);
            this.dtpManDate.TabIndex = 5;
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Location = new System.Drawing.Point(488, 465);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(174, 39);
            this.btnUpdateVehicle.TabIndex = 8;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = true;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(683, 465);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(174, 39);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dgvVehicle
            // 
            this.dgvVehicle.AllowUserToAddRows = false;
            this.dgvVehicle.AllowUserToDeleteRows = false;
            this.dgvVehicle.AllowUserToResizeRows = false;
            this.dgvVehicle.AutoGenerateColumns = false;
            this.dgvVehicle.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.CustomerID,
            this.plateNumberDataGridViewTextBoxColumn});
            this.dgvVehicle.DataSource = this.vEHICLEBindingSource;
            this.dgvVehicle.Location = new System.Drawing.Point(33, 47);
            this.dgvVehicle.Name = "dgvVehicle";
            this.dgvVehicle.ReadOnly = true;
            this.dgvVehicle.RowHeadersVisible = false;
            this.dgvVehicle.RowHeadersWidth = 51;
            this.dgvVehicle.RowTemplate.Height = 24;
            this.dgvVehicle.Size = new System.Drawing.Size(325, 457);
            this.dgvVehicle.TabIndex = 17;
            this.dgvVehicle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicle_CellContentClick);
            this.dgvVehicle.Click += new System.EventHandler(this.dgvVehicle_Click);
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "Vehicle ID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerID";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            this.CustomerID.Width = 125;
            // 
            // plateNumberDataGridViewTextBoxColumn
            // 
            this.plateNumberDataGridViewTextBoxColumn.DataPropertyName = "PlateNumber";
            this.plateNumberDataGridViewTextBoxColumn.HeaderText = "Plate Number";
            this.plateNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plateNumberDataGridViewTextBoxColumn.Name = "plateNumberDataGridViewTextBoxColumn";
            this.plateNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.plateNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // mountEdenGarageDataSet
            // 
            this.mountEdenGarageDataSet.DataSetName = "MountEdenGarageDataSet";
            this.mountEdenGarageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn});
            this.dgvCustomer.DataSource = this.cUSTOMERBindingSource;
            this.dgvCustomer.Location = new System.Drawing.Point(1065, 252);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(304, 78);
            this.dgvCustomer.TabIndex = 18;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.mountEdenGarageDataSet;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(598, 338);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(210, 32);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(598, 379);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(210, 32);
            this.txtFirstName.TabIndex = 7;
            // 
            // cUSTOMERVEHICLEBindingSource
            // 
            this.cUSTOMERVEHICLEBindingSource.DataMember = "CUSTOMER_VEHICLE";
            this.cUSTOMERVEHICLEBindingSource.DataSource = this.cUSTOMERBindingSource;
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(404, 346);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(188, 24);
            this.lblCustomerLastName.TabIndex = 21;
            this.lblCustomerLastName.Text = "Customer Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(403, 379);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(191, 24);
            this.lblCustomerFirstName.TabIndex = 22;
            this.lblCustomerFirstName.Text = "Customer First Name:";
            // 
            // UpdateVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(928, 548);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.dgvVehicle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.dtpManDate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblManDate);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblVehicleID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Vehicle";
            this.Load += new System.EventHandler(this.UpdateVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERVEHICLEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblManDate;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.DateTimePicker dtpManDate;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dgvVehicle;
        private MountEdenGarageDataSet mountEdenGarageDataSet;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private MountEdenGarageDataSetTableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private MountEdenGarageDataSetTableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.BindingSource cUSTOMERVEHICLEBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumberDataGridViewTextBoxColumn;
    }
}