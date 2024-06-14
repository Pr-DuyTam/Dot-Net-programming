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
    public partial class FrmBai2_9 : Form
    {
        public FrmBai2_9()
        {
            InitializeComponent();
        }

        private void FrmBai2_9_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tong = a + b;

            txtKetqua.Text = tong.ToString();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int hieu = a - b;

            txtKetqua.Text = hieu.ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tich = a * b;

            txtKetqua.Text = tich.ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int thuong = a / b;

            txtKetqua.Text = thuong.ToString();
        }
    }
}
