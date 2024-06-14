using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._3_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day = Int32.Parse(txtDay.Text);
            int month = Int32.Parse(txtMonth.Text);
            int year = Int32.Parse(txtYear.Text);

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (day < 1 || day > 31)
                    {
                        MessageBox.Show("Ngày KHÔNG hợp lệ!");
                    }
                    else
                    {
                        MessageBox.Show("Ngày hợp lệ!");
                    }
                    break;
                case 2:

                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        if (day < 1 || day > 29)
                        {
                            MessageBox.Show("Ngày KHÔNG hợp lệ!");
                        }
                        else
                        {
                            MessageBox.Show("Ngày hợp lệ!");
                        }
                    }
                    else
                    {
                        if (day < 1 || day > 28)
                        {
                            MessageBox.Show("Ngày KHÔNG hợp lệ!");
                        }
                        else
                        {
                            MessageBox.Show("Ngày hợp lệ!");
                        }
                    }

                    break;


                case 4:
                case 6:
                case 9:
                case 11:
                    if (day < 1 || day > 30)
                    {
                        MessageBox.Show("Ngày KHÔNG hợp lệ!");
                    }
                    else
                    {
                        MessageBox.Show("Ngày hợp lệ!");
                    }
                    break;
                default:
                    MessageBox.Show("Đây không phải là 1 ngày!");
                    break ;
            }
        }
    }
}
