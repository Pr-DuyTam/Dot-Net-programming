using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_buoi8// Tinh chu vi _ dien tich hinh vuong
{
    public partial class Form2 : Form
    {
     /*   public Form2()
        {
            InitializeComponent();
        }
     */
     public Form2(double x)
        {
            InitializeComponent();
            canha = x;
        }
        public double canha;
/*
        public double TinhDienTich()
        {
            double dientich = this.canha * this.canha;
            return dientich;
        }
*/
        public double TinhDienTich()
        {
            return Math.Round(canha * canha, 2);
        }
/* 
        public double TinhChuVi()
        {
            double chuvi = this.canha * 4;
            return chuvi;
        }
*/
        public double TinhChuVi()
        {
            return Math.Round(canha * 4, 2);
        }
    

        private void Form2_Load(object sender, EventArgs e)
        {
            this.txtDienTich.Text = TinhDienTich().ToString();
            this.txtChuVi.Text = TinhChuVi().ToString();
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
