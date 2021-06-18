using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mount_Eden_Garage
{
    public partial class UpdateServiceForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmService;
        private CurrencyManager cmVehicle;
        public UpdateServiceForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();

        }

        public void BindControls()
        {
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];

             dgvService.DataSource = DC.dsEdenGarage;
             dgvService.DataMember = "Service";

             dgvCustomer.DataSource = DC.dsEdenGarage;
             dgvCustomer.DataMember = "Customer";

            dgvVehicle.DataSource = DC.dsEdenGarage;
            dgvVehicle.DataMember = "Vehicle";
        }


        private void clearField()
        {
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtServiceDescription.Text = "";
            txtServiceID.Text = "";

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);
            int aCustomerID = Convert.ToInt32(dgvVehicle["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            nudServiceFee.Value = Convert.ToDecimal(drService["ServiceFee"]);
            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"]);
            cboStatus.Text = drService["Status"].ToString();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if ((txtServiceDescription.Text == "") || (txtServiceID.Text == "") || (nudServiceFee.Text == ""))
            {

                MessageBox.Show("Please fill in all fields correctly.", "Error");
                return;
            }

            {
                try
                {
                    DataRow updateServiceRow = DC.dtService.Rows[cmService.Position];

                    updateServiceRow["ServiceDescription"] = txtServiceDescription.Text;
                    updateServiceRow["ServiceFee"] = nudServiceFee.Value;
                    updateServiceRow["ServiceDate"] = dtpServiceDate.Value;
                    updateServiceRow["Status"] = cboStatus.Text;
                    cmService.EndCurrentEdit();

                    DC.daService.Update(DC.dsEdenGarage, "Service");
                    DC.UpdateService();
                    MessageBox.Show("Service Updated successfully", "Success");
                    clearField();


                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Please Fill out all relavant information", "Error");
                }
            }
        }

        private void UpdateServiceForm_Load(object sender, EventArgs e)
        {
            dgvService.EnableHeadersVisualStyles = false;
            dgvService.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvService.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvService.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvService.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvService.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvService.BorderStyle = BorderStyle.None;
            dgvService.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dgvService.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvService.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvService.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvService_Click(object sender, EventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);
            int aCustomerID = Convert.ToInt32(dgvVehicle["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            nudServiceFee.Value = Convert.ToDecimal(drService["ServiceFee"]);
            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"]);
            cboStatus.Text = drService["Status"].ToString();

        }
    }

}