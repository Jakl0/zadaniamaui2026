namespace tem11zad2i3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()

        {

            InitializeComponent();

            // Po starcie ustawiamy duzy prostokat na kolor wynikajacy z suwakow 

            AktualizujDuzyProstokat();

        }



        // Metoda obslugujaca zmiane dowolnego z trzech suwakow. 

        // Jeden uchwyt obsluguje wszystkie suwaki, bo logika jest taka sama. 

        private void SuwakZmieniony(object sender, ValueChangedEventArgs e)

        {

            AktualizujDuzyProstokat();

        }



        // Metoda pomocnicza: czyta wartosci suwakow, aktualizuje etykiety 

        // wartosci oraz ustawia kolor duzego prostokata. 

        private void AktualizujDuzyProstokat()

        {

            // Suwak zwraca wartosc typu double, kolor potrzebuje calkowitej 0–255 

            int r = (int)suwakR.Value;

            int g = (int)suwakG.Value;

            int b = (int)suwakB.Value;



            // Aktualizujemy etykiety z wartosciami po prawej stronie suwakow 

            etykietaR.Text = r.ToString();

            etykietaG.Text = g.ToString();

            etykietaB.Text = b.ToString();



            // Color.FromRgb tworzy kolor z trzech skladowych calkowitych 

            duzyProstokat.Color = Color.FromRgb(r, g, b);

        }



        // Metoda obslugujaca klikniecie przycisku Pobierz. 

        // Zapisuje aktualny kolor do malego prostokata wraz z tekstem. 

        private void PobierzKolor(object sender, EventArgs e)

        {

            int r = (int)suwakR.Value;

            int g = (int)suwakG.Value;

            int b = (int)suwakB.Value;



            // Maly prostokat to Border, wiec ustawiamy jego tlo 

            // Border znajduje sie wokol etykiety etykietaPobrany 

            if (etykietaPobrany.Parent is Border ramka)

            {

                ramka.BackgroundColor = Color.FromRgb(r, g, b);

            }



            // Ustawiamy tekst w formacie wymaganym przez arkusz: "R, G, B" 

            etykietaPobrany.Text = r + ", " + g + ", " + b;

        }
    }
}
