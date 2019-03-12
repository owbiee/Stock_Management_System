﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StockControl
{
    public partial class FacilityReceivedReport : Form
    {
        public FacilityReceivedReport()
        {
            InitializeComponent();
        }

        private void FacilityReceivedReport_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'stockControlDataSet3.Facility_Received' table. You can move, or remove it, as needed.
                this.facility_ReceivedTableAdapter.Fill(this.stockControlDataSet3.Facility_Received);

                List<String> rolelist = new List<string>();
                rolelist.Add("--Select  Column--");
                rolelist.Add("Item Code");
                rolelist.Add("Category");
                rolelist.Add("Supplier");
                rolelist.Add("GRN No");

                this.comboBox1.DataSource = rolelist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Generate Report Using DGVPrinter Class...
        private void button1_Click(object sender, EventArgs e)
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

        //Search DataGridView(FacilityReceivedReport) Event Handler...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "Item Code")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,Item_Code,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Facility_Received Where Item_Code like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Category")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,Item_Code,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Facility_Received Where Category like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "Supplier")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,Item_Code,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Facility_Received Where Supplier like '" + textBox1.Text + "%'", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (comboBox1.Text == "GRN No")
                {
                    SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT Serial_No,Item_Code,Description,Category,Supplier,Received_By,Quantity_Received,Unit_Cost,Total_Cost,Received_Date,Grn_No,Remarks FROM Facility_Received Where Grn_No like '" + textBox1.Text + "%'", conn);
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

        //Export as Pdf
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExportAsPdf(dataGridView1, "Save as PDF");
        }

        public void ExportAsPdf(DataGridView data, string file)
        {
            try
            {
                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable table = new PdfPTable(data.Columns.Count);
                table.DefaultCell.Padding = 3;
                table.WidthPercentage = 100;
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.DefaultCell.BorderWidth = 1;

                iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
                //Add Header...
                foreach (DataGridViewColumn column in data.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    table.AddCell(cell);
                }

                //Add Data Row
                foreach (DataGridViewRow row in data.Rows)
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

        //Call Export To Excel method here...
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        public void ExportToExcel()
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Facility Received";

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }

                var savefile = new SaveFileDialog();
                savefile.FileName = "file";
                savefile.DefaultExt = ".xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    workbook.SaveAs(savefile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                }
                app.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
