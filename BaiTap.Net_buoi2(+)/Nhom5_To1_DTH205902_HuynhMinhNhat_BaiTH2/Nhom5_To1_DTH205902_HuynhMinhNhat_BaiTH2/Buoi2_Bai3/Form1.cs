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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txtx.Text);
            float f = 0;

            if( x>=2)
            {
                f = -8 * x *x *x - 12 * x - 1;
            }
            else if(1 < x && x < 2)
            {
                f = x * x - 6 * x - 19;
            }
            else
            {
                f = 7 * x;
            }
            txtf.Text = f.ToString();
        }
    }
}
