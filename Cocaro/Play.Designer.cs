namespace Cocaro
{
    partial class Play
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlChessBoard = new Panel();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            prgbCoolDown = new ProgressBar();
            pictureBox2 = new PictureBox();
            txtLAN = new TextBox();
            btnLaN = new Button();
            listView1 = new ListView();
            txtmess = new TextBox();
            btnsend = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.Control;
            pnlChessBoard.Location = new Point(3, 0);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(570, 570);
            pnlChessBoard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(607, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 102);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(607, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(110, 27);
            txtUsername.TabIndex = 2;
            // 
            // prgbCoolDown
            // 
            prgbCoolDown.Location = new Point(746, 87);
            prgbCoolDown.Name = "prgbCoolDown";
            prgbCoolDown.Size = new Size(131, 27);
            prgbCoolDown.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(788, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtLAN
            // 
            txtLAN.Location = new Point(655, 164);
            txtLAN.Name = "txtLAN";
            txtLAN.Size = new Size(176, 27);
            txtLAN.TabIndex = 5;
            // 
            // btnLaN
            // 
            btnLaN.Location = new Point(655, 197);
            btnLaN.Name = "btnLaN";
            btnLaN.Size = new Size(176, 26);
            btnLaN.TabIndex = 6;
            btnLaN.Text = "LAN";
            btnLaN.UseVisualStyleBackColor = true;
            btnLaN.Click += btnLaN_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(607, 229);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 306);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtmess
            // 
            txtmess.Location = new Point(607, 543);
            txtmess.Name = "txtmess";
            txtmess.Size = new Size(224, 27);
            txtmess.TabIndex = 8;
            // 
            // btnsend
            // 
            btnsend.Location = new Point(840, 541);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(40, 30);
            btnsend.TabIndex = 9;
            btnsend.Text = "Gửi";
            btnsend.UseVisualStyleBackColor = true;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 588);
            Controls.Add(btnsend);
            Controls.Add(txtmess);
            Controls.Add(listView1);
            Controls.Add(btnLaN);
            Controls.Add(txtLAN);
            Controls.Add(pictureBox2);
            Controls.Add(prgbCoolDown);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(pnlChessBoard);
            Name = "Play";
            Text = "Play";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlChessBoard;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private ProgressBar prgbCoolDown;
        private PictureBox pictureBox2;
        private TextBox txtLAN;
        private Button btnLaN;
        private ListView listView1;
        private TextBox txtmess;
        private Button btnsend;
    }
}