using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class AddUser : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        public AddUser()
        {
            InitializeComponent();
        }
        
        //Add User to User_Login Database Table...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO User_Login Values('" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Data Entry Successful!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        //Load User Roles into Combobox1.Text...
        private void AddUser_Load(object sender, EventArgs e)
        {
            List<String> rolelist = new List<string>();
            rolelist.Add("--Select Role--");
            rolelist.Add("Managing Director");
            rolelist.Add("Technical Manager");
            rolelist.Add("IT Admin");
            rolelist.Add("Maintenance Manager");
            rolelist.Add("Facility Manager");
            rolelist.Add("Finance Manager");
            rolelist.Add("Store Keeper");

            this.comboBox1.DataSource = rolelist;
        }

        //Delete User from Database User_Login...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM User_Login WHERE Username='" + textBox3.Text + "'";
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("User Deleted Successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Search user from User_Login
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Name, Role, Password FROM User_Login where UserName='" + textBox3.Text + "'";
                //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        textBox1.Text = reader[0].ToString(); //Name
                        //comboBox1.Text = reader[1].ToString(); //
                        comboBox1.Text = reader[1].ToString(); //Role
                        textBox4.Text = reader[2].ToString(); //Password

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

        //Clear New User Form
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "--Select Role--";
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
