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
        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        public static bool checktimeout;
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
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            MessageBox.Show("Đối thủ quá gà bạn đã chiến thắng!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            newGameToolStripMenuItem.Enabled = true;
        }

        private void btnLaN_Click(object sender, EventArgs e)
        {
            socket.IP = txtLAN.Text;
            try
            {
                if (socket.ConnectServer() == false)
                {
                    checktimeout = true;
                    socket.isServer = true;
                    pnlChessBoard.Enabled = true;
                    socket.CreateServer();
                }
                else
                {
                    checktimeout = false;
                    socket.isServer = false;
                    pnlChessBoard.Enabled = false;
                    Listen();
                }

                btnLaN.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không thể kết nối qua Ip này");
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
            newGameToolStripMenuItem.Enabled = false;
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
                    request();
                    break;
                case (int)SocketCommand.QUIT:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.END_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                    }));
                    MessageBox.Show("Nice try, Đối thủ quá hay cố gắng lần sau nhé", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                    }));
                    MessageBox.Show("Đối thủ suy nghĩ quá lâu, bạn đã chiến thắng", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)SocketCommand.NO:
                    MessageBox.Show("Đối thủ không muốn chơi tiếp, Hẹn lần sau!", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)SocketCommand.YES:
                    MessageBox.Show("Đối thủ đồng ý", "chấp nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                    }));
                    break;
                default: break;
            }
            Listen();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));

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
            else
            {
                try
                {
                    socket.close();
                }
                catch { }
            }
        }

        private void Play_Shown(object sender, EventArgs e)
        {
            txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (String.IsNullOrEmpty(txtLAN.Text))
            {
                txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
            newGameToolStripMenuItem.Enabled = false;
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string username = FormDangNhap.username;
            txtUsername.Text = username;
        }
        void request()
        {
            DialogResult res = MessageBox.Show("Đối thủ muốn chơi tiếp", "Mời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                socket.Send(new SocketData((int)SocketCommand.YES, "", new Point()));
                this.Invoke((MethodInvoker)(() =>
                {
                    NewGame();
                    pnlChessBoard.Enabled = false;
                    
                }));
            }
            else
            {
                socket.Send(new SocketData((int)SocketCommand.NO, "", new Point()));
            }
        }
    }
}
