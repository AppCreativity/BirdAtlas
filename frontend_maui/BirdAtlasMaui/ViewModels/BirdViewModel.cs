using System;
using BirdAtlasMaui.API.Models;

namespace BirdAtlasMaui.ViewModels
{
    public class BirdViewModel : BaseViewModel
    {
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

        public BirdViewModel()
        {
        }
    }
}
