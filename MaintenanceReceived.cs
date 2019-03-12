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

namespace StockControl
{
    public partial class MaintenanceReceived : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        SqlCommand command;

        public MaintenanceReceived()
        {
            InitializeComponent();
        }

        //Search Item from Maintenence_Stock into MaintenenceReceived form...Event Handler...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Description, Category, In_Stock FROM Maintenance_Stock where ItemCode='" + textBox1.Text + "'";
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
                        //comboBox1.Text = reader[1].ToString(); //Category
                        textBox3.Text = reader[1].ToString(); //Location
                        textBox6.Text = reader[2].ToString(); //In_Stock
                        
                    }
                    else
                    {
                        MessageBox.Show("Data does not exist!");
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

        //Save Received Data to Maintenance_Received DB & Update Stock Balance in Maintenance_Stock...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Maintenance_Received Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + dateTimePicker1.Value + "','" + textBox10.Text + "','" + textBox11.Text + "')";

                cmd.ExecuteNonQuery();
                conn.Close();

                UpdateStock();

                MessageBox.Show("Data Entry Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Update Stock Method...
        public void UpdateStock()
        {
            int instock = Convert.ToInt32(textBox6.Text); //Convert Stock balance to Type integer...
            int qtyreceived = Convert.ToInt32(textBox7.Text); //Convert Quantity received to Type integer...

            int bal = instock += qtyreceived;
            textBox7.Text = bal.ToString();

            conn.Open();
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Maintenance_Stock set In_Stock='" + textBox7.Text + "' where In_Stock='" + textBox6.Text + "'";
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Search Item from Maintenance_Received DB...
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT ItemNo, Description, Category, Supplier, Received_By, Quantity_Received, Unit_Cost, Total_Cost, Received_Date, Grn_No, Remarks FROM Maintenance_Received where Serial_No='" + textBox12.Text + "'";
                //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        textBox1.Text = reader[0].ToString(); //ItemNo
                        textBox2.Text = reader[1].ToString(); //Description
                        //comboBox1.Text = reader[1].ToString(); //Category
                        textBox3.Text = reader[2].ToString(); //Supplier
                        textBox4.Text = reader[3].ToString(); //Received_By
                        textBox5.Text = reader[4].ToString(); //Quantity_REceived
                        textBox7.Text = reader[5].ToString();
                        textBox8.Text = reader[6].ToString();
                        textBox9.Text = reader[7].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader[8]);
                        textBox10.Text = reader[9].ToString();
                        textBox11.Text = reader[10].ToString();
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

        private void MaintenanceReceived_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockControlDataSet10.Maintenance_Received' table. You can move, or remove it, as needed.
            this.maintenance_ReceivedTableAdapter.Fill(this.stockControlDataSet10.Maintenance_Received);

        }
    }
}
