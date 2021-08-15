using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;

namespace BirdAtlasMaui.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        bool _loaded = false;
        private IStoryApi _storyService;

        private ObservableCollection<Story> _stories = new ObservableCollection<Story>();

        public event PropertyChangedEventHandler PropertyChanged;

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

        public MainViewModel(IStoryApi storyService)
        {
            _storyService = storyService;
        }

        public async Task Load()
        {
            if (!_loaded)
            {
                await Task.WhenAll(new List<Task>()
                {
                    { Task.Run(() => GetStoriesAsync()) }
                });
                _loaded = true;
            }
        }

        private async Task GetStoriesAsync()
        {
            var stories = await _storyService.Stories();
            stories.Add(stories[0]);
            stories.Add(stories[0]);
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Stories = new ObservableCollection<Story>(stories));
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}