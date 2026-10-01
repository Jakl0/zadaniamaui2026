namespace tem12zad2i3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void NumerOpuszczony(object sender, FocusEventArgs e)

        {

            string numer = poleNumer.Text;



            // Gdy pole jest puste, nie probujemy ladowac obrazow 

            if (string.IsNullOrWhiteSpace(numer))

            {

                obrazZdjecie.Source = null;

                obrazOdcisk.Source = null;

                return;

            }



            // Skladamy nazwy plikow z numeru, np. 333 –> 333–zdjecie.jpg 

            obrazZdjecie.Source = numer + "–zdjecie.jpg";

            obrazOdcisk.Source = numer + "–odcisk.jpg";

        }



        // Metoda wywolywana po kliknieciu przycisku OK. 

        // Sprawdza wypelnienie pol i wyswietla odpowiedni komunikat. 

        private async void ZatwierdzDane(object sender, EventArgs e)

        {

            string imie = poleImie.Text;

            string nazwisko = poleNazwisko.Text;

            string numer = poleNumer.Text;



            // Walidacja: imie i nazwisko musza byc wpisane 

            if (string.IsNullOrWhiteSpace(numer))
            {
                await DisplayAlert("Uwaga","Wprowadz numer","OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))

            {

                await DisplayAlert("Uwaga", "Wprowadz dane", "OK");

                return;

            }



            // Ustalamy zaznaczony kolor oczu na podstawie pol wyboru 

            string kolorOczu = PobierzKolorOczu();



            string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

            await DisplayAlert("Dane paszportowe", komunikat, "OK");



        }



        // Metoda pomocnicza zwracajaca nazwe zaznaczonego koloru oczu 

        private string PobierzKolorOczu()

        {

            if (oczyNiebieskie.IsChecked)

                return "niebieskie";

            if (oczyZielone.IsChecked)

                return "zielone";
            if (oczySzare.IsChecked)
                return "szare";

            return "piwne";

        }

        private void WyczyscDane(object sender , EventArgs e)
        {
            oczyNiebieskie.IsChecked = true;

            poleImie.Text = "";
            poleNazwisko.Text = "";
            poleNumer.Text = "";

            obrazZdjecie.Source = null;
            obrazOdcisk.Source = null;
        }

    }
}
