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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.atlas = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.minevra = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.juno = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.meridi = new Bunifu.Framework.UI.BunifuCircleProgressbar();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(85, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "ATLAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(333, 624);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "JUNO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(320, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "MERIDI";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(54, 710);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "MINEVRA";
            // 
            // atlas
            // 
            this.atlas.animated = true;
            this.atlas.animationIterval = 10;
            this.atlas.animationSpeed = 25;
            this.atlas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.atlas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("atlas.BackgroundImage")));
            this.atlas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atlas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.atlas.LabelVisible = true;
            this.atlas.LineProgressThickness = 8;
            this.atlas.LineThickness = 8;
            this.atlas.Location = new System.Drawing.Point(175, 599);
            this.atlas.MaxValue = 100;
            this.atlas.Name = "atlas";
            this.atlas.ProgressBackColor = System.Drawing.Color.Transparent;
            this.atlas.ProgressColor = System.Drawing.Color.Crimson;
            this.atlas.Size = new System.Drawing.Size(60, 60);
            this.atlas.TabIndex = 9;
            this.atlas.Value = 85;
            // 
            // minevra
            // 
            this.minevra.animated = true;
            this.minevra.animationIterval = 10;
            this.minevra.animationSpeed = 17;
            this.minevra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.minevra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minevra.BackgroundImage")));
            this.minevra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minevra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.minevra.LabelVisible = true;
            this.minevra.LineProgressThickness = 8;
            this.minevra.LineThickness = 8;
            this.minevra.Location = new System.Drawing.Point(177, 683);
            this.minevra.MaxValue = 100;
            this.minevra.Name = "minevra";
            this.minevra.ProgressBackColor = System.Drawing.Color.Transparent;
            this.minevra.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.minevra.Size = new System.Drawing.Size(60, 60);
            this.minevra.TabIndex = 10;
            this.minevra.Value = 85;
            // 
            // juno
            // 
            this.juno.animated = true;
            this.juno.animationIterval = 10;
            this.juno.animationSpeed = 15;
            this.juno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.juno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("juno.BackgroundImage")));
            this.juno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.juno.LabelVisible = true;
            this.juno.LineProgressThickness = 8;
            this.juno.LineThickness = 8;
            this.juno.Location = new System.Drawing.Point(435, 599);
            this.juno.MaxValue = 100;
            this.juno.Name = "juno";
            this.juno.ProgressBackColor = System.Drawing.Color.Transparent;
            this.juno.ProgressColor = System.Drawing.Color.OrangeRed;
            this.juno.Size = new System.Drawing.Size(60, 60);
            this.juno.TabIndex = 11;
            this.juno.Value = 85;
            // 
            // meridi
            // 
            this.meridi.animated = true;
            this.meridi.animationIterval = 10;
            this.meridi.animationSpeed = 18;
            this.meridi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.meridi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("meridi.BackgroundImage")));
            this.meridi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meridi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.meridi.LabelVisible = true;
            this.meridi.LineProgressThickness = 8;
            this.meridi.LineThickness = 8;
            this.meridi.Location = new System.Drawing.Point(435, 683);
            this.meridi.MaxValue = 100;
            this.meridi.Name = "meridi";
            this.meridi.ProgressBackColor = System.Drawing.Color.Transparent;
            this.meridi.ProgressColor = System.Drawing.Color.DeepPink;
            this.meridi.Size = new System.Drawing.Size(60, 60);
            this.meridi.TabIndex = 12;
            this.meridi.Value = 85;
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
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.PacketReceived);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.NetworkAdapter);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.NetworkDevice);
            this.Controls.Add(this.PacketSent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.meridi);
            this.Controls.Add(this.juno);
            this.Controls.Add(this.minevra);
            this.Controls.Add(this.atlas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCircleProgressbar atlas;
        private Bunifu.Framework.UI.BunifuCircleProgressbar minevra;
        private Bunifu.Framework.UI.BunifuCircleProgressbar juno;
        private Bunifu.Framework.UI.BunifuCircleProgressbar meridi;
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
    }
}