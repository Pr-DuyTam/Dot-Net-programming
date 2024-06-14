﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.lstWeb.Items.Add("Tuổi Trẻ");
            this.lstWeb.Items.Add("Thanh Niên");
            this.lstWeb.Items.Add("VNExpress");
            this.lstWeb.Items.Add("Dân Trí");
            this.lstWeb.Items.Add("Công an");
            this.lstWeb.SelectedItem = "Tuổi Trẻ";

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chọn website";
            this.txtKQ.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }
    }
}
