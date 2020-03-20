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
    public partial class MailServer : Form
    {
        int count = 3; 
        public MailServer()
        {
            InitializeComponent();
        }

        private void MailServer_Load(object sender, EventArgs e)
        {
            RequestCalculation.Start();
            
        }

        private void RequestCalculation_Tick(object sender, EventArgs e)
        {
            if(count >= 0)
            {
                ListenLabel.Text += ".";
                count--;
            }
            else
            {
                count = 3;
                ListenLabel.Text = "Listening";
            }
            MailProcessed.Text = Utility.Mail().ToString();
            MailFailed.Text = Utility.MailFail().ToString();
            MailQueue.Text = Utility.MailQueue().ToString();
        }
    }
}
