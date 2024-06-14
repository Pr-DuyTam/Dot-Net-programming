using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3_bai3
{
    public partial class cbWeb : Form
    {
        public cbWeb()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.cmbWed.Items.Add("Tuổi Trẻ");
            this.cmbWed.Items.Add("Thanh Niên");
            this.cmbWed.Items.Add("VNExpress");
            this.cmbWed.Items.Add("Dân Trí");
            this.cmbWed.Items.Add("Công An");
            this.cmbWed.Items.Add("24h");
            this.cmbWed.Items.Add("Zingme");
            this.cmbWed.Items.Add("Kênh 14");
            this.cmbWed.Items.Add("Sài Gòn Tiếp Thị");
            this.cmbWed.SelectedItem = "VNExpress";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn chọn web";
            this.txtKQ.Text += this.cmbWed.SelectedItem.ToString();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            this.cmbWed.SelectedItem = "VNExpress";
            this.txtKQ.Clear();
        }
    }
}
