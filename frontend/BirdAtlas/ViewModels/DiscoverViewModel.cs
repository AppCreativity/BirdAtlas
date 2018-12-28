using System;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        private ICommand _settingsCommand;
        public ICommand SettingsCommand => _settingsCommand ?? (_settingsCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("SettingsPage")));

        public DiscoverViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}