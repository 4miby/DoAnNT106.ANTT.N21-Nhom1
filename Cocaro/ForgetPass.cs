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
    public partial class ForgetPass : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public ForgetPass()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSDT.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtAnswer.Text) || string.IsNullOrEmpty(cbbQuestion.Text))
            {
                MessageBox.Show("Mời điền tất cả nội dung", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Mật khẩu không tương đồng", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FirebaseResponse response = client.Get("users/" + txtSDT.Text);
                if (response == null)
                {
                    MessageBox.Show("Không tồn tại số điện thoại này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    register Register = response.ResultAs<register>();
                    if (Register.Question != cbbQuestion.Text || Register.QuestionAnswer != txtAnswer.Text)
                    {
                        MessageBox.Show("Sai câu hỏi bảo mật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        register update = new register
                        {
                            Name = Register.Name,
                            PhoneNumber = Register.PhoneNumber,
                            Password = txtPass.Text,
                            Elo = Register.Elo,
                            Question = Register.Question,
                            QuestionAnswer = Register.QuestionAnswer
                        };
                        client.Update("users/" + txtSDT.Text, update);
                        MessageBox.Show("Đổi mật khẩu thành công");
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.Show();
        }

        private void ForgetPass_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
        }
    }
}
