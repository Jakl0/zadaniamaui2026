

namespace tem6zad3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if(przycisk.Text == "Minus")
            {
                if(count > 0) count--;

            }
            else if(przycisk.Text == "Plus")
            {
                count++;
            }
            else
            {
                count = 0;
            }
            DisplayLabel.Text = $"{count}";
        }
    }
}
