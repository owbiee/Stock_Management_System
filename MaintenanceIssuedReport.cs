using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;

namespace StockControl
{
    public partial class MaintenanceIssuedReport : Form
    {
        public MaintenanceIssuedReport()
        {
            InitializeComponent();
        }

        private void MaintenanceIssuedReport_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'stockControlDataSet6.Maintenance_Issued' table. You can move, or remove it, as needed.
                this.maintenance_IssuedTableAdapter.Fill(this.stockControlDataSet6.Maintenance_Issued);

                List<String> rolelist = new List<string>();
                rolelist.Add("--Select Column--");
                rolelist.Add("Item Code");
                rolelist.Add("Category");
                rolelist.Add("Customer");
                rolelist.Add("Requisition No");
                

                this.comboBox1.DataSource = rolelist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Search MaintenanceIssuedReport...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Item Code")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemCode,Description,Category,Issued_By,Customer,Quantity,Unit_Cost,Total_Cost,Requisition_No,Issue_Date,Remarks FROM Maintenance_Issued Where ItemCode like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Category")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemCode,Description,Category,Issued_By,Customer,Quantity,Unit_Cost,Total_Cost,Requisition_No,Issue_Date,Remarks FROM Maintenance_Issued Where Category like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Customer")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemCode,Description,Category,Issued_By,Customer,Quantity,Unit_Cost,Total_Cost,Requisition_No,Issue_Date,Remarks FROM Maintenance_Issued Where Customer like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Requisition No")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemCode,Description,Category,Issued_By,Customer,Quantity,Unit_Cost,Total_Cost,Requisition_No,Issue_Date,Remarks FROM Maintenance_Issued Where Requisition_No like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        //Generate Report using DGVPrinterHelper Class...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Josepdam Port Services Ltd."; //Header
                printer.SubTitle = textBox1.Text; //Sub-Header
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.Footer = "jps.ng"; //Footer
                printer.FooterSpacing = 15;
                printer.PrintPreviewDataGridView(dataGridView1);
                printer.PrintDataGridView(dataGridView1);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Export As Pdf...
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //Export To Excel...
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
