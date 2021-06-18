
namespace Mount_Eden_Garage
{
    partial class DeleteVehicleForm
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
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.vehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plateNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vEHICLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet3 = new Mount_Eden_Garage.MountEdenGarageDataSet3();
            this.vEHICLETableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSet3TableAdapters.VEHICLETableAdapter();
            this.lblVehicleID = new System.Windows.Forms.Label();
            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.lblCustomerLastName = new System.Windows.Forms.Label();
            this.lblCustomerFirstName = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.dtpManDate = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.AllowUserToResizeRows = false;
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleID,
            this.CustomerID,
            this.plateNumber});
            this.dgvVehicles.DataSource = this.vEHICLEBindingSource;
            this.dgvVehicles.Location = new System.Drawing.Point(61, 54);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.Size = new System.Drawing.Size(253, 481);
            this.dgvVehicles.TabIndex = 0;
            this.dgvVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellContentClick);
            this.dgvVehicles.Click += new System.EventHandler(this.dgvVehicles_Click);
            // 
            // vehicleID
            // 
            this.vehicleID.DataPropertyName = "VehicleID";
            this.vehicleID.HeaderText = "Vehicle ID";
            this.vehicleID.MinimumWidth = 6;
            this.vehicleID.Name = "vehicleID";
            this.vehicleID.ReadOnly = true;
            this.vehicleID.Width = 125;
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
            // plateNumber
            // 
            this.plateNumber.DataPropertyName = "PlateNumber";
            this.plateNumber.HeaderText = "Plate Number";
            this.plateNumber.MinimumWidth = 6;
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.ReadOnly = true;
            this.plateNumber.Width = 125;
            // 
            // vEHICLEBindingSource
            // 
            this.vEHICLEBindingSource.DataMember = "VEHICLE";
            this.vEHICLEBindingSource.DataSource = this.mountEdenGarageDataSet3;
            // 
            // mountEdenGarageDataSet3
            // 
            this.mountEdenGarageDataSet3.DataSetName = "MountEdenGarageDataSet3";
            this.mountEdenGarageDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLETableAdapter
            // 
            this.vEHICLETableAdapter.ClearBeforeFill = true;
            // 
            // lblVehicleID
            // 
            this.lblVehicleID.AutoSize = true;
            this.lblVehicleID.Location = new System.Drawing.Point(483, 125);
            this.lblVehicleID.Name = "lblVehicleID";
            this.lblVehicleID.Size = new System.Drawing.Size(96, 24);
            this.lblVehicleID.TabIndex = 1;
            this.lblVehicleID.Text = "Vehicle ID:";
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Location = new System.Drawing.Point(458, 167);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(130, 24);
            this.lblPlateNumber.TabIndex = 2;
            this.lblPlateNumber.Text = "Plate Number:";
            // 
            // lblManDate
            // 
            this.lblManDate.AutoSize = true;
            this.lblManDate.Location = new System.Drawing.Point(410, 217);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(191, 24);
            this.lblManDate.TabIndex = 3;
            this.lblManDate.Text = "Date Of Manufacture:";
            // 
            // lblCustomerLastName
            // 
            this.lblCustomerLastName.AutoSize = true;
            this.lblCustomerLastName.Location = new System.Drawing.Point(413, 329);
            this.lblCustomerLastName.Name = "lblCustomerLastName";
            this.lblCustomerLastName.Size = new System.Drawing.Size(188, 24);
            this.lblCustomerLastName.TabIndex = 4;
            this.lblCustomerLastName.Text = "Customer Last Name:";
            // 
            // lblCustomerFirstName
            // 
            this.lblCustomerFirstName.AutoSize = true;
            this.lblCustomerFirstName.Location = new System.Drawing.Point(410, 365);
            this.lblCustomerFirstName.Name = "lblCustomerFirstName";
            this.lblCustomerFirstName.Size = new System.Drawing.Size(191, 24);
            this.lblCustomerFirstName.TabIndex = 5;
            this.lblCustomerFirstName.Text = "Customer First Name:";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Location = new System.Drawing.Point(568, 122);
            this.txtVehicleID.MaxLength = 5;
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(57, 32);
            this.txtVehicleID.TabIndex = 1;
            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Location = new System.Drawing.Point(567, 167);
            this.txtPlateNumber.MaxLength = 10;
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.ReadOnly = true;
            this.txtPlateNumber.Size = new System.Drawing.Size(144, 32);
            this.txtPlateNumber.TabIndex = 2;
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(567, 326);
            this.txtCustomerLastName.MaxLength = 25;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.ReadOnly = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(208, 32);
            this.txtCustomerLastName.TabIndex = 4;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(567, 362);
            this.txtCustomerFirstName.MaxLength = 25;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.ReadOnly = true;
            this.txtCustomerFirstName.Size = new System.Drawing.Size(208, 32);
            this.txtCustomerFirstName.TabIndex = 5;
            // 
            // dtpManDate
            // 
            this.dtpManDate.Enabled = false;
            this.dtpManDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManDate.Location = new System.Drawing.Point(568, 211);
            this.dtpManDate.Name = "dtpManDate";
            this.dtpManDate.Size = new System.Drawing.Size(143, 32);
            this.dtpManDate.TabIndex = 3;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Location = new System.Drawing.Point(406, 499);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(139, 36);
            this.btnDeleteVehicle.TabIndex = 6;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = true;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(630, 499);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(145, 36);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // DeleteVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(831, 575);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.dtpManDate);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.txtPlateNumber);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblCustomerFirstName);
            this.Controls.Add(this.lblCustomerLastName);
            this.Controls.Add(this.lblManDate);
            this.Controls.Add(this.lblPlateNumber);
            this.Controls.Add(this.lblVehicleID);
            this.Controls.Add(this.dgvVehicles);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Vehicle";
            this.Load += new System.EventHandler(this.DeleteVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicles;
        private MountEdenGarageDataSet3 mountEdenGarageDataSet3;
        private System.Windows.Forms.BindingSource vEHICLEBindingSource;
        private MountEdenGarageDataSet3TableAdapters.VEHICLETableAdapter vEHICLETableAdapter;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblPlateNumber;
        private System.Windows.Forms.Label lblManDate;
        private System.Windows.Forms.Label lblCustomerLastName;
        private System.Windows.Forms.Label lblCustomerFirstName;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.TextBox txtPlateNumber;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.DateTimePicker dtpManDate;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plateNumber;
    }
}