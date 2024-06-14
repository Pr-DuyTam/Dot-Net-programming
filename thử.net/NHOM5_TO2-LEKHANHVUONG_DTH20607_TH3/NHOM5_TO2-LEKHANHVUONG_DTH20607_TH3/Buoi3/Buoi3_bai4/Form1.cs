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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtHoten.Clear();
            this.txtKQ.Clear();
            this.txtHoten.Focus();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (this.txtHoten.Text == "")
            {
                MessageBox.Show("Nhập vào họ tên", "Thông báo"); this.txtHoten.Focus();
            }
            else
            {
                string hoten = this.txtHoten.Text;
                if (this.radioThuong.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToLower();
                }
                if (this.radioHoa.Checked == true)
                {
                    this.txtKQ.Text = hoten.ToUpper();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
