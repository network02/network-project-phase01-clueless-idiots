using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckHost
{
    public partial class Form1 : Form
    {
        Ping pinger=new Ping();
        Socket sck;
        int[] ports = new int[8] { 20, 21, 22, 25, 53, 80, 123, 433 };
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sck=Socket_Init();
            foreach(int port in ports)
            {
                try
                {
                    sck.Connect(new IPEndPoint(IPAddress.Parse(IPInput.Text), port));
                    break;
                }
                catch
                {
                    counter++;
                }
            }

            if(counter <8)
            {
                MessageBox.Show("Port is Up");
            }
            else
            {
                MessageBox.Show("Port is Down");
            }
            sck.Close();
        }
        private Socket Socket_Init()=>new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
    }
}
