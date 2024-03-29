﻿namespace Cocaro
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            panel1 = new Panel();
            btnForgetPass = new CustomButton();
            customButton2 = new CustomButton();
            customButton1 = new CustomButton();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(btnForgetPass);
            panel1.Controls.Add(customButton2);
            panel1.Controls.Add(customButton1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(192, 192, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 598);
            panel1.TabIndex = 0;
            // 
            // btnForgetPass
            // 
            btnForgetPass.BackColor = Color.PaleTurquoise;
            btnForgetPass.BackgroundColor = Color.PaleTurquoise;
            btnForgetPass.BorderColor = Color.White;
            btnForgetPass.BorderRadius = 30;
            btnForgetPass.BorderSize = 0;
            btnForgetPass.FlatAppearance.BorderColor = Color.White;
            btnForgetPass.FlatAppearance.BorderSize = 3;
            btnForgetPass.FlatAppearance.MouseDownBackColor = Color.Black;
            btnForgetPass.FlatAppearance.MouseOverBackColor = Color.Black;
            btnForgetPass.FlatStyle = FlatStyle.Popup;
            btnForgetPass.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            btnForgetPass.ForeColor = Color.White;
            btnForgetPass.Location = new Point(0, 443);
            btnForgetPass.Name = "btnForgetPass";
            btnForgetPass.Size = new Size(446, 46);
            btnForgetPass.TabIndex = 11;
            btnForgetPass.Text = "Quên mật khẩu";
            btnForgetPass.TextColor = Color.White;
            btnForgetPass.UseVisualStyleBackColor = false;
            btnForgetPass.Click += btnForgetPass_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.PaleTurquoise;
            customButton2.BackgroundColor = Color.PaleTurquoise;
            customButton2.BorderColor = Color.White;
            customButton2.BorderRadius = 30;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderColor = Color.White;
            customButton2.FlatAppearance.BorderSize = 3;
            customButton2.FlatAppearance.MouseDownBackColor = Color.Black;
            customButton2.FlatAppearance.MouseOverBackColor = Color.Black;
            customButton2.FlatStyle = FlatStyle.Popup;
            customButton2.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(3, 500);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(446, 46);
            customButton2.TabIndex = 10;
            customButton2.Text = "Thoát";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.PaleTurquoise;
            customButton1.BackgroundColor = Color.PaleTurquoise;
            customButton1.BorderColor = Color.White;
            customButton1.BorderRadius = 30;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderColor = Color.White;
            customButton1.FlatAppearance.BorderSize = 3;
            customButton1.FlatAppearance.MouseDownBackColor = Color.Black;
            customButton1.FlatAppearance.MouseOverBackColor = Color.Black;
            customButton1.FlatStyle = FlatStyle.Popup;
            customButton1.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(1, 386);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(446, 46);
            customButton1.TabIndex = 9;
            customButton1.Text = "Đăng nhập";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.LinkColor = Color.PaleTurquoise;
            linkLabel1.Location = new Point(1, 353);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng ký";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HighlightText;
            textBox2.Location = new Point(190, 304);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(247, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(190, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 27);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(-2, 296);
            label2.Name = "label2";
            label2.Size = new Size(199, 36);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(-2, 255);
            label1.Name = "label1";
            label1.Size = new Size(213, 36);
            label1.TabIndex = 0;
            label1.Text = "Số điện thoại";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Black;
            label4.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(449, 78);
            label4.TabIndex = 2;
            label4.Text = "CARO";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(443, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(386, 598);
            panel2.TabIndex = 3;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(829, 598);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            ForeColor = Color.PaleTurquoise;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private Label label4;
        private Panel panel2;
        private CustomButton btnForgetPass;
    }
}