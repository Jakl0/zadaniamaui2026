namespace tem4zad2i3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SignUpClicked(object sender , EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameEntry.Text))
            {
                string boxvalue;
                string switchvalue;
                if (wiedzaBox.IsChecked)
                {
                    boxvalue = "Tak";
                }
                else
                {
                    boxvalue = "Nie";
                }


                if (certyfikatSwitch.IsToggled)
                {
                    switchvalue = "Tak";
                }
                else
                {
                    switchvalue = "Nie";
                }
                string rodzajkursu = "Online";
                if (OpcjaStac.IsChecked)
                {
                    rodzajkursu = "Stacjonarny";
                }
                if (OpcjaOnline.IsChecked)
                {
                    rodzajkursu = "Online";
                }
                if (OpcjaHybrid.IsChecked)
                {
                    rodzajkursu = "Hybrydowy";
                }





                SummaryLabel.Text = $"{NameEntry.Text} \nCzy posiadasz wiedzę: {boxvalue} \nCzy chcesz otrzymać certyfikat: {switchvalue} \nRodzaj kursu: {rodzajkursu} \nOczekiwania:{ExpectationEditor.Text} ";
            }
            else
            {
                SummaryLabel.Text = "Podaj imię i nazwisko";
            }
        }

        
    }
}
