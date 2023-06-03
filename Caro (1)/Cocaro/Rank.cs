using Firebase.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FireSharp.Response;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cocaro
{
    public partial class Rank : Form
    {
        static public string username = FormDangNhap.username;
        static public string sdt = FormDangNhap.sdt;
        int top = 1;
        public Rank()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn quay về Menu không ?", "Quay về", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {

                this.Hide();
                MainMenu mainMenu = new MainMenu(username);
                mainMenu.Show();
            }
        }

        private async void Rank_Load(object sender, EventArgs e)
        {
            FirebaseClient firebaseClient = new FirebaseClient("https://caro-79944-default-rtdb.firebaseio.com/");

            // Lấy tham chiếu đến đường dẫn dữ liệu bạn muốn truy vấn
            var dataRef = firebaseClient.Child("users/");

            // Sử dụng phương thức OnceAsync để lấy toàn bộ dữ liệu từ Firebase
            var dataSnapshot = await dataRef.OnceAsync<register>(); 

            // Sắp xếp danh sách theo trường "Elo" theo thứ tự giảm dần
            var orderedData = dataSnapshot.OrderBy(d => d.Object.Elo).Reverse().Take(10);

            // Tạo một danh sách để chứa dữ liệu từ Firebase
            List<register> dataList = new List<register>();

            // Lặp qua dữ liệu đã sắp xếp và thêm vào danh sách
            foreach (var item in orderedData)
            {
                dataList.Add(item.Object);
            }

            // Gán dữ liệu vào ListView
            for (int i = 0; i < dataList.Count - 1; i++)
            {
                ListViewItem listViewItem = new ListViewItem(top.ToString());
                listViewItem.SubItems.Add(dataList[i].Name);
                listViewItem.SubItems.Add(dataList[i].Elo.ToString());
                lsvRank.Items.Add(listViewItem);
                // Xử lý đồng hạng
                if (dataList[i].Elo != dataList[i + 1].Elo)
                {
                    top = i + 2;
                }


            }
            // Xử lý vị trí thứ 10
            if (dataList[9].Elo != dataList[8].Elo)
                top = 10;
            ListViewItem lsv = new ListViewItem(top.ToString());
            lsv.SubItems.Add(dataList[9].Name);
            lsv.SubItems.Add(dataList[9].Elo.ToString());
            lsvRank.Items.Add(lsv);

        }
    }
}
