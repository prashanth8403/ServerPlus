namespace ServerPlus
{
    partial class MailServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailServer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MailProcessed = new System.Windows.Forms.Label();
            this.MailQueue = new System.Windows.Forms.Label();
            this.MailFailed = new System.Windows.Forms.Label();
            this.RequestCalculation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListenLabel = new System.Windows.Forms.Label();
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
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAIL SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(146, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Processed Requests:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(496, 603);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pending Requests:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(807, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Failed Requests:";
            // 
            // MailProcessed
            // 
            this.MailProcessed.AutoSize = true;
            this.MailProcessed.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailProcessed.ForeColor = System.Drawing.Color.ForestGreen;
            this.MailProcessed.Location = new System.Drawing.Point(201, 646);
            this.MailProcessed.Name = "MailProcessed";
            this.MailProcessed.Size = new System.Drawing.Size(84, 96);
            this.MailProcessed.TabIndex = 5;
            this.MailProcessed.Text = "0";
            // 
            // MailQueue
            // 
            this.MailQueue.AutoSize = true;
            this.MailQueue.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailQueue.ForeColor = System.Drawing.Color.BlueViolet;
            this.MailQueue.Location = new System.Drawing.Point(551, 646);
            this.MailQueue.Name = "MailQueue";
            this.MailQueue.Size = new System.Drawing.Size(84, 96);
            this.MailQueue.TabIndex = 6;
            this.MailQueue.Text = "0";
            // 
            // MailFailed
            // 
            this.MailFailed.AutoSize = true;
            this.MailFailed.Font = new System.Drawing.Font("Roboto Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailFailed.ForeColor = System.Drawing.Color.Red;
            this.MailFailed.Location = new System.Drawing.Point(849, 646);
            this.MailFailed.Name = "MailFailed";
            this.MailFailed.Size = new System.Drawing.Size(84, 96);
            this.MailFailed.TabIndex = 7;
            this.MailFailed.Text = "0";
            // 
            // RequestCalculation
            // 
            this.RequestCalculation.Interval = 1000;
            this.RequestCalculation.Tick += new System.EventHandler(this.RequestCalculation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 445);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ListenLabel
            // 
            this.ListenLabel.AutoSize = true;
            this.ListenLabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ListenLabel.Location = new System.Drawing.Point(496, 468);
            this.ListenLabel.Name = "ListenLabel";
            this.ListenLabel.Size = new System.Drawing.Size(121, 29);
            this.ListenLabel.TabIndex = 9;
            this.ListenLabel.Text = "Listening";
            this.ListenLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MailServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.ListenLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MailFailed);
            this.Controls.Add(this.MailQueue);
            this.Controls.Add(this.MailProcessed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MailServer";
            this.Text = "MailServer";
            this.Load += new System.EventHandler(this.MailServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label MailProcessed;
        private System.Windows.Forms.Label MailQueue;
        private System.Windows.Forms.Label MailFailed;
        private System.Windows.Forms.Timer RequestCalculation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ListenLabel;
    }
}