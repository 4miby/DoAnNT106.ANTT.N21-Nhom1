namespace Cocaro
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnChange = new CustomButton();
            txtSDT = new TextBox();
            txtNewPass = new TextBox();
            txtConfirmPass = new TextBox();
            customButton4 = new CustomButton();
            txtOldPass = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(96, 232);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "SỐ ĐIỆN THOẠI";
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.RoyalBlue;
            btnChange.BackgroundColor = Color.RoyalBlue;
            btnChange.BorderColor = Color.PaleTurquoise;
            btnChange.BorderRadius = 40;
            btnChange.BorderSize = 0;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.LightYellow;
            btnChange.Location = new Point(237, 493);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(194, 72);
            btnChange.TabIndex = 4;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.TextColor = Color.LightYellow;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(306, 228);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(249, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(306, 352);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.Size = new Size(249, 27);
            txtNewPass.TabIndex = 6;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(306, 414);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(249, 27);
            txtConfirmPass.TabIndex = 7;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.DeepSkyBlue;
            customButton4.BackgroundColor = Color.DeepSkyBlue;
            customButton4.BorderColor = Color.PaleTurquoise;
            customButton4.BorderRadius = 16;
            customButton4.BorderSize = 0;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            customButton4.ForeColor = Color.Crimson;
            customButton4.Location = new Point(-2, -2);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(60, 42);
            customButton4.TabIndex = 11;
            customButton4.Text = "Thoát";
            customButton4.TextColor = Color.Crimson;
            customButton4.UseVisualStyleBackColor = false;
            customButton4.Click += customButton4_Click;
            // 
            // txtOldPass
            // 
            txtOldPass.Location = new Point(306, 290);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '*';
            txtOldPass.Size = new Size(249, 27);
            txtOldPass.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(96, 294);
            label2.Name = "label2";
            label2.Size = new Size(137, 23);
            label2.TabIndex = 14;
            label2.Text = "MẬT KHẨU CŨ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(96, 356);
            label3.Name = "label3";
            label3.Size = new Size(149, 23);
            label3.TabIndex = 15;
            label3.Text = "MẬT KHẨU MỚI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(91, 418);
            label4.Name = "label4";
            label4.Size = new Size(198, 23);
            label4.TabIndex = 16;
            label4.Text = "NHẬP LẠI MẬT KHẨU";
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(644, 620);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtOldPass);
            Controls.Add(customButton4);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Controls.Add(txtSDT);
            Controls.Add(btnChange);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "ChangePass";
            Text = "ChangePass";
            Load += ChangePass_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private CustomButton btnChange;
        private TextBox txtSDT;
        private TextBox txtNewPass;
        private TextBox txtConfirmPass;
        private CustomButton customButton4;
        private TextBox txtOldPass;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}