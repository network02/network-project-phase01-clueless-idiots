using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
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
            sck=Socket_Init();
            UsersPanel.Text="";
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(IPInput.Text), Int32.Parse(PortInput.Text));
                sck.Connect(endPoint);
                MessageBox.Show("Connected");
            }
            catch 
            {
                MessageBox.Show("Connection Failed");
            }
        }
        private void Read()
        {
            try
            {
                byte[] buffer=new byte[255];
                int bufferSize = sck.Receive(buffer, 0, buffer.Length, SocketFlags.None);
                if (bufferSize <= 0)
                    throw new SocketException();
                Array.Resize(ref buffer, bufferSize);

                string data = Encoding.ASCII.GetString(buffer);
                ServerResponse response=JsonSerializer.Deserialize<ServerResponse>(data);
                string userData = JsonSerializer.Serialize(response.data);
                string text = response.response+"\n"+response.header+"\n"+userData;
                Invoke((MethodInvoker)delegate
                {
                    UsersPanel.Text = text;
                });
            }
            catch
            {
                MessageBox.Show("Not Connected to the server");
            }  
        }
        private Socket Socket_Init() => new Socket(AddressFamily.InterNetwork,SocketType.Stream, ProtocolType.Tcp);
        private void GetButton_Click(object sender, EventArgs e)
        {
            ServerRequest request=new ServerRequest();
            try
            {
                request.requestType="GET";
                request.id=Int32.Parse(UserId.Text);
                request.data=null;
            }
            catch
            {
                MessageBox.Show("Invalid Entry");
            }
            string requestText=JsonSerializer.Serialize(request);
            byte[] buffer = Encoding.ASCII.GetBytes(requestText);
            sck.Send(buffer,0,buffer.Length,SocketFlags.None);

            new Thread(() =>
            {
                Read();
            }).Start();
        }
        private void SetButton_Click(object sender, EventArgs e)
        {
            if(NameBox.Text.Length<=0 || AgeBox.Text.Length<=0)
            {
                MessageBox.Show("The entry fields can't be empty");
                return;
            }

            try
            {
                ServerRequest request=new ServerRequest();
                request.requestType="POST";
                request.id=0;
                request.data= new Data();
                request.data.name=NameBox.Text; 
                request.data.age=Int32.Parse(AgeBox.Text);
                string dataText=JsonSerializer.Serialize(request);
                byte[]buffer=Encoding.ASCII.GetBytes(dataText);
                sck.Send(buffer,0,buffer.Length,SocketFlags.None);
            }
            catch(SocketException)
            {
                MessageBox.Show("Socket not connected");
                return;
            }
            catch
            {
                MessageBox.Show("Invalid entries");
                return;
                
            }
        }
    }
}
