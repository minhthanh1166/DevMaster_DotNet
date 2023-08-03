using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Windows.Forms;

namespace chatclientserver
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMsg();
            AddMsg(txtMessage.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        IPEndPoint IP;
        Socket client;
        void Connect()
        {
            // Get the host name of the local machine
            string hostName = Dns.GetHostName();

            // Get the IP address list of the local machine
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] ipAddresses = ipEntry.AddressList;

            // Loop through each IP address and find the one that has IPv4 format
            // and matches your connection type (Ethernet or Wi-Fi)
            IPAddress ipAddress = null;
            foreach (IPAddress ip in ipAddresses)
            {
                // IPv4 format
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    // Check if the IP address matches your connection type by using a prefix or a substring
                    // For example, if your connection type is Ethernet and your IP address starts with "192.168",
                    // you can use this condition
                    //if (ip.ToString().StartsWith("192.168"))
                    //{
                    ipAddress = ip; // Assign the IP address to a variable
                    Console.WriteLine(ipAddress);
                    break; // Exit the loop
                    //}
                }
            }
            int port = 9000;
            IP = new IPEndPoint(ipAddress, port);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            try
            {
                client.Connect(IP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối server: " + ex.Message, "Lỗi", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

            Thread listen = new Thread(ReceiveMsg);
            listen.IsBackground = true;
            listen.Start();
        }

        void CloseConnection()
        {
            client.Close();
        }

        void SendMsg()
        {
            if (txtMessage.Text != string.Empty)
            {
                client.Send(Serialize(txtMessage.Text));
            }

        }

        void ReceiveMsg()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);

                    string message = Deserialize(data).ToString();
                    AddMsg(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Close();
            }


        }

        void AddMsg(string s)
        {
            listView1.Items.Add(new ListViewItem() { Text = s });
            txtMessage.Clear();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseConnection();
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
