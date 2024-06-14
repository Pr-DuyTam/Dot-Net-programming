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
    public partial class FrmBai2_8 : Form
    {
        public FrmBai2_8()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txta.Text);
            int b = Int32.Parse(txtb.Text);
            int tong = a + b;

            txtKetqua.Text = tong.ToString();
           
        }

        private void FrmBai2_8_Load(object sender, EventArgs e)
        {

        }
    }
}
