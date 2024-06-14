using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8_Bai8._1
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtN.ResetText();
            txtN.Focus();

        }

        private void btnTaomang_Click(object sender, EventArgs e)
        {
            FrmTm frm = new FrmTm(Convert.ToInt32(txtN.Text));
            frm.Show();
            btnLamlai.Enabled = true;
        }

        private void btnKTCL_Click(object sender, EventArgs e)
        {
            Frmktcl frm = new Frmktcl(Convert.ToInt32(txtN.Text));
            frm.Show();
            btnLamlai.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLamlai.Enabled = false;
        }
    }
}
