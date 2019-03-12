using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class FMUserPage : Form
    {
        //private int childFormNumber = 0;

        public FMUserPage()
        {
            //DO NOT MODIFY...
            InitializeComponent();
            timer1.Start();
        }

        
        //Maintenance Stock Balance Report...
        private void stockBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceStockReport report = new MaintenanceStockReport();
            report.MdiParent = this;
            report.Show();
        }

        //Maintenance Received Report...
        private void receivedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceReceivedReport receivedReport = new MaintenanceReceivedReport();
            receivedReport.MdiParent = this;
            receivedReport.Show();
        }

        //Maintenance Issued Report...
        private void issuedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceIssuedReport issuedReport = new MaintenanceIssuedReport();
            issuedReport.MdiParent = this;
            issuedReport.Show();
        }

        //Facility Stock Balance Report...
        private void stockBalanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacilityStockReport report = new FacilityStockReport();
            report.MdiParent = this;
            report.Show();
        }

        //Facility Received Report...
        private void receivedReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacilityReceivedReport receivedReport = new FacilityReceivedReport();
            receivedReport.MdiParent = this;
            receivedReport.Show();
        }

        //Facility Issued Report...
        private void issuedReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacilityIssuedReport issuedReport = new FacilityIssuedReport();
            issuedReport.MdiParent = this;
            issuedReport.Show();
        }

        //Facility Received Entry (CRUD)...Function Disabled 
        private void receivedStockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*
            FacilityReceived received = new FacilityReceived();
            received.MdiParent = this;
            received.Show();
            */
        }

            //Facility Issued Entry (CRUD)...Function Disabled
            private void issuedStockToolStripMenuItem1_Click(object sender, EventArgs e)
            {
            /*
                FacilityIssued issued = new FacilityIssued();
                issued.MdiParent = this;
                issued.Show();
                */
            }

            //Maintenance Received Entry (CRUD)...Function Disabled
            private void receivedStockToolStripMenuItem_Click(object sender, EventArgs e)
            {
            /*
                MaintenanceReceived maintenanceReceived = new MaintenanceReceived();
                maintenanceReceived.MdiParent = this;
                maintenanceReceived.Show();
                */
            }

            //Maintenance Issued Entry (CRUD)...
            private void issuedStockToolStripMenuItem_Click(object sender, EventArgs e)
            {
            /*
                MaintenanceIssued maintenanceIssued = new MaintenanceIssued();
                maintenanceIssued.MdiParent = this;
                maintenanceIssued.Show();
            */
            }

            //Implement RealTime ...
            private void timer1_Tick(object sender, EventArgs e)
            {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString();
            }

        //Exit Application Handler...
        private void FMUserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //LogOut Button Event Handler...
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
