using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._2_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlert_Click(object sender, EventArgs e)
        {
            int month = Int32.Parse(txtThang.Text);

            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    MessageBox.Show("Mùa Xuân");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Mùa Hạ");
                    break;
                case 7:
                case 8:
                case 9:
                    MessageBox.Show("Mùa Thu");
                    break;
                case 10:
                case 11:
                case 12:
                    MessageBox.Show("Mùa Đông");
                    break;
                default:
                    MessageBox.Show(month + " không phải là 1 tháng trong năm!");
                    break;
            }
        }
    }
}
