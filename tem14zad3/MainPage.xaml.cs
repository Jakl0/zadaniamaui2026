namespace tem14zad3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            DisplayLabel.Text = $"Wysokość {Height} Szerokość {Width}";
            
        }
    }
}
