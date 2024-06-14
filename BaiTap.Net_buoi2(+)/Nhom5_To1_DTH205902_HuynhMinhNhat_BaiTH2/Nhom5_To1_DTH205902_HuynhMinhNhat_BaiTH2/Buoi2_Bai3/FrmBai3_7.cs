using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi2_Bai3
{
    public partial class FrmBai3_7 : Form
    {
        public FrmBai3_7()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txta.Text);
            float b = float.Parse(txtb.Text);
            float c = float.Parse(txtc.Text);
            double Delta = b * b - 4 * a * c;
            float x1, x2;
            string kq = "";
            if (a == 0)
                MessageBox.Show("a khac 0, vui long nhap lai!");
            else if (Delta < 0)
                kq = "Phuong trinh vo nghiem";
            else if (Delta == 0)
                kq = string.Format("Phuong trinh co 2 nghiem kep x1 = x2 = {0}", -(b / (2 * a)));
            else
            {
                x1 = (float)((-b + Math.Sqrt(Delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(Delta)) / (2 * a));

                kq = string.Format("Phuong trinh co 2 nghiem x1 = {0} , x2 = {1}", x1, x2);
            }
            txtKetqua.Text = kq;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
