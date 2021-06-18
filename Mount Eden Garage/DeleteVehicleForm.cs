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
    public partial class DeleteVehicleForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmService;
        private CurrencyManager cmVehicle;
        private CurrencyManager cmCustomer;
        CurrencyManager cmServicePart;

        public DeleteVehicleForm(DataController dc, MainForm mnu)
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
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];
            cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "ServicePart"];

            dgvVehicles.DataSource = DC.dsEdenGarage;
            dgvVehicles.DataMember = "Vehicle";


        }

        private void DeleteVehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet3.VEHICLE' table. You can move, or remove it, as needed.
            this.vEHICLETableAdapter.Fill(this.mountEdenGarageDataSet3.VEHICLE);

            dgvVehicles.EnableHeadersVisualStyles = false;
            dgvVehicles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicles.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvVehicles.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVehicles.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvVehicles.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvVehicles.BorderStyle = BorderStyle.None;
            dgvVehicles.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dgvVehicles.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvVehicles.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVehicles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int aCustomerID = Convert.ToInt32(dgvVehicles["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

            txtVehicleID.Text = drVehicle["VehicleID"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            dtpManDate.Value = Convert.ToDateTime(drVehicle["DateofManufacture"].ToString());
        }

        public void clearFields()
        {
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtVehicleID.Text = "";
            txtPlateNumber.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            DataRow car = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow[] noServiceCars = car.GetChildRows(DC.dtVehicle.ChildRelations["Vehicle_Service"]);

            if (noServiceCars.Length == 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this Vehicle?", "Warning",
                                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    car.Delete();
                    DC.DeleteVehicle();

                    MessageBox.Show("Vehicle deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    clearFields();
                }
            }
            else
            {
                MessageBox.Show("Vehicles with services cannot be deleted", "Error", MessageBoxButtons.OK);
            
            }


        }

    

        private void dgvVehicles_Click(object sender, EventArgs e)
        {

            int aCustomerID = Convert.ToInt32(dgvVehicles["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

            txtVehicleID.Text = drVehicle["VehicleID"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            dtpManDate.Value = Convert.ToDateTime(drVehicle["DateofManufacture"].ToString());
        }
    }
}
