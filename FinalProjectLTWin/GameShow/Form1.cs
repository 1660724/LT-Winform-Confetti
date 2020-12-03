using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if (txbName.Text==String.Empty)
            {
                MessageBox.Show("Please enter your name to play !", "Insert name !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {                
                GameShow frmPlayer = new GameShow();
                frmPlayer.PlayerName = txbName.Text;                
                this.Hide();
                frmPlayer.Closed += (s, args) => this.Close();
                frmPlayer.ShowDialog();

            }
        }
    }
}
