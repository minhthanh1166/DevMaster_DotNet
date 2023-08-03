using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }

        private void ServerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            // gửi tin cho các client
            foreach (Socket client in clientList)
            {
                SendMsg(client);
            }
            AddMsg(txtMessage.Text);
            txtMessage.Clear();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }



        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        void Connect()
        {
            clientList = new List<Socket>();
            // Get the host name of the local machine

            int port = 9000;
            // IP: Địa chỉ của server
            IP = new IPEndPoint(IPAddress.Any, port);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

            server.Bind(IP);

            Thread listen = new Thread(
                () =>
                {
                    try
                    {
                        while (true)
                        {
                            server.Listen(100);
                            Socket client = server.Accept();
                            clientList.Add(client);

                            Thread receive = new Thread(ReceiveMsg);
                            receive.IsBackground = true;
                            receive.Start(client);
                        }
                    }
                    catch (Exception ex)
                    {
                        IP = new IPEndPoint(IPAddress.Any, port);
                        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                    }
                });
            listen.IsBackground = true;
            listen.Start();
        }

        void CloseConnection()
        {
            server.Close();
        }

        void SendMsg(Socket client)
        {
            if (client != null && txtMessage.Text != string.Empty)
            {
                client.Send(Serialize(txtMessage.Text));
            }

        }

        void ReceiveMsg(object obj)
        {
            Socket client = obj as Socket;
            try
            {
               
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();

                    foreach (Socket item in clientList)
                    {
                        if(item != null && item != client)
                        {
                            item.Send(Serialize(message));
                        }
                    }

                    AddMsg(message);
                }
            }
            catch (Exception ex)
            {
                clientList.Remove(client);
                client.Close();
            }


        }

        void AddMsg(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
        }

        // phân mảnh
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

    }
}
