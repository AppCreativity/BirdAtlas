using Xamarin.Forms;

namespace BirdAtlas.Views
{
    public partial class OverlayTabView : ContentView
    {
        public OverlayTabView()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            if(App.Current.MainPage is TabbedPage mainPage && sender is Button button)
            {
                var tab = int.Parse(button.Text[button.Text.Length -1].ToString());
                mainPage.CurrentPage = mainPage.Children[tab];
            }
        }
    }
}