namespace Buoi3_bai7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnKQ = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.AutoSize = true;
            this.LB1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LB1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LB1.Location = new System.Drawing.Point(193, 101);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(268, 26);
            this.LB1.TabIndex = 0;
            this.LB1.Text = "PHÉP TÍNH ĐƠN GIẢN";
            this.LB1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(179, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(144, 104);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(129, 31);
            this.txtb.TabIndex = 3;
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(144, 53);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(129, 31);
            this.txta.TabIndex = 2;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập b :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập a :";
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(332, 423);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(129, 31);
            this.txtKQ.TabIndex = 3;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(201, 424);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(111, 38);
            this.btnKQ.TabIndex = 4;
            this.btnKQ.Text = "Kết Qủa";
            this.btnKQ.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngToolStripMenuItem1,
            this.hiệuToolStripMenuItem1,
            this.tíchToolStripMenuItem,
            this.thươngToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 29);
            this.toolStripMenuItem1.Text = "Tính Toán";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // tổngToolStripMenuItem1
            // 
            this.tổngToolStripMenuItem1.Name = "tổngToolStripMenuItem1";
            this.tổngToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.tổngToolStripMenuItem1.Text = "Tổng";
            this.tổngToolStripMenuItem1.Click += new System.EventHandler(this.tổngToolStripMenuItem1_Click);
            // 
            // hiệuToolStripMenuItem1
            // 
            this.hiệuToolStripMenuItem1.Name = "hiệuToolStripMenuItem1";
            this.hiệuToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.hiệuToolStripMenuItem1.Text = "Hiệu";
            this.hiệuToolStripMenuItem1.Click += new System.EventHandler(this.hiệuToolStripMenuItem1_Click);
            // 
            // tíchToolStripMenuItem
            // 
            this.tíchToolStripMenuItem.Name = "tíchToolStripMenuItem";
            this.tíchToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tíchToolStripMenuItem.Text = "Tích";
            this.tíchToolStripMenuItem.Click += new System.EventHandler(this.tíchToolStripMenuItem_Click);
            // 
            // thươngToolStripMenuItem
            // 
            this.thươngToolStripMenuItem.Name = "thươngToolStripMenuItem";
            this.thươngToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.thươngToolStripMenuItem.Text = "Thương";
            this.thươngToolStripMenuItem.Click += new System.EventHandler(this.thươngToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 577);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LB1;
        private GroupBox groupBox1;
        private TextBox txtb;
        private TextBox txta;
        private Label label3;
        private Label label2;
        private TextBox txtKQ;
        private Button btnKQ;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tổngToolStripMenuItem1;
        private ToolStripMenuItem hiệuToolStripMenuItem1;
        private ToolStripMenuItem tíchToolStripMenuItem;
        private ToolStripMenuItem thươngToolStripMenuItem;
    }
}