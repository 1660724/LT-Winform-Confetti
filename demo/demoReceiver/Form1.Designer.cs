namespace demoReceiver
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
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.btnConnectVideo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnReceiveStream = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(12, 27);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(292, 228);
            this.axVideoChatReceiver1.TabIndex = 0;
            // 
            // btnConnectVideo
            // 
            this.btnConnectVideo.Location = new System.Drawing.Point(103, 261);
            this.btnConnectVideo.Name = "btnConnectVideo";
            this.btnConnectVideo.Size = new System.Drawing.Size(102, 23);
            this.btnConnectVideo.TabIndex = 1;
            this.btnConnectVideo.Text = "Connect Video";
            this.btnConnectVideo.UseVisualStyleBackColor = true;
            this.btnConnectVideo.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 261);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(85, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnReceiveStream
            // 
            this.btnReceiveStream.Location = new System.Drawing.Point(211, 261);
            this.btnReceiveStream.Name = "btnReceiveStream";
            this.btnReceiveStream.Size = new System.Drawing.Size(93, 23);
            this.btnReceiveStream.TabIndex = 4;
            this.btnReceiveStream.Text = "Receive Stream";
            this.btnReceiveStream.UseVisualStyleBackColor = true;
            this.btnReceiveStream.Click += new System.EventHandler(this.btnReceiveStream_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 289);
            this.Controls.Add(this.btnReceiveStream);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnectVideo);
            this.Controls.Add(this.axVideoChatReceiver1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Receive Stream";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private System.Windows.Forms.Button btnConnectVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnReceiveStream;
    }
}

