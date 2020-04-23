using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlas.Models;

namespace BirdAtlas.Services
{
    public class BirdAtlasMockAPI : IBirdAtlasAPI
    {
        private List<Story> _stories = new List<Story>();

        public BirdAtlasMockAPI()
        {
            InitStories();
        }

        public Task<List<Habitat>> GetHabitatsAsync()
        {
            return null;
        }

        public Task<List<Nearby>> GetNearbiesAsync()
        {
            return null;
        }

        public Task<List<Story>> GetStoriesAsync()
        {
            return Task.FromResult<List<Story>>(_stories);
        }

        private void InitStories()
        {
            //https://stackoverflow.com/questions/41160918/xamarin-forms-image-source-with-ssl
            _stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/slider_image/public/slider/arcticternb1_markus_varesvuo-2.jpg" });
            _stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            _stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            _stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            _stories.Add(new Story() { Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });
            _stories.Add(new Story() { Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/blossomcrown_c_martin_mecnarowski_shutterstock_2.jpg" });
        }
    }
}
