using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8_1
{
    public partial class FrmTm : Form
    {
        public FrmTm()
        {
            InitializeComponent();
        }

        private void FrmTm_Load(object sender, EventArgs e)
        {
            int DemChan = 0;
            int DemLe = 0;

            int[] m = new int[n];
            Random rnd = new Random();
            for(int i = 0; i<n;i++)
            {
                m[i] = rnd.Next(1, 9);
            }
            lblMang.Text = sxMang(m, n);

            for(int i = 0; i < n; i++)
            {
                if ((m[i] % 2) == 0)
                    DemChan++;
                else
                    DemLe++;
            }
            label2.Text = "Mảng có" + DemChan.ToString() + "Số chẵn";
            Label3.Text = "Mảng có" + DemLe.ToString() + "Số lẻ";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKTCL_Click(object sender, EventArgs e)
        {
            Frmktcl frm = new Frmktcl(Convert.ToInt32(txtN.Text))
            frm.Show();
            btnLamlai.Enabled = true;
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtN.ResetText();
            txtN.Focus();
        }
    }
}
