
namespace Mount_Eden_Garage
{
    partial class PrintInvoicesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintInvoicesForm));
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printInvoices = new System.Drawing.Printing.PrintDocument();
            this.prvInvoices = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.Location = new System.Drawing.Point(30, 422);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(163, 39);
            this.btnPrintInvoice.TabIndex = 0;
            this.btnPrintInvoice.Text = "Print Invoices";
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(261, 422);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(164, 39);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printInvoices
            // 
            this.printInvoices.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printInvoices_PrintPage);
            // 
            // prvInvoices
            // 
            this.prvInvoices.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvInvoices.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvInvoices.ClientSize = new System.Drawing.Size(400, 300);
            this.prvInvoices.Document = this.printInvoices;
            this.prvInvoices.Enabled = true;
            this.prvInvoices.Icon = ((System.Drawing.Icon)(resources.GetObject("prvInvoices.Icon")));
            this.prvInvoices.Name = "prvInvoices";
            this.prvInvoices.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PrintInvoicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(462, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrintInvoice);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintInvoicesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Invoices";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printInvoices;
        private System.Windows.Forms.PrintPreviewDialog prvInvoices;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}