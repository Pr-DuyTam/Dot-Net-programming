﻿
namespace Buoi8_Bai8._1
{
    partial class From1
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
            this.btnTaomang = new System.Windows.Forms.Button();
            this.btnKTCL = new System.Windows.Forms.Button();
            this.btnLamlai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập N";
            // 
            // btnTaomang
            // 
            this.btnTaomang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaomang.Location = new System.Drawing.Point(36, 102);
            this.btnTaomang.Name = "btnTaomang";
            this.btnTaomang.Size = new System.Drawing.Size(98, 33);
            this.btnTaomang.TabIndex = 1;
            this.btnTaomang.Text = "Tạo mảng";
            this.btnTaomang.UseVisualStyleBackColor = true;
            this.btnTaomang.Click += new System.EventHandler(this.btnTaomang_Click);
            // 
            // btnKTCL
            // 
            this.btnKTCL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKTCL.Location = new System.Drawing.Point(273, 102);
            this.btnKTCL.Name = "btnKTCL";
            this.btnKTCL.Size = new System.Drawing.Size(148, 33);
            this.btnKTCL.TabIndex = 2;
            this.btnKTCL.Text = "Kiểm Tra Chẳn lẻ";
            this.btnKTCL.UseVisualStyleBackColor = true;
            this.btnKTCL.Click += new System.EventHandler(this.btnKTCL_Click);
            // 
            // btnLamlai
            // 
            this.btnLamlai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamlai.Location = new System.Drawing.Point(36, 186);
            this.btnLamlai.Name = "btnLamlai";
            this.btnLamlai.Size = new System.Drawing.Size(98, 33);
            this.btnLamlai.TabIndex = 3;
            this.btnLamlai.Text = "Làm lại";
            this.btnLamlai.UseVisualStyleBackColor = true;
            this.btnLamlai.Click += new System.EventHandler(this.btnLamlai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(273, 186);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(148, 36);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 5;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamlai);
            this.Controls.Add(this.btnKTCL);
            this.Controls.Add(this.btnTaomang);
            this.Controls.Add(this.label1);
            this.Name = "From1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTaomang;
        private System.Windows.Forms.Button btnKTCL;
        private System.Windows.Forms.Button btnLamlai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtN;
    }
}

