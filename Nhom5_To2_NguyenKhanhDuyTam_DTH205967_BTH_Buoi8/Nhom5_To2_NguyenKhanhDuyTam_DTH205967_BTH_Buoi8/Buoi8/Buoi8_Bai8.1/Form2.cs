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
    public partial class Frmktcl : Form
    {
        int a;
        public Frmktcl(int b)
        {
            InitializeComponent();
            a = b;
        }
        public static bool KTChan(int a)
        {
            if ((a % 2) == 0)
                return true;
            else
                return false;
        }

        private void Frmktcl_Load(object sender, EventArgs e)
        {
            if (KTChan(a) == true)
                LblSnt1.Text = a + " là số chẵn";
            else
                LblSnt1.Text = a + " là số lẻ";

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
