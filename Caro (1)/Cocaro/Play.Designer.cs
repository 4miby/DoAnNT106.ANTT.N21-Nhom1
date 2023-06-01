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
            pnlChessBoard.AutoSize = true;
            pnlChessBoard.BackColor = SystemColors.Control;
            pnlChessBoard.Location = new Point(10, 20);
            pnlChessBoard.Margin = new Padding(3, 2, 3, 2);
            pnlChessBoard.Name = "pnlChessBoard";
            pnlChessBoard.Size = new Size(475, 475);
            pnlChessBoard.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 3);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(23, 79);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(94, 23);
            txtUsername.TabIndex = 2;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // prgbCoolDown
            // 
            prgbCoolDown.Location = new Point(141, 59);
            prgbCoolDown.Margin = new Padding(3, 2, 3, 2);
            prgbCoolDown.Name = "prgbCoolDown";
            prgbCoolDown.Size = new Size(115, 20);
            prgbCoolDown.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(179, 15);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // txtLAN
            // 
            txtLAN.Location = new Point(62, 104);
            txtLAN.Margin = new Padding(3, 2, 3, 2);
            txtLAN.Name = "txtLAN";
            txtLAN.Size = new Size(154, 23);
            txtLAN.TabIndex = 5;
            // 
            // btnLaN
            // 
            btnLaN.Location = new Point(62, 128);
            btnLaN.Margin = new Padding(3, 2, 3, 2);
            btnLaN.Name = "btnLaN";
            btnLaN.Size = new Size(154, 20);
            btnLaN.TabIndex = 6;
            btnLaN.Text = "LAN";
            btnLaN.UseVisualStyleBackColor = true;
            btnLaN.Click += btnLaN_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(19, 152);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(237, 250);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // txtmess
            // 
            txtmess.Location = new Point(20, 407);
            txtmess.Margin = new Padding(3, 2, 3, 2);
            txtmess.Name = "txtmess";
            txtmess.Size = new Size(196, 23);
            txtmess.TabIndex = 8;
            // 
            // btnsend
            // 
            btnsend.Location = new Point(221, 406);
            btnsend.Margin = new Padding(3, 2, 3, 2);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(35, 22);
            btnsend.TabIndex = 9;
            btnsend.Text = "Gửi";
            btnsend.UseVisualStyleBackColor = true;
            btnsend.Click += btnsend_Click;
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(763, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, quitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newGameToolStripMenuItem.Size = new Size(175, 22);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            quitToolStripMenuItem.Size = new Size(175, 22);
            quitToolStripMenuItem.Text = "Quit";
            quitToolStripMenuItem.Click += quitToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
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
            panel1.Location = new Point(491, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 475);
            panel1.TabIndex = 11;
            // 
            // Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(763, 501);
            Controls.Add(panel1);
            Controls.Add(pnlChessBoard);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 2, 3, 2);
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