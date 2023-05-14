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

namespace Cocaro
{
    public partial class Play : Form
    {
        #region
        ChessBoardManager ChessBoard;
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

            ChessBoard.DrawChessBoard();
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
            MessageBox.Show("Kết thúc");
        }

        private void btnLaN_Click(object sender, EventArgs e)
        {

        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prgbCoolDown.PerformStep();
            if (prgbCoolDown.Value >= prgbCoolDown.Maximum)
            {
                EndGame();
            }
        }
    }
}
