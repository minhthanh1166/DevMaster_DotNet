using AppChatOnline.Model;
using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace AppChatOnline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public static UserModel userLog;

        private async void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPass.Text;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://shopmt.bsite.net/chat/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var res = await client.GetAsync("user");
                var user = await res.Content.ReadAsAsync<UserModel[]>();
                var result = user.FirstOrDefault(x => x.UserName == userName && x.Password == passWord);

                if (result != null)
                {
                    userLog = result;
                    Chat chat = new Chat();
                    chat.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
    }
}
