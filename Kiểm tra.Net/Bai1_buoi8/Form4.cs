using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi8//Tinh chu vi_dien tich hinh tron
{
    public partial class Form4 : Form
    {
 /*       public Form4()
        {
            InitializeComponent();
        }
 */
    public Form4(double r)
        {
            InitializeComponent();
            bankinh = r;
        }
        public double bankinh;
        public double TinhDienTich()
        {
            double dientich = ((this.bankinh * this.bankinh) * 3.14);
            return dientich;
        }
        public double TinhChuVi()
        {
            double chuvi = ((this.bankinh * 2) * 3.14);
           
            return chuvi;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Mày có muốn thoát?", "Nhìn nè!",
                MessageBoxButtons.OKCancel);
            if (traloi == DialogResult.OK)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }
            //Application.Exit();
        }
    }
}
