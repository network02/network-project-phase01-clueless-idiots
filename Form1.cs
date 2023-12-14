using System;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        private Socket sck,acp;
        private Data[] users = new Data[0];
        public Form1()
        {
            InitializeComponent();
        }


        private Socket Socket_Init() => new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        private void ListenButton_Click(object sender, EventArgs e)
        {
            sck=Socket_Init();
            acp=Socket_Init();
            string portNum=PortInput.Text;
            try
            {
                sck.Bind(new IPEndPoint(0, Int32.Parse(portNum)));
                sck.Listen(0);
            }
            catch
            {
                MessageBox.Show("Port Invalid");
            }

            new Thread(() =>
            {
                try
                {
                    acp=sck.Accept();
                    sck.Close();
                    Read();
                }
                catch
                {
                    MessageBox.Show("Disconnected");
                    Application.Exit();
                }
            }).Start();

        }

        private void Read()
        {
            while (true)
            {
                byte[]buffer= new byte[255];
                int bufferSize = acp.Receive(buffer, 0, buffer.Length, SocketFlags.None);
                if (bufferSize<=0)
                    throw new SocketException();

                Array.Resize(ref buffer, bufferSize);
                string data=Encoding.ASCII.GetString(buffer);
                ServerRequest request=JsonSerializer.Deserialize<ServerRequest>(data);
                if (request.requestType=="GET")
                {
                    new Thread(() =>
                    {
                        ServerResponse response = new ServerResponse("HTTP/1.1 200 OK", "Content-Type:application/json", users[request.id]);
                        string usersText = JsonSerializer.Serialize(response);
                        byte[] userSend=Encoding.ASCII.GetBytes(usersText);
                        acp.Send(userSend, 0, userSend.Length, SocketFlags.None);
                    }).Start();
                }
                else
                {
                    Array.Resize(ref users, users.Length+1);
                    users[users.Length-1] = request.data;
                    Invoke((MethodInvoker)delegate
                    {
                        Names.Items.Add(request.data.name);
                        Ages.Items.Add(request.data.age);
                    });
                }
                

            }

        }
    }
}
