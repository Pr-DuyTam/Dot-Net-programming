using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int TimMax(int so1, int so2)
        {
            if (so1 < so2)
                return so1;
            else
                return so2;
        }
        //phuong thuc tim uoc chung cua 2 so
        public String TimUocChung(int a, int b)
        {
            int max = TimMax(a, b);
            String chuoi = "";
            for (int i = 1; i <= max; i++)
                if ((a % i == 0) && (b % i == 0))
                    chuoi += " " + i.ToString();
            return chuoi;
        }
        //phuong thuc tim UCLN cua 2 so
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            return a;
        }
       
        private void btnTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(this.txtM.Text);
            b = int.Parse(this.txtN.Text);
            if (this.rd1.Checked == true)
                this.txtKQ.Text = TimUocChung(a, b);
            if (this.rd2.Checked == true)
                this.txtKQ.Text = timUCLN(a, b).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtM.Clear();
            this.txtN.Clear();
            this.txtKQ.Clear();
            this.txtM.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {

        }
    }
}
