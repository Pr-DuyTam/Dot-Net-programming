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
    public partial class Bai2_5 : Form
    {
        public Bai2_5()
        {
            InitializeComponent();
        }

        private void KQ0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao "+txtHoTen.Text);
        }
    }
}
