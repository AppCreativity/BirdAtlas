using BirdAtlas.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using BirdAtlas.ViewModels;
using Sharpnado.Presentation.Forms.CustomViews.Tabs;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BirdAtlas
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer platformInitializer) : base(platformInitializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/StartPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<BasePage, BaseViewModel>();
            containerRegistry.RegisterForNavigation<StartPage, StartViewModel>();
            containerRegistry.RegisterForNavigation<StoryDetailPage, StoryDetailViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsViewModel>();
        }
    }
}