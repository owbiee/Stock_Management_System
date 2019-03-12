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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Login Event Handler...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [StockControl].[dbo].[User_Login] where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //User Authentication...
                if (dt.Rows.Count == 1)
                {                   
                    string role = textBox3.Text; //TextBox containing User/Role...
                    switch (role)
                    {
                        //Verify User Role & Identity...
                        case "Software Engineer":
                            this.Hide();
                            
                            TMUserPage tm = new TMUserPage();
                            tm.Show();
                            break;

                        case "Technical Manager":
                            this.Hide();
                            
                            TMUserPage tMUser = new TMUserPage();
                            tMUser.Show();
                            break;

                        case "Managing Director":
                            this.Hide();
                            
                            FMUserPage fm = new FMUserPage();
                            fm.Show();
                            break;

                        case "Finance Manager":
                            this.Hide();

                            FMUserPage fM = new FMUserPage();
                            fM.Show();
                            break;

                        case "IT Admin":
                            this.Hide();
                            
                            TMUserPage it = new TMUserPage();
                            it.Show();
                            break;

                        case "Maintenance Manager":
                            this.Hide();
                            
                            MMUserPage mm = new MMUserPage();
                            mm.Show();
                            break;

                        case "Facility Manager":
                            this.Hide();
                            
                            PFMUserPage pfm = new PFMUserPage();
                            pfm.Show();
                            break;

                        case "Store Keeper":
                            this.Hide();
                            
                            StoreKeeperUserPage storeKeeper = new StoreKeeperUserPage();
                            storeKeeper.Show();
                            break;
                       
                        default:
                            MessageBox.Show("Invalid User!");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!, Contact System Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Call the Clear Event Handler(Method)...
                    button2_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Clear Button Event Handler...
        private void button2_Click(object sender, EventArgs e)
        {
            //Clear Login Textboxes & focus on Textbox1
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        //Verify Role/User Identity...
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
                SqlCommand command;
                string sql = "SELECT Role FROM User_Login where UserName='" + textBox1.Text + "' and Password='"+ textBox2.Text +"'";
                //string sql = "SELECT * FROM [StockControl].[dbo].[Maintenance_Stock] where ItemCode='" + textBox1.Text + "'";
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        //textBox2.Text = reader[0].ToString(); //Description
                        //comboBox1.Text = reader[1].ToString(); //Category
                        textBox3.Text = reader[0].ToString(); //Location
                        //textBox4.Text = reader[3].ToString(); //In_Stock
                        
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
                //conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //Open AddNewUser Page From Login Page...
        private void label4_Click(object sender, EventArgs e)
        {
            AdminKey key = new AdminKey();
            key.Show();
            /*AddUser user = new AddUser();
            user.Show();*/
        }

        //Exit Application from Login Form...
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
