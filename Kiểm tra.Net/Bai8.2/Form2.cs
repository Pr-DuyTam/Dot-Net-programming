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
    public partial class frmTimkiem : Form
    {
        int k, x, dem;
        public int[] b = new int[100];
        public frmTimkiem(int [] temp, int spt_temp)
        {
            InitializeComponent();
            b = temp;
            k = spt_temp;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(txtX.Text);
                dem = 0;
            for (int i = 0; i < k; i++)
                if (b[i] == x)
                    dem  = dem + 1;
            lblX.Text = x + " xuất hiện " + dem + " lần trong mảng";
        }

        private void btnDong2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTimkiem_Load(object sender, EventArgs e)
        {

        }
    }
}
