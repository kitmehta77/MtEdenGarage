using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Mount_Eden_Garage
{
    public partial class DeleteServiceForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmService;


        public DeleteServiceForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
            

        }

        private void DeleteServiceForm_Load(object sender, EventArgs e)
        {

            lstServices.BorderStyle = BorderStyle.None;
            lstServices1.BorderStyle = BorderStyle.None;
            lstServices.BackColor = Color.Black;
            lstServices1.BackColor = Color.Black;
            lstServices.ForeColor = Color.White;
            lstServices1.ForeColor = Color.White;
            
        }

        public void BindControls()
        {
            txtServiceID.DataBindings.Add("Text", DC.dsEdenGarage, "Service.ServiceID");
            txtServiceDescription.DataBindings.Add("Text", DC.dsEdenGarage, "Service.ServiceDescription");
            txtServiceFee.DataBindings.Add("Value", DC.dsEdenGarage, "Service.ServiceFee");
            txtStatus.DataBindings.Add("Text", DC.dsEdenGarage, "Service.Status");
            dtpServiceDate.DataBindings.Add("Text", DC.dsEdenGarage, "Service.ServiceDate");

            lstServices.DataSource = DC.dsEdenGarage;
            lstServices.DisplayMember = "Service.ServiceID";
            lstServices.ValueMember = "Service.ServiceID";
            

            lstServices1.DataSource = DC.dsEdenGarage;
            lstServices1.DisplayMember = "Service.ServiceDescription";
            lstServices1.ValueMember = "Service.ServiceDescription";

            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];

        }

        public void clearFields()
        {
            txtServiceID.Text = "";
            txtStatus.Text = "Current";
            txtServiceDescription.Text = "";
            txtServiceFee.Value = 50;

        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            CurrencyManager cmServicePart;
            cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Servicepart"];
            DataRow deleteSeriveRow = DC.dtServicePart.Rows[cmServicePart.Position];
         
            DataRow drService = DC.dtService.Rows[cmService.Position];
            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

            if (txtStatus.Text == "Paid")
            {

                if (MessageBox.Show("Are you sure you want to delete this Service?", "Warning",
                              MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    foreach (DataRow drServicepart in drServiceParts)

                    {
                        drServicepart.Delete();
                    }
                    drService.Delete();
                    DC.DeleteServicePart();
                    DC.DeleteServices();
                    clearFields();

                    MessageBox.Show("Service deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Current Services cannot be deleted.", "Error");
                }

            }
            else
            {
                MessageBox.Show("This Service cannot be deleted.", "Error");
            }
            

        }
    }
}
