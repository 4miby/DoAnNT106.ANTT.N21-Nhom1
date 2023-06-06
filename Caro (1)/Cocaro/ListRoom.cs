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

namespace Cocaro
{
    public partial class ListRoom : Form
    {
        Thread th;
        private string BaseIP = "127.0.0.";
        private int StartIP = 2;
        private int StopIP = 255;
        private string ip;
        private int timeout = 3000;
        private int nFound = 0;

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
                    if (ip != GetIPAddress())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = ip;
                        listView1.Items.Add(item);
                        nFound++;
                    }
                }
            }
        }

        private void ListRoom_Load(object sender, EventArgs e)
        {
            RunPingSweep_Async(GetIPAddress().Remove(GetIPAddress().LastIndexOf(".")));
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count >= 0)
            {
                string ip = listView1.SelectedItems[0].Text;
                this.Hide();
                Play play = new Play();
                play.Show();
            }
            else
            {
                return; 
            }    
        }

        private void PlayGame(object? obj)
        {
            Application.Run(new Play());
        }
    }
}
