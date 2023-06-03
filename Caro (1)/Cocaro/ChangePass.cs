using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cocaro
{
    public partial class ChangePass : Form
    {
        public static string username;
        public static string sdt;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public ChangePass(string sdt)
        {
            InitializeComponent();
            txtSDT.Text = sdt;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPass.Text) || (string.IsNullOrEmpty(txtNewPass.Text)) || string.IsNullOrEmpty(txtOldPass.Text) || (string.IsNullOrEmpty(txtSDT.Text)))
            {
                MessageBox.Show("Vui lòng điền tất cả thông tin");
                return;
            }
            if (txtNewPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FirebaseResponse a = client.Get("users/" + sdt);
            if (a == null)
            {
                MessageBox.Show("Không tồn tại số điện thoại này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                register Register = a.ResultAs<register>();
                if (Register.Password != txtOldPass.Text)
                {
                    MessageBox.Show("Nhập sai mật khẩu cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    register update = new register
                    {
                        Name = Register.Name,
                        PhoneNumber = Register.PhoneNumber,
                        Password = txtNewPass.Text,
                        Elo = Register.Elo,
                        Question=Register.Question,
                        QuestionAnswer=Register.QuestionAnswer
                    };
                    client.Update("users/" + sdt, update);
                    MessageBox.Show("Đổi mật khẩu thành công");
                }
            }
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            username = FormDangNhap.username;
            sdt = FormDangNhap.sdt;
            client = new FireSharp.FirebaseClient(config);
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn quay lại Menu ?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                MainMenu menu = new MainMenu(username);
                menu.Show();
                this.Close();
            }
        }
    }
}
