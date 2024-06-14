using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi2_bai1
{
    public partial class Bai2_6 : Form
    {
        public Bai2_6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show(s.ToString(), "Thong bao");
        }

        private void Bai2_6_Load(object sender, EventArgs e)
        {

        }
    }
}
