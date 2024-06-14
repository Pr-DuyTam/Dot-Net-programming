
namespace Buoi3_Bai7
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
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.RichTextBox();
            this.lstWeb = new System.Windows.Forms.ListBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnMau = new System.Windows.Forms.Button();
            this.btnNen = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnĐóng = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Chuỗi";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(48, 64);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(99, 20);
            this.txtNhap.TabIndex = 3;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(219, 64);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(236, 85);
            this.txt1.TabIndex = 4;
            this.txt1.Text = "";
            // 
            // lstWeb
            // 
            this.lstWeb.FormattingEnabled = true;
            this.lstWeb.Location = new System.Drawing.Point(35, 149);
            this.lstWeb.Name = "lstWeb";
            this.lstWeb.Size = new System.Drawing.Size(139, 56);
            this.lstWeb.TabIndex = 5;
            this.lstWeb.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(35, 111);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 6;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(116, 111);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(73, 23);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnMau
            // 
            this.btnMau.Location = new System.Drawing.Point(219, 169);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(75, 23);
            this.btnMau.TabIndex = 8;
            this.btnMau.Text = "màu Chữ";
            this.btnMau.UseVisualStyleBackColor = true;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnNen
            // 
            this.btnNen.Location = new System.Drawing.Point(320, 169);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(75, 23);
            this.btnNen.TabIndex = 9;
            this.btnNen.Text = "Màu Nền";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // btnfont
            // 
            this.btnfont.Location = new System.Drawing.Point(411, 169);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(75, 23);
            this.btnfont.TabIndex = 10;
            this.btnfont.Text = "Font";
            this.btnfont.UseVisualStyleBackColor = true;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnĐóng
            // 
            this.btnĐóng.Location = new System.Drawing.Point(320, 215);
            this.btnĐóng.Name = "btnĐóng";
            this.btnĐóng.Size = new System.Drawing.Size(75, 23);
            this.btnĐóng.TabIndex = 11;
            this.btnĐóng.Text = "Đóng";
            this.btnĐóng.UseVisualStyleBackColor = true;
            this.btnĐóng.Click += new System.EventHandler(this.btnĐóng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 352);
            this.Controls.Add(this.btnĐóng);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lstWeb);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ConTrols";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.RichTextBox txt1;
        private System.Windows.Forms.ListBox lstWeb;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.Button btnNen;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnĐóng;
    }
}

