using Cocaro.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace Cocaro
{
    public partial class Play : Form
    {
        #region
        ChessBoardManager ChessBoard;
        SocketManager socket;
        #endregion
        public Play()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard, txtUsername, pictureBox2);
            ChessBoard.EndedGame += ChessBoard_EndGame;
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            prgbCoolDown.Step = Cons.COOL_DOWN_STEP;
            prgbCoolDown.Maximum = Cons.COOL_DOWN_TIME;
            prgbCoolDown.Value = 0;
            tmCoolDown.Interval = Cons.COOL_DOWN_INTERVAL;
            socket = new SocketManager();

            NewGame();
        }

        void ChessBoard_EndGame(object? sender, EventArgs e)
        {
            EndGame();
        }

        void ChessBoard_PlayerMark(object? sender, EventArgs e)
        {
            tmCoolDown.Start();
            prgbCoolDown.Value = 0;
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            MessageBox.Show("Kết thúc", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLaN_Click(object sender, EventArgs e)
        {
            socket.IP=txtLAN.Text;
            if(socket.ConnectServer()==false)
            {
                socket.CreateServer();
            }
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prgbCoolDown.PerformStep();
            if (prgbCoolDown.Value >= prgbCoolDown.Maximum)
            {
                EndGame();
            }
        }
        void NewGame()
        {
            prgbCoolDown.Value = 0;
            tmCoolDown.Stop();
            ChessBoard.DrawChessBoard();
        }
        void Quit()
        {
            Application.Exit();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có thực sự muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Play_Shown(object sender, EventArgs e)
        {
            txtLAN.Text=socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if(String.IsNullOrEmpty(txtLAN.Text))
            {
                txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
    }
}
