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
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Cocaro
{
    public partial class Play : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        SocketManager socket;
        public static bool checktimeout, quitcheck = false;
        List<Image> images;
        static int index = 0, check = 0;

        #endregion
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        public string username;
        public string sdt;
        public string ip = "";
        public Play(string ip)
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
            images = new List<Image>();
            images.Add(Image.FromFile(Application.StartupPath + "\\Resources\\o.png"));
            images.Add(Image.FromFile(Application.StartupPath + "\\Resources\\x.png"));
            this.ip= ip;
            NewGame();

        }

        void ChessBoard_EndGame(object? sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
            MessageBox.Show("Đối thủ quá gà bạn đã chiến thắng!", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Win();
        }

        void ChessBoard_PlayerMark(object? sender, ButtonClickEvent e)
        {
            tmCoolDown.Start();
            pnlChessBoard.Enabled = false;
            prgbCoolDown.Value = 0;
            checktimeout = false;
            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickPoint));
            pictureBox2.Image = images[index];
            if (index == 1)
                index = 0;
            else
                index = 1;
            Listen();
        }

        void EndGame()
        {
            tmCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            newGameToolStripMenuItem.Enabled = true;
            quitcheck = false;
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
                    quitcheck = true;
                }
                else
                {
                    checktimeout = false;
                    socket.isServer = false;
                    pnlChessBoard.Enabled = false;
                    quitcheck = true;
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
                    socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                    MessageBox.Show("Hết thời gian suy nghĩ rồi, cố gắng lần sau nhé", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lose();
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
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        checktimeout = true;
                        pnlChessBoard.Enabled = true;
                        prgbCoolDown.Value = 0;
                        tmCoolDown.Start();
                        pictureBox2.Image = images[index];
                        if (index == 1)
                            index = 0;
                        else
                            index = 1;
                        Listen();
                    }));
                    ChessBoard.OtherPlayerMark(data.Point);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    request();
                    Listen();
                    break;
                case (int)SocketCommand.QUIT:
                    if (quitcheck == true)
                    {
                        this.Invoke((MethodInvoker)(() =>
                        {
                            check = 0;
                            tmCoolDown.Stop();
                            EndGame();
                            MessageBox.Show("Đối thủ đã chạy mất dép", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            socket.close();
                            Win();
                        }));
                    }
                    break;
                case (int)SocketCommand.END_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        Listen();
                    }));
                    MessageBox.Show("Nice try, Đối thủ quá hay cố gắng lần sau nhé", "Lose", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Lose();
                    break;
                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        Listen();
                    }));
                    MessageBox.Show("Đối thủ suy nghĩ quá lâu, bạn đã chiến thắng", "Win", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Win();
                    break;
                case (int)SocketCommand.NO:
                    MessageBox.Show("Đối thủ không muốn chơi tiếp, Hẹn lần sau!", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case (int)SocketCommand.YES:
                    MessageBox.Show("Đối thủ đồng ý", "chấp nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        Listen();
                    }));
                    break;
                case (int)SocketCommand.SEND_MESS:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        listView1.Items.Add(new ListViewItem(data.Message));
                        Listen();
                    }));
                    break;
                default:
                    break;
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            check = 1;
            DialogResult Q = MessageBox.Show("Bạn có chắc muốn thoát trận đấu?", "Warning!", MessageBoxButtons.OKCancel);
            if (Q == DialogResult.OK)
            {
                if (quitcheck)
                {
                    Lose();
                }

                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    socket.close();
                }
                catch
                {
                   
                }
                this.Close();
                Thread th = new Thread(reopenMenu);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                //this.Hide();
                //var menu = new MainMenu(username);
                //menu.Closed += (s, args) => this.Close();
                //menu.Show();
            }
            check = 0;
        }

        private void reopenMenu(object? obj)
        {
            Application.Run(new MainMenu(username));
        }

        private void Play_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check == 0)
            {

                DialogResult Q = MessageBox.Show("Bạn có chắc muốn thoát Game?", "Warning!", MessageBoxButtons.OKCancel);
                if (Q == DialogResult.Cancel)
                    e.Cancel = true;
                else
                {
                    if (quitcheck)
                    {
                        Lose();
                    }
                    try
                    {
                        socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                        socket.close();
                    }
                    catch
                    { }

                }
            }
        }

        private void Play_Shown(object sender, EventArgs e)
        {
            if (ip != "")
            {
                txtLAN.Text = ip;
            }
            else
            {
                txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
                if (String.IsNullOrEmpty(txtLAN.Text))
                {
                    txtLAN.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
                }
            }
            newGameToolStripMenuItem.Enabled = false;
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

        private void btnsend_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string message = "[" + date.ToString() + "] " + txtUsername.Text + " : " + txtmess.Text;
            socket.Send(new SocketData((int)SocketCommand.SEND_MESS, message, new Point()));
            listView1.Items.Add(new ListViewItem(message));
            txtmess.Clear();
            Listen();
        }

        private void Play_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            username = FormDangNhap.username;
            sdt = FormDangNhap.sdt;
            txtUsername.Text = username;
        }
        void Win()
        {
            FirebaseResponse response = client.Get("users/" + sdt);
            register update = response.ResultAs<register>();
            update.Elo += 15;
            client.Update("users/" + sdt, update);
            response = client.Get("History/" + sdt);
            History history=response.ResultAs<History>();
            history.winmatch += 1;
            history.match += 1;
            client.Update("History/" + sdt,history);
        }
        void Lose()
        {
            FirebaseResponse response = client.Get("users/" + sdt);
            register update = response.ResultAs<register>();            
            update.Elo -= 15;
            client.Update("users/" + sdt, update);
            response = client.Get("History/" + sdt);
            History history = response.ResultAs<History>();
            history.match += 1;
            client.Update("History/" + sdt, history);
        }
    }
}
