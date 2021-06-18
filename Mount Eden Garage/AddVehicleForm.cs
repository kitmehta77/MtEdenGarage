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
    public partial class AddVehicleForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmVehicle;
        private CurrencyManager cmService;

        public AddVehicleForm(DataController dc, MainForm mnu)
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
            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];

            dgvCustomers.DataSource = DC.dsEdenGarage;
            dgvCustomers.DataMember = "Customer";
        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.mountEdenGarageDataSet1.CUSTOMER);

            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomers.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvCustomers.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCustomers.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCustomers.BorderStyle = BorderStyle.None;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int aCustomerID = Convert.ToInt32(dgvCustomers["CustomerID", cmCustomer.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void clearfield()
        {
            txtVehicleModel.Text = "";
            txtVehiclePlate.Text = "";
            txtVehicleMake.Text = "";
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
        }
        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if ((txtVehicleMake.Text == "") || (txtVehicleModel.Text == "") || (txtVehiclePlate.Text == "")) 
            {
                MessageBox.Show("Please fill in all fields Correctly", "Error");
            }
            else
            {
                try
                {

                    DataRow newVehicleRow = DC.dtVehicle.NewRow();

                    newVehicleRow["PlateNumber"] = txtVehiclePlate.Text;
                    newVehicleRow["Make"] = txtVehicleMake.Text;
                    newVehicleRow["Model"] = txtVehicleModel.Text;
                    newVehicleRow["DateOfManufacture"] = dtpDateOfMan.Text;
                    newVehicleRow["CustomerID"] = dgvCustomers["CustomerID", cmCustomer.Position].Value;



                    DC.dsEdenGarage.Tables["Vehicle"].Rows.Add(newVehicleRow);
                    DC.AddNewVehicle();
                    MessageBox.Show("Vehicle added successfully", "Success");
                    clearfield();

                }



                catch (FormatException ex)
                {
                    MessageBox.Show("Please Fill out all relavant information", "Error");
                }
            }
        }

        private void dgvCustomers_Click(object sender, EventArgs e)
        {
            int aCustomerID = Convert.ToInt32(dgvCustomers["CustomerID", cmCustomer.Position].Value);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

        }
    }
}
