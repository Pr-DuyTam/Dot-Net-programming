using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._7_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtA.Text);
            int b = Int32.Parse(txtB.Text);
            int c = Int32.Parse(txtC.Text);

            int denta = (b*b) - (4*a*c);

            if (denta < 0)
            {
                txtResult.Text = "PT vô nghiệm";
            }
            else if (denta > 0)
            {
                float x1 = (float)(-b - Math.Sqrt(denta)) / (2 * a);
                float x2 = (float)(-b + Math.Sqrt(denta)) / (2 * a);


                txtResult.Text = "PT có 2 nghiệm: x1 = " + x1 + " " + " x2 = " + x2;
            }
        }
    }
}
