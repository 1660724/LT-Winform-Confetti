﻿namespace GameShow
{
    partial class LoseForm
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lbSoNguoiThang = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.lbSoNguoiChoi = new Telerik.WinControls.UI.RadLabel();
            this.lbName = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoNguoiThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoNguoiChoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbName)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.BackColor = System.Drawing.Color.White;
            this.radLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radLabel1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(29, 216);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(512, 45);
            this.radLabel1.TabIndex = 19;
            this.radLabel1.Text = "BETTER LUCK NEXT TIME";
            // 
            // lbSoNguoiThang
            // 
            this.lbSoNguoiThang.BackColor = System.Drawing.Color.White;
            this.lbSoNguoiThang.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoNguoiThang.ForeColor = System.Drawing.Color.Crimson;
            this.lbSoNguoiThang.Location = new System.Drawing.Point(357, 57);
            this.lbSoNguoiThang.Name = "lbSoNguoiThang";
            this.lbSoNguoiThang.Size = new System.Drawing.Size(56, 53);
            this.lbSoNguoiThang.TabIndex = 16;
            this.lbSoNguoiThang.Text = "10";
            // 
            // radLabel3
            // 
            this.radLabel3.BackColor = System.Drawing.Color.White;
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLabel3.ForeColor = System.Drawing.Color.Red;
            this.radLabel3.Location = new System.Drawing.Point(292, 14);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(118, 53);
            this.radLabel3.TabIndex = 18;
            this.radLabel3.Text = "3000$";
            // 
            // radLabel2
            // 
            this.radLabel2.BackColor = System.Drawing.Color.White;
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.radLabel2.Location = new System.Drawing.Point(153, 26);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(150, 37);
            this.radLabel2.TabIndex = 17;
            this.radLabel2.Text = "THE PRICE IS";
            // 
            // lbSoNguoiChoi
            // 
            this.lbSoNguoiChoi.BackColor = System.Drawing.Color.White;
            this.lbSoNguoiChoi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoNguoiChoi.ForeColor = System.Drawing.Color.Blue;
            this.lbSoNguoiChoi.Location = new System.Drawing.Point(131, 73);
            this.lbSoNguoiChoi.Name = "lbSoNguoiChoi";
            this.lbSoNguoiChoi.Size = new System.Drawing.Size(117, 37);
            this.lbSoNguoiChoi.TabIndex = 15;
            this.lbSoNguoiChoi.Text = "radLabel2";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(256, 264);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(60, 31);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name";
            // 
            // LoseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameShow.Properties.Resources.GOODL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(571, 307);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.lbSoNguoiThang);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.lbSoNguoiChoi);
            this.Name = "LoseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoseForm";
            this.Load += new System.EventHandler(this.LoseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoNguoiThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbSoNguoiChoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel lbSoNguoiThang;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel lbSoNguoiChoi;
        private Telerik.WinControls.UI.RadLabel lbName;
    }
}