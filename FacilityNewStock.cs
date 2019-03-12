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
using System.IO;

namespace StockControl
{
    public partial class FacilityNewStock : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        SqlCommand command;
        string imgLoc;

        public FacilityNewStock()
        {
            InitializeComponent();
        }

        //Save New Facility Stock to Facility_Stock Db...Handler
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                img = reader.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO Facility_Stock Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', @img)";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.Parameters.Add(new SqlParameter("@img", img));
                    int x = command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(x.ToString() + "Record(s) Saved.");

                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Browse Image Event Handler...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Stock Image";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search Item from Facility_Stock Db...
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Description, Category, Location, In_Stock, Stock_Image FROM Facility_Stock where Item_Code='" + textBox1.Text + "'";
                //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        textBox2.Text = reader[0].ToString(); //Description
                        comboBox1.Text = reader[1].ToString(); //Category
                        textBox3.Text = reader[2].ToString(); //Location
                        textBox4.Text = reader[3].ToString(); //In_Stock
                        byte[] img = (byte[])(reader[4]); //Stock_Image

                        if (img == null)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Item does not exist!");
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Delete Item from Facility_Stock Db...
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Facility_Stock WHERE ItemCode='" + textBox1.Text + "'";
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
