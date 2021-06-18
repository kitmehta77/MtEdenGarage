using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Mount_Eden_Garage
{
    public partial class UpdateVehicleForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmVehicle;
        
        public UpdateVehicleForm(DataController dc, MainForm mnu)
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
            

            dgvCustomer.DataSource = DC.dsEdenGarage;
            dgvCustomer.DataMember = "Customer";

            dgvVehicle.DataSource = DC.dsEdenGarage;
            dgvVehicle.DataMember = "Vehicle";

        }

        private void clearField()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtMake.Text = "";
            txtModel.Text = "";
            txtPlateNumber.Text = "";
            txtVehicleID.Text = "";
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            DataRow updateVehicleRow = DC.dtVehicle.Rows[cmVehicle.Position];

            if ((txtMake.Text == "") || (txtModel.Text == "") || (txtPlateNumber.Text == ""))
            {

                MessageBox.Show("Please fill in all fields Correctly.", "Error");
                return;
            }

            {
                try
                {
                    updateVehicleRow["PlateNumber"] = txtPlateNumber.Text;
                    updateVehicleRow["Make"] = txtMake.Text;
                    updateVehicleRow["Model"] = txtModel.Text;
                    updateVehicleRow["DateofManufacture"] = dtpManDate.Value;
                    cmVehicle.EndCurrentEdit();

                    DC.daVehicle.Update(DC.dsEdenGarage, "Vehicle");
                    DC.UpdateVehicle();
                    MessageBox.Show("Vehicle Updated successfully", "Success");
                    clearField();
                }

                catch (FormatException ex)
                {
                    MessageBox.Show("Please Fill out all relavant information", "Error");
                }
            }
        }

        private void UpdateVehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.mountEdenGarageDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.VEHICLE' table. You can move, or remove it, as needed.
            //this.vEHICLETableAdapter.Fill(this.mountEdenGarageDataSet.VEHICLE);

            dgvVehicle.EnableHeadersVisualStyles = false;
            dgvVehicle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicle.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvVehicle.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVehicle.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvVehicle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvVehicle.BorderStyle = BorderStyle.None;
            dgvVehicle.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dgvVehicle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvVehicle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void dgvVehicle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int aCustomerID = Convert.ToInt32(dgvVehicle["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtLastName.Text = drCustomer["LastName"].ToString();
            txtFirstName.Text = drCustomer["FirstName"].ToString();

            txtVehicleID.Text = drVehicle["VehicleID"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtModel.Text = drVehicle["Model"].ToString();
            txtMake.Text = drVehicle["Make"].ToString();
            dtpManDate.Value = Convert.ToDateTime(drVehicle["DateofManufacture"].ToString());
        }

        private void dgvVehicle_Click(object sender, EventArgs e)
        {
            int aCustomerID = Convert.ToInt32(dgvVehicle["CustomerID", cmVehicle.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtLastName.Text = drCustomer["LastName"].ToString();
            txtFirstName.Text = drCustomer["FirstName"].ToString();

            txtVehicleID.Text = drVehicle["VehicleID"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtModel.Text = drVehicle["Model"].ToString();
            txtMake.Text = drVehicle["Make"].ToString();
            dtpManDate.Value = Convert.ToDateTime(drVehicle["DateofManufacture"].ToString());
        }
    }
}
