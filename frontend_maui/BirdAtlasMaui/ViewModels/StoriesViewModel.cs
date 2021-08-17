using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;
using Polly;

namespace BirdAtlasMaui.ViewModels
{
    public class StoriesViewModel : BaseViewModel
    {
        private IStoryApi _storyService;

        private ObservableCollection<Story> _stories;
        public ObservableCollection<Story> Stories
        {
            get => _stories;
            set
            {
                if (value != null)
                {
                    _stories = value;
                    OnPropertyChanged();
                }
            }
        }

        public StoriesViewModel(IStoryApi storyService)
        {
            _storyService = storyService;
        }

        public async Task Load()
        {
            //var stories = await _storyService.Stories();
            //var stories = await Policy.Handle<WebException>().WaitAndRetryAsync(retryCount: 3, sleepDurationProvider: retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt))).ExecuteAsync(async () => await _storyService.Stories());

            var stories = await Policy<List<Story>>
                .Handle<WebException>()
                .FallbackAsync(async (System.Threading.CancellationToken arg) => await _storyService.FeaturedStories())
                .ExecuteAsync(async () => await _storyService.Stories());

            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Stories = new ObservableCollection<Story>(stories));
        }
    }
}
