
namespace Bai8._2
{
    partial class frmTongMang
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
            this.btnDong3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTBC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDong3
            // 
            this.btnDong3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong3.Location = new System.Drawing.Point(94, 253);
            this.btnDong3.Name = "btnDong3";
            this.btnDong3.Size = new System.Drawing.Size(75, 29);
            this.btnDong3.TabIndex = 0;
            this.btnDong3.Text = "Đóng";
            this.btnDong3.UseVisualStyleBackColor = true;
            this.btnDong3.Click += new System.EventHandler(this.btnDong3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng các phần tử trong mảng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trung bình cộng các phần tử trong mảng";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(94, 83);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(100, 20);
            this.txtTong.TabIndex = 3;
            // 
            // txtTBC
            // 
            this.txtTBC.Location = new System.Drawing.Point(94, 187);
            this.txtTBC.Name = "txtTBC";
            this.txtTBC.Size = new System.Drawing.Size(100, 20);
            this.txtTBC.TabIndex = 4;
            // 
            // frmTongMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.txtTBC);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong3);
            this.Name = "frmTongMang";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmTongMang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTBC;
    }
}