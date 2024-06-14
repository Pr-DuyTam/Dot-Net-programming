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
    public partial class FrmBai2_11 : Form
    {
        public FrmBai2_11()
        {
            InitializeComponent();
        }

        private void btnChuvi_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float chuvi = (a + b) * 2;

            MessageBox.Show("Chu vi : " + chuvi.ToString());
        }

        private void btnDientich_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float dientich = a * b;

            MessageBox.Show("Dien tich : " + dientich.ToString());
        }

        private void btnDuongcheo_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txta.Text);
            double b = double.Parse(txtb.Text);

            double c = (Math.Pow(a, a) + Math.Pow(b, b));
            double duongcheo = Math.Sqrt(c);

            MessageBox.Show("Duong cheo : " + duongcheo.ToString());
        }

        private void FrmBai2_11_Load(object sender, EventArgs e)
        {

        }
    }
}
