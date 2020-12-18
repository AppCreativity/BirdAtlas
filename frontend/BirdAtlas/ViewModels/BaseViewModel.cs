using System;
using System.Threading.Tasks;
using BirdAtlas.Services;
using BirdAtlas.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware, IInitializeAsync
    {
        protected INavigationService NavigationService { get; private set; }
        protected IBirdAtlasAPI BirdAtlasAPI { get; private set; }

        private DelegateCommand _navigateBackCommand;
        public DelegateCommand NavigateBackCommand => _navigateBackCommand ?? (_navigateBackCommand = new DelegateCommand(async () => await NavigationService.GoBackAsync()));

        private DelegateCommand _settingsCommand;
        public DelegateCommand SettingsCommand => _settingsCommand ?? (_settingsCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("SettingsPage")));

        public BaseViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService)
        {
            BirdAtlasAPI = birdAtlasAPI;
            NavigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public virtual async Task InitializeAsync(INavigationParameters parameters)
        {
        }
    }
}