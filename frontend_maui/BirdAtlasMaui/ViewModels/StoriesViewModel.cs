using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using BirdAtlasMaui.API.Services;

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
            var stories = await _storyService.Stories();
            App.Current.Dispatcher.BeginInvokeOnMainThread(() => Stories = new ObservableCollection<Story>(stories));
        }
    }
}
