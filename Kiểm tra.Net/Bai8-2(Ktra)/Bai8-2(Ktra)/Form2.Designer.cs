namespace Bai8_2_Ktra_
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.txtTBC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng các phần tử trong mảng";
            // 
            // txtTong
            // 
            this.txtTong.Location = new System.Drawing.Point(132, 105);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(261, 22);
            this.txtTong.TabIndex = 1;
            // 
            // txtTBC
            // 
            this.txtTBC.Location = new System.Drawing.Point(132, 236);
            this.txtTBC.Name = "txtTBC";
            this.txtTBC.Size = new System.Drawing.Size(261, 22);
            this.txtTBC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trung bình cộng các phần tử trong mảng";
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(222, 294);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 32);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmTongMang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTBC);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label1);
            this.Name = "frmTongMang";
            this.Text = "Tổng mảng";
            this.Load += new System.EventHandler(this.frmTongMang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.TextBox txtTBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDong;
    }
}