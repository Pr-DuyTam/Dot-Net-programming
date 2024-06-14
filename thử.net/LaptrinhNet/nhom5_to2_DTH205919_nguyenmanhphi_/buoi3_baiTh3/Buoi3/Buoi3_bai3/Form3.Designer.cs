
namespace Buoi3_bai3
{
    partial class cbWeb
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cmbWed = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(74, 42);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(88, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Liên Kết website:";
            // 
            // cmbWed
            // 
            this.cmbWed.FormattingEnabled = true;
            this.cmbWed.Location = new System.Drawing.Point(77, 72);
            this.cmbWed.Name = "cmbWed";
            this.cmbWed.Size = new System.Drawing.Size(93, 21);
            this.cmbWed.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(193, 72);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(70, 20);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(269, 72);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(67, 20);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(77, 116);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(259, 88);
            this.txtKQ.TabIndex = 4;
            this.txtKQ.Text = "";
            // 
            // cbWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 350);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cmbWed);
            this.Controls.Add(this.linkLabel1);
            this.Name = "cbWeb";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cmbWed;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.RichTextBox txtKQ;
    }
}