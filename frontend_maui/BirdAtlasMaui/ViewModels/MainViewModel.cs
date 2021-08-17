using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;
using BirdAtlasMaui.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls;

namespace BirdAtlasMaui.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private bool _loaded = false;

        private IServiceProvider _serviceProvider;
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

        private Bird _selectedBird;
        public Bird SelectedBird
        {
            get => _selectedBird;
            set
            {
                if (value != null)
                {
                    _selectedBird = value;
                    OnPropertyChanged();

                    var birdPage = new BirdPage(_serviceProvider.GetRequiredService<BirdViewModel>());
                    ((BirdViewModel)birdPage.BindingContext).Bird = _selectedBird;

                    (App.Current.MainPage as NavigationPage).PushAsync(birdPage);
                }
            }
        }

        private ICommand _showAllStoriesCommand;
        public ICommand ShowAllStoriesCommand => _showAllStoriesCommand ?? (_showAllStoriesCommand = new Command(() =>
        {
            var storiesPage = new StoriesPage(_serviceProvider.GetRequiredService<StoriesViewModel>());
            (App.Current.MainPage as NavigationPage).PushAsync(storiesPage);
        }));

        public MainViewModel(IServiceProvider serviceProvider, IStoryApi storyService, IHabitatApi habitatApi, IBirdApi birdApi)
        {
            _serviceProvider = serviceProvider;
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
            var stories = await _storyService.Stories(0, 5);

            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Stories = new ObservableCollection<Story>(stories));
        }

        private async Task GetHabitatsAsync()
        {
            var habitats = await _habitatService.Habitats();
            habitats.Add(habitats[0]);
            habitats.Add(habitats[0]);

            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Habitats = new ObservableCollection<Habitat>(habitats));
        }

        private async Task GetBirdsAsync()
        {
            var birds = await _birdService.Birds();
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Birds = new ObservableCollection<Bird>(birds));
        }
    }
}