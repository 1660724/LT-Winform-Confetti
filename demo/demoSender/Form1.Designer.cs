namespace demoSender
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.axVideoChatServer1 = new AxVideoChatServerLib.AxVideoChatServer();
            this.btnConnectVideo = new System.Windows.Forms.Button();
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.btnBroadcast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(12, 12);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(299, 203);
            this.axVideoChatSender1.TabIndex = 0;
            // 
            // axVideoChatServer1
            // 
            this.axVideoChatServer1.Enabled = true;
            this.axVideoChatServer1.Location = new System.Drawing.Point(24, 1);
            this.axVideoChatServer1.Name = "axVideoChatServer1";
            this.axVideoChatServer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatServer1.OcxState")));
            this.axVideoChatServer1.Size = new System.Drawing.Size(10, 10);
            this.axVideoChatServer1.TabIndex = 1;
            // 
            // btnConnectVideo
            // 
            this.btnConnectVideo.Location = new System.Drawing.Point(102, 221);
            this.btnConnectVideo.Name = "btnConnectVideo";
            this.btnConnectVideo.Size = new System.Drawing.Size(119, 23);
            this.btnConnectVideo.TabIndex = 2;
            this.btnConnectVideo.Text = "Connect Video";
            this.btnConnectVideo.UseVisualStyleBackColor = true;
            this.btnConnectVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Location = new System.Drawing.Point(12, 221);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(84, 23);
            this.btnConnectServer.TabIndex = 3;
            this.btnConnectServer.Text = "Connect ";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // btnBroadcast
            // 
            this.btnBroadcast.Location = new System.Drawing.Point(227, 221);
            this.btnBroadcast.Name = "btnBroadcast";
            this.btnBroadcast.Size = new System.Drawing.Size(84, 23);
            this.btnBroadcast.TabIndex = 4;
            this.btnBroadcast.Text = "Broadcast";
            this.btnBroadcast.UseVisualStyleBackColor = true;
            this.btnBroadcast.Click += new System.EventHandler(this.btnBroadcast_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 254);
            this.Controls.Add(this.btnBroadcast);
            this.Controls.Add(this.btnConnectServer);
            this.Controls.Add(this.btnConnectVideo);
            this.Controls.Add(this.axVideoChatServer1);
            this.Controls.Add(this.axVideoChatSender1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Host Video Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatServer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
        private AxVideoChatServerLib.AxVideoChatServer axVideoChatServer1;
        private System.Windows.Forms.Button btnConnectVideo;
        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.Button btnBroadcast;
    }
}

