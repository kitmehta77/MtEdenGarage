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
    public partial class PrintMechanicReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int amountOfMechanicsPrinted, pagesAmountExpected;
        private DataRow[] mechanicsForPrint;
        public PrintMechanicReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();

        }

        private void printMechanic_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Calibri", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Calibri", 16, FontStyle.Bold);
            Font totalSubtotal = new Font("Calibri", 12, FontStyle.Bold);
            Font headingFont = new Font("Calibri", 12, FontStyle.Bold);

            DataRow drMechanic = mechanicsForPrint[amountOfMechanicsPrinted];
            CurrencyManager cmVehicle;
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];

            Brush brush = new SolidBrush(Color.Black);

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;


            g.DrawString("Mount Eden Garage" + "\r\n" + " Mechanics Report", textFontCenter, brush, leftMargin + 40 + topMarginDetails, topMargin);

            linesSoFar++;
            linesSoFar++;
            linesSoFar++;
            linesSoFar++;


            g.DrawString("Mechanic ID: " + drMechanic["MechanicID"].ToString() + "\r\n" + "Name: " + drMechanic["LastName"] + " " + drMechanic["FirstName"] + "\r\n"
                         + "Phone Number:" + drMechanic["PhoneNumber"] + "\r\n", headingFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));


            g.DrawString("Fee: $" + string.Format("{0:#,##0.00}", drMechanic["Fee"]), headingFont, brush, rightMargin - 120, topMargin + (linesSoFar * textFont.Height));


            linesSoFar++;
            linesSoFar++;
            linesSoFar++;
            linesSoFar++;
            linesSoFar++;


            DataRow[] drServices = drMechanic.GetChildRows(DC.dtMechanic.ChildRelations["MECHANIC_SERVICE"]);

            if (drServices.Length == 0)
            {
                
                g.DrawString("No Services have been Assigned to this Mechanic yet!", textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
            }
            else
            {
                foreach (DataRow drService in drServices)
                {
                    string vehicleDetails = "";
                    string customerName = "";
                    

                    int aVehicleID = Convert.ToInt32(drService["VehicleID"].ToString());
                    cmVehicle.Position = DC.vehicleView.Find(aVehicleID);
                    DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];

                  
                    g.DrawString(" Service ID: " + drService["ServiceID"]
                                        + "                        Date: " + string.Format("{0:d/M/yyyy}",drService["ServiceDate"]), textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                    g.DrawString("Status: " + drService["Status"], textFont, brush, rightMargin - 120, topMargin +
                                (linesSoFar * textFont.Height));

                    linesSoFar++;

                    g.DrawString(" Description:  " + drService["ServiceDescription"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                    g.DrawString("Fee:  $" + string.Format("{0:#,##0.00}",drService["ServiceFee"]), textFont, brush, rightMargin - 120, topMargin +
                                (linesSoFar * textFont.Height));

                    linesSoFar++;
                    linesSoFar++;

                    vehicleDetails += " Vehicle ID: " + drVehicle["VehicleID"]
                                        + "          Plate Number: " + drVehicle["PlateNumber"] + "\r\n"
                                        + " Date of Manufacture: " + string.Format("{0:d/M/yyyy}", drVehicle["DateOfManufacture"]);
                    g.DrawString(vehicleDetails, textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));

                    
                    CurrencyManager cmCustmer;
                    cmCustmer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
                    int aCustmerID = Convert.ToInt32(drVehicle["CustomerID"].ToString());
                    cmCustmer.Position = DC.customerView.Find(aCustmerID);
                    DataRow drCustomer = DC.dtCustomer.Rows[cmCustmer.Position];

                    customerName += "Customer ID: " + drCustomer["CustomerID"] + "    Name: " + drCustomer["LastName"] + ", " + drCustomer["FirstName"];
                   
                    linesSoFar++;
                    linesSoFar++;
                    g.DrawString(customerName, textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));

                    
                    linesSoFar++;
                    linesSoFar++;

                    CurrencyManager cmPart;
                    CurrencyManager cmServicePart;
                    cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "ServicePart"];
                    


                    DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);

                    g.DrawString("Parts:", textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

                    if (drServiceParts.Length == 0)
                    {
                        linesSoFar++;
                        linesSoFar++;
                        g.DrawString("No Parts in this Service", textFont, brush,
                    leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                    }
                    else
                    {
                        foreach (DataRow drServicePart in drServiceParts)
                        {

                            string parts = "";
                            string partsDetails = "";
                            string partsPrice = "";
                            

                            cmPart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Part"];
                            int aPartID = Convert.ToInt32(drServicePart["PartID"].ToString());
                            cmPart.Position = DC.partView.Find(aPartID);
                            DataRow drPart = DC.dtPart.Rows[cmPart.Position];


                            parts += drPart["PartID"] + "     " + drPart["PartDescription"];
                            g.DrawString(parts, textFont, brush, leftMargin + 120, topMargin + (linesSoFar * textFont.Height));

                            partsDetails += drServicePart["Quantity"];
                            g.DrawString(partsDetails, textFont, brush, leftMargin + 320, topMargin + (linesSoFar * textFont.Height));

                            partsPrice += "$" + string.Format("{0:#,##0.00}", drPart["Cost"]);
                            g.DrawString(partsPrice, textFont, brush, leftMargin + 360, topMargin + (linesSoFar * textFont.Height));

                           
                            linesSoFar++;
                        }
                    }
                    
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                    linesSoFar++;
                }
                linesSoFar++;
               
            }
          
            amountOfMechanicsPrinted++;

            if (!(amountOfMechanicsPrinted == pagesAmountExpected))
            {
                e.HasMorePages = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            amountOfMechanicsPrinted = 0;
            string strSort = "MechanicID";
            string strFilter = null;
            mechanicsForPrint = DC.dsEdenGarage.Tables["Mechanic"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = mechanicsForPrint.Length;
            prvMechanics.Show();

        }


       



    }
}
