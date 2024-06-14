using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi2_Bai3
{
    public partial class FrmBai3_4 : Form
    {
        public FrmBai3_4()
        {
            InitializeComponent();
        }

        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            int Ngay = int.Parse(txtNgay.Text);
            int Thang = int.Parse(txtThang.Text);
            int Nam = int.Parse(txtNam.Text);

            if (Thang == 1 || Thang == 3 || Thang == 5 || Thang == 7 || Thang == 8 || Thang == 10 || Thang == 12)
            {
                if (Ngay >= 1 && Ngay <= 31)
                    MessageBox.Show("Ngay hop le!");
                else
                    MessageBox.Show("Ngay khong hop le!");
            }
            else if (Thang == 4 || Thang == 6 || Thang == 9 || Thang == 11)
            {
                if (Ngay >= 1 && Ngay <= 30)
                    MessageBox.Show("Ngay hop le!");
                else
                    MessageBox.Show("Ngay khong hop le!");
            }
            else if (Nam % 400 == 0 || (Nam % 4 == 0 && Nam % 100 != 0))
                if (Ngay <= 29 && Ngay >= 1)
                    MessageBox.Show("Ngay hop le!");
                else
                    MessageBox.Show("Ngay khong hop le!");
            else if (Nam % 400 != 0 || (Nam % 4 != 0 && Nam % 100 == 0))
                if (Ngay <= 28 && Ngay >= 1)
                    MessageBox.Show("Ngay hop le!");
                else
                    MessageBox.Show("Ngay khong hop le!");
            else
                MessageBox.Show("Ngay khong hop le!");
        }
    }
}
