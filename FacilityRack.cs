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
    public partial class FacilityRack : Form
    {
        public FacilityRack()
        {
            InitializeComponent();
        }

        //Search from FacilityStock DataSet...
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            if (textBox1.Text != "")
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
                            textBox3.Text = reader[1].ToString(); //Category
                            textBox4.Text = reader[2].ToString(); //Location
                            textBox5.Text = reader[3].ToString(); //In_Stock
                            byte[] img = (byte[])(reader[4]); //Stock_Image

                           string itemCode = textBox1.Text;

                                switch(itemCode)
                                {
                                    case "FLTY0001":
                                    MemoryStream ms = new MemoryStream(img);
                                    pictureBox1.Image = Image.FromStream(ms);
                                    textBox6.Text = textBox4.Text;
                                    textBox6.BackColor = Color.DodgerBlue;
                                        break;

                                    case "FLTY0032":
                                    MemoryStream ms1 = new MemoryStream(img);
                                    pictureBox4.Image = Image.FromStream(ms1);
                                    textBox9.Text = textBox4.Text;
                                    textBox9.BackColor = Color.DodgerBlue;
                                        break;

                                    case "FLTY0002":
                                    MemoryStream ms2 = new MemoryStream(img);
                                    pictureBox6.Image = Image.FromStream(ms2);
                                    textBox11.Text = textBox4.Text;
                                    textBox11.BackColor = Color.DodgerBlue;
                                    break;

                                    default:
                                        MessageBox.Show("Search Error Occured!");
                                        break;
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
            else if (textBox2.Text != "")
            {
                try
                {

                    string sql = "SELECT Item_Code, Category, Location, In_Stock, Stock_Image FROM Facility_Stock where Description='" + textBox2.Text + "'";
                    //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                        command = new SqlCommand(sql, conn);
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            textBox1.Text = reader[0].ToString(); //Item_Code                                                                
                            textBox3.Text = reader[1].ToString(); //Category
                            textBox4.Text = reader[2].ToString(); //Location
                            textBox5.Text = reader[3].ToString(); //In_Stock
                            byte[] img = (byte[])(reader[4]); //Stock_Image

                            string description = textBox2.Text;

                            switch (description)
                            {
                                case "FLTY0001": //item description
                                    MemoryStream ms = new MemoryStream(img);
                                    pictureBox1.Image = Image.FromStream(ms);
                                    textBox6.Text = textBox4.Text;
                                    textBox6.BackColor = Color.DodgerBlue;
                                    break;

                                case "FLTY0032": //item description
                                    MemoryStream ms1 = new MemoryStream(img);
                                    pictureBox4.Image = Image.FromStream(ms1);
                                    textBox9.Text = textBox4.Text;
                                    textBox9.BackColor = Color.DodgerBlue;
                                    break;

                                case "FLTY0002": //item description
                                    MemoryStream ms2 = new MemoryStream(img);
                                    pictureBox6.Image = Image.FromStream(ms2);
                                    textBox11.Text = textBox4.Text;
                                    textBox11.BackColor = Color.DodgerBlue;
                                    break;

                                default:
                                    MessageBox.Show("Search Error Occured!");
                                    break;
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
        }

        //Load Rack...
        private void FacilityRack_Load(object sender, EventArgs e)
        {

        }

        //Clear Item Search Form...
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Focus();
        }
    }
}
