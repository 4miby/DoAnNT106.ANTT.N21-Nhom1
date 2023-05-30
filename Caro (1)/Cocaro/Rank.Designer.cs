namespace Cocaro
{
    partial class Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rank));
            lsvRank = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            customButton1 = new CustomButton();
            SuspendLayout();
            // 
            // lsvRank
            // 
            lsvRank.BackColor = Color.LightSkyBlue;
            lsvRank.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lsvRank.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lsvRank.ForeColor = Color.IndianRed;
            lsvRank.FullRowSelect = true;
            lsvRank.GridLines = true;
            lsvRank.Location = new Point(117, 87);
            lsvRank.Name = "lsvRank";
            lsvRank.Size = new Size(324, 382);
            lsvRank.TabIndex = 0;
            lsvRank.UseCompatibleStateImageBehavior = false;
            lsvRank.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Top";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên người chơi";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Elo";
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.CornflowerBlue;
            customButton1.BackgroundColor = Color.CornflowerBlue;
            customButton1.BorderColor = Color.PaleTurquoise;
            customButton1.BorderRadius = 29;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            customButton1.ForeColor = Color.OrangeRed;
            customButton1.Location = new Point(201, 530);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(148, 51);
            customButton1.TabIndex = 1;
            customButton1.Text = "Back";
            customButton1.TextColor = Color.OrangeRed;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // Rank
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(542, 593);
            Controls.Add(customButton1);
            Controls.Add(lsvRank);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Rank";
            Text = "Rank";
            ResumeLayout(false);
        }

        #endregion

        private ListView lsvRank;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private CustomButton customButton1;
    }
}