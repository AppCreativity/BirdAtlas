using System.Collections.ObjectModel;
using BirdAtlas.Models;
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

        public DiscoverViewModel(INavigationService navigationService) : base(navigationService)
        {
            //https://stackoverflow.com/questions/41160918/xamarin-forms-image-source-with-ssl
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/1600/public/news/european_turtle_dove_streptopelia_turtur_websitec_revital_salomon.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/shutterstock_459632779.jpg" });
        }
    }
}