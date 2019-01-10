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
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening..." });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening..." });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?" });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening..." });
        }
    }
}