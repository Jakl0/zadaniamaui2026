namespace tem7zad3
{
    public partial class MainPage : ContentPage
    {
        double R, G, B = 0;
        int r, g, b;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ZmienKolor(object sender, EventArgs e)
        {
            R = slidR.Value/255;
            G = slidG.Value/255;
            B = slidB.Value/255;
            r = (int)slidR.Value;
            g = (int)slidG.Value;
            b = (int)slidB.Value;
            Content.BackgroundColor = Color.FromRgb(R,G,B);
            HexLabel.Text = $"#{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}";
        }
    }
}
