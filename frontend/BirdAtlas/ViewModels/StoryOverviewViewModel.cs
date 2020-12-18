using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BirdAtlas.Models;
using BirdAtlas.Services;
using BirdAtlas.Views;
using Prism.Commands;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class StoryOverviewViewModel : BaseViewModel
    {
        private bool _loaded = false;

        private ObservableCollection<Story> _featuredStories = new ObservableCollection<Story>();
        public ObservableCollection<Story> FeaturedStories
        {
            get => _featuredStories;
            set => SetProperty(ref _featuredStories, value);
        }

        private ObservableCollection<Story> _newStories = new ObservableCollection<Story>();
        public ObservableCollection<Story> NewStories
        {
            get => _newStories;
            set => SetProperty(ref _newStories, value);
        }

        private DelegateCommand<Story> _storyItemTappedCommand;
        public DelegateCommand<Story> StoryItemTappedCommand => _storyItemTappedCommand ?? (_storyItemTappedCommand = new DelegateCommand<Story>(async story => await NavigationService.NavigateAsync($"{nameof(StoryDetailPage)}?id={story.ID}")));

        public StoryOverviewViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
        }

        public override async Task InitializeAsync(INavigationParameters parameters)
        {
            await Task.WhenAll(new List<Task>()
                {
                    { Task.Run(() => GetFeaturedStoriesAsync()) }
                    , { Task.Run(() => GetNewestStoriesAsync()) }
                });
        }

        private async Task GetFeaturedStoriesAsync()
        {
            var featuredStories = await BirdAtlasAPI.GetFeaturedStories(3);
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => FeaturedStories = new ObservableCollection<Story>(featuredStories));
            //foreach (var story in featuredStories)
            //    App.Current.Dispatcher.BeginInvokeOnMainThread(() => FeaturedStories.Add(story));
        }

        private async Task GetNewestStoriesAsync()
        {
            var newStories = await BirdAtlasAPI.GetNewestStories(5);
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => NewStories = new ObservableCollection<Story>(newStories));
            //foreach (var story in newStories)
            //    App.Current.Dispatcher.BeginInvokeOnMainThread(() => NewStories.Add(story));
        }
    }
}