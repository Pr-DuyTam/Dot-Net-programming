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
    public partial class FrmBai2_7 : Form
    {
        public FrmBai2_7()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tong = a + b;
            MessageBox.Show(tong.ToString());
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int hieu = a - b;
            MessageBox.Show(hieu.ToString());
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tich = a * b;

            MessageBox.Show(tich.ToString());
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
           
            int thuong = a / b;
           
            MessageBox.Show(thuong.ToString());
        }

        private void FrmBai2_7_Load(object sender, EventArgs e)
        {

        }
    }
}
