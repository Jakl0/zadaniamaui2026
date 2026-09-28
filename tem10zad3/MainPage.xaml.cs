using System.ComponentModel;

namespace tem10zad3
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
          
        }
        private void ChangeGreyClicked(object sender, EventArgs e)
        {
            Content.BackgroundColor = Color.FromRgb(Suwaczek.Value/255, Suwaczek.Value/255, Suwaczek.Value/255);
            if(Suwaczek.Value < 120)
            {
                ValueLabel.TextColor = Color.FromRgb(255, 255, 255);
            }
            else
            {
                ValueLabel.TextColor = Color.FromRgb(0,0 ,0);
            }
        }
        
    }
    
}
