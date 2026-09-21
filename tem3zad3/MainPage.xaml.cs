namespace tem3zad3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OrderButtonClicked(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(ProductEntry.Text)&& !string.IsNullOrWhiteSpace(QuantityEntry.Text)&& !string.IsNullOrWhiteSpace(AdressEntry.Text))
            {

                DisplayAlert("Hej","Co jest","OK");

            }

        }
    }
}
