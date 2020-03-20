using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPlus
{
    public partial class DatabaseServer : Form
    {
        public DatabaseServer()
        {
            InitializeComponent();
        }

        private void DatabaseServer_Load(object sender, EventArgs e)
        {
            DataRequest.Start();
        }

        private void DataRequest_Tick(object sender, EventArgs e)
        {
            DataProcessed.Text = Utility.Database().ToString();
        }
    }
}
