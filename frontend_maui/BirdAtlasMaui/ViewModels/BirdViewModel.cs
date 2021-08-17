using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;
using Microsoft.Maui.Controls;

namespace BirdAtlasMaui.ViewModels
{
    public class BirdViewModel : BaseViewModel
    {
        private IBirdApi _birdService;

        private Bird _bird;
        public Bird Bird
        {
            get => _bird;
            set
            {
                _bird = value;
                OnPropertyChanged();
            }
        }

        private ICommand _favoriteCommand;
        public ICommand FavoriteCommand => _favoriteCommand ?? (_favoriteCommand = new Command(async () => await Favorite()));

        public BirdViewModel(IBirdApi birdApi)
        {
            _birdService = birdApi;
        }

        public async Task Load()
        {
            var bird = await _birdService.Bird(Bird.Id);
        }

        public Task Favorite()
        {
            return _birdService.Bird(Bird.Id, true);
        }
    }
}
