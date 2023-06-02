namespace Cocaro
{
    partial class FormDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKy));
            panel1 = new Panel();
            panel2 = new Panel();
            cbbQuestion = new ComboBox();
            txtAnswer = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnThoat = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 596);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(cbbQuestion);
            panel2.Controls.Add(txtAnswer);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnThoat);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(55, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 463);
            panel2.TabIndex = 14;
            // 
            // cbbQuestion
            // 
            cbbQuestion.FormattingEnabled = true;
            cbbQuestion.Items.AddRange(new object[] { "Bạn sinh vào ngày tháng năm nào?", "Bạn sinh ở thành phố nào?", "Con vật yêu thích của bạn là gì?", "Tên người bạn thân nhất của bạn là gì?", "Tên người bạn thân nhất của bạn là gì?" });
            cbbQuestion.Location = new Point(259, 262);
            cbbQuestion.Name = "cbbQuestion";
            cbbQuestion.Size = new Size(245, 28);
            cbbQuestion.TabIndex = 19;
            // 
            // txtAnswer
            // 
            txtAnswer.BackColor = SystemColors.HighlightText;
            txtAnswer.Location = new Point(259, 306);
            txtAnswer.Name = "txtAnswer";
            txtAnswer.Size = new Size(245, 27);
            txtAnswer.TabIndex = 18;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.PaleTurquoise;
            label8.Location = new Point(15, 302);
            label8.Name = "label8";
            label8.Size = new Size(238, 36);
            label8.TabIndex = 16;
            label8.Text = "Đáp án";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.PaleTurquoise;
            label7.Location = new Point(15, 254);
            label7.Name = "label7";
            label7.Size = new Size(238, 36);
            label7.TabIndex = 15;
            label7.Text = "Câu hỏi bảo mật";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(158, 412);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(204, 48);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.HighlightText;
            textBox4.Location = new Point(259, 212);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(245, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HighlightText;
            textBox3.Location = new Point(259, 165);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(245, 27);
            textBox3.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(158, 358);
            button1.Name = "button1";
            button1.Size = new Size(204, 48);
            button1.TabIndex = 11;
            button1.Text = "Đăng Ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.PaleTurquoise;
            label6.Location = new Point(15, 206);
            label6.Name = "label6";
            label6.Size = new Size(238, 36);
            label6.TabIndex = 10;
            label6.Text = "Nhập lại mật khẩu";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.PaleTurquoise;
            label5.Location = new Point(15, 158);
            label5.Name = "label5";
            label5.Size = new Size(207, 36);
            label5.TabIndex = 9;
            label5.Text = "Mật khẩu";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.PaleTurquoise;
            label3.Location = new Point(185, 12);
            label3.Name = "label3";
            label3.Size = new Size(177, 50);
            label3.TabIndex = 8;
            label3.Text = "ĐĂNG KÝ";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HighlightText;
            textBox2.Location = new Point(259, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.Location = new Point(259, 71);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.PaleTurquoise;
            label2.Location = new Point(15, 110);
            label2.Name = "label2";
            label2.Size = new Size(207, 36);
            label2.TabIndex = 5;
            label2.Text = "Số điện thoại";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI Black", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.PaleTurquoise;
            label1.Location = new Point(15, 62);
            label1.Name = "label1";
            label1.Size = new Size(219, 36);
            label1.TabIndex = 4;
            label1.Text = "Tên người chơi";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(139, 9);
            label4.Name = "label4";
            label4.Size = new Size(370, 83);
            label4.TabIndex = 3;
            label4.Text = "CARO";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // FormDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(649, 596);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDangKy";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox3;
        private Panel panel2;
        private Button button1;
        private Button btnThoat;
        private ComboBox cbbQuestion;
        private TextBox txtAnswer;
        private Label label8;
        private Label label7;
    }
}