using System.Collections.ObjectModel;

namespace tem9zad2i3
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> listaZakupow = new ObservableCollection<string>();
        int LiczbaElementow=0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AddEntry.Text))
            {

                listaZakupow.Add(AddEntry.Text);
                ListaView.ItemsSource = listaZakupow;
                AddEntry.Text = "";
                LiczbaElementow++;
                CountLabel.Text = $"Liczba elementów: {LiczbaElementow}";

            }

        }

        private void DeleteClick(object sender, EventArgs e)
        {

            if(ListaView.SelectedItem != null)
            {

                string Zaznaczony = (string)ListaView.SelectedItem;
                listaZakupow.Remove(Zaznaczony);
                LiczbaElementow--;
                CountLabel.Text = $"Liczba elementów: {LiczbaElementow}";
            }
            

        }
    }
}
