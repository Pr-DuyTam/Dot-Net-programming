
namespace Buoi3_bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.lstchuoi = new System.Windows.Forms.ListBox();
            this.txtKQ = new System.Windows.Forms.RichTextBox();
            this.btnChu = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnNen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChuoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Chuỗi";
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(36, 31);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(112, 20);
            this.txtChuoi.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnXoa.Location = new System.Drawing.Point(117, 139);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 30);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn.Location = new System.Drawing.Point(12, 139);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(80, 30);
            this.btn.TabIndex = 13;
            this.btn.Text = "Thêm";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // lstchuoi
            // 
            this.lstchuoi.FormattingEnabled = true;
            this.lstchuoi.Location = new System.Drawing.Point(12, 203);
            this.lstchuoi.Name = "lstchuoi";
            this.lstchuoi.Size = new System.Drawing.Size(185, 56);
            this.lstchuoi.TabIndex = 14;
            this.lstchuoi.SelectedIndexChanged += new System.EventHandler(this.lstchuoi_SelectedIndexChanged);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(306, 31);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(163, 74);
            this.txtKQ.TabIndex = 15;
            this.txtKQ.Text = "";
            // 
            // btnChu
            // 
            this.btnChu.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnChu.Location = new System.Drawing.Point(257, 139);
            this.btnChu.Name = "btnChu";
            this.btnChu.Size = new System.Drawing.Size(113, 30);
            this.btnChu.TabIndex = 16;
            this.btnChu.Text = "Chọn màu chữ ";
            this.btnChu.UseVisualStyleBackColor = true;
            this.btnChu.Click += new System.EventHandler(this.btnChu_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnFont.Location = new System.Drawing.Point(512, 139);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(96, 30);
            this.btnFont.TabIndex = 17;
            this.btnFont.Text = "Chọn Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNen
            // 
            this.btnNen.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNen.Location = new System.Drawing.Point(389, 139);
            this.btnNen.Name = "btnNen";
            this.btnNen.Size = new System.Drawing.Size(98, 30);
            this.btnNen.TabIndex = 18;
            this.btnNen.Text = "Chọn màu nền ";
            this.btnNen.UseVisualStyleBackColor = true;
            this.btnNen.Click += new System.EventHandler(this.btnNen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNen);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnChu);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.lstchuoi);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ConTrol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ListBox lstchuoi;
        private System.Windows.Forms.RichTextBox txtKQ;
        private System.Windows.Forms.Button btnChu;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnNen;
    }
}

