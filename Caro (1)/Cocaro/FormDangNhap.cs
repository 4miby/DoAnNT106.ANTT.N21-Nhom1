using System.Security.Cryptography.X509Certificates;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
namespace Cocaro
{
    public partial class FormDangNhap : Form
    {
        public static string username;
        public static string sdt;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy form2 = new FormDangKy();
            this.Hide();
            form2.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Vui lòng điền tất cả thông tin");
            }
            else
            {
                FirebaseResponse response = client.Get("users/" + textBox1.Text);
                register register = response.ResultAs<register>();

                register curuser = new register()
                {
                    PhoneNumber = textBox1.Text,
                    Password = textBox2.Text,
                };
                if (register.IsEqual(register, curuser))
                {
                    FormDangNhap.username = register.Name.ToString();
                    FormDangNhap.sdt = register.PhoneNumber.ToString();
                    MainMenu mainMenu = new MainMenu(username);
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    register.ShowError();
                }
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}