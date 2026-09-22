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

                if (int.TryParse(QuantityEntry.Text,out int x))
                {

                    DisplayAlert($"{ProductEntry.Text}", $"Ilość: {x}  adres: {AdressEntry.Text}", $"Ok");

                }
                else
                {
                    DisplayAlert("Nieprawidłowe wprowadzenie danych", "Pole ilość musi być liczbą", "Ok");
                }

                

            }
            else
            {

                DisplayAlert("Uzupełnij wszystkie pola", "Należy uzupełnić wszystkie pola", "Ok");

            }

        }
    }
}
