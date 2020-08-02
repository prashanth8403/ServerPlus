using System;
using System.Drawing;
using System.Threading;
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
            if (Utility.PerformanceClick == 0)
            {
                ControlPanel.Controls.Clear();
                Performance _performance = new Performance();
                _performance.TopLevel = false;
                ControlPanel.Controls.Add(_performance);
                _performance.Dock = DockStyle.Fill;
                _performance.Show();
                Utility.PerformanceClick = 1;
                Utility.HomeClick = 0;
                Utility.DatabaseClick = 0;
                Utility.EmailClick = 0;
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            if (Utility.HomeClick == 0)
            {
                ControlPanel.Controls.Clear();
                Dashboard _formPreview = new Dashboard();
                _formPreview.TopLevel = false;
                ControlPanel.Controls.Add(_formPreview);
                _formPreview.Dock = DockStyle.Fill;
                _formPreview.Show();
                Utility.PerformanceClick = 0;
                Utility.HomeClick = 1;
                Utility.EmailClick = 0;
                Utility.DatabaseClick = 0;
            }
        }

        private void Core_Load(object sender, EventArgs e)
        {
            ControlPanel.Controls.Clear();
            Dashboard _formPreview = new Dashboard();
            _formPreview.TopLevel = false;
            ControlPanel.Controls.Add(_formPreview);
            _formPreview.Dock = DockStyle.Fill;
            _formPreview.Show();
            if (Utility.Atlas_Function == 0)
            {
                Atlas();
                Utility.Atlas_Function = 1;
            }
            if (Utility.Juno_Function == 0)
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
            if (Utility.EmailClick == 0)
            {
                ControlPanel.Controls.Clear();
                MailServer _formPreview = new MailServer();
                _formPreview.TopLevel = false;
                ControlPanel.Controls.Add(_formPreview);
                _formPreview.Dock = DockStyle.Fill;
                _formPreview.Show();
                Utility.PerformanceClick = 0;
                Utility.EmailClick = 1;
                Utility.HomeClick = 0;
                Utility.DatabaseClick = 0;
            }
        }

        private void DatabaseButton_Click(object sender, EventArgs e)
        {
            if (Utility.DatabaseClick == 0)
            {
                ControlPanel.Controls.Clear();
                DatabaseServer _formPreview = new DatabaseServer();
                _formPreview.TopLevel = false;
                ControlPanel.Controls.Add(_formPreview);
                _formPreview.Dock = DockStyle.Fill;
                _formPreview.Show();
                Utility.PerformanceClick = 0;
                Utility.DatabaseClick = 1;
                Utility.HomeClick = 0;
                Utility.EmailClick = 0;
            }
        }
    }
}