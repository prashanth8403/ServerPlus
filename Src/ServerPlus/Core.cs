using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerPlus
{
    public partial class Core : Form
    {
        private bool _dragging;
        private Point _offset;
        
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
        public Core()
        {
            InitializeComponent();
        }

        private void Performance_Click(object sender, EventArgs e)
        {
            ControlPanel.Controls.Clear();
            Performance _performance = new Performance();
            _performance.TopLevel = false;
            ControlPanel.Controls.Add(_performance);
            _performance.Dock = DockStyle.Fill;
            _performance.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            
            ControlPanel.Controls.Clear();
            Dashboard _formPreview = new Dashboard();
            _formPreview.TopLevel = false;
            ControlPanel.Controls.Add(_formPreview);
            _formPreview.Dock = DockStyle.Fill;
            _formPreview.Show();
        }

        private void Core_Load(object sender, EventArgs e)
        {
            //MailProcess Atlas = new MailProcess();
            ControlPanel.Controls.Clear();
            Dashboard _formPreview = new Dashboard();
            _formPreview.TopLevel = false;
            ControlPanel.Controls.Add(_formPreview);
            _formPreview.Dock = DockStyle.Fill;
            _formPreview.Show();
            if(Utility.Atlas_Function == 0)
            {
                Atlas();
                Utility.Atlas_Function = 1;
            }
            if(Utility.Juno_Function == 0)
            {
                Juno();
                Utility.Juno_Function = 1;
            } 
        }

        public void Juno()
        {
            Thread _datathread = new Thread(DatabaseProcess.DataServer);
            _datathread.Start();
        }

        public void Atlas()
        {
            Thread _mailthread = new Thread(MailProcess.MessageServer);
            _mailthread.Start();
        }

        private void EmailButton_Click(object sender, EventArgs e)
        {
            ControlPanel.Controls.Clear();
            MailServer _formPreview = new MailServer();
            _formPreview.TopLevel = false;
            ControlPanel.Controls.Add(_formPreview);
            _formPreview.Dock = DockStyle.Fill;
            _formPreview.Show();
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            ControlPanel.Controls.Clear();
            DatabaseServer _formPreview = new DatabaseServer();
            _formPreview.TopLevel = false;
            ControlPanel.Controls.Add(_formPreview);
            _formPreview.Dock = DockStyle.Fill;
            _formPreview.Show();
        }
    }
}
