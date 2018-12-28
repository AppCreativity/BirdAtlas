using System.Collections.Generic;
using BirdAtlas.Framework;
using Xamarin.Forms;

namespace BirdAtlas.Views
{
    public partial class BasePage : ContentPage
    {
        public IList<View> BasePageContent => BaseContentGrid.Children;

        #region Bindable properties
        public static readonly BindableProperty BasePageTitleProperty =
            BindableProperty.Create(nameof(BasePageTitle), typeof(string), typeof(BasePage), string.Empty, defaultBindingMode: BindingMode.OneWay, propertyChanged: OnBasePageTitleChanged);

        //public static readonly BindableProperty PageModeProperty =
            //BindableProperty.Create(nameof(PageMode), typeof(PageMode), typeof(BasePage), PageMode.None, propertyChanged: OnPageModePropertyChanged);

        public string BasePageTitle
        {
            get => (string)GetValue(BasePageTitleProperty);
            set => SetValue(BasePageTitleProperty, value);
        }

        //public PageMode PageMode
        //{
        //    get => (PageMode)GetValue(PageModeProperty);
        //    set => SetValue(PageModeProperty, value);
        //}

        private static void OnBasePageTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable != null && bindable is BasePage basePage)
                basePage.TitleLabel.Text = (string)newValue;
        }

        //private static void OnPageModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    if (bindable != null && bindable is BasePage basePage)
        //        basePage.SetPageMode((PageMode)newValue);
        //}
        #endregion

        public BasePage()
        {
            InitializeComponent();

            //Hide the Xamarin Forms build in navigation header
            NavigationPage.SetHasNavigationBar(this, false);

            //Fix top page marging requirement depending on the current device running the app
            StatusRowDefinition.Height = DependencyService.Get<IDeviceInfo>().StatusbarHeight;
        }
    }
}