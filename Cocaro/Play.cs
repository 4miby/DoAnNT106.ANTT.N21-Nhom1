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
using static Cocaro.Class.SocketData;

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

        void ChessBoard_PlayerMark(object? sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            prgbCoolDown.Value = 0;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));

            Listen();    
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
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer=false;
                pnlChessBoard.Enabled=false;
                Listen();
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
        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProCessData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }
        private void ProCessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                        MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pnlChessBoard.Enabled = true;
                        prgbCoolDown.Value = 0;
                        tmCoolDown.Start();
                    }));
                    ChessBoard.OtherPlayerMark(data.Point);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show(data.Message);
                    break;
                default: break;
            }
            Listen();
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
