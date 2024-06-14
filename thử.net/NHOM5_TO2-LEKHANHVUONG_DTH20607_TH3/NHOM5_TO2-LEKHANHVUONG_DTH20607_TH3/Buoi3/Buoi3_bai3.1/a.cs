using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai3._1
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chọn website ";
            this.txtKQ.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
