using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using BirdAtlas.Models;
using BirdAtlas.Services;
using BirdAtlas.Views;
using Prism.Commands;
using Prism.Navigation;

namespace BirdAtlas.ViewModels
{
    public class DiscoverViewModel : BaseViewModel
    {
        private ObservableCollection<Story> _stories = new ObservableCollection<Story>();
        public ObservableCollection<Story> Stories
        {
            get => _stories;
            set => SetProperty(ref _stories, value);
        }

        private ObservableCollection<Habitat> _habitats = new ObservableCollection<Habitat>();
        public ObservableCollection<Habitat> Habitats
        {
            get => _habitats;
            set => SetProperty(ref _habitats, value);
        }

        private ObservableCollection<Nearby> _nearbyBirds = new ObservableCollection<Nearby>();
        public ObservableCollection<Nearby> NearbyBirds
        {
            get => _nearbyBirds;
            set => SetProperty(ref _nearbyBirds, value);
        }

        private DelegateCommand _storiesTappedCommand;
        public DelegateCommand StoriesTappedCommand => _storiesTappedCommand ?? (_storiesTappedCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync(nameof(StoryOverviewPage))));

        private DelegateCommand<Story> _storyTappedCommand;
        public DelegateCommand<Story> StoryTappedCommand => _storyTappedCommand ?? (_storyTappedCommand = new DelegateCommand<Story>(async (Story story) => await NavigationService.NavigateAsync($"{nameof(StoryDetailPage)}")));

        public DiscoverViewModel(IBirdAtlasAPI birdAtlasAPI, INavigationService navigationService) : base(birdAtlasAPI, navigationService)
        {
            Habitats.Add(new Habitat() { Name = "Forests", Type = HabitatType.Forest, Amount = 290 });
            Habitats.Add(new Habitat() { Name = "Tundra", Type = HabitatType.Tundra, Amount = 311 });
            Habitats.Add(new Habitat() { Name = "Deserts", Type = HabitatType.Desert, Amount = 307 });

            NearbyBirds.Add(new Nearby() { Name = "Eurasian hoopoe", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/canada_warbler_borb_c_steve_jones.jpg" });
            NearbyBirds.Add(new Nearby() { Name = "Short-eared owl", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/black-breasted_puffleg_branch_c_murray_cooper_1.jpg" });
            NearbyBirds.Add(new Nearby() { Name = "Raven", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/marsh_antwren_c_marco_silva.jpg" });
            NearbyBirds.Add(new Nearby() { Name = "Pigeon", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/Fujingaho_Magazine/Fujingaho202001/fg2002_jpgjing_sayan_fg2001_taka_01_01.jpg" });
        }
    }
}