using Cocaro.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocaro
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }
        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
        }
        #endregion
        #region Methods
        public void DrawChessBoard()
        {
            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y)
                    };
                    ChessBoard.Controls.Add(btn);
                    oldbtn = btn;
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.CHESS_HEIGHT);
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }
        #endregion

    }
}
