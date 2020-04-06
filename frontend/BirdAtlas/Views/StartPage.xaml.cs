using System;
using System.Collections.Generic;
using Sharpnado.Presentation.Forms.CustomViews.Tabs;
using Xamarin.Forms;

namespace BirdAtlas.Views
{
    public partial class StartPage : BasePage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void OnTabHostSelectedTabIndexChanged(Object sender, SelectedPositionChangedEventArgs e)
        {
            BasePageTitle = ((BottomTabItem)TabHost.Tabs[TabHost.SelectedIndex]).Label;
        }
    }
}