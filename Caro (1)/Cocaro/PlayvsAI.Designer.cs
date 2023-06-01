namespace Cocaro
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            psbCooldownTime = new ProgressBar();
            ptbPlayer = new PictureBox();
            txtUsername = new TextBox();
            tmCooldown = new System.Windows.Forms.Timer(components);
            pnlChessBoard = new Panel();
            menuStrip1 = new MenuStrip();
            newgameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem1 = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // psbCooldownTime
            // 
            psbCooldownTime.Location = new Point(130, 49);
            psbCooldownTime.Name = "psbCooldownTime";
            psbCooldownTime.Size = new Size(100, 23);
            psbCooldownTime.TabIndex = 10;
            // 
            // ptbPlayer
            // 
            ptbPlayer.Image = (Image)resources.GetObject("ptbPlayer.Image");
            ptbPlayer.Location = new Point(3, 0);
            ptbPlayer.Name = "ptbPlayer";
            ptbPlayer.Size = new Size(78, 71);
            ptbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbPlayer.TabIndex = 9;
            ptbPlayer.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(130, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(100, 23);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtNamePlayer_TextChanged;
            // 
            // tmCooldown
            // 
            tmCooldown.Tick += tmCooldown_Tick;
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.AutoSize = true;
            pnlChessBoard.BackColor = Color.Silver;
            pnlChessBoard.Location = new Point(0, 27);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(475, 475);
            pnlChessBoard.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { newgameToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(757, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // newgameToolStripMenuItem
            // 
            newgameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem1, quitToolStripMenuItem });
            newgameToolStripMenuItem.Name = "newgameToolStripMenuItem";
            newgameToolStripMenuItem.Size = new Size(50, 20);
            newgameToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem1
            // 
            newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            newGameToolStripMenuItem1.Size = new Size(129, 22);
            newGameToolStripMenuItem1.Text = "NewGame";
            newGameToolStripMenuItem1.Click += newGameToolStripMenuItem1_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(129, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(psbCooldownTime);
            panel1.Controls.Add(ptbPlayer);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(481, 27);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 475);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 507);
            Controls.Add(panel1);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "AIChess";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ptbPlayer).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ProgressBar psbCooldownTime;
        private PictureBox ptbPlayer;
        private TextBox txtUsername;
        private System.Windows.Forms.Timer tmCooldown;
        private Panel pnlChessBoard;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem newgameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Panel panel1;
    }
}