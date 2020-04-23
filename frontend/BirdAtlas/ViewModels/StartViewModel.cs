using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BirdAtlas.Models;
using BirdAtlas.Services;
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

        public StartViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
            DiscoverViewModel = new DiscoverViewModel(BirdAtlasAPI, NavigationService);
            SearchViewModel = new SearchViewModel(BirdAtlasAPI, NavigationService);
            BookmarkViewModel = new BookmarkViewModel(BirdAtlasAPI, NavigationService);
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            await Task.WhenAll(new List<Task>()
            {
                { Task.Run(() => GetStoriesAsync()) }
                //, { Task.Run(() => BirdAtlasAPI.GetHabitatsAsync()) }
                //, { Task.Run(() => BirdAtlasAPI.GetNearbiesAsync()) }
            });
        }

        private async Task GetStoriesAsync()
        {
            var stories = await BirdAtlasAPI.GetStoriesAsync();
            foreach (var story in stories)
                App.Current.Dispatcher.BeginInvokeOnMainThread(() => DiscoverViewModel.Stories.Add(story));
        }
    }
}