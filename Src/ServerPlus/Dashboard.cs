using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ServerPlus
{
    public partial class Dashboard : Form
    {
        static int MemoryUsage = 0;
        static int CPUUsage = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            NetworkInterface.Start();
            if (Utility.DashboardLoad == 0)
            {
                Thread cpu_performance_thread = new Thread(CPU_Performance);
                Thread memory_performance_thread = new Thread(Memory_Performance);
                cpu_performance_thread.Start();
                memory_performance_thread.Start();
                Utility.DashboardLoad = 1;
            }
        }

        private void Memory_Performance()
        {
            do
            {
                Thread.Sleep(1000);
                PerformanceCounter _memory = new PerformanceCounter("Memory", "Available MBytes");
                MemoryUsage = Convert.ToInt32(((8000.00 - _memory.NextValue()) / 8000.00) * 100);
            } while (true);
        }

        private void CPU_Performance()
        {
            do
            {
                PerformanceCounter CPU = new PerformanceCounter();
                CPU.CategoryName = "Processor";
                CPU.CounterName = "% Processor Time";
                CPU.InstanceName = "_Total";
                var Dummy = CPU.NextValue();
                Thread.Sleep(1000);
                CPUUsage = Convert.ToInt32(CPU.NextValue());
            } while (true);
        }

        private void NetworkInterface_Tick(object sender, EventArgs e)
        {
            MemoryProgress.Value = MemoryUsage;
            CPUProgress.Value = CPUUsage;
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

