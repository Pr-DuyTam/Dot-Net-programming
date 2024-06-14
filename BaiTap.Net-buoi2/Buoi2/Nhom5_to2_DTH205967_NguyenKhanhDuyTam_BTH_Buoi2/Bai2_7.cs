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
    public partial class Bai2_7 : Form
    {
        public Bai2_7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
            MessageBox.Show(s.ToString(), "Thong bao");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
            MessageBox.Show(s.ToString(), "Thong bao");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
            MessageBox.Show(s.ToString(), "Thong bao");
        }

        private void Bai2_7_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s;
            s = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
            MessageBox.Show(s.ToString(), "Thong bao");
        }
    }
}
