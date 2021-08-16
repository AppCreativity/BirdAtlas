using System;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;

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

        public BirdViewModel(IBirdApi birdApi)
        {
            _birdService = birdApi;
        }

        public async Task Load()
        {
            var bird = await _birdService.Bird(Bird.Id);
        }
    }
}
