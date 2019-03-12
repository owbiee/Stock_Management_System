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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockControlDataSet17.Facility_Issued' table. You can move, or remove it, as needed.
            this.Facility_IssuedTableAdapter.Fill(this.StockControlDataSet17.Facility_Issued);
            // TODO: This line of code loads data into the 'Freight365DataSet.Shipping_DB' table. You can move, or remove it, as needed.
            this.Shipping_DBTableAdapter.Fill(this.Freight365DataSet.Shipping_DB);

            //this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
