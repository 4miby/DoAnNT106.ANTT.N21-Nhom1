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
    public partial class Rank : Form
    {
        static public string username = FormDangNhap.username;
        public Rank()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn quay về Menu không ?", "Quay về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                this.Hide();
                MainMenu mainMenu = new MainMenu(username);
                mainMenu.Show();
            }
        }
    }
}
