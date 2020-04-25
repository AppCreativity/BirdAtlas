using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdAtlas.Extensions;
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

        public Task<IEnumerable<Habitat>> GetHabitatsAsync()
        {
            return null;
        }

        public Task<IEnumerable<Nearby>> GetNearbiesAsync()
        {
            return null;
        }

        public Task<IEnumerable<Story>> GetStoriesAsync()
        {
            return Task.FromResult<IEnumerable<Story>>(_stories);
        }

        public Task<IEnumerable<Story>> GetFeaturedStories(int amount)
        {
            amount = amount > _stories.Count ? _stories.Count : amount;
            return Task.FromResult<IEnumerable<Story>>(_stories.Shuffle().Take(amount));
        }

        public Task<IEnumerable<Story>> GetNewestStories(int amount)
        {
            amount = amount > _stories.Count ? _stories.Count : amount;
            return Task.FromResult<IEnumerable<Story>>(_stories.OrderByDescending(story => story.PublishedOn).Take(amount));
        }

        private void InitStories()
        {
            //https://stackoverflow.com/questions/41160918/xamarin-forms-image-source-with-ssl
            _stories.Add(new Story() { IsFeatured = true, PublishedOn = DateTime.Now, Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/slider_image/public/slider/arcticternb1_markus_varesvuo-2.jpg" });
            _stories.Add(new Story() { IsFeatured = false, PublishedOn = DateTime.Now.AddDays(-1), Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            _stories.Add(new Story() { IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-2), Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            _stories.Add(new Story() { IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-3), Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            _stories.Add(new Story() { IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-4), Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });
            _stories.Add(new Story() { IsFeatured = false, PublishedOn = DateTime.Now.AddDays(-5), Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/blossomcrown_c_martin_mecnarowski_shutterstock_2.jpg" });
        }
    }
}
