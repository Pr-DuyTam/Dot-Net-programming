using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi4_Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a ; int n;


        //phuong thuc tao mang 
        public void TaoMang(int n)
        {
            //khai báo mảng có n phần tử nhập từ Textbox 
            a = new int[n];
            //khởi  tạo  giá  tri  ngẫu  nhiên  cho  mảng 
            int num;
            Random ran = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                //tạo số ngẫu nhiên nằm giữa -10 và 100 
                num = ran.Next(-10, 100);
                a[i] += num;
            }
        }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < a.Length; i++)
            {
                chuoi += a[i] + " ";
            }
            return chuoi;
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Nhập Số Phần Tử Của Mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if (n < 0)
                {
                    MessageBox.Show("Số phần tử mảng phải > 0", "Thông báo"); 
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(n);
                    txtKetqua.Text = "Mảng đã tạo : " +InMang();
                    btnInmang.Enabled = true;
                }
            }

        }

        private void btnInmang_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag
            if (a.Length == 0)
            {
                MessageBox.Show("Mảng Rỗng", "Thông Báo");
                this.txtNhap.Focus();
            }
            else
                txtKetqua.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không ?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
