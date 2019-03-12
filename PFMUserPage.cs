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
    public partial class PFMUserPage : Form
    {
        public PFMUserPage()
        {
            //DO NOT MODIFY...
            InitializeComponent();
            timer1.Start();
        }

        //Facility New Stock View...PFM
        private void newStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityNewStock stock = new FacilityNewStock();
            stock.MdiParent = this;
            stock.Show();
        }

        //Facility Received View...PFM
        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityReceived received = new FacilityReceived();
            received.MdiParent = this;
            received.Show();
        }

        //Facility Issued View...PFM
        private void issuedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityIssued issued = new FacilityIssued();
            issued.MdiParent = this;
            issued.Show();
        }

        //Facility Stock Report View...PFM
        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityStockReport report = new FacilityStockReport();
            report.MdiParent = this;
            report.Show();
        }

        //Facility Received Report View...PFM
        private void receivedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityReceivedReport receivedReport = new FacilityReceivedReport();
            receivedReport.MdiParent = this;
            receivedReport.Show();
        }

        //Facility Issued Report View...PFM
        private void issuedReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityIssuedReport facility = new FacilityIssuedReport();
            facility.MdiParent = this;
            facility.Show();
        }

        //Exit Application 
        private void PFMUserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //RealTime Counter...
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString();
        }

        //Display Facility Rack...
        private void facilityToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FacilityRack facilityRack = new FacilityRack();
            facilityRack.MdiParent = this;
            facilityRack.Show();
        }

        //PFMUser LogOut Handler...
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        //Displays PFMApprovalPage...
        private void approvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacilityApprove facilityApprove = new FacilityApprove();
            facilityApprove.MdiParent = this;
            facilityApprove.Show();
        }
    }
}
