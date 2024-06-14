using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi8_Bai8._1
{
   
    public partial class FrmTm : Form
    {
        int n;
        public FrmTm(int c)
        {
            InitializeComponent();
            n = c;
        }
        private static string sxMang(int[] b, int k)
        {
            int tam;
            for(int i = 0; i < k - 1; i ++)
                for (int j = 0; j < k - 1; j++)
                    if(b[i] < b[j])
                    {
                        tam = b[i];
                        b[i] = b[j];
                        b[j] = tam;
                    }
            string g = " ";
            for (int i = 0; i < k; i++)
                g += " " + b[i].ToString();
            return g.Trim();
        }

        private void FrmTm_Load(object sender, EventArgs e)
        {
            int DemChan = 0;
            int DemLe = 0;
            int[] m = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                m[i] = rnd.Next(1, 9);
            }
            lblMang.Text = sxMang(m, n);
            for (int i = 0; i < n; i++)
            {
                if ((m[i] % 2) == 0)
                    DemChan++;
                else
                    DemLe++;

            }
            textBox1.Text = " Mảng có" + DemChan.ToString() + " Số chẵn";
            textBox2.Text = " Mảng có" + DemLe.ToString() + " Số lẻ";



        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
