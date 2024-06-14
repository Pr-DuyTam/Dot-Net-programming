namespace Bai2_11
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
            this.btxChuvi = new System.Windows.Forms.Button();
            this.btxDientich = new System.Windows.Forms.Button();
            this.btxDuongcheo = new System.Windows.Forms.Button();
            this.btxThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHCN = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btxChuvi
            // 
            this.btxChuvi.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxChuvi.Location = new System.Drawing.Point(12, 251);
            this.btxChuvi.Name = "btxChuvi";
            this.btxChuvi.Size = new System.Drawing.Size(122, 61);
            this.btxChuvi.TabIndex = 0;
            this.btxChuvi.Text = "Chu vi";
            this.btxChuvi.UseVisualStyleBackColor = true;
            this.btxChuvi.Click += new System.EventHandler(this.btxChuvi_Click);
            // 
            // btxDientich
            // 
            this.btxDientich.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxDientich.Location = new System.Drawing.Point(181, 251);
            this.btxDientich.Name = "btxDientich";
            this.btxDientich.Size = new System.Drawing.Size(133, 61);
            this.btxDientich.TabIndex = 1;
            this.btxDientich.Text = "Dien tich";
            this.btxDientich.UseVisualStyleBackColor = true;
            this.btxDientich.Click += new System.EventHandler(this.btxDientich_Click);
            // 
            // btxDuongcheo
            // 
            this.btxDuongcheo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxDuongcheo.Location = new System.Drawing.Point(379, 251);
            this.btxDuongcheo.Name = "btxDuongcheo";
            this.btxDuongcheo.Size = new System.Drawing.Size(188, 61);
            this.btxDuongcheo.TabIndex = 2;
            this.btxDuongcheo.Text = "Duong cheo";
            this.btxDuongcheo.UseVisualStyleBackColor = true;
            this.btxDuongcheo.Click += new System.EventHandler(this.btxDuongcheo_Click);
            // 
            // btxThoat
            // 
            this.btxThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxThoat.Location = new System.Drawing.Point(623, 251);
            this.btxThoat.Name = "btxThoat";
            this.btxThoat.Size = new System.Drawing.Size(130, 61);
            this.btxThoat.TabIndex = 3;
            this.btxThoat.Text = "Thoat";
            this.btxThoat.UseVisualStyleBackColor = true;
            this.btxThoat.Click += new System.EventHandler(this.btxThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "B:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(387, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(169, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(387, 22);
            this.textBox2.TabIndex = 7;
            // 
            // lblHCN
            // 
            this.lblHCN.AutoSize = true;
            this.lblHCN.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHCN.Location = new System.Drawing.Point(165, 24);
            this.lblHCN.Name = "lblHCN";
            this.lblHCN.Size = new System.Drawing.Size(242, 32);
            this.lblHCN.TabIndex = 8;
            this.lblHCN.Text = "HINH CHU NHAT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHCN);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btxThoat);
            this.Controls.Add(this.btxDuongcheo);
            this.Controls.Add(this.btxDientich);
            this.Controls.Add(this.btxChuvi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btxChuvi;
        private System.Windows.Forms.Button btxDientich;
        private System.Windows.Forms.Button btxDuongcheo;
        private System.Windows.Forms.Button btxThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblHCN;
    }
}

