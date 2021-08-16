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
        private bool _loaded = false;

        private IStoryApi _storyService;
        private IHabitatApi _habitatService;
        private IBirdApi _birdService;

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

        private ObservableCollection<Habitat> _habitats;
        public ObservableCollection<Habitat> Habitats
        {
            get => _habitats;
            set
            {
                if (value != null)
                {
                    _habitats = value;
                    OnPropertyChanged();
                }
            }
        }

        private ObservableCollection<Bird> _birds;
        public ObservableCollection<Bird> Birds
        {
            get => _birds;
            set
            {
                if (value != null)
                {
                    _birds = value;
                    OnPropertyChanged();
                }
            }
        }        

        public MainViewModel(IStoryApi storyService, IHabitatApi habitatApi, IBirdApi birdApi)
        {
            _storyService = storyService;
            _habitatService = habitatApi;
            _birdService = birdApi;
        }

        public async Task Load()
        {
            if (!_loaded)
            {
                await Task.WhenAll(new List<Task>()
                {
                    { Task.Run(() => GetStoriesAsync()) },
                    { Task.Run(() => GetHabitatsAsync()) },
                    { Task.Run(() => GetBirdsAsync()) }
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

        private async Task GetHabitatsAsync()
        {
            var habitats = await _habitatService.Habitats();
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Habitats = new ObservableCollection<Habitat>(habitats));
        }

        private async Task GetBirdsAsync()
        {
            var birds = await _birdService.Birds();
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Birds = new ObservableCollection<Story>(birds));
        }        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}