
namespace Mount_Eden_Garage
{
    partial class PrintMechanicReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintMechanicReportForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.printMechanic = new System.Drawing.Printing.PrintDocument();
            this.prvMechanics = new System.Windows.Forms.PrintPreviewDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblmechreport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(19, 394);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(168, 40);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print Mechanics";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(214, 394);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 40);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // printMechanic
            // 
            this.printMechanic.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMechanic_PrintPage);
            // 
            // prvMechanics
            // 
            this.prvMechanics.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvMechanics.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvMechanics.ClientSize = new System.Drawing.Size(400, 300);
            this.prvMechanics.Document = this.printMechanic;
            this.prvMechanics.Enabled = true;
            this.prvMechanics.Icon = ((System.Drawing.Icon)(resources.GetObject("prvMechanics.Icon")));
            this.prvMechanics.Name = "prvMechanics";
            this.prvMechanics.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblmechreport
            // 
            this.lblmechreport.AutoSize = true;
            this.lblmechreport.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmechreport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmechreport.Location = new System.Drawing.Point(78, 330);
            this.lblmechreport.Name = "lblmechreport";
            this.lblmechreport.Size = new System.Drawing.Size(234, 29);
            this.lblmechreport.TabIndex = 3;
            this.lblmechreport.Text = "Print Mechanic Report";
            // 
            // PrintMechanicReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(406, 463);
            this.Controls.Add(this.lblmechreport);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnPrint);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintMechanicReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Mechanics";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReturn;
        private System.Drawing.Printing.PrintDocument printMechanic;
        private System.Windows.Forms.PrintPreviewDialog prvMechanics;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblmechreport;
    }
}