using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._1_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(txtValue_X.Text);

            if (x >= 2)
            {
                int result = -8 * x ^ 3 - 12 * x - 1;
                txtResult.Text = result.ToString();
            }
            else if (x > 1 && x < 2)
            {
                int result = x ^ 2 - 6 * x - 19;
                txtResult.Text = result.ToString();
            }
            else
            {
                int result = 7 * x;
                txtResult.Text = result.ToString();

            }
        }
    }
}
