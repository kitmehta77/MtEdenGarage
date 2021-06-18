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
    public partial class MainForm : Form
    {
        private DataController DC;
        private AddServiceForm frmAddService;
        private UpdateServiceForm frmUpdateService;
        private DeleteServiceForm frmDeleteService;
        private AddVehicleForm frmAddVehicle;
        private UpdateVehicleForm frmUpdateVehicle;
        private DeleteVehicleForm frmDeleteVehicle;
        private AssignPartForm frmAssignPart;
        private RemovePartForm frmRemovePart;
        private PrintMechanicReportForm frmPrintMechReport;
        private PrintInvoicesForm frmPrintInvoices;
      
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (frmAddService == null)
            {
                frmAddService = new AddServiceForm(DC, this);
            }
            frmAddService.ShowDialog();
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (frmUpdateService == null)
            {
                frmUpdateService = new UpdateServiceForm(DC, this);
            }
            frmUpdateService.ShowDialog();
        }

        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            if (frmDeleteService == null)
            {
                frmDeleteService = new DeleteServiceForm(DC, this);
            }
            frmDeleteService.ShowDialog();

        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            if (frmAddVehicle == null)
            {
                frmAddVehicle = new AddVehicleForm(DC, this);
            }
            frmAddVehicle.ShowDialog();
        }

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (frmUpdateVehicle == null)
            {
                frmUpdateVehicle = new UpdateVehicleForm(DC, this);
            }
            frmUpdateVehicle.ShowDialog();
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (frmDeleteVehicle == null)
            {
                frmDeleteVehicle = new DeleteVehicleForm(DC, this);
            }
            frmDeleteVehicle.ShowDialog();
        }

        private void btnAssignPart_Click(object sender, EventArgs e)
        {
            if (frmAssignPart == null)
            {
                frmAssignPart = new AssignPartForm(DC, this);
            }
            frmAssignPart.ShowDialog();
        }

        private void btnRemovePart_Click(object sender, EventArgs e)
        {
            if (frmRemovePart == null)
            {
                frmRemovePart = new RemovePartForm(DC, this);
            }
            frmRemovePart.ShowDialog();
        }

        private void btnPrintMecReport_Click(object sender, EventArgs e)
        {
            if (frmPrintMechReport == null)
            {
                frmPrintMechReport = new PrintMechanicReportForm(DC, this);
            }
            frmPrintMechReport.ShowDialog(); 
        }

        private void btnPrintInvoices_Click_1(object sender, EventArgs e)
        {
            if (frmPrintInvoices == null)
            {
                frmPrintInvoices = new PrintInvoicesForm(DC, this);
            }
            frmPrintInvoices.ShowDialog();
        }
    }
}
