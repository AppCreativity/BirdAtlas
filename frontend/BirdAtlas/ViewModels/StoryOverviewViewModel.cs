using BirdAtlas.Services;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class StoryOverviewViewModel : BaseViewModel
    {
        public StoryOverviewViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
        }
    }
}