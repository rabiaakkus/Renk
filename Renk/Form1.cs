namespace Renk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnYesil_Click(object sender, EventArgs e)
        {
            btnYesil.BackColor = Color.Green;
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            btnMavi.BackColor = Color.Blue;
            btnMavi.ForeColor = Color.White;
        }

        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            btnKirmizi.BackColor = Color.Red;
            btnKirmizi.ForeColor = Color.Yellow;
        }

        private void btnSari_Click(object sender, EventArgs e)
        {
            btnSari.BackColor = Color.Yellow;
        }
    }
}