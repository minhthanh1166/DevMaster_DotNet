using AppChatOnline.Model;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Windows.Forms;

namespace AppChatOnline
{
    public partial class Chat : Form
    {
        private HttpClient client = new HttpClient();
        private Timer apiTimer;
        public Chat()
        {
            InitializeComponent();

            apiTimer = new Timer();
            apiTimer.Interval = 1000; // 60000 milliseconds = 1 minute
            apiTimer.Tick += new EventHandler(LoadMessages);

            // Start the timer
            apiTimer.Start();
        }

        private async void LoadMessages(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://shopmt.bsite.net/chat/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var res = await client.GetAsync("message");
                var msg = await res.Content.ReadAsAsync<MessageModel[]>();
                listViewChat.Items.Clear();
                foreach (var item in msg)
                {
                    AddMsg(item);
                }
            }
        }

        private void AddMsg(MessageModel item)
        {
            listViewChat.Items.Add(new ListViewItem(item.name + ": " + item.text));
        }

        private async void Chat_Load(object sender, EventArgs e)
        {
            Userame.Text = Login.userLog.UserName;
        }
        private string Serialize(object obj)
        {
            var serializer = new DataContractJsonSerializer(typeof(MessageModel));
            MemoryStream stream = new MemoryStream();
            // BinaryFormatter formatter = new BinaryFormatter();
            // formatter.Serialize(stream, obj);
            serializer.WriteObject(stream, obj);
            stream.Position = 0;
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
        private async void btnSend_Click(object sender, EventArgs e)
        {

            using (var client = new HttpClient())
            {
                string url = "https://shopmt.bsite.net/chat/message";
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                MessageModel message = new MessageModel()
                {
                    text = txtSend.Text,
                    ID_USER = Login.userLog.ID_USER
                };

                var content = new StringContent(Serialize(message), Encoding.UTF8, "application/json");
                var res = await client.PostAsync(url, content);
                txtSend.Clear();
            }
        }

        private void Userame_Click(object sender, EventArgs e)
        {

        }

        private void Chat_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }
    }
}
