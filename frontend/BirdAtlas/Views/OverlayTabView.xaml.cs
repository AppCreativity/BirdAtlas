using Xamarin.Forms;

namespace BirdAtlas.Views
{
    public partial class OverlayTabView : ContentView
    {
        public OverlayTabView()
        {
            InitializeComponent();
        }

        private void OnDiscoveryClicked(object sender, System.EventArgs e)
        {
            if(App.Current.MainPage is TabbedPage mainPage && sender is Button button)
                mainPage.CurrentPage = mainPage.Children[0];
        }

        private void OnSearchClicked(object sender, System.EventArgs e)
        {
            if (App.Current.MainPage is TabbedPage mainPage && sender is Button button)
                mainPage.CurrentPage = mainPage.Children[1];
        }

        private void OnBookmarksClicked(object sender, System.EventArgs e)
        {
            if (App.Current.MainPage is TabbedPage mainPage && sender is Button button)
                mainPage.CurrentPage = mainPage.Children[2];
        }
    }
}