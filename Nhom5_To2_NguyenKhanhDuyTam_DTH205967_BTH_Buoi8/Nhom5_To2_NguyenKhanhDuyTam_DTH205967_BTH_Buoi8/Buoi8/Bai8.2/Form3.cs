using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8._2
{
    public partial class frmTongMang : Form
    {
        int k,tong;
        float tbc;
        public int[] b = new int[100];
        public frmTongMang(int [] temp, int spt_temp)
        {
            InitializeComponent();
            b = temp;
            k = spt_temp;
        }

        private void frmTongMang_Load(object sender, EventArgs e)
        {
            tong = 0;
            for (int i = 0; i < k; i++)
                tong = tong + b[i];
            txtTong.Text = tong.ToString();
            tbc = (float)tong / (k);
            txtTBC.Text = tbc.ToString();
        }

        private void btnDong3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
