
namespace Mount_Eden_Garage
{
    partial class AddVehicleForm
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mountEdenGarageDataSet1 = new Mount_Eden_Garage.MountEdenGarageDataSet1();
            this.cUSTOMERTableAdapter = new Mount_Eden_Garage.MountEdenGarageDataSet1TableAdapters.CUSTOMERTableAdapter();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.lblVehicleName = new System.Windows.Forms.Label();
            this.lblVehicleMake = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.lblManDate = new System.Windows.Forms.Label();
            this.txtVehiclePlate = new System.Windows.Forms.TextBox();
            this.txtVehicleMake = new System.Windows.Forms.TextBox();
            this.txtVehicleModel = new System.Windows.Forms.TextBox();
            this.dtpDateOfMan = new System.Windows.Forms.DateTimePicker();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToResizeRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.lastName,
            this.firstName});
            this.dgvCustomers.DataSource = this.cUSTOMERBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(57, 61);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(409, 469);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            this.dgvCustomers.Click += new System.EventHandler(this.dgvCustomers_Click);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "CustomerID";
            this.customerID.HeaderText = "Customer ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Width = 125;
            // 
            // lastName
            // 
            this.lastName.DataPropertyName = "LastName";
            this.lastName.HeaderText = "Last Name";
            this.lastName.MinimumWidth = 6;
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            this.lastName.Width = 140;
            // 
            // firstName
            // 
            this.firstName.DataPropertyName = "FirstName";
            this.firstName.HeaderText = "First Name";
            this.firstName.MinimumWidth = 6;
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            this.firstName.Width = 140;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.mountEdenGarageDataSet1;
            // 
            // mountEdenGarageDataSet1
            // 
            this.mountEdenGarageDataSet1.DataSetName = "MountEdenGarageDataSet1";
            this.mountEdenGarageDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(619, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(102, 24);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(619, 128);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(105, 24);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(730, 75);
            this.txtCustomerLastName.MaxLength = 25;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.ReadOnly = true;
            this.txtCustomerLastName.Size = new System.Drawing.Size(225, 32);
            this.txtCustomerLastName.TabIndex = 1;
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(730, 128);
            this.txtCustomerFirstName.MaxLength = 25;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.ReadOnly = true;
            this.txtCustomerFirstName.Size = new System.Drawing.Size(225, 32);
            this.txtCustomerFirstName.TabIndex = 2;
            // 
            // lblVehicleName
            // 
            this.lblVehicleName.AutoSize = true;
            this.lblVehicleName.Location = new System.Drawing.Point(601, 226);
            this.lblVehicleName.Name = "lblVehicleName";
            this.lblVehicleName.Size = new System.Drawing.Size(121, 24);
            this.lblVehicleName.TabIndex = 5;
            this.lblVehicleName.Text = "Vehicle Plate:";
            // 
            // lblVehicleMake
            // 
            this.lblVehicleMake.AutoSize = true;
            this.lblVehicleMake.Location = new System.Drawing.Point(601, 283);
            this.lblVehicleMake.Name = "lblVehicleMake";
            this.lblVehicleMake.Size = new System.Drawing.Size(124, 24);
            this.lblVehicleMake.TabIndex = 6;
            this.lblVehicleMake.Text = "Vehicle Make:";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.Location = new System.Drawing.Point(592, 337);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(133, 24);
            this.lblVehicleModel.TabIndex = 7;
            this.lblVehicleModel.Text = "Vehicle Model:";
            // 
            // lblManDate
            // 
            this.lblManDate.AutoSize = true;
            this.lblManDate.Location = new System.Drawing.Point(558, 389);
            this.lblManDate.Name = "lblManDate";
            this.lblManDate.Size = new System.Drawing.Size(167, 24);
            this.lblManDate.TabIndex = 8;
            this.lblManDate.Text = "Manufacture Date:";
            // 
            // txtVehiclePlate
            // 
            this.txtVehiclePlate.Location = new System.Drawing.Point(730, 223);
            this.txtVehiclePlate.MaxLength = 10;
            this.txtVehiclePlate.Name = "txtVehiclePlate";
            this.txtVehiclePlate.Size = new System.Drawing.Size(165, 32);
            this.txtVehiclePlate.TabIndex = 3;
            // 
            // txtVehicleMake
            // 
            this.txtVehicleMake.Location = new System.Drawing.Point(730, 275);
            this.txtVehicleMake.MaxLength = 30;
            this.txtVehicleMake.Name = "txtVehicleMake";
            this.txtVehicleMake.Size = new System.Drawing.Size(165, 32);
            this.txtVehicleMake.TabIndex = 4;
            // 
            // txtVehicleModel
            // 
            this.txtVehicleModel.Location = new System.Drawing.Point(730, 329);
            this.txtVehicleModel.MaxLength = 30;
            this.txtVehicleModel.Name = "txtVehicleModel";
            this.txtVehicleModel.Size = new System.Drawing.Size(165, 32);
            this.txtVehicleModel.TabIndex = 5;
            // 
            // dtpDateOfMan
            // 
            this.dtpDateOfMan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfMan.Location = new System.Drawing.Point(730, 383);
            this.dtpDateOfMan.Name = "dtpDateOfMan";
            this.dtpDateOfMan.Size = new System.Drawing.Size(165, 32);
            this.dtpDateOfMan.TabIndex = 6;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.ForeColor = System.Drawing.Color.Black;
            this.btnAddVehicle.Location = new System.Drawing.Point(635, 487);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(152, 43);
            this.btnAddVehicle.TabIndex = 7;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.btnAddVehicle_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(836, 487);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(152, 43);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1032, 571);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.dtpDateOfMan);
            this.Controls.Add(this.txtVehicleModel);
            this.Controls.Add(this.txtVehicleMake);
            this.Controls.Add(this.txtVehiclePlate);
            this.Controls.Add(this.lblManDate);
            this.Controls.Add(this.lblVehicleModel);
            this.Controls.Add(this.lblVehicleMake);
            this.Controls.Add(this.lblVehicleName);
            this.Controls.Add(this.txtCustomerFirstName);
            this.Controls.Add(this.txtCustomerLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountEdenGarageDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private MountEdenGarageDataSet1 mountEdenGarageDataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private MountEdenGarageDataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.Label lblVehicleName;
        private System.Windows.Forms.Label lblVehicleMake;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Label lblManDate;
        private System.Windows.Forms.TextBox txtVehiclePlate;
        private System.Windows.Forms.TextBox txtVehicleMake;
        private System.Windows.Forms.TextBox txtVehicleModel;
        private System.Windows.Forms.DateTimePicker dtpDateOfMan;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
    }
}