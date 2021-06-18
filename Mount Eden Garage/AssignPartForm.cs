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
    public partial class AssignPartForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmCustomer;
        private CurrencyManager cmVehicle;
        private CurrencyManager cmService;
        private CurrencyManager cmPart;
        private CurrencyManager cmServicePart;
       
        
        public AssignPartForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
            LoadParts();
        }

        private void LoadParts()
        {
            cboPartID.DataSource = DC.dsEdenGarage;
            cboPartID.DisplayMember = "Part.PartID";
            cboPartID.ValueMember = "Part.PartID";

            cboPartDescription.DataSource = DC.dsEdenGarage;
            cboPartDescription.DisplayMember = "Part.PartDescription";
            cboPartDescription.ValueMember = "Part.PartDescription";
        }

        public void BindControls()
        {
            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];
            cmPart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Part"];
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
            cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Servicepart"];
            
            
            dgvService.DataSource = DC.dsEdenGarage;
            dgvService.DataMember = "Service";

            
        }
        private void AssignPartForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.SERVICEPART' table. You can move, or remove it, as needed.
            //this.sERVICEPARTTableAdapter1.Fill(this.mountEdenGarageDataSet.SERVICEPART);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet.PART' table. You can move, or remove it, as needed.
            this.pARTTableAdapter.Fill(this.mountEdenGarageDataSet.PART);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet4.SERVICEPART' table. You can move, or remove it, as needed.
            this.sERVICEPARTTableAdapter.Fill(this.mountEdenGarageDataSet4.SERVICEPART);
            // TODO: This line of code loads data into the 'mountEdenGarageDataSet4.SERVICE' table. You can move, or remove it, as needed.
            this.sERVICETableAdapter.Fill(this.mountEdenGarageDataSet4.SERVICE);

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

        private void dgvService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drPart = DC.dtPart.Rows[cmPart.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];
            DataRow drServicePart = DC.dtServicePart.Rows[cmServicePart.Position];

            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"].ToString());
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtVehicleID.Text = drService["VehicleID"].ToString();
            cboPartID.Text = drPart["PartID"].ToString();
            cboPartDescription.Text = drPart["PartDescription"].ToString();
            nudQuantity.Value = Convert.ToInt32(drServicePart["Quantity"].ToString());

            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

            string partDetailsText = "";
            lstCurrentParts.Text = "";
            lstCurrentParts.ForeColor = Color.Black;

            if (drServiceParts.Length == 0)
            {
                lstCurrentParts.Items.Clear();
                partDetailsText += "No Parts Attached to this Service!";
                lstCurrentParts.Items.Add(partDetailsText);
                lstCurrentParts.ForeColor = Color.Red;

                return;
            }
            else
            {
                foreach (DataRow drSParts in drServiceParts)
                {
                  
                    DataRow drSP = DC.dtServicePart.Rows[cmServicePart.Position];
                    int aPartID = Convert.ToInt32(drSParts["PartID"].ToString());
                    cmPart.Position = DC.partView.Find(aPartID);
                    DataRow drParts = DC.dtPart.Rows[cmPart.Position];


                    partDetailsText += "Part ID:" + drParts["PartID"] + "   ";
                    partDetailsText += drParts["PartDescription"] + "   " + "Quantity: ";
                    partDetailsText += drSParts["Quantity"];
                    partDetailsText += ",";
                    lstCurrentParts.Items.Clear();
                }
                lstCurrentParts.Text += partDetailsText;
                String[] Values = lstCurrentParts.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstCurrentParts.Items.Add(Value.Trim());
                }
                partDetailsText = "";


            }
        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void clearField()
        {
            txtPlateNumber.Text = "";
            txtServiceDescription.Text = "";
            txtServiceID.Text = "";
            txtVehicleID.Text = "";
            cboPartID.Text = "";
            cboPartDescription.Text = "";
            nudQuantity.Value = 1;
            dtpServiceDate.Value = DateTime.Now;

        }

        private void btnAssignPart_Click(object sender, EventArgs e)
        {

            try
            {
                DataRow AssignPart = DC.dtServicePart.NewRow();

                AssignPart["ServiceID"] = txtServiceID.Text;
                AssignPart["PartID"] = cboPartID.Text;
                AssignPart["Quantity"] = nudQuantity.Value;

                DC.dsEdenGarage.Tables["Servicepart"].Rows.Add(AssignPart);

                DC.daVehicle.Update(DC.dsEdenGarage, "Vehicle");
                DC.AssignPart();
                MessageBox.Show("Parts Assigned successfully", "Success");
                clearField();
            }
            catch(System.Data.ConstraintException)
            {
                MessageBox.Show("Please fill in details correctly!", "Error");
            }
            catch (System.Data.OleDb.OleDbException)
            {
                MessageBox.Show("Parts are already assigned to the same Service.", "Error");
            }

        }

        private void dgvService_Click(object sender, EventArgs e)
        {
            int aVehicleID = Convert.ToInt32(dgvService["VehicleID", cmService.Position].Value);
            cmVehicle.Position = DC.vehicleView.Find(aVehicleID);

            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
            DataRow drPart = DC.dtPart.Rows[cmPart.Position];
            DataRow drService = DC.dtService.Rows[cmService.Position];
            DataRow drServicePart = DC.dtServicePart.Rows[cmServicePart.Position];

            dtpServiceDate.Value = Convert.ToDateTime(drService["ServiceDate"].ToString());
            txtServiceID.Text = drService["ServiceID"].ToString();
            txtServiceDescription.Text = drService["ServiceDescription"].ToString();
            txtPlateNumber.Text = drVehicle["PlateNumber"].ToString();
            txtVehicleID.Text = drService["VehicleID"].ToString();
            cboPartID.Text = drPart["PartID"].ToString();
            cboPartDescription.Text = drPart["PartDescription"].ToString();
            nudQuantity.Value = Convert.ToInt32(drServicePart["Quantity"].ToString());

            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

            string partDetailsText = "";
            lstCurrentParts.Text = "";
            lstCurrentParts.ForeColor = Color.Black;


            if (drServiceParts.Length == 0)
            {
                lstCurrentParts.Items.Clear();
                partDetailsText += "No Parts Attached to this Service!";
                
                lstCurrentParts.Items.Add(partDetailsText);
                lstCurrentParts.ForeColor = Color.Red;

                return;
            }
            else
            {
                foreach (DataRow drSParts in drServiceParts)
                {
                    DataRow drSP = DC.dtServicePart.Rows[cmServicePart.Position];
                    int aPartID = Convert.ToInt32(drSParts["PartID"].ToString());
                    cmPart.Position = DC.partView.Find(aPartID);
                    DataRow drParts = DC.dtPart.Rows[cmPart.Position];


                    partDetailsText += "Part ID:" + drParts["PartID"] + "   ";
                    partDetailsText += drParts["PartDescription"] + "   " + "Quantity: ";
                    partDetailsText += drSParts["Quantity"];
                    partDetailsText += ",";
                    lstCurrentParts.Items.Clear();
                }
                lstCurrentParts.Text += partDetailsText;
                String[] Values = lstCurrentParts.Text.Split(',');

                foreach (string Value in Values)
                {
                    if (Value.Trim() == "")
                        continue;
                    lstCurrentParts.Items.Add(Value.Trim());
                }
                partDetailsText = "";
            }
        }
      
    }
}
