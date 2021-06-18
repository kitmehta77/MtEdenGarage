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
    public partial class RemovePartForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmVehicle;
        private CurrencyManager cmService;
        private CurrencyManager cmPart;
        private CurrencyManager cmServicePart;
        private string partID;


        public RemovePartForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();

        }

        public void BindControls()
        {
            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];
            cmPart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Part"];
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
            cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "SERVICEPART"];


            dgvService.DataSource = DC.dsEdenGarage;
            dgvService.DataMember = "Service";

            dgvParts.DataSource = DC.dsEdenGarage;
            dgvParts.DataMember = "Part";

            dgvServicePart.DataSource = DC.dsEdenGarage;
            dgvServicePart.DataMember = "SERVICEPART";


        }
        public void ClearFields()
        {
            txtCustomerFirstName.Text = "";
            txtCustomerLastName.Text = "";
            txtPartDetails.Text = "";
            txtPlateNumber.Text = "";
            txtServiceDescription.Text = "";
            txtServiceID.Text = "";
        }

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];

            int aCustomerID = Convert.ToInt32(drVehicle["CustomerID"]);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"]);
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();

            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

            string partDetailsText = "";
            txtPartDetails.Text = "";
            lblParts1.Text = "";

            if (drServiceParts.Length == 0)
            {
                lstParts.Items.Clear();
                lblParts1.Text = "No Parts Attached to this Service!";
                lblParts1.ForeColor = Color.Red;
                return;
            }
            else
            {
                foreach (DataRow drServicePart in drServiceParts)
                {
                    DataRow drSP = DC.dtServicePart.Rows[cmServicePart.Position];
                    int aPartID = Convert.ToInt32(drServicePart["PartID"].ToString());
                    cmPart.Position = DC.partView.Find(aPartID);
                    DataRow drPart = DC.dtPart.Rows[cmPart.Position];


                    partDetailsText += "Part ID:" + drPart["PartID"] + "   ";
                    partDetailsText += drPart["PartDescription"] + "   " + "Quantity: ";
                    partDetailsText += drServicePart["Quantity"];
                    partDetailsText += ",";
                    lstParts.Items.Clear();
                }
                txtPartDetails.Text += partDetailsText;
                String[] Values = txtPartDetails.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstParts.Items.Add(Value.Trim());
                }
                partDetailsText = "";

            }

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void RemovePartForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.mountEdenGarageDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.VEHICLE' table. You can move, or remove it, as needed.
            // this.vEHICLETableAdapter.Fill(this.mountEdenGarageDataSet.VEHICLE);

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

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            int aServiceID = Convert.ToInt32(dgvService["ServiceID", cmService.Position].Value);
            cmService.Position = DC.serviceView.Find(aServiceID);
            DataRow drService = DC.dtService.Rows[cmService.Position];
            //string servicePartID = drService["PartID"].ToString();
            string servicePartID = aServiceID.ToString() + partID;
            // Create an array for the key values to find.
            object[] findTheseVals = new object[2];

            // Set the values of the keys to find.
            findTheseVals[0] = aServiceID.ToString();
            findTheseVals[1] = partID;
            cmServicePart.Position = DC.servicePartView.Find(findTheseVals);

            DataRow deletePartRow = DC.dtServicePart.Rows[cmServicePart.Position];
            DataRow[] drParts = deletePartRow.GetChildRows(DC.dtServicePart.ChildRelations["SERVICE_SERVICEPART"]);


            if (drParts.Length == 0)
            {

                if (MessageBox.Show("Are you sure you want to remove this Part?", "Warning",
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    for (int i = 0; i < lstParts.SelectedItems.Count; i++)
                    {
                        lstParts.Items.Remove(lstParts.SelectedItems[i]);

                    }
                   
                    deletePartRow.Delete();
                    DC.DeleteServicePart();

                    MessageBox.Show("Part deleted successfully", "Acknowledgement", MessageBoxButtons.OK);
                    ClearFields();
                }
            }

        }

        private void dgvService_Click(object sender, EventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];

            int aCustomerID = Convert.ToInt32(drVehicle["CustomerID"]);
            cmCustomer.Position = DC.customerView.Find(aCustomerID);

            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtCustomerLastName.Text = drCustomer["LastName"].ToString();
            txtCustomerFirstName.Text = drCustomer["FirstName"].ToString();

            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"].ToString());
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();

            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

            string partDetailsText = "";
            txtPartDetails.Text = "";
            lblParts1.Text = "";

            if (drServiceParts.Length == 0)
            {
                lstParts.Items.Clear();
                lblParts1.Text = "No Parts Attached to this Service!";
                lblParts1.ForeColor = Color.Red;
                return;
            }
            else
            {
                foreach (DataRow drServicePart in drServiceParts)
                {
                    DataRow drSP = DC.dtServicePart.Rows[cmServicePart.Position];
                    int aPartID = Convert.ToInt32(drServicePart["PartID"].ToString());
                    cmPart.Position = DC.partView.Find(aPartID);
                    DataRow drPart = DC.dtPart.Rows[cmPart.Position];


                    partDetailsText += "Part ID:" + drPart["PartID"] + "   ";
                    partDetailsText += drPart["PartDescription"] + "   " + "Quantity: ";
                    partDetailsText += drServicePart["Quantity"];
                    partDetailsText += ",";
                    lstParts.Items.Clear();
                }
                txtPartDetails.Text += partDetailsText;
                String[] Values = txtPartDetails.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstParts.Items.Add(Value.Trim());
                }
                partDetailsText = "";

            }


        }

        private void lstParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstParts.SelectedItem != null)
            {
                int startIndex = 8;
                int length = 2;
                string part;
                part = lstParts.SelectedItem.ToString();
                partID = part.Substring(startIndex,length);


            }
        }
    }
}