using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckPorts
{
    public partial class Form1 : Form
    {
        Socket sck;
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            int startPort = 0, endPort = 0;
            try
            {
                startPort = Int32.Parse(StartPort.Text);
                endPort = Int32.Parse(EndPort.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Entries");
                return;
            }
            if (startPort > endPort || !IPAddress.TryParse(IPInput.Text,out IPAddress address))
            {
                MessageBox.Show("Invalid Entries");
                return;
            }
            
            ConsoleLog.Items.Clear();
            for (int i = startPort; i <= endPort; i++)
            {
                sck=Socket_Init();
                try
                {
                    var connectionResult=sck.BeginConnect(new IPEndPoint(address,i),null,null);

                    bool success = connectionResult.AsyncWaitHandle.WaitOne(300, true);
                    if (success)
                    {
                        ConsoleLog.Items.Add("Port " + i.ToString() + " is Open\n");
                        sck.EndConnect(connectionResult);
                    }
                    else
                    {
                        ConsoleLog.Items.Add("Port " + i.ToString() + " is Closed or Unreachable\n");
                    }
                    
                }
                catch
                {
                    MessageBox.Show("Unexpected error");
                }
                
            }
        }

        private Socket Socket_Init() => new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
    }
}
