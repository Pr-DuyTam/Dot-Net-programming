using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai4
{
    public partial class Form111 : Form
    {
        public Form111()
        {
            InitializeComponent();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            if (this.txtHoTen.Text == "")
            {
                MessageBox.Show("Nhập họ và tên", "Thông Báo");
                this.txtHoTen.Focus();
            }
            else
            {
                string hotten = this.txtHoTen.Text;
                if (this.rad1.Checked == true)
                {
                    this.txtKetQua.Text = hotten.ToLower();
                }
                if (this.rad2.Checked == true)
                {
                    this.txtKetQua.Text = hotten.ToUpper();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKetQua.Clear();
            this.btnKetQua.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

