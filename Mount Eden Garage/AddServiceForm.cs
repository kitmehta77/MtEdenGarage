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
    public partial class AddServiceForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmCustomerVehicle;
        private CurrencyManager cmVehicle;
        public AddServiceForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            DC.customerView.RowFilter = "CreditStatus = 'Valid'";
            BindControls();
            LoadMechanics();
            

        }
        private void AddServiceForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.CUSTOMER' table. You can move, or remove it, as needed.
          //  this.cUSTOMERTableAdapter.Fill(this.mountEdenGarageDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.VEHICLE' table. You can move, or remove it, as needed.
          //  this.vEHICLETableAdapter.Fill(this.mountEdenGarageDataSet.VEHICLE);

            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCustomer.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvCustomer.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvCustomer.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvCustomer.BorderStyle = BorderStyle.None;
            dgvCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 14, FontStyle.Bold);

            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvVehicle.EnableHeadersVisualStyles = false;
            dgvVehicle.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicle.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dgvVehicle.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVehicle.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvVehicle.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvVehicle.BorderStyle = BorderStyle.None;
            dgvVehicle.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 12, FontStyle.Bold);
            dgvVehicle.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 37, 38);
            dgvVehicle.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvCustomer.AllowUserToResizeRows = false;
            dgvVehicle.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgvVehicle.AllowUserToResizeRows = false;

            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehicle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
 
        }

        public void BindControls()
        {
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
            cmCustomerVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer.CUSTOMER_VEHICLE"];

            dgvCustomer.DataSource = DC.dsEdenGarage;
            dgvCustomer.DataMember = "Customer";
         

            dgvVehicle.DataSource = DC.dsEdenGarage;
            dgvVehicle.DataMember = "Customer.Customer_Vehicle";

            
        }
        private void LoadMechanics()
        {
            cboMechanicId.DataSource = DC.dsEdenGarage;
            cboMechanicId.DisplayMember = "Mechanic.MechanicID";
            cboMechanicId.ValueMember = "Mechanic.MechanicID";

            cboMechLastName.DataSource = DC.dsEdenGarage;
            cboMechLastName.DisplayMember = "Mechanic.LastName";
            cboMechLastName.ValueMember = "Mechanic.LastName";

            cboMechFirstName.DataSource = DC.dsEdenGarage;
            cboMechFirstName.DisplayMember = "Mechanic.FirstName";
            cboMechFirstName.ValueMember = "Mechanic.FirstName";

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
            DataRow[] drVehicles = drCustomer.GetChildRows(DC.dtCustomer.ChildRelations["CUSTOMER_VEHICLE"]);

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

        }
        public void clearFields()
        {
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtDescription.Text = "";
            cboMechanicId.Text = "";
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text == "" || nudServiceFee.Text == "")
            {
                MessageBox.Show("Please fill in all fields Correctly.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                
                DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
                DataRow[] drVehicles = drCustomer.GetChildRows(DC.dtCustomer.ChildRelations["CUSTOMER_VEHICLE"]);

                if (drVehicles.Length == 0)
                {
                    MessageBox.Show("There is no Vehicle assigned to this customer!", "Error", MessageBoxButtons.OK);
                    
                }
                else
                {
                    DataRow newServiceID = DC.dtService.NewRow();

                    newServiceID["ServiceFee"] = nudServiceFee.Value;
                    newServiceID["ServiceDescription"] = txtDescription.Text;
                    newServiceID["ServiceDate"] = dtpServiceDate.Value;

                    newServiceID["VehicleID"] = dgvVehicle["VehicleID", cmCustomerVehicle.Position].Value;

                    newServiceID["Status"] = "Current";
                    newServiceID["MechanicID"] = cboMechanicId.Text;
                    DC.dsEdenGarage.Tables["Service"].Rows.Add(newServiceID);
                    DC.UpdateService();
                    MessageBox.Show("Service added Successfully!", "Acknowledgment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }

                DC.AddNewService();
                
            }
            
        }

        private void dgvCustomer_Click(object sender, EventArgs e)
        {
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];
            DataRow[] drVehicles = drCustomer.GetChildRows(DC.dtCustomer.ChildRelations["CUSTOMER_VEHICLE"]);

            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

        }
    }
}
