namespace ServerPlus
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PacketSent = new System.Windows.Forms.Label();
            this.NetworkInterface = new System.Windows.Forms.Timer(this.components);
            this.NetworkDevice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.NetworkAdapter = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PacketReceived = new System.Windows.Forms.Label();
            this.MemoryProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.CPUProgress = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(237, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 507);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(447, 476);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "SERVER:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(578, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "RUNNING";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(607, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Network Device:";
            // 
            // PacketSent
            // 
            this.PacketSent.AutoSize = true;
            this.PacketSent.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketSent.ForeColor = System.Drawing.Color.White;
            this.PacketSent.Location = new System.Drawing.Point(787, 659);
            this.PacketSent.Name = "PacketSent";
            this.PacketSent.Size = new System.Drawing.Size(82, 51);
            this.PacketSent.TabIndex = 14;
            this.PacketSent.Text = "0.0";
            // 
            // NetworkInterface
            // 
            this.NetworkInterface.Interval = 1000;
            this.NetworkInterface.Tick += new System.EventHandler(this.NetworkInterface_Tick);
            // 
            // NetworkDevice
            // 
            this.NetworkDevice.AutoSize = true;
            this.NetworkDevice.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkDevice.ForeColor = System.Drawing.Color.Orange;
            this.NetworkDevice.Location = new System.Drawing.Point(792, 581);
            this.NetworkDevice.Name = "NetworkDevice";
            this.NetworkDevice.Size = new System.Drawing.Size(156, 24);
            this.NetworkDevice.TabIndex = 16;
            this.NetworkDevice.Text = "<NetworkName>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(684, 607);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Adapter:";
            // 
            // NetworkAdapter
            // 
            this.NetworkAdapter.AutoSize = true;
            this.NetworkAdapter.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NetworkAdapter.ForeColor = System.Drawing.Color.Orange;
            this.NetworkAdapter.Location = new System.Drawing.Point(792, 610);
            this.NetworkAdapter.Name = "NetworkAdapter";
            this.NetworkAdapter.Size = new System.Drawing.Size(98, 24);
            this.NetworkAdapter.TabIndex = 18;
            this.NetworkAdapter.Text = "<Adapter>";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DimGray;
            this.label14.Location = new System.Drawing.Point(690, 640);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 29);
            this.label14.TabIndex = 19;
            this.label14.Text = "Packets:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(724, 677);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Sent";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DimGray;
            this.label16.Location = new System.Drawing.Point(684, 729);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 29);
            this.label16.TabIndex = 21;
            this.label16.Text = "Received";
            // 
            // PacketReceived
            // 
            this.PacketReceived.AutoSize = true;
            this.PacketReceived.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacketReceived.ForeColor = System.Drawing.Color.White;
            this.PacketReceived.Location = new System.Drawing.Point(787, 720);
            this.PacketReceived.Name = "PacketReceived";
            this.PacketReceived.Size = new System.Drawing.Size(82, 51);
            this.PacketReceived.TabIndex = 22;
            this.PacketReceived.Text = "0.0";
            // 
            // MemoryProgress
            // 
            this.MemoryProgress.animated = false;
            this.MemoryProgress.animationIterval = 5;
            this.MemoryProgress.animationSpeed = 300;
            this.MemoryProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.MemoryProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MemoryProgress.BackgroundImage")));
            this.MemoryProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F);
            this.MemoryProgress.ForeColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.LabelVisible = true;
            this.MemoryProgress.LineProgressThickness = 10;
            this.MemoryProgress.LineThickness = 1;
            this.MemoryProgress.Location = new System.Drawing.Point(407, 610);
            this.MemoryProgress.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MemoryProgress.MaxValue = 100;
            this.MemoryProgress.Name = "MemoryProgress";
            this.MemoryProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MemoryProgress.ProgressColor = System.Drawing.Color.DeepPink;
            this.MemoryProgress.Size = new System.Drawing.Size(115, 115);
            this.MemoryProgress.TabIndex = 25;
            this.MemoryProgress.Value = 100;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(306, 610);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 116);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 26;
            this.pictureBox3.TabStop = false;
            // 
            // CPUProgress
            // 
            this.CPUProgress.animated = false;
            this.CPUProgress.animationIterval = 5;
            this.CPUProgress.animationSpeed = 300;
            this.CPUProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.CPUProgress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CPUProgress.BackgroundImage")));
            this.CPUProgress.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUProgress.ForeColor = System.Drawing.Color.Yellow;
            this.CPUProgress.LabelVisible = true;
            this.CPUProgress.LineProgressThickness = 10;
            this.CPUProgress.LineThickness = 1;
            this.CPUProgress.Location = new System.Drawing.Point(130, 610);
            this.CPUProgress.Margin = new System.Windows.Forms.Padding(10);
            this.CPUProgress.MaxValue = 100;
            this.CPUProgress.Name = "CPUProgress";
            this.CPUProgress.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CPUProgress.ProgressColor = System.Drawing.Color.Yellow;
            this.CPUProgress.Size = new System.Drawing.Size(115, 115);
            this.CPUProgress.TabIndex = 24;
            this.CPUProgress.Value = 100;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 610);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.MemoryProgress);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.CPUProgress);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PacketReceived);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NetworkAdapter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NetworkDevice);
            this.Controls.Add(this.PacketSent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PacketSent;
        private System.Windows.Forms.Timer NetworkInterface;
        private System.Windows.Forms.Label NetworkDevice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label NetworkAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label PacketReceived;
        private Bunifu.Framework.UI.BunifuCircleProgressbar MemoryProgress;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CPUProgress;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}