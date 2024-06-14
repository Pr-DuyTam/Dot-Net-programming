using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Buoi2_Bai1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnHienThi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHienThi
            // 
            this.btnHienThi.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThi.Location = new System.Drawing.Point(70, 94);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(149, 56);
            this.btnHienThi.TabIndex = 0;
            this.btnHienThi.Text = "Hien Thi";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // Bai2
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnHienThi);
            this.Name = "Bai2";
            this.Text = "Bai2.4";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chao mung ban den voi mon hoc LAP TRINH TREN MOI TRUONG WINDOWS");
        }
    }
}
