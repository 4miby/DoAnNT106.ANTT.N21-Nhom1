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
        private List<Player> player;
        private Panel chessBoard;
        private int currentPlayer;
        private TextBox playername;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox Playername { get => playername; set => playername = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        #endregion
        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.Playername = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
            {
                new Player("HuyVo",Image.FromFile(Application.StartupPath+"\\Resources\\x.png")),
                new Player("LXL",Image.FromFile(Application.StartupPath+"\\Resources\\o.png"))
                
            };
            CurrentPlayer = 0;
            ChangePlayer();
        }
        #endregion
        #region Methods
        public void DrawChessBoard()
        {
            matrix = new List<List<Button>>();

            Button oldbtn = new Button() { Width = 0, Location = new Point(0, 0) }; // tạo ô cũ để ơ mới có vị trí dịch phải từ ô cũ
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                matrix.Add(new List<Button>()); 
                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y),// ô mới dịch phải 1 khoảng ô cũ
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString() // Lưu lại vị trí button theo hàng
                    };
                    btn.Click += Btn_Click; // Tạo sự kiện click vào ô cờ
                    ChessBoard.Controls.Add(btn); 
                    matrix[i].Add(btn);
                    oldbtn = btn; // Lưu lại ô cũ từ ô mới
                }
                oldbtn.Location = new Point(0, oldbtn.Location.Y + Cons.CHESS_HEIGHT); //Xuống dòng và đưa về vị trí đầu
                oldbtn.Width = 0;
                oldbtn.Height = 0;
            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            if ( btn.BackgroundImage != null)
                 return;
            Mark(btn);
            ChangePlayer(); 
            if(isEndGame(btn))
            {
                EndGame();
            }
        }
        private void EndGame()
        {
            MessageBox.Show("Kết thúc game","Win",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }
        // Hàm lấy vị trí của ô trong bàn cờ
        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = matrix[vertical].IndexOf(btn);
            Point point = new Point(horizontal,vertical);
            
            return point;
        }
        //Xử lý hàng ngang
        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countLeft = 0;
            for(int i =point.X; i >= 0; i--) // Đếm từ ô vừa chọn về trái
            {
                if (matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countLeft++;
                else // nếu khác thoát không đếm nửa
                    break;
            }    
            int countRight = 0;
            for (int i = point.X+1; i <Cons.CHESS_BOARD_WIDTH; i++) // Đếm từ ô vừa chọn +1(không đếm thêm ô vừa chọn) về phải
            {
                if (matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                    countRight++;
                else // nếu khác thoát không đếm nửa
                    break;
            }
            return countLeft + countRight==5;
        }
        // Xử lý hàng dọc
        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = point.Y; i >=0; i--) // Đếm từ ô vừa chọn lên trên đầu
            {
                if (matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else 
                    break;
            }
            int countBot = 0;
            for (int i = point.Y+1; i < Cons.CHESS_BOARD_HEIGHT; i++) 
            {
                if (matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    countBot++;
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        //Xử lý đường chéo chính
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <=point.X ; i++) 
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;
                if (matrix[point.Y-i][point.X-i].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <=Cons.CHESS_WIDTH-point.X ; i++)
            {
                if (point.X + i >= Cons.CHESS_BOARD_WIDTH || point.Y + i >= Cons.CHESS_BOARD_HEIGHT)
                    break;
                if (matrix[point.Y+i][point.X+i].BackgroundImage == btn.BackgroundImage)
                    countBot++;
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        //Xử lý đường chéo phụ
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);
            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i >Cons.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;
                if (matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    countTop++;
                else
                    break;
            }
            int countBot = 0;
            for (int i = 1; i <= Cons.CHESS_WIDTH - point.X; i++)
            {
                if (point.X - i <0 || point.Y + i >= Cons.CHESS_BOARD_HEIGHT)
                    break;
                if (matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    countBot++;
                else
                    break;
            }
            return countTop + countBot == 5;
        }
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            Playername.Text = Player[CurrentPlayer].Name;
            PlayerMark.Image = Player[CurrentPlayer].Mark;
        }
        #endregion

    }
}
