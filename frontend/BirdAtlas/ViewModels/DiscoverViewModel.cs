using System.Collections.ObjectModel;
using BirdAtlas.Models;
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

        public DiscoverViewModel(INavigationService navigationService) : base(navigationService)
        {
            //https://stackoverflow.com/questions/41160918/xamarin-forms-image-source-with-ssl
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/slider_image/public/slider/arcticternb1_markus_varesvuo-2.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/blossomcrown_c_martin_mecnarowski_shutterstock_2.jpg" });

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