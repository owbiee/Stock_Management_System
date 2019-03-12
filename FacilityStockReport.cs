using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace StockControl
{
    public partial class FacilityStockReport : Form
    {
        public FacilityStockReport()
        {
            InitializeComponent();
        }

        private void FacilityStockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockControlDataSet12.Facility_Stock' table. You can move, or remove it, as needed.
            this.facility_StockTableAdapter1.Fill(this.stockControlDataSet12.Facility_Stock);
            // TODO: This line of code loads data into the 'stockControlDataSet.Facility_Stock' table. You can move, or remove it, as needed.
            this.facility_StockTableAdapter.Fill(this.stockControlDataSet.Facility_Stock);
            // TODO: This line of code loads data into the 'stockControlDataSet9.Facility_Stock' table. You can move, or remove it, as needed.
            //this.facility_StockTableAdapter.Fill(this.stockControlDataSet9.Facility_Stock);

        }

        //Export As PDF Event Handler...
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExportAsPdf(dataGridView1, "Save as Pdf");
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
    }
}
