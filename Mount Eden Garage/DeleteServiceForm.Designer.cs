
namespace Mount_Eden_Garage
{
    partial class DeleteServiceForm
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
            this.lblServiceID = new System.Windows.Forms.Label();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.lblServiceFee = new System.Windows.Forms.Label();
            this.lblServiceDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.dtpServiceDate = new System.Windows.Forms.DateTimePicker();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtServiceFee = new System.Windows.Forms.NumericUpDown();
            this.lstServices = new System.Windows.Forms.ListBox();
            this.lstServices1 = new System.Windows.Forms.ListBox();
            this.lblService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceID.Location = new System.Drawing.Point(516, 106);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(95, 24);
            this.lblServiceID.TabIndex = 1;
            this.lblServiceID.Text = "Service ID:";
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceDescription.Location = new System.Drawing.Point(439, 158);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(172, 24);
            this.lblServiceDescription.TabIndex = 2;
            this.lblServiceDescription.Text = "Service Description:";
            // 
            // lblServiceFee
            // 
            this.lblServiceFee.AutoSize = true;
            this.lblServiceFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceFee.Location = new System.Drawing.Point(504, 272);
            this.lblServiceFee.Name = "lblServiceFee";
            this.lblServiceFee.Size = new System.Drawing.Size(107, 24);
            this.lblServiceFee.TabIndex = 3;
            this.lblServiceFee.Text = "Service Fee:";
            // 
            // lblServiceDate
            // 
            this.lblServiceDate.AutoSize = true;
            this.lblServiceDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblServiceDate.Location = new System.Drawing.Point(494, 322);
            this.lblServiceDate.Name = "lblServiceDate";
            this.lblServiceDate.Size = new System.Drawing.Size(117, 24);
            this.lblServiceDate.TabIndex = 4;
            this.lblServiceDate.Text = "Service Date:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStatus.Location = new System.Drawing.Point(544, 369);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 24);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // txtServiceID
            // 
            this.txtServiceID.Location = new System.Drawing.Point(620, 103);
            this.txtServiceID.MaxLength = 8;
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(51, 32);
            this.txtServiceID.TabIndex = 1;
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Location = new System.Drawing.Point(620, 155);
            this.txtServiceDescription.MaxLength = 100;
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.ReadOnly = true;
            this.txtServiceDescription.Size = new System.Drawing.Size(262, 96);
            this.txtServiceDescription.TabIndex = 2;
            // 
            // dtpServiceDate
            // 
            this.dtpServiceDate.Enabled = false;
            this.dtpServiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpServiceDate.Location = new System.Drawing.Point(621, 320);
            this.dtpServiceDate.Name = "dtpServiceDate";
            this.dtpServiceDate.Size = new System.Drawing.Size(149, 32);
            this.dtpServiceDate.TabIndex = 4;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(621, 369);
            this.txtStatus.MaxLength = 7;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(118, 32);
            this.txtStatus.TabIndex = 5;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(529, 483);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(142, 35);
            this.btnDeleteService.TabIndex = 6;
            this.btnDeleteService.Text = "Delete Service";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(739, 483);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(142, 35);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.DecimalPlaces = 2;
            this.txtServiceFee.Enabled = false;
            this.txtServiceFee.Location = new System.Drawing.Point(621, 270);
            this.txtServiceFee.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.Size = new System.Drawing.Size(92, 32);
            this.txtServiceFee.TabIndex = 3;
            // 
            // lstServices
            // 
            this.lstServices.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstServices.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstServices.FormattingEnabled = true;
            this.lstServices.ItemHeight = 24;
            this.lstServices.Location = new System.Drawing.Point(76, 62);
            this.lstServices.Name = "lstServices";
            this.lstServices.Size = new System.Drawing.Size(56, 456);
            this.lstServices.TabIndex = 15;
            // 
            // lstServices1
            // 
            this.lstServices1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstServices1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstServices1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lstServices1.FormattingEnabled = true;
            this.lstServices1.ItemHeight = 24;
            this.lstServices1.Location = new System.Drawing.Point(128, 62);
            this.lstServices1.Name = "lstServices1";
            this.lstServices1.Size = new System.Drawing.Size(244, 456);
            this.lstServices1.TabIndex = 16;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblService.Location = new System.Drawing.Point(81, 30);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(326, 36);
            this.lblService.TabIndex = 17;
            this.lblService.Text = "ID        Service Description";
            // 
            // DeleteServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(956, 567);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.lstServices1);
            this.Controls.Add(this.lstServices);
            this.Controls.Add(this.txtServiceFee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteService);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtpServiceDate);
            this.Controls.Add(this.txtServiceDescription);
            this.Controls.Add(this.txtServiceID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblServiceDate);
            this.Controls.Add(this.lblServiceFee);
            this.Controls.Add(this.lblServiceDescription);
            this.Controls.Add(this.lblServiceID);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteServiceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Service";
            this.Load += new System.EventHandler(this.DeleteServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtServiceFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblServiceID;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.Label lblServiceFee;
        private System.Windows.Forms.Label lblServiceDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.DateTimePicker dtpServiceDate;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.NumericUpDown txtServiceFee;
        private System.Windows.Forms.ListBox lstServices;
        private System.Windows.Forms.ListBox lstServices1;
        private System.Windows.Forms.Label lblService;
    }
}