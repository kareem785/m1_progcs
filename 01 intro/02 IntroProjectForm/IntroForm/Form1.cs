namespace IntroForm
{
    public partial class Form1 : Form
    {
        //1) ken waardes toe aan de variabelen (assignement (=))
        int x = 250;// iets van tussen de 50 en 300
        int y = 250;// iets van tussen de 50 en 300
        string introSentence = "120"; // 2) zet hier een string waarde neer, let op je "
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            g.DrawString(introSentence, Font, Brushes.Black, x, y);
        }
    }
}
