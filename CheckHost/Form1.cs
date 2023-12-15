using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckHost
{
    public partial class Form1 : Form
    {
        Ping pinger=new Ping();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PingReply reply = pinger.Send(IPInput.Text);
                bool hostStatus = reply.Status ==IPStatus.Success;
                if (hostStatus)
                    MessageBox.Show("Host is up");
                else
                    MessageBox.Show("Host is down");
            }
            catch
            {
                MessageBox.Show("Invalid IP Address");
            }
        }
    }
}
