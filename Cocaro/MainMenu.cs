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
        public MainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
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

        }
        void PlayGame()
        {
            Application.Run(new Play());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            th = new Thread(PlayGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
