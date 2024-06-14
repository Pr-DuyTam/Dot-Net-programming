using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btxChuvi_Click(object sender, EventArgs e)
        {
            int t;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox1.Text);
            t = (a + b) * 2;
            MessageBox.Show(t.ToString(), "CHU VI");
        }

        private void btxDientich_Click(object sender, EventArgs e)
        {
            int t;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox1.Text);
            t= a * b;
            MessageBox.Show(t.ToString(), "Dien tich");
        }

        private void btxDuongcheo_Click(object sender, EventArgs e)
        {
            int t;
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox1.Text);
            t = a * a + b * b;
            MessageBox.Show(t.ToString(), "Duong cheo");
        }

        private void btxThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
