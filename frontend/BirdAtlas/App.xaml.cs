using BirdAtlas.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using BirdAtlas.ViewModels;
using BirdAtlas.Services;

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

            Sharpnado.Tabs.Initializer.Initialize(false, false);
            Sharpnado.Shades.Initializer.Initialize(false);
            Sharpnado.HorizontalListView.Initializer.Initialize(false, false);

            await NavigationService.NavigateAsync("NavigationPage/StartPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IBirdAtlasAPI, BirdAtlasMockAPI>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<BasePage, BaseViewModel>();
            containerRegistry.RegisterForNavigation<StartPage, StartViewModel>();
            containerRegistry.RegisterForNavigation<StoryOverviewPage, StoryOverviewViewModel>();
            containerRegistry.RegisterForNavigation<StoryDetailPage, StoryDetailViewModel>();
            containerRegistry.RegisterForNavigation<SettingsPage, SettingsViewModel>();
        }
    }
}