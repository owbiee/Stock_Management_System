using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockControl
{
    public partial class AdminKey : Form
    {
        public AdminKey()
        {
            InitializeComponent();
        }

        //Admin Key Authenticator...
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "jpsadmin123@jps.ng") //Admin Pass...
            {
                AddUser user = new AddUser();
                //user.MdiParent = this;
                this.Hide();
                user.Show();
            }
            
            else if(textBox1.Text == "")
            {
                //MessageBox.Show("Enter Admin Password!");
                label2.Text = "Enter Admin Password!";
            }
            else
            {
                label2.Text = "Invalid Password";
            }
        }
        //On Text  Changed...
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label2.Text = "";
            }
        }
    }
}
