
namespace Bai1_buoi8
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.txtCanh = new System.Windows.Forms.TextBox();
            this.canh = new System.Windows.Forms.Label();
            this.dai = new System.Windows.Forms.Label();
            this.txtDai = new System.Windows.Forms.TextBox();
            this.rong = new System.Windows.Forms.Label();
            this.txtRong = new System.Windows.Forms.TextBox();
            this.labBanKinh = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính Diện Tích Và Chu Vi ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb3);
            this.groupBox1.Controls.Add(this.rb2);
            this.groupBox1.Controls.Add(this.rb1);
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(15, 124);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(94, 23);
            this.rb3.TabIndex = 2;
            this.rb3.TabStop = true;
            this.rb3.Text = "Hình Tròn";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged_1);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(15, 76);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(129, 23);
            this.rb2.TabIndex = 1;
            this.rb2.TabStop = true;
            this.rb2.Text = "Hình Chữ Nhật";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged_1);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(15, 31);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(105, 23);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Hình Vuông";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // txtCanh
            // 
            this.txtCanh.Location = new System.Drawing.Point(407, 79);
            this.txtCanh.Name = "txtCanh";
            this.txtCanh.Size = new System.Drawing.Size(100, 20);
            this.txtCanh.TabIndex = 2;
            // 
            // canh
            // 
            this.canh.AutoSize = true;
            this.canh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canh.Location = new System.Drawing.Point(310, 79);
            this.canh.Name = "canh";
            this.canh.Size = new System.Drawing.Size(36, 15);
            this.canh.TabIndex = 3;
            this.canh.Text = "Cạnh";
            // 
            // dai
            // 
            this.dai.AutoSize = true;
            this.dai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dai.Location = new System.Drawing.Point(310, 115);
            this.dai.Name = "dai";
            this.dai.Size = new System.Drawing.Size(26, 15);
            this.dai.TabIndex = 4;
            this.dai.Text = "Dài";
            // 
            // txtDai
            // 
            this.txtDai.Location = new System.Drawing.Point(407, 115);
            this.txtDai.Name = "txtDai";
            this.txtDai.Size = new System.Drawing.Size(100, 20);
            this.txtDai.TabIndex = 5;
            // 
            // rong
            // 
            this.rong.AutoSize = true;
            this.rong.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rong.Location = new System.Drawing.Point(310, 157);
            this.rong.Name = "rong";
            this.rong.Size = new System.Drawing.Size(36, 15);
            this.rong.TabIndex = 6;
            this.rong.Text = "Rộng";
            // 
            // txtRong
            // 
            this.txtRong.Location = new System.Drawing.Point(407, 157);
            this.txtRong.Name = "txtRong";
            this.txtRong.Size = new System.Drawing.Size(100, 20);
            this.txtRong.TabIndex = 7;
            // 
            // labBanKinh
            // 
            this.labBanKinh.AutoSize = true;
            this.labBanKinh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBanKinh.Location = new System.Drawing.Point(310, 205);
            this.labBanKinh.Name = "labBanKinh";
            this.labBanKinh.Size = new System.Drawing.Size(71, 15);
            this.labBanKinh.TabIndex = 8;
            this.labBanKinh.Text = "Bán Kính R";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(407, 200);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(100, 20);
            this.txtBanKinh.TabIndex = 9;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.Location = new System.Drawing.Point(231, 297);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(115, 32);
            this.btnThucHien.TabIndex = 10;
            this.btnThucHien.Text = "Thực Hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(407, 297);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 32);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.labBanKinh);
            this.Controls.Add(this.txtRong);
            this.Controls.Add(this.rong);
            this.Controls.Add(this.txtDai);
            this.Controls.Add(this.dai);
            this.Controls.Add(this.canh);
            this.Controls.Add(this.txtCanh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.TextBox txtCanh;
        private System.Windows.Forms.Label canh;
        private System.Windows.Forms.Label dai;
        private System.Windows.Forms.TextBox txtDai;
        private System.Windows.Forms.Label rong;
        private System.Windows.Forms.TextBox txtRong;
        private System.Windows.Forms.Label labBanKinh;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnThoat;
    }
}

