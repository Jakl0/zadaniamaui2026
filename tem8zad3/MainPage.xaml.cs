namespace tem8zad3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void CalculateClick(object sender, EventArgs e)
        {
            if(double.TryParse(FirstEntry.Text,out double a)&& double.TryParse(SecondEntry.Text, out double b))
            {
                if (a > 0 && b > 0)
                {
                    ResultLabel.Text = $"{a * b}";
                }
                else
                {
                    DisplayAlert("Błąd", "Liczby muszą być większe od 0", "Ok");
                }
            }
            else
            {
                DisplayAlert("Błąd", "Musisz wpisać jakieś liczby", "Ok");
            }
        }
        private async void ClearCLick(object sender, EventArgs e)
        {
            bool usunac = await DisplayAlert("Uwaga","Czy na pewno chcesz usunac dane","Tak","Nie");

            if (usunac)
            {
                FirstEntry.Text = "";
                SecondEntry.Text = "";
                ResultLabel.Text = "";
            }
            
           

        }
    }
}
