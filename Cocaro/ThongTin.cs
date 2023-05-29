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
    public partial class ThongTin : Form
    {
        public string sdt;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public ThongTin()
        {
            InitializeComponent();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            sdt = MainMenu.sdt;
            client = new FireSharp.FirebaseClient(config);
            FirebaseResponse response = client.Get("users/" + sdt);
            register register = response.ResultAs<register>();
            if (register != null)
            {
                btnName.Text = register.Name;
                btnSDT.Text = register.PhoneNumber;
                btnELo.Text = register.Elo.ToString();
            }
        }

        private void ThongTin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn trở lại Menu", "Quay về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                e.Cancel = true;
            }
          
        }

        private void customButton4_Click(object sender, EventArgs e)
        {
            reOpenMenu();
        }

        private void reOpenMenu()
        {
            this.Hide();
            MainMenu menu = new MainMenu(btnName.Text);
            menu.Show();
            this.Close();
        }
    }
}
