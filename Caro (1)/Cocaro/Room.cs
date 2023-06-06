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
    public partial class Room : Form
    {
        Thread th;
        public Room()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(PlayGame);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void PlayGame(object? obj)
        {
            Application.Run(new Play());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListRoom listroom= new ListRoom();
            listroom.Show();
            this.Close();
        }
    }
}
