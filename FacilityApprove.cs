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
    public partial class FacilityApprove : Form
    {
        public FacilityApprove()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        SqlCommand command;

        //Search Item from facility_Stock for Approval
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Description, Category, In_Stock FROM Facility_Stock where Item_Code='" + textBox1.Text + "'";
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

        //Verify From User_Login DB...
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Role FROM User_Login where Name='" + textBox4.Text + "'";
                //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        textBox5.Text = reader[0].ToString(); //Role
                        //comboBox1.Text = reader[1].ToString(); //
                        //comboBox1.Text = reader[1].ToString(); //Role
                        //textBox4.Text = reader[2].ToString(); //Password

                    }
                    else
                    {
                        MessageBox.Show("User does not exist!");
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

        //Insert INTO facility_Issued /Approve Issue...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Facility_Issued (Item_Code, Description, Category, Issued_By, Customer, Quantity, Unit_Cost, Total_Cost, Requisition_No, Issue_Date, Reason, Approved_By, Role, Remarks ) Values ('" + textBox1.Text + "','" + textBox2.Text + "', '"+textBox3.Text+"', '"+textBox7.Text+"', '"+textBox8.Text+"', '"+textBox9.Text+"', '"+textBox10.Text+"', '"+textBox11.Text+"', '"+textBox12.Text+"', '"+textBox13.Text+"', '"+textBox14.Text+"', '" + textBox4.Text + "','" + textBox5.Text + "', '"+textBox15.Text+"')";           
                cmd.ExecuteNonQuery();
                conn.Close();

                //DeductStock();

                MessageBox.Show("Approval was Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
