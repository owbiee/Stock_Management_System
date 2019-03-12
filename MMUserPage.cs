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
    public partial class MMUserPage : Form
    {
   
        public MMUserPage()
        {
            //DO NOT MODIFY...
            InitializeComponent();
            timer1.Start();
        }
        private void MMUserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Maintenance New Stock View...MM
        private void newStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceNewStock mtce = new MaintenanceNewStock();
            mtce.MdiParent = this;
            mtce.Show();
        }

        //Maintenance Stock Report View...MM
        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceStockReport report = new MaintenanceStockReport();
            report.MdiParent = this;
            report.Show();
        }

        //Maintenance Received Report View...MM
        private void receivedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaintenanceReceivedReport receivedReport = new MaintenanceReceivedReport();
            receivedReport.MdiParent = this;
            receivedReport.Show();
        }

        //Maintenance Issued Report View...MM
        private void issuedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaintenanceIssuedReport issuedReport = new MaintenanceIssuedReport();
            issuedReport.MdiParent = this;
            issuedReport.Show();
        }

        //Maintenance Received Form View...MM
        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceReceived maintenanceReceived = new MaintenanceReceived();
            maintenanceReceived.MdiParent = this;
            maintenanceReceived.Show();

        }

        //Maintenance Issued Form View...MM
        private void issuedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceIssued issued = new MaintenanceIssued();
            issued.MdiParent = this;
            issued.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.label1.Text = dateTime.ToString();
        }

        //Display Maintenance Rack...
        private void maintenanceItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaintenanceRack maintenanceRack = new MaintenanceRack();
            maintenanceRack.MdiParent = this;
            maintenanceRack.Show();
        }

        //MMUser LogOut...
        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
        //Display MMApprovalPage...
        private void maintenanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MaintenanceApprove maintenanceApprove = new MaintenanceApprove();
            maintenanceApprove.MdiParent = this;
            maintenanceApprove.Show();
        }
    }
}
