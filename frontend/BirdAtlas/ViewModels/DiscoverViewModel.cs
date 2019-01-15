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
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "https://www.birdlife.org/sites/default/files/styles/1600/public/news/european_turtle_dove_streptopelia_turtur_websitec_revital_salomon.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "https://i.kinja-img.com/gawker-media/image/upload/s--CWKHA2W9--/c_scale,f_auto,fl_progressive,q_80,w_800/yxeok4wpwe54cn9y05j1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "https://d1ia71hq4oe7pn.cloudfront.net/og/75335251-1200px.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl= "https://thumbs-prod.si-cdn.com/Ydqvo3gkyR7me97ovoMWJqwpsHM=/800x600/filters:no_upscale():focal(331x308:332x309)/https://public-media.si-cdn.com/filer/74/87/748780b7-1b70-4a98-904d-e37ac8cd3622/cardinal.jpg" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl= "https://cdn.pixabay.com/photo/2017/02/07/16/47/kingfisher-2046453_960_720.jpg" });
        }
    }
}