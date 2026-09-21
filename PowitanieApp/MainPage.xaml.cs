namespace PowitanieApp
{
    public partial class MainPage : ContentPage
    {
        int counter = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void WelcomeChange(object sender , EventArgs e)
        {

            WelcomeLabel.Text = "Aplikacja działa poprawnie";

            counter++;

            CounterLabel.Text = $"tyle razy kliknąłeś/aś jakiś przycisk {counter}";

        }

        private void WelcomeReset(object sender, EventArgs e)
        {

            WelcomeLabel.Text = "Witamy w aplikacji";

            counter++;

            CounterLabel.Text = $"tyle razy kliknąłeś/aś jakiś przycisk {counter}";

        }
    }
}
