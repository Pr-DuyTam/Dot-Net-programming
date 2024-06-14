using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi2_Bai2
{
    public partial class FrmBai2_10 : Form
    {
        public FrmBai2_10()
        {
            InitializeComponent();
        }

        private void FrmBai2_10_Load(object sender, EventArgs e)
        {

        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float chuvi = (a + b) * 2;

            txtKetqua.Text = chuvi.ToString();
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float dientich = a * b;

            txtKetqua.Text = dientich.ToString();
        }

        private void btnDuongcheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double c = (Math.Pow(a, a) + Math.Pow(b, b));
            double duongcheo = Math.Sqrt(c);

            txtKetqua.Text = duongcheo.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
