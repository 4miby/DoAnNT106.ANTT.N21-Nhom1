using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cocaro
{
    public partial class MainMenu : Form
    {
        Thread th;
        public string username;
        public static string sdt;
        public MainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
            sdt = FormDangNhap.sdt;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
            txtUsername.Text = username;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThongTin thongtin = new ThongTin();
            thongtin.ShowDialog();
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room room = new Room();
            room.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 playvsAI = new Form1();
            playvsAI.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Rank rank = new Rank();
            rank.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất hay không", "Quay về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                FormDangNhap formDangNhap = new FormDangNhap();
                this.Hide();
                formDangNhap.Show();
            }
        }
    }
}
