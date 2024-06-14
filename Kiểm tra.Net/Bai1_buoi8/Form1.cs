using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi8 //Tinh dien tich và chu vi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

   
        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCanh.Clear();
            this.txtDai.Clear();
            this.txtRong.Clear();
            this.txtBanKinh.Clear();

            this.txtCanh.Enabled = true;
            this.txtDai.Enabled = false;
            this.txtRong.Enabled = false;
            this.txtBanKinh.Enabled = false;

            this.txtCanh.Focus();
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if(this.rb1.Checked == true)
            {
                if (this.txtCanh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào chiều dài cạnh", "Thông báo");
                    this.txtCanh.Focus();

                }
                else
                {
                     Form2 f2 = new Form2(double.Parse(this.txtCanh.Text));
                //    f2.canha = double.Parse(this.txtCanh.Text);
                //  Form2 f2 = new From2(Double.Parse(txtCanh.Text));
                    f2.ShowDialog();
                }
            }
                if (this.rb2.Checked == true)
            {     
                if ((this.txtDai.Text == "")||(this.txtRong.Text==""))
                {
                    MessageBox.Show("Hãy nhập vào chiều dài và chiều rộng", "Thông báo");
                    this.txtDai.Focus();
                }
                else
                {
                    Form3 f3 = new Form3(double.Parse(this.txtDai.Text), double.Parse(this.txtRong.Text));
                 //   f3.dai = double.Parse(this.txtDai.Text);
                 // f3.rong = double.Parse(this.txtRong.Text);
                    f3.ShowDialog();
                }
            }
            if (this.rb3.Checked == true)
            {
                if (this.txtBanKinh.Text == "")
                {
                    MessageBox.Show("Hãy nhập vào bán kính", "Thông báo");
                    this.txtBanKinh.Focus();
                }
                else
                {
                    Form4 f4 = new Form4(double.Parse(this.txtDai.Text));
                 // f4.bankinh = double.Parse(this.txtDai.Text);
                    
                    f4.ShowDialog();
                }
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void rb2_CheckedChanged_1(object sender, EventArgs e)
        {
                this.txtCanh.Clear();
                this.txtDai.Clear();
                this.txtRong.Clear();
                this.txtBanKinh.Clear();

                this.txtCanh.Enabled = false;
                this.txtDai.Enabled = true;
                this.txtRong.Enabled = true;
                this.txtBanKinh.Enabled = false;

                this.txtDai.Focus();
                this.txtRong.Focus();
        }

        private void rb3_CheckedChanged_1(object sender, EventArgs e)
        {
                this.txtCanh.Clear();
                this.txtDai.Clear();
                this.txtRong.Clear();
                this.txtBanKinh.Clear();

                this.txtCanh.Enabled = false;
                this.txtDai.Enabled = false;
                this.txtRong.Enabled = false;
                this.txtBanKinh.Enabled = true;

                this.txtBanKinh.Focus();
           
        }
    }
}
