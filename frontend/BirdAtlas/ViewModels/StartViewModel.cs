using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        private int _selectedViewModelIndex = 0;
        public int SelectedViewModelIndex
        {
            get => _selectedViewModelIndex;
            set => SetProperty(ref _selectedViewModelIndex, value);
        }

        public DiscoverViewModel DiscoverViewModel { get; }
        public SearchViewModel SearchViewModel { get; }
        public BookmarkViewModel BookmarkViewModel { get; }

        public StartViewModel(INavigationService navigationService) : base(navigationService)
        {
            DiscoverViewModel = new DiscoverViewModel(NavigationService);
            SearchViewModel = new SearchViewModel(NavigationService);
            BookmarkViewModel = new BookmarkViewModel(NavigationService);
        }
    }
}