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
            ChessBoard.DrawChessBoard();
        }
        private void btnLaN_Click(object sender, EventArgs e)
        {
        }
    }
}
