using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
namespace Cocaro
{
    public partial class FormDangKy : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public FormDangKy()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
            try
            {
                client = new FireSharp.FirebaseClient(config);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(txtAnswer.Text) || string.IsNullOrEmpty(cbbQuestion.Text))
            {
                MessageBox.Show("Mời điền tất cả nội dung");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Mật khẩu không tương đồng");
            }
            else
            {
                var register = new register
                {
                    Name = textBox1.Text,
                    PhoneNumber = textBox2.Text,
                    Password = textBox3.Text,
                    ConfirmPassword = textBox4.Text,
                    Elo = 400,
                    Question = cbbQuestion.Text,
                    QuestionAnswer = txtAnswer.Text
                };
                SetResponse set = client.Set("users/" + textBox2.Text, register);
                MessageBox.Show("Đăng ký thành công");
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            this.Hide();
            formDangNhap.Show();
        }
    }
}
