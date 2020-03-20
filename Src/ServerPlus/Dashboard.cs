using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ServerPlus
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            NetworkInterface.Start();
        }

        private void NetworkInterface_Tick(object sender, EventArgs e)
        {
            NetworkInterface[] adapters = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters.Where(a => a.OperationalStatus == OperationalStatus.Up))
            {
                if (adapter.Description == "Intel(R) Wireless-AC 9462")
                {
                    NetworkAdapter.Text = adapter.Description;
                    var NetworkInfo = adapter.GetIPv4Statistics();
                    NetworkDevice.Text = adapter.Name;
                    PacketSent.Text = NetworkInfo.BytesSent.ToString();
                    PacketReceived.Text = NetworkInfo.BytesReceived.ToString();
                }
            }
        }
    }
}

