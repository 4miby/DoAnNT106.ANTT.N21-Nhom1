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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
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
            tmCoolDown = new System.Windows.Forms.Timer(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            quitToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlChessBoard
            // 
            pnlChessBoard.BackColor = SystemColors.Control;
            pnlChessBoard.Location = new Point(12, 27);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(570, 570);
            pnlChessBoard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 102);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(26, 105);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(107, 27);
            txtUsername.TabIndex = 2;
            // 
            // prgbCoolDown
            // 
            prgbCoolDown.Location = new Point(161, 79);
            prgbCoolDown.Name = "prgbCoolDown";
            prgbCoolDown.Size = new Size(131, 27);
            prgbCoolDown.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(205, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtLAN
            // 
            txtLAN.Location = new Point(71, 138);
            txtLAN.Name = "txtLAN";
            txtLAN.Size = new Size(176, 27);
            txtLAN.TabIndex = 5;
            // 
            // btnLaN
            // 
            btnLaN.Location = new Point(71, 171);
            btnLaN.Name = "btnLaN";
            btnLaN.Size = new Size(176, 26);
            btnLaN.TabIndex = 6;
            btnLaN.Text = "LAN";
            btnLaN.UseVisualStyleBackColor = true;
            btnLaN.Click += btnLaN_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(22, 203);
            listView1.Name = "listView1";
            listView1.Size = new Size(270, 332);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txtmess
            // 
            txtmess.Location = new Point(23, 543);
            txtmess.Name = "txtmess";
            txtmess.Size = new Size(224, 27);
            txtmess.TabIndex = 8;
            // 
            // btnsend
            // 
            btnsend.Location = new Point(253, 541);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(40, 30);
            btnsend.TabIndex = 9;
            btnsend.Text = "Gửi";
            btnsend.UseVisualStyleBackColor = true;
            // 
            // tmCoolDown
            // 
            tmCoolDown.Tick += tmCoolDown_Tick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(892, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(218, 26);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            quitToolStripMenuItem.Size = new Size(218, 26);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnsend);
            panel1.Controls.Add(txtmess);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(btnLaN);
            panel1.Controls.Add(txtLAN);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(prgbCoolDown);
            panel1.Controls.Add(txtUsername);
            panel1.Location = new Point(588, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 582);
            panel1.TabIndex = 11;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(892, 612);
            Controls.Add(panel1);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Name = "Play";
            Text = "Play";
            FormClosing += Play_FormClosing;
            Shown += Play_Shown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private System.Windows.Forms.Timer tmCoolDown;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private Panel panel1;
    }
}