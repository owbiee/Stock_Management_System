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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StockControl
{
    public partial class MaintenanceReceivedReport : Form
    {
        public MaintenanceReceivedReport()
        {
            InitializeComponent();
        }

        private void MaintenanceReceivedReport_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'stockControlDataSet5.Maintenance_Received' table. You can move, or remove it, as needed.
                this.maintenance_ReceivedTableAdapter.Fill(this.stockControlDataSet5.Maintenance_Received);

                List<String> rolelist = new List<string>();
                rolelist.Add("--Select  Column--");
                rolelist.Add("Item Code");
                rolelist.Add("Category");
                rolelist.Add("Supplier");
                rolelist.Add("GRN No");

                this.comboBox1.DataSource = rolelist;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search MaintenanceReceivedReport...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Item Code")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemNo,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Maintenance_Received Where ItemNo like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Category")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemNo,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Maintenance_Received Where Category like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Supplier")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemNo,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Maintenance_Received Where Supplier like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "GRN No")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,ItemNo,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Maintenance_Received Where Grn_No like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Generate Report from MaintenanceReceivedReport Using DGVPrinterHelper Class...
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ExportAsPdf() Method...
        public void ExportAsPdf(DataGridView dataGrid, string file)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable table = new PdfPTable(dataGrid.Columns.Count);
                table.DefaultCell.Padding = 3;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                //Add Header...
                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table.AddCell(cell);
                }

                //Add Data Row
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value.ToString(), text));
                    }
                }
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.FileName = file;
                saveFileDialog.DefaultExt = ".pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f); //Layout Settings...
                        PdfWriter writer = PdfWriter.GetInstance(pdfdoc, stream);
                        //writer.PageEvent = new Common.ITextEvents();

                        //table.WidthPercentage = 100;
                        pdfdoc.Open();
                        pdfdoc.SetMargins(10, 10, 50, 10); //Margin Settings...
                        //pdfdoc.AddHeader("A", "African Atlantic Agencies");
                        pdfdoc.NewPage();
                        pdfdoc.Add(table);
                        //pdfdoc.AddHeader("A","African Atlantic Agencies");
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Export As Pdf...
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Call ExportAsPdf() Here...
            ExportAsPdf(dataGridView1, "Save As");
        }

        //Export To Excel...
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
