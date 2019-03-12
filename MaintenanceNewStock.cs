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
    public partial class MaintenanceNewStock : Form
    {
        //Declare SQL Server Connection String...
        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        SqlCommand command;
        string imgLoc = "";

        public MaintenanceNewStock()
        {
            InitializeComponent();
        }

        //Browse Image Button...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif|All Files (*.*)|*.*";
                dlg.Title = "Select Stock Image";
                if (dlg.ShowDialog()== DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Save Button Event Handler...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(fs);
                img = reader.ReadBytes((int)fs.Length);
                string sql = "INSERT INTO Maintenance_Stock Values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "', @img)";
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

        //Search Data from Database(SQL Server)...
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Description, Category, Location, In_Stock, Stock_Image FROM Maintenance_Stock where ItemCode='" + textBox1.Text + "'";
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
                        MessageBox.Show("Data does not exist!");
                    }
                    conn.Close();

                }
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Cancel Button Event Handler...
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            textBox3.Clear();
            textBox4.Clear();
        }

        //Delete Button Event Handler...
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Maintenance_Stock WHERE ItemCode='"+textBox1.Text+"'";
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Deleted Successfully!");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        //Update Event Handler...
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                //Update Database Source Code...
                conn.Open();
                command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "update Maintenance_Stock set ItemCode='"+textBox2.Text+"' where ItemCode='" + textBox1.Text + "'";
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Updated Successfully!");

            }
            catch(Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
