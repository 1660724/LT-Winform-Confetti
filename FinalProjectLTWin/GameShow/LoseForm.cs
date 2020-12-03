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
    public partial class LoseForm : Form
    {
        string songuoichoi;
        string songuoithang;
        string name;
        public string tennguoichoi
        {
            get { return name; }
            set { name = value; }
        }
        public string nguoichoi
        {
            get { return songuoichoi; }
            set { songuoichoi = value; }
        }
        public string nguoithang
        {
            get { return songuoithang; }
            set { songuoithang = value; }
        }
        public LoseForm()
        {
            InitializeComponent();
        }
        


        private void LoseForm_Load(object sender, EventArgs e)
        {
            lbSoNguoiChoi.Text = songuoichoi.ToString() + "PLAYERS";
            lbSoNguoiThang.Text = songuoithang.ToString() + "WINNERS";
            lbName.Text = name.ToString() + "!";
        }
    }
}
