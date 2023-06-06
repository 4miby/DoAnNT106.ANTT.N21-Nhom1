namespace Cocaro
{
    partial class Room
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(255, 107);
            button1.Name = "button1";
            button1.Size = new Size(309, 82);
            button1.TabIndex = 0;
            button1.Text = "Tạo Phòng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 250);
            button2.Name = "button2";
            button2.Size = new Size(309, 69);
            button2.TabIndex = 1;
            button2.Text = "Vào phòng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Room";
            Text = "Room";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}