using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnĐóng_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có muốn thoát không", "Thông Báo", MessageBoxButtons.OKCancel);
            if(traloi == DialogResult.OK)
                Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWeb.SelectedIndex >= 0)
            {
                txt1.Text = lstWeb.SelectedItem.ToString();
            }
            else
                txt1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Phan Thanh Điền");
            this.lstWeb.Items.Add("Phạm Thị Bích Ngọc");
            this.lstWeb.Items.Add("Phùng Văn Sơn");
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (this.txtNhap.Text == "")
                MessageBox.Show("Vui Long Nhap Ho Ten", "Thong Bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.lstWeb.Items.Add(txtNhap.Text);
            this.txtNhap.ResetText();
            this.txtNhap.Focus();
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            ColorDialog mauchu = new ColorDialog();
            if (mauchu.ShowDialog() == DialogResult.OK)
                this.txt1.ForeColor = mauchu.Color;
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog maunen = new ColorDialog();
            if (maunen.ShowDialog() == DialogResult.OK)
                this.txt1.BackColor = maunen.Color;
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                this.txt1.Font = font.Font;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lstWeb.SelectedIndex>=0)
            {
                lstWeb.Items.Remove(lstWeb.SelectedItem);
            }    
        }
    }
}
