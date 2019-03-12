using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace StockControl
{
    public partial class Messaging : Form
    {
        Socket socket;
        EndPoint epLocal, epRemote;

        //DO NOT MODIFY...
        public Messaging()
        {
            InitializeComponent();
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textBox1.Text = GetLocalIP(); //Sender IP Address...
            textBox3.Text = GetLocalIP(); //Receiver IP Address...
        }

        //Method to Get Local IP Address of the User Computer...
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }

        //CallBack Event Handler...
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = socket.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;

                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);

                    listBox1.Items.Add("Friend: " +receivedMessage);
                }

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Start Connection Event Handler...
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                epLocal = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                socket.Bind(epLocal);

                epRemote = new IPEndPoint(IPAddress.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text));
                socket.Connect(epRemote);

                byte[] buffer = new byte[1500];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);

                button1.Text = "Connected";
                button1.Enabled = false;
                button2.Enabled = true;

                textBox5.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Messaging_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }

        //Send Message Handler...
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(textBox5.Text);
                socket.Send(msg);
                listBox1.Items.Add("You: "+ textBox5.Text);
                textBox5.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
