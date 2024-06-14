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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThuchien_Click(object sender, EventArgs e)
        {
            int[] a = new int[100];
            string s, s1;
            int n = 0;
            int i, spt;
            s = txtNhapMang.Text;
            s = s.Trim();
            i = s.LastIndexOf(" ");
            while (i != -1)
            {
                s1 = s.Substring(i + 1);
                s = s.Substring(0, i);
                a[n] = Convert.ToInt32(s1);
                n++;
                i = s.LastIndexOf(" ");
            }
            a[n] = Convert.ToInt32(s);
            spt = n + 1;
            if (rad1.Checked == true) 
            {
                frmTimkiem frm = new frmTimkiem(a, spt);
                frm.ShowDialog();
            }
            if (rad2.Checked == true)
            {
                frmTongMang frm1 = new frmTongMang(a, spt);
                frm1.ShowDialog();
            }

        }


        private void btnLamlai_Click(object sender, EventArgs e)
        {
            txtNhapMang.ResetText();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            btnThuchien.Enabled = true;
            btnLamlai.Enabled = true;
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            btnThuchien.Enabled = true;
            btnLamlai.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad1.Checked = false;
            txtNhapMang.Enabled = true;
            btnThoat.Enabled = true;
            btnThuchien.Enabled = false;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rad1.Checked = false;
            txtNhapMang.Enabled = true;
            btnThoat.Enabled = true;
            btnThuchien.Enabled = false;
        }
    }
}
