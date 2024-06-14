using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi2_Bai3
{
    public partial class FrmBai3_2 : Form
    {
        public FrmBai3_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int thang = Int32.Parse(txtThang.Text);

            if(thang == 1 || thang == 2 || thang == 3)
            {
                MessageBox.Show("Mua Xuan");
            }
            else if (thang == 4 || thang == 5 || thang == 6)
            {
                MessageBox.Show("Mua Ha");
            }
            else if (thang == 7 || thang == 8 || thang == 9)
            {
                MessageBox.Show("Mua Thu");
            }
            else if (thang == 10 || thang == 11 || thang == 12)
            {
                MessageBox.Show("Mua Dong");
            }
            else
            {
                MessageBox.Show("Mot nam co 12 thang ban a. Vui long nhap lai !");
            }
        }
    }
}
