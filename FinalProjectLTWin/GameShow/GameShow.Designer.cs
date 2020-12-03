namespace GameShow
{
    partial class GameShow
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
            this.btnConnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.lbCountDown = new Telerik.WinControls.UI.RadLabel();
            this.btnDisconnect = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblQuestion = new System.Windows.Forms.RichTextBox();
            this.btnA = new Telerik.WinControls.UI.RadButton();
            this.btnB = new Telerik.WinControls.UI.RadButton();
            this.btnC = new Telerik.WinControls.UI.RadButton();
            this.btnD = new Telerik.WinControls.UI.RadButton();
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.lbPoint = new System.Windows.Forms.Label();
            this.txbChat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.lbCorrectAnswer = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lsbChat = new System.Windows.Forms.ListBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.btnOpenStream = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbCountDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenStream)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.Depth = 0;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConnect.Location = new System.Drawing.Point(30, 15);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Primary = false;
            this.btnConnect.Size = new System.Drawing.Size(75, 36);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbCountDown
            // 
            this.lbCountDown.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbCountDown.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.Red;
            this.lbCountDown.Location = new System.Drawing.Point(434, 18);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(36, 26);
            this.lbCountDown.TabIndex = 10;
            this.lbCountDown.Text = "10";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSize = true;
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.Depth = 0;
            this.btnDisconnect.Location = new System.Drawing.Point(113, 15);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDisconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Primary = false;
            this.btnDisconnect.Size = new System.Drawing.Size(96, 36);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblQuestion.Enabled = false;
            this.lblQuestion.Font = new System.Drawing.Font("Papyrus", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(17, 104);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(453, 127);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "Question here";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(17, 237);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(213, 33);
            this.btnA.TabIndex = 12;
            this.btnA.Text = "btnA";
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(244, 237);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(226, 33);
            this.btnB.TabIndex = 13;
            this.btnB.Text = "btnB";
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(17, 276);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(213, 32);
            this.btnC.TabIndex = 13;
            this.btnC.Text = "btnC";
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(244, 276);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(226, 32);
            this.btnD.TabIndex = 13;
            this.btnD.Text = "btnD";
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name!";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.BackColor = System.Drawing.Color.Goldenrod;
            this.lbPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbPoint.Location = new System.Drawing.Point(109, 60);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(65, 20);
            this.lbPoint.TabIndex = 16;
            this.lbPoint.Text = "Correct:";
            // 
            // txbChat
            // 
            this.txbChat.BackColor = System.Drawing.Color.LavenderBlush;
            this.txbChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbChat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txbChat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbChat.HintForeColor = System.Drawing.Color.Empty;
            this.txbChat.HintText = "";
            this.txbChat.isPassword = false;
            this.txbChat.LineFocusedColor = System.Drawing.Color.Black;
            this.txbChat.LineIdleColor = System.Drawing.Color.Black;
            this.txbChat.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txbChat.LineThickness = 4;
            this.txbChat.Location = new System.Drawing.Point(476, 259);
            this.txbChat.Margin = new System.Windows.Forms.Padding(6);
            this.txbChat.Name = "txbChat";
            this.txbChat.Size = new System.Drawing.Size(243, 51);
            this.txbChat.TabIndex = 19;
            this.txbChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSendChat
            // 
            this.btnSendChat.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendChat.Location = new System.Drawing.Point(728, 256);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(76, 54);
            this.btnSendChat.TabIndex = 20;
            this.btnSendChat.Text = "Send";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // lbCorrectAnswer
            // 
            this.lbCorrectAnswer.AutoSize = true;
            this.lbCorrectAnswer.BackColor = System.Drawing.Color.Yellow;
            this.lbCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCorrectAnswer.Location = new System.Drawing.Point(235, 60);
            this.lbCorrectAnswer.Name = "lbCorrectAnswer";
            this.lbCorrectAnswer.Size = new System.Drawing.Size(156, 20);
            this.lbCorrectAnswer.TabIndex = 21;
            this.lbCorrectAnswer.Text = "Correct answer:none";
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.radLabel1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.ForeColor = System.Drawing.Color.White;
            this.radLabel1.Location = new System.Drawing.Point(299, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(140, 26);
            this.radLabel1.TabIndex = 11;
            this.radLabel1.Text = "Time left:";
            // 
            // lsbChat
            // 
            this.lsbChat.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lsbChat.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbChat.FormattingEnabled = true;
            this.lsbChat.ItemHeight = 18;
            this.lsbChat.Location = new System.Drawing.Point(476, 48);
            this.lsbChat.Name = "lsbChat";
            this.lsbChat.Size = new System.Drawing.Size(328, 202);
            this.lsbChat.TabIndex = 22;
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.Fuchsia;
            this.radLabel2.Location = new System.Drawing.Point(30, 60);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(29, 18);
            this.radLabel2.TabIndex = 23;
            this.radLabel2.Text = "0/10";
            // 
            // btnOpenStream
            // 
            this.btnOpenStream.BackColor = System.Drawing.Color.Turquoise;
            this.btnOpenStream.Location = new System.Drawing.Point(694, 23);
            this.btnOpenStream.Name = "btnOpenStream";
            this.btnOpenStream.Size = new System.Drawing.Size(110, 24);
            this.btnOpenStream.TabIndex = 24;
            this.btnOpenStream.Text = "Open Stream";
            this.btnOpenStream.Click += new System.EventHandler(this.btnOpenStream_Click);
            // 
            // GameShow
            // 
            this.AcceptButton = this.btnSendChat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::GameShow.Properties.Resources.universe;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 327);
            this.Controls.Add(this.btnOpenStream);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lsbChat);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lbCorrectAnswer);
            this.Controls.Add(this.btnSendChat);
            this.Controls.Add(this.txbChat);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lbCountDown);
            this.Controls.Add(this.btnConnect);
            this.Name = "GameShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player";
            this.Load += new System.EventHandler(this.GameShow_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.lbCountDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenStream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnConnect;
        private Telerik.WinControls.UI.RadLabel lbCountDown;
        private MaterialSkin.Controls.MaterialFlatButton btnDisconnect;
        private System.Windows.Forms.RichTextBox lblQuestion;
        private Telerik.WinControls.UI.RadButton btnA;
        private Telerik.WinControls.UI.RadButton btnB;
        private Telerik.WinControls.UI.RadButton btnC;
        private Telerik.WinControls.UI.RadButton btnD;
        private Telerik.WinControls.UI.RadLabel label1;
        private System.Windows.Forms.Label lbPoint;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txbChat;
        private System.Windows.Forms.Button btnSendChat;
        private Bunifu.Framework.UI.BunifuCustomLabel lbCorrectAnswer;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private System.Windows.Forms.ListBox lsbChat;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton btnOpenStream;
    }
}