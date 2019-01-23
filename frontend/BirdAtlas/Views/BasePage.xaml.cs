using System;
using System.Collections.Generic;
using BirdAtlas.Controls;
using BirdAtlas.Framework;
using BirdAtlas.Models;
using Xamarin.Forms;

namespace BirdAtlas.Views
{
    public partial class BasePage : ContentPage
    {
        public IList<View> BasePageContent => BaseContentGrid.Children;

        #region Bindable properties
        public static readonly BindableProperty BasePageTitleProperty =
            BindableProperty.Create(nameof(BasePageTitle), typeof(string), typeof(BasePage), string.Empty, defaultBindingMode: BindingMode.OneWay, propertyChanged: OnBasePageTitleChanged);

        public static readonly BindableProperty HideTabbarProperty =
            BindableProperty.Create(nameof(HideTabbar), typeof(bool), typeof(BasePage), false);

        public static readonly BindableProperty PageModeProperty =
            BindableProperty.Create(nameof(PageMode), typeof(PageMode), typeof(BasePage), PageMode.None, propertyChanged: OnPageModePropertyChanged);

        public static readonly BindableProperty PageActionProperty =
            BindableProperty.Create(nameof(PageMode), typeof(PageAction), typeof(BasePage), PageAction.None, propertyChanged: OnPageActionPropertyChanged);

        public static readonly BindableProperty PageTabModeProperty =
            BindableProperty.Create(nameof(PageTabMode), typeof(PageTabMode), typeof(BasePage), PageTabMode.None, propertyChanged: OnPageTabModePropertyChanged);

        public string BasePageTitle
        {
            get => (string)GetValue(BasePageTitleProperty);
            set => SetValue(BasePageTitleProperty, value);
        }

        public bool HideTabbar
        {
            get => (bool)GetValue(HideTabbarProperty);
            set => SetValue(HideTabbarProperty, value);
        }

        public PageMode PageMode
        {
            get => (PageMode)GetValue(PageModeProperty);
            set => SetValue(PageModeProperty, value);
        }

        public PageAction PageAction
        {
            get => (PageAction)GetValue(PageActionProperty);
            set => SetValue(PageActionProperty, value);
        }

        public PageTabMode PageTabMode
        {
            get => (PageTabMode)GetValue(PageTabModeProperty);
            set => SetValue(PageTabModeProperty, value);
        }

        private static void OnBasePageTitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.TitleLabel.Text = (string)newValue;
        }

        private static void OnPageModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.SetPageMode((PageMode)newValue);
        }

        private static void OnPageActionPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.SetPageAction((PageAction)newValue);
        }

        private static void OnPageTabModePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BasePage basePage)
                basePage.SetPageTabMode((PageTabMode)newValue);
        }
        #endregion

        public BasePage()
        {
            InitializeComponent();

            //Hide the Xamarin Forms build in navigation header
            NavigationPage.SetHasNavigationBar(this, false);

            //Initialize the page mode
            SetPageMode(PageMode.None);

            //Initialize the page action
            SetPageAction(PageAction.None);

            //Fix top page marging requirement depending on the current device running the app
            StatusRowDefinition.Height = DependencyService.Get<IDeviceInfo>().StatusbarHeight;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var mainPage = App.Current.MainPage as CustomTabbedPage;
            mainPage.IsHidden = HideTabbar;

            SetPageTabMode(PageTabMode);
        }

        private void SetPageMode(PageMode pageMode)
        {
            //((ViewModelBase)BindingContext).PageMode = pageMode;

            switch (pageMode)
            {
                case PageMode.Menu:
                    //HamburgerButton.IsVisible = true;
                    NavigateBackButton.IsVisible = false;
                    //CloseButton.IsVisible = false;
                    break;
                case PageMode.Navigate:
                    //HamburgerButton.IsVisible = false;
                    NavigateBackButton.IsVisible = true;
                    //CloseButton.IsVisible = false;
                    break;
                case PageMode.Modal:
                    //HamburgerButton.IsVisible = false;
                    NavigateBackButton.IsVisible = false;
                    //CloseButton.IsVisible = true;
                    break;
                default:
                    //HamburgerButton.IsVisible = false;
                    NavigateBackButton.IsVisible = false;
                    break;
            }

            //HandleHamburgerMenuGesture(PageMode == PageMode.Menu);
        }

        private void SetPageAction(PageAction pageAction)
        {
            switch(pageAction)
            {
                case PageAction.Settings:
                    SettingsButton.IsVisible = true;
                    break;
                default:
                    SettingsButton.IsVisible = false;
                    break;
            }
        }

        private void SetPageTabMode(PageTabMode pageTabMode)
        {
            if(App.Current.MainPage is CustomTabbedPage mainPage)
                mainPage.PageTabMode = pageTabMode;
        }
    }
}