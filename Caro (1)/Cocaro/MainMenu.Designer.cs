namespace Cocaro
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            button3 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            button4 = new Button();
            btnPlayVsPeople = new Button();
            button1 = new Button();
            txtUsername = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            Online = new ListBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.AliceBlue;
            button3.Location = new Point(119, 234);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(338, 50);
            button3.TabIndex = 3;
            button3.Text = "Thông tin người chơi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnPlayVsPeople);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(877, 433);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.AliceBlue;
            button2.Location = new Point(119, 295);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(338, 50);
            button2.TabIndex = 12;
            button2.Text = "Bảng Xếp Hạng";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.AliceBlue;
            button4.Location = new Point(119, 356);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(338, 50);
            button4.TabIndex = 11;
            button4.Text = "Đăng Xuất";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnPlayVsPeople
            // 
            btnPlayVsPeople.BackColor = Color.Blue;
            btnPlayVsPeople.FlatAppearance.BorderSize = 3;
            btnPlayVsPeople.FlatStyle = FlatStyle.Popup;
            btnPlayVsPeople.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlayVsPeople.ForeColor = Color.AliceBlue;
            btnPlayVsPeople.Location = new Point(119, 173);
            btnPlayVsPeople.Margin = new Padding(3, 2, 3, 2);
            btnPlayVsPeople.Name = "btnPlayVsPeople";
            btnPlayVsPeople.Size = new Size(338, 50);
            btnPlayVsPeople.TabIndex = 10;
            btnPlayVsPeople.Text = "Chơi với bạn";
            btnPlayVsPeople.UseVisualStyleBackColor = false;
            btnPlayVsPeople.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(119, 112);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(338, 50);
            button1.TabIndex = 9;
            button1.Text = "Chơi với máy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(4, 88);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(96, 23);
            txtUsername.TabIndex = 8;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 7;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Online);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 112);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(99, 294);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bạn bè";
            // 
            // Online
            // 
            Online.Dock = DockStyle.Fill;
            Online.FormattingEnabled = true;
            Online.ItemHeight = 15;
            Online.Location = new Point(3, 18);
            Online.Margin = new Padding(3, 2, 3, 2);
            Online.Name = "Online";
            Online.Size = new Size(93, 274);
            Online.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(475, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(402, 433);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(402, 433);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Showcard Gothic", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(104, 0);
            label3.Name = "label3";
            label3.Size = new Size(368, 88);
            label3.TabIndex = 2;
            label3.Text = "CARO";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 433);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainMenu";
            Text = "Main_Menu";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Panel panel1;
        private Label label3;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox Online;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private Button button4;
        private Button btnPlayVsPeople;
        private Button button1;
        private Button button2;
    }
}