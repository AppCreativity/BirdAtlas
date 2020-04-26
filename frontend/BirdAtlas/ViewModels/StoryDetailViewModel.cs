using System;
using BirdAtlas.Models;
using BirdAtlas.Services;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class StoryDetailViewModel : BaseViewModel
    {
        private Story _story;
        public Story Story
        {
            get => _story;
            set => SetProperty(ref _story, value);
        }

        public StoryDetailViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
        }

        public async override void OnNavigatedTo(INavigationParameters parameters)
        {
            string stringID = parameters["id"] as string;

            if (!string.IsNullOrEmpty(stringID) && Guid.Parse(stringID) is Guid id)
                Story = await BirdAtlasAPI.GetStoryAsync(id);
        }
    }
}