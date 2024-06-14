using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string name = txtChuoi.Text.ToString();
            if (name != "")
            {
                lstchuoi.Items.Add(name);
                txtChuoi.Clear();
                txtChuoi.Focus();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập chuỗi vào ô trống !", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                   
            }
            

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstchuoi.SelectedIndex >= 0)
            {
                lstchuoi.Items.Remove(lstchuoi.SelectedItem);
            }
            

        }

        private void lstchuoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstchuoi.SelectedIndex >= 0)
            {
                txtKQ.Text = lstchuoi.SelectedItem.ToString();
            }
            else
                txtKQ.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
                this.txtKQ.Font = font.Font;
        }

        private void btnChu_Click(object sender, EventArgs e)
        {
            ColorDialog mauchu = new ColorDialog();
            if (mauchu.ShowDialog() == DialogResult.OK)
                this.txtKQ.ForeColor = mauchu.Color;
        }

        private void btnNen_Click(object sender, EventArgs e)
        {
            ColorDialog maunen = new ColorDialog();
            if (maunen.ShowDialog() == DialogResult.OK)
                this.txtKQ.BackColor = maunen.Color;
        }
    }
}
