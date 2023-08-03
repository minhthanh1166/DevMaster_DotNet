using System;
using System.Windows.Forms;

namespace AppChatOnline
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
