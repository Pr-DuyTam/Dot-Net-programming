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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstWeb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.txtKQ.Text = "Bạn đã chọn website";
            this.txtKQ.Text += this.lstWeb.SelectedItem.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtKQ.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }
    }
}
