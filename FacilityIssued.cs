using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //SqlServer Namespace...

namespace StockControl
{
    public partial class FacilityIssued : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DEV-001\\SQLEXPRESS;Initial Catalog=StockControl;Integrated Security=True");
        SqlCommand command;

        public FacilityIssued()
        {
            //DO NOT MODIFY...
            InitializeComponent();
        }

        //Save Item to Facility_Issued && Deduct Stock from Facility_Stock DB...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int stock = Convert.ToInt32(textBox4.Text);
                int qty = Convert.ToInt32(textBox7.Text);

                if (textBox13.Text == "" && textBox14.Text == "" )
                {
                    groupBox1.BackColor = Color.Red;
                    groupBox2.BackColor = Color.Red;
                    MessageBox.Show("Approval is Required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                else if (qty > stock)
                {
                    MessageBox.Show("Stock Balance is less than Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    
                        SqlCommand command = new SqlCommand();
                        conn.Open();
                        command = conn.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "UPDATE Facility_Issued set Item_Code='" + textBox1.Text + "', Description='" + textBox2.Text + "', Category='" + textBox3.Text + "', Issued_By='" + textBox5.Text + "', Customer='" + textBox6.Text + "', Quantity='" + textBox7.Text + "', Unit_Cost='" + textBox8.Text + "', Total_Cost='" + textBox9.Text + "', Requisition_No='" + textBox10.Text + "', Issue_Date='" + dateTimePicker1.Value + "', Reason='" + textBox15.Text + "', Approved_By='" + textBox13.Text + "', Role='" + textBox14.Text + "', Remarks='" + textBox11.Text + "'  where Serial_No='" + textBox12.Text + "'";
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Item Updated Successfully!");

                    DeductStock();
                        /*
                        conn.Open();
                        SqlCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO Facility_Issued Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + dateTimePicker1.Value + "','" + textBox15.Text + "','" + textBox13.Text + "','" + textBox14.Text + "','" + textBox11.Text + "')";

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        DeductStock();

                        MessageBox.Show("Item Entry Successful!");
                        */                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Deduct Stock from Facility_Stock DB && Return Balance...
        public void DeductStock()
        {
            int instock = Convert.ToInt32(textBox4.Text); //Convert Stock balance to Type integer...
            int qtyissued = Convert.ToInt32(textBox7.Text); //Convert Quantity Issued to Type integer...

            int bal = instock -= qtyissued; //Deduct Issued quantity from Stock balance...& save as integer into bal...
            textBox7.Text = bal.ToString(); //Convert bal to string and save into textbox7.Text...

            conn.Open(); //Open Connection to SQL Server DB...StockControl...
            command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update Facility_Stock set In_Stock='" + textBox7.Text + "' where In_Stock='" + textBox4.Text + "'";
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Search Item from Facility_Stock && Display info in FacilityIssued UserForm...
        private void button3_Click(object sender, EventArgs e)
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
                        textBox4.Text = reader[2].ToString(); //In_Stock

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

        //Search Item from Facility_Issued DB...
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT Item_Code, Description, Category, Issued_By, Customer, Quantity, Unit_Cost, Total_Cost, Requisition_No, Issue_Date, Reason, Approved_By, Role, Remarks FROM Facility_Issued where Serial_No='" + textBox12.Text + "'";
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
                        //comboBox1.Text = reader[1].ToString(); 
                        textBox3.Text = reader[2].ToString(); //Category
                        textBox5.Text = reader[3].ToString(); //Issued_By
                        textBox6.Text = reader[4].ToString(); //Customer
                        textBox7.Text = reader[5].ToString(); //Quantity
                        textBox8.Text = reader[6].ToString(); //Unit_Cost
                        textBox9.Text = reader[7].ToString(); //Total_Cost
                        textBox10.Text = reader[8].ToString(); //Requisition_No
                        dateTimePicker1.Value = Convert.ToDateTime(reader[9]); //Issued_Date  
                        textBox15.Text = reader[10].ToString(); //Reason
                        textBox13.Text = reader[11].ToString(); //Approved_By
                        textBox14.Text = reader[12].ToString(); //Role
                        textBox11.Text = reader[13].ToString(); //Remarks                                                                                             
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

        private void FacilityIssued_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stockControlDataSet15.Facility_Issued' table. You can move, or remove it, as needed.
            this.facility_IssuedTableAdapter2.Fill(this.stockControlDataSet15.Facility_Issued);
            // TODO: This line of code loads data into the 'stockControlDataSet13.Facility_Issued' table. You can move, or remove it, as needed.
            //this.facility_IssuedTableAdapter1.Fill(this.stockControlDataSet13.Facility_Issued);
            // TODO: This line of code loads data into the 'stockControlDataSet7.Facility_Issued' table. You can move, or remove it, as needed.
            //this.facility_IssuedTableAdapter.Fill(this.stockControlDataSet7.Facility_Issued);

        }

        //Stock Level...
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int stockbal = Convert.ToInt32(textBox4.Text);

            if (stockbal < 6)
            {
                label14.Text = "Re-Order";
                textBox4.BackColor = Color.RosyBrown;
            }
            else
            {
                label14.ForeColor = Color.SeaGreen;
                label14.Text = "OK";
                textBox4.BackColor = Color.LightGreen;
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                groupBox1.BackColor = Color.Cornsilk;
                label18.Text = "Approved";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            
          groupBox2.BackColor = Color.Cornsilk;

                        
        }
    }
}
