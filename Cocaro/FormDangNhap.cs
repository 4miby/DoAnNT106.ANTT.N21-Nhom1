namespace Cocaro
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKy form2 = new FormDangKy();
            this.Visible = false;
            form2.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            client form3 = new client();
            this.Visible = false;
            form3.ShowDialog();
        }
    }
}