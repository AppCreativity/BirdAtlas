using System;
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
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", Image = new Uri("http://placekitten.com/g/200/100") });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", Image = new Uri("http://placekitten.com/g/200/100") });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", Image = new Uri("http://placekitten.com/g/200/100") });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", Image = new Uri("http://placekitten.com/g/200/100") });
            Stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", Image = new Uri("http://placekitten.com/g/200/100") });
            Stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", Image = new Uri("http://placekitten.com/g/200/100") });
        }
    }
}