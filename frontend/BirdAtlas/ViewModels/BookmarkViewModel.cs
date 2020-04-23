using System;
using BirdAtlas.Services;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class BookmarkViewModel : BaseViewModel
    {
        public BookmarkViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
        }
    }
}