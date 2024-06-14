using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi8//Tinh chu vi_dien tich HCN
{
    public partial class Form3 : Form
    {
 /*      public Form3()
        {
            InitializeComponent();
        }
*/
    public Form3(double x, double y)
        {
            InitializeComponent();
            dai = x;
            rong = y;
        }
        public double dai;
        public double rong;
        public double TinhDienTich()
        {
            double dientich = this.dai * this.rong;
            return dientich;
        }
        public double TinhChuVi()
        {
            double chuvi = ((this.dai + this.rong) * 2);
            return chuvi;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            this.txtDienTich.Text = TinhDienTich().ToString();
            this.txtChuVi.Text = TinhChuVi().ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            DialogResult traloi = MessageBox.Show("Mày có muốn thoát?", "Nhìn nè!",
                MessageBoxButtons.OKCancel);
            if(traloi == DialogResult.OK)
            {
                this.Close();
                Form1 f1 = new Form1();
                f1.Show();
            }    
                // Application.Exit();
        }
    }
}
