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
    public partial class PrintInvoicesForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private int amountOfCustomerPrinted, pagesAmountExpected;
        private DataRow[] customerForPrint;
        

        public PrintInvoicesForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            amountOfCustomerPrinted = 0;
            string strFilter = "status = 'current'";
            string strSort = "ServiceID";
            customerForPrint = DC.dsEdenGarage.Tables["Service"].Select(strFilter, strSort, DataViewRowState.CurrentRows);
            pagesAmountExpected = customerForPrint.Length;
            
            prvInvoices.Show();
        }

        private void printInvoices_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int linesSoFar = 0;
            Font textFont = new Font("Calibri", 12, FontStyle.Regular);
            Font textFontCenter = new Font("Calibri", 16, FontStyle.Bold);
            Font totalSubtotal = new Font("Calibri", 12, FontStyle.Bold);
            Font headingFont = new Font("Calibri", 12, FontStyle.Bold);

            DataRow drService = customerForPrint[amountOfCustomerPrinted];
            
            
            CurrencyManager cmMechanic;
            cmMechanic = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Mechanic"];
            CurrencyManager cmCustomer;
            cmCustomer = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Customer"];
            CurrencyManager cmService;
            cmService = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Service"];
            CurrencyManager cmVehicle;
            cmVehicle = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Vehicle"];

            int aVehicle = Convert.ToInt32(drService["VehicleID"].ToString());
            cmVehicle.Position = DC.vehicleView.Find(aVehicle);
            DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];

            int aCustomer5 = Convert.ToInt32(drVehicle["CustomerID"].ToString());
            cmCustomer.Position = DC.customerView.Find(aCustomer5);
            DataRow drCustomer = DC.dtCustomer.Rows[cmCustomer.Position];

            Brush brush = new SolidBrush(Color.Black);

            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int headingLeftMargin = 50;
            int topMarginDetails = topMargin + 70;
            int rightMargin = e.MarginBounds.Right;

            g.DrawString("Mount Eden Vehicle Clinic" + "\r\n" + "                 Invoice", textFontCenter, brush, leftMargin + 40 + topMarginDetails, topMargin);

            linesSoFar++;
            linesSoFar++;
            linesSoFar++;
            linesSoFar++;

            g.DrawString(drCustomer["FirstName"] +" "+ drCustomer["LastName"] + "\r\n" + drCustomer["StreetAddress"] + "\r\n" + drCustomer["Suburb"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));

            linesSoFar++;
            linesSoFar++;
            linesSoFar++;
            linesSoFar++; 
            linesSoFar++;



            g.DrawString("Customer ID:   " + (Convert.ToInt32(drCustomer["CustomerID"])).ToString(), textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                                      (linesSoFar * textFont.Height));

            linesSoFar++;
            linesSoFar++;
          
            DataRow[] drDetails = drCustomer.GetChildRows(DC.dtCustomer.ChildRelations["CUSTOMER_VEHICLE"]);
           

            if (drDetails.Length == 0)
            {
                
                g.DrawString("No Service invoices for this customer!", textFont, brush, leftMargin + headingLeftMargin, topMargin +
                               (linesSoFar * textFont.Height));
            }
            else
            {
                foreach (DataRow drDetail in drDetails)
                {
                    int aVehicleID = Convert.ToInt32(drDetail["VehicleID"].ToString());
                    cmVehicle.Position = DC.vehicleView.Find(aVehicleID);
                   // DataRow drVehicle = DC.dtVehicle.Rows[cmVehicle.Position];
                    

                    DataRow[] drServiceDetails = drDetail.GetChildRows(DC.dtVehicle.ChildRelations["VEHICLE_SERVICE"]);
                    if (drServiceDetails.Length == 0)
                    {
                       
                    }
                    else
                    {

                        foreach (DataRow drServiceDetail in drServiceDetails)
                        {
                            int aServiceID = Convert.ToInt32(drServiceDetail["ServiceID"].ToString());
                            cmService.Position = DC.serviceView.Find(aServiceID);
                           // DataRow drService = DC.dtService.Rows[cmService.Position];
                            

                            g.DrawString("Service ID:  " + drService["ServiceID"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                            g.DrawString("Date:  " + string.Format("{0:d/M/yyyy}", drService["ServiceDate"]), textFont, brush, rightMargin - 120, topMargin +
                                (linesSoFar * textFont.Height));

                            linesSoFar++;
                            linesSoFar++;

                            g.DrawString("Vehicle ID:" + drVehicle["VehicleID"] + "     Vehicle Plate Number:  " + drVehicle["PlateNumber"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));

                            linesSoFar++;
                            linesSoFar++;

                            int aMehanicID = Convert.ToInt32(drService["MechanicID"].ToString());
                            cmMechanic.Position = DC.mechanicView.Find(aMehanicID);
                            DataRow drMechanic = DC.dtMechanic.Rows[cmMechanic.Position];

                            g.DrawString("Mechanic:  " + drMechanic["FirstName"] + " " + drMechanic["LastName"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                            g.DrawString("$" + string.Format("{0:#,##0.00}", drMechanic["Fee"]), textFont, brush, rightMargin - 60, topMargin +
                                (linesSoFar * textFont.Height));


                            linesSoFar++;
                            
                            g.DrawString("Description:  " + drService["ServiceDescription"], textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                            g.DrawString("$" + string.Format("{0:#,##0.00}", drService["ServiceFee"]), textFont, brush, rightMargin - 60, topMargin +
                                (linesSoFar * textFont.Height));
                            linesSoFar++;
                            linesSoFar++;

                            g.DrawString("Parts ", textFont, brush, leftMargin + headingLeftMargin, topMargin +
                                (linesSoFar * textFont.Height));
                            linesSoFar++;
                            linesSoFar++;

                            CurrencyManager cmPart;
                            CurrencyManager cmServicePart;
                            cmServicePart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "ServicePart"];

                            DataRow[] drServiceParts = drService.GetChildRows(DC.dtService.ChildRelations["SERVICE_SERVICEPART"]);
                            double totalParts = -1;
                            double serviceTotal = 0;
                            if (drServiceParts.Length == 0)
                            {
                                linesSoFar++;
                                linesSoFar++;
                                g.DrawString("No Parts in this Service", textFont, brush,
                            leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                                 totalParts = 0;
                            }
                            else
                            {
                                foreach (DataRow drServicePart in drServiceParts)
                                {
                                    
                                    string parts = "";
                                    string partsDetails = "";
                                    string partsPrice = "";
                                    double Costs = 0;
                                    

                                    cmPart = (CurrencyManager)this.BindingContext[DC.dsEdenGarage, "Part"];
                                    int aPartID = Convert.ToInt32(drServicePart["PartID"].ToString());
                                    cmPart.Position = DC.partView.Find(aPartID);
                                    DataRow drPart = DC.dtPart.Rows[cmPart.Position];

                                    

                                    parts += drPart["PartID"] + "     " + drPart["PartDescription"];
                                    g.DrawString(parts, textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));

                                    partsDetails += drServicePart["Quantity"];
                                    g.DrawString(partsDetails, textFont, brush, leftMargin + 220, topMargin + (linesSoFar * textFont.Height));

                                    partsPrice += "$" + string.Format("{0:#,##0.00}", drPart["Cost"]);
                                    g.DrawString(partsPrice, textFont, brush, leftMargin + 260, topMargin + (linesSoFar * textFont.Height));

                                    Costs += Convert.ToDouble(drPart["Cost"]) * Convert.ToInt32(drServicePart["Quantity"]);
                                    g.DrawString("$" + string.Format("{0:#,##0.00}", Costs), textFont, brush, rightMargin - 200, topMargin +(linesSoFar * textFont.Height));
                                    
                                    linesSoFar++;
                                    totalParts += Costs;
                                }
                                totalParts++;
                            }
                            linesSoFar++;
                            linesSoFar++;
                            g.DrawString("Total Parts : ", textFont, brush, leftMargin + headingLeftMargin, topMargin + (linesSoFar * textFont.Height));
                            g.DrawString("$" + string.Format("{0:#,##0.00}", totalParts), textFont, brush, rightMargin - 200, topMargin + (linesSoFar * textFont.Height));
                            
                            linesSoFar++;
                            linesSoFar++;
                            linesSoFar++;
                           
                            g.DrawString("Service Total: ", textFont, brush, rightMargin - 200, topMargin + (linesSoFar * textFont.Height));
                            serviceTotal += totalParts + Convert.ToDouble(drMechanic["Fee"]) + Convert.ToDouble(drService["ServiceFee"]);
                            g.DrawString("$" + string.Format("{0:#,##0.00}", serviceTotal), textFont, brush, rightMargin - 60, topMargin + (linesSoFar * textFont.Height));

                            linesSoFar++;
                            linesSoFar++;
                            linesSoFar++;

                            
                        }
                      
                        linesSoFar++;
                        linesSoFar++;
                        
                    }
                  
                }
                

            }
            amountOfCustomerPrinted++;

            if (!(amountOfCustomerPrinted == pagesAmountExpected))
            {
                
                    e.HasMorePages = true;
                
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }


    }
}
