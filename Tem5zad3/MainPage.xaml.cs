namespace Tem5zad3
{
    public partial class MainPage : ContentPage
    {

        List<string> sale = new List<string>();
        string pickervalue;
        DateTime datevalue = DateTime.Now;
        double steppervalue=1;
        public MainPage()
        {
            sale = new List<string>();
            sale.Add("Sala A");
            sale.Add("Sala B");
            sale.Add("Sala C");

            InitializeComponent();
            SalaPicker.ItemsSource = sale;
        }

        private void PickerChange(object sender, EventArgs e)
        {
            pickervalue = SalaPicker.SelectedItem?.ToString();
        }

        private void StepperChange(object sender, ValueChangedEventArgs e)
        {
            steppervalue = LiczbaOsob.Value;
            StepperLabel.Text = $": {steppervalue}";
        }

        private void DateChange(object sender, DateChangedEventArgs e)
        {
            datevalue = (DateTime)e.NewDate;  
        }

        private void ReserveClicked(object sender, EventArgs e)
        {
            if(pickervalue == null)
            {
                DisplayAlert("Błąd", "Musisz wybrać jakąś salę", "Ok");
            }
            else
            {
                DisplayLabel.Text = $"Wybrano {pickervalue}; liczba osob {steppervalue}; Data {datevalue:dd.MM.yyyy}";
            }
            
            
        }

    }
}
