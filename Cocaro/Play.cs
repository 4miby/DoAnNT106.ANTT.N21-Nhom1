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
using Microsoft.VisualBasic.Logging;

namespace Cocaro
{
    public partial class Play : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        Thread th;
        public static int check = 0;
        public static bool checktimeout, quitcheck = false;
        #endregion

        public Play()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard, txtChangePlayer, pictureBox2);
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
            MessageBox.Show("Đối thủ quá gà bạn đã chiến thắng!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            EndGame();
        }

        void ChessBoard_PlayerMark(object? sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            prgbCoolDown.Value = 0;
            checktimeout = false;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));

            Listen();
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
        }

        private void btnLaN_Click(object sender, EventArgs e)
        {
            socket.IP = txtLAN.Text;
            if (socket.ConnectServer() == false)
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
            }
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prgbCoolDown.PerformStep();
            if (checktimeout)
            {
                if (prgbCoolDown.Value >= prgbCoolDown.Maximum)
                {
                    EndGame();
                    MessageBox.Show("Hết thời gian suy nghĩ rồi, cố gắng lần sau nhé", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                }
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
                        checktimeout = true;
                        pnlChessBoard.Enabled = true;
                        prgbCoolDown.Value = 0;
                        tmCoolDown.Start();
                    }));
                    ChessBoard.OtherPlayerMark(data.Point);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.QUIT:
                    //try
                    //{
                    //    this.Invoke((MethodInvoker)(() =>
                    //    {
                    //        MessageBox.Show("Đối thủ đã chạy mất dép", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //        EndGame();
                    //        socket.close();
                    //    }));
                    //}
                    //catch
                    //{
                    //socket.close();
                    //}
                    break;
                case (int)SocketCommand.END_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                    MessageBox.Show("Nice try, Đối thủ quá hay cố gắng lần sau nhé", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;
                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                    MessageBox.Show("Đối thủ suy nghĩ quá lâu, bạn đã chiến thắng","Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;
                default:
                    break;
            }
            Listen();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            pnlChessBoard.Enabled=true;
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
            //else
            //{
            //    socket.Send(new SocketData((int)SocketCommand.QUIT, " ", new Point()));
            //    socket.close();
            //}
        }

        private void Play_Shown(object sender, EventArgs e)
        {
            txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (String.IsNullOrEmpty(txtLAN.Text))
            {
                txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }
    }
}
