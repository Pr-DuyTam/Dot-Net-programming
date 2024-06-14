namespace Buoi3_bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tÍNHTONASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tổngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float S;
            S = float.Parse(txta.Text) + float.Parse(txtb.Text);
            txtKQ.Text= S.ToString();
        }

        private void txta_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void hiệuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            float S;
            S = float.Parse(txta.Text) - float.Parse(txtb.Text);
            txtKQ.Text = S.ToString();

        }

        private void tíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float S;
            S = float.Parse(txta.Text) * float.Parse(txtb.Text);
            txtKQ.Text = S.ToString();
        }

        private void thươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float S;
            S = float.Parse(txta.Text) / float.Parse(txtb.Text);
            txtKQ.Text = S.ToString();
        }
    }
}