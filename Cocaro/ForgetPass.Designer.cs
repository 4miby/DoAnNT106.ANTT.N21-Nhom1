namespace Cocaro
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            panel1 = new Panel();
            cbbQuestion = new ComboBox();
            txtAnswer = new TextBox();
            txtConfirmPass = new TextBox();
            txtPass = new TextBox();
            txtSDT = new TextBox();
            btnThoat = new Button();
            btnChange = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(cbbQuestion);
            panel1.Controls.Add(txtAnswer);
            panel1.Controls.Add(txtConfirmPass);
            panel1.Controls.Add(txtPass);
            panel1.Controls.Add(txtSDT);
            panel1.Controls.Add(btnThoat);
            panel1.Controls.Add(btnChange);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(84, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 474);
            panel1.TabIndex = 0;
            // 
            // cbbQuestion
            // 
            cbbQuestion.FormattingEnabled = true;
            cbbQuestion.Items.AddRange(new object[] { "Bạn sinh vào ngày tháng năm nào?", "Bạn sinh ở thành phố nào?", "Con vật yêu thích của bạn là gì?", "Tên người bạn thân nhất của bạn là gì?", "Bạn có bao nhiêu anh em ruột?", "Tên trường học tiểu học của bạn là gì? " });
            cbbQuestion.Location = new Point(231, 255);
            cbbQuestion.Name = "cbbQuestion";
            cbbQuestion.Size = new Size(276, 28);
            cbbQuestion.TabIndex = 20;
            // 
            // txtAnswer
            // 
            txtAnswer.Location = new Point(231, 306);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(276, 27);
            txtAnswer.TabIndex = 19;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(231, 200);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(276, 27);
            txtConfirmPass.TabIndex = 17;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(231, 147);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(276, 27);
            txtPass.TabIndex = 16;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(231, 94);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(276, 27);
            txtSDT.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(172, 423);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(204, 48);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnChange
            // 
            btnChange.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.Red;
            btnChange.Location = new Point(172, 359);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(204, 48);
            btnChange.TabIndex = 13;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += button1_Click;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.PaleTurquoise;
            label7.Location = new Point(0, 300);
            label7.Name = "label7";
            label7.Size = new Size(207, 36);
            label7.TabIndex = 12;
            label7.Text = "Đáp án";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(3, 247);
            label6.Name = "label6";
            label6.Size = new Size(207, 36);
            label6.TabIndex = 11;
            label6.Text = "Câu hỏi bảo mật";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(3, 194);
            label5.Name = "label5";
            label5.Size = new Size(230, 36);
            label5.TabIndex = 10;
            label5.Text = "Nhập lại mật khẩu";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(135, 0);
            label3.Name = "label3";
            label3.Size = new Size(274, 50);
            label3.TabIndex = 9;
            label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(0, 141);
            label1.Name = "label1";
            label1.Size = new Size(207, 36);
            label1.TabIndex = 7;
            label1.Text = "Mật khẩu mới";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(0, 86);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 6;
            label2.Text = "Số điện thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(185, -2);
            label4.Name = "label4";
            label4.Size = new Size(370, 83);
            label4.TabIndex = 4;
            label4.Text = "CARO";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // ForgetPass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(672, 575);
            Controls.Add(label4);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgetPass";
            Text = "ForgetPass";
            Load += ForgetPass_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button btnThoat;
        private Button btnChange;
        private TextBox txtAnswer;
        private TextBox txtConfirmPass;
        private TextBox txtPass;
        private TextBox txtSDT;
        private ComboBox cbbQuestion;
    }
}