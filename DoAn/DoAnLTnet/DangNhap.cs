using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnLTnet
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txttk.Text=="DTH205919"&&txtmk.Text=="123456")
            {
                Form1 frm = new Form1(); // "new" tạo đối tượng (Phương thức khởi tạo)
                this.Hide();
                frm.Show();
            } 
            else
            {
                MessageBox.Show("đăng nhập sai", "thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                txttk.Text = "";
                txtmk.Text = "";
                txttk.Focus();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
