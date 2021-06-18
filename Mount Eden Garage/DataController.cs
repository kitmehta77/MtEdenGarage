using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mount_Eden_Garage
{
    public partial class DataController : Form
    {
        public DataTable dtCustomer;
        public DataTable dtMechanic;
        public DataTable dtPart;
        public DataTable dtService;
        public DataTable dtServicePart;
        public DataTable dtVehicle;

        public DataView customerView;
        public DataView mechanicView;
        public DataView partView;
        public DataView serviceView;
        public DataView servicePartView;
        public DataView vehicleView;

        public DataController()
        {
            InitializeComponent();
            dsEdenGarage.EnforceConstraints = false;
            daCustomer.Fill(dsEdenGarage);
            daMechanic.Fill(dsEdenGarage);
            daPart.Fill(dsEdenGarage);
            daService.Fill(dsEdenGarage);
            daServicePart.Fill(dsEdenGarage);
            daVehicle.Fill(dsEdenGarage);

            daService.Update(dsEdenGarage);
            daCustomer.Update(dsEdenGarage);
            daMechanic.Update(dsEdenGarage);
            daPart.Update(dsEdenGarage);
            daService.Update(dsEdenGarage);
            daServicePart.Update(dsEdenGarage);
            daVehicle.Update(dsEdenGarage);


            dtCustomer = dsEdenGarage.Tables["Customer"];
            dtMechanic = dsEdenGarage.Tables["Mechanic"];
            dtPart = dsEdenGarage.Tables["Part"];
            dtService = dsEdenGarage.Tables["Service"];
            dtServicePart = dsEdenGarage.Tables["Servicepart"];
            dtVehicle = dsEdenGarage.Tables["Vehicle"];
            customerView = new DataView(dtCustomer);
            customerView.Sort = "CustomerID";
            mechanicView = new DataView(dtMechanic);
            mechanicView.Sort = "MechanicID";
            partView = new DataView(dtPart);
            partView.Sort = "PartID";
            serviceView = new DataView(dtService);
            serviceView.Sort = "ServiceID";
            servicePartView = new DataView(dtServicePart);
            servicePartView.Sort = "ServiceID, PartID";
            vehicleView = new DataView(dtVehicle);
            vehicleView.Sort = "VehicleID";
           // dsEdenGarage.EnforceConstraints = true;
        }

        private void DataController_Load(object sender, EventArgs e)
        {

        }

        public void AssignPart()
        {
            daServicePart.Update(dsEdenGarage, "Servicepart");
        }
        public void AddNewVehicle()
        {
            daVehicle.Update(dsEdenGarage, "Vehicle");
        }

        private void daVehicle_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMtEdenGarage);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["VehicleID"] = newID;
            }

        }

        public void UpdateVehicle()
        {
            daVehicle.Update(dsEdenGarage,"Vehicle");
        }


        public void AddNewService()
        {

            daService.Fill(dsEdenGarage, "Service");

        }
        private void daService_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMtEdenGarage);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ServiceID"] = newID;
            }

        }

        public void UpdateService()
        {
            daService.Update(dsEdenGarage, "Service");
        }

        public void DeleteServices()
        {
            daService.Update(dsEdenGarage, "Service");
        }

       
        public void DeleteServicePart()
        {
            daServicePart.Update(dsEdenGarage, "Servicepart");
        }

        private void daServicePart_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnMtEdenGarage);
            if (e.StatementType == StatementType.Insert)
            {
                newID = (int)idCMD.ExecuteScalar();
                e.Row["ServiceID"] = newID;
            }

        }

        public void DeletePart()
        {
            daPart.Update(dsEdenGarage, "Part");
        }

        public void DeleteVehicle()
        {
           
            daVehicle.Update(dsEdenGarage, "Vehicle");
            
        }
    }
}
    
