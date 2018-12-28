using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class BaseViewModel : BindableBase, INavigationAware
    {
        protected INavigationService NavigationService { get; private set; }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }
    }
}