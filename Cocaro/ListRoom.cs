using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Database;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace Cocaro
{
    public partial class ListRoom : Form
    {
        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "Y7HTwFyBihudSAw6bBQ85PsKcmCTJaEBNfQ7vxc7",
            BasePath = "https://caro-79944-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;
        Thread th;
        private string BaseIP = "127.0.0.";
        private int StartIP = 2;
        private int StopIP = 255;
        private string ip;
        private int timeout = 3000;
        private int nFound = 0;
        public string username;
        static object lockObj = new object();
        Stopwatch stopWatch = new Stopwatch();
        TimeSpan ts;
        public ListRoom()
        {

            InitializeComponent();
        }
        private string GetIPAddress()
        {
            string IPAddress = string.Empty;
            IPHostEntry Host = default(IPHostEntry);
            string Hostname = null;
            Hostname = System.Environment.MachineName;
            Host = Dns.GetHostEntry(Hostname);
            foreach (IPAddress IP in Host.AddressList)
            {
                if (IP.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    IPAddress = Convert.ToString(IP);
                }
            }
            return IPAddress;
        }

        public async void RunPingSweep_Async(string txt_ip)
        {
            nFound = 0;
            BaseIP = txt_ip + ".";
            var tasks = new List<Task>();

            stopWatch.Start();

            for (int i = StartIP; i <= StopIP; i++)
            {
                ip = BaseIP + i.ToString();

                System.Net.NetworkInformation.Ping p = new System.Net.NetworkInformation.Ping();
                var task = PingAndUpdateAsync(p, ip);
                tasks.Add(task);
            }

            await Task.WhenAll(tasks).ContinueWith(t =>
            {
                stopWatch.Stop();
                ts = stopWatch.Elapsed;
            });
        }
        private async Task PingAndUpdateAsync(System.Net.NetworkInformation.Ping ping, string ip)
        {
            var reply = await ping.SendPingAsync(ip, timeout);

            if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
            {
                lock (lockObj)
                {
                    FirebaseResponse res = client.Get(@"users");
                    Dictionary<string, register> data = JsonConvert.DeserializeObject<Dictionary<string, register>>(res.Body.ToString());
                    foreach (var item in data)
                    {
                        if (ip != GetIPAddress() && ip == item.Value.Ip)
                        {
                            ListViewItem lv_item = new ListViewItem();
                            lv_item.Text = ip;
                            lv_item.SubItems.Add(item.Value.Name);
                            listView1.Items.Add(lv_item);
                            nFound++;
                        }
                    }
                    
                }
            }
        }

        private void ListRoom_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Check your connection!");
            }
            RunPingSweep_Async(GetIPAddress().Remove(GetIPAddress().LastIndexOf(".")));
            username = FormDangNhap.username;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count >= 0)
            {
                string ip = listView1.SelectedItems[0].Text;
                this.Hide();
                Play play = new Play(ip);
                play.Show();
            }

            else
            {
                return;
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Quay lại Menu?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
                MainMenu menu = new MainMenu(username);
                menu.Show();
            }
        }
    }
}
