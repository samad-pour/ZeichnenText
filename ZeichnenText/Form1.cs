namespace ZeichnenText
{
    public partial class Form1 : Form
    {
        private Graphics z;
        private Font f = new Font("Arial", 16);
        private SolidBrush pinsel = new SolidBrush(Color.Red);
        private Color[] colorFeld =
        { Color.Red, Color.Green, Color.Blue };

        public Form1()
        {
            InitializeComponent();
            z = CreateGraphics();
            LstSchriftart.SelectedIndex = 0;
            LstFarbe.SelectedIndex = 0;
        }

        private void BtnAnzeige_Click(object sender, EventArgs e)
        {
            z.DrawString(TxtEingabe.Text, f, pinsel, 20, 20);
        }

        private void LstSchriftart_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = new Font(LstSchriftart.Text, f.Size);
        }

        private void NumSchriftgroesse_ValueChanged(object sender, EventArgs e)
        {
            f = new Font(f.FontFamily, (float)NumSchriftgroesse.Value);
        }

        private void LstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pinsel.Color = colorFeld[LstFarbe.SelectedIndex];
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}