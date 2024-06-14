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
    public partial class FrmBai2_6 : Form
    {
        public FrmBai2_6()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tong = a + b;
            MessageBox.Show(tong.ToString());
        }

        private void FrmBai2_6_Load(object sender, EventArgs e)
        {

        }
    }
}
