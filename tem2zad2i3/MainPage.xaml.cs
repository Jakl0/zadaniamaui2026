namespace tem2zad2i3
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }

        private void ShowClicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(NameEntry.Text) && !string.IsNullOrWhiteSpace(CityEntry.Text))
            {

                ResultLabel.Text = $"Witaj, {NameEntry.Text} z miasta: {CityEntry.Text}";

            }
            else
            {

                ResultLabel.Text = "Uzupełnij oba pola";

            }
        }
    }
}
