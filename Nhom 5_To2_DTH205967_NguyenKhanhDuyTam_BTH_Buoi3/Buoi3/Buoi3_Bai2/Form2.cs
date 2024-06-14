using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.txtUser.Text == "") || (this.txtpass.Text == ""))
                MessageBox.Show("Vui Lòng Nhập Tên người dùng hoặc mật khẩu");
            else
            {
                if((this.txtUser.Text=="nguyenvanhung")&&(this.txtpass.Text=="123123"))
                {
                    MessageBox.Show("Đăng Nhập Thành Công.","Thông Báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng,Hãy Nhập Lại.", "Thông Báo");
                    this.txtUser.Clear();
                    this.txtpass.Clear();
                    this.txtUser.Focus();
                }
            }    
        }
    }
}
