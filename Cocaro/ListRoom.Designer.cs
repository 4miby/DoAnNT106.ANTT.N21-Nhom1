namespace Cocaro
{
    partial class ListRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListRoom));
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            customButton1 = new CustomButton();
            label1 = new Label();
            columnHeader2 = new ColumnHeader();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(60, 85);
            listView1.Name = "listView1";
            listView1.Size = new Size(353, 303);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "IP";
            columnHeader1.Width = 200;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.Gray;
            customButton1.BackgroundColor = Color.Gray;
            customButton1.BorderColor = Color.PaleTurquoise;
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Crimson;
            customButton1.Location = new Point(171, 396);
            customButton1.Margin = new Padding(3, 4, 3, 4);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(130, 53);
            customButton1.TabIndex = 1;
            customButton1.Text = "Thoát";
            customButton1.TextColor = Color.Crimson;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 255, 255);
            label1.Location = new Point(171, 43);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 2;
            label1.Text = "Danh sách phòng";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // ListRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(469, 451);
            Controls.Add(label1);
            Controls.Add(customButton1);
            Controls.Add(listView1);
            Name = "ListRoom";
            Text = "ListRoom";
            Load += ListRoom_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private CustomButton customButton1;
        private Label label1;
        private ColumnHeader columnHeader2;
    }
}