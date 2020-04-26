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

        public Task<Story> GetStoryAsync(Guid id)
        {
            return Task.FromResult<Story>(_stories.FirstOrDefault(i => i.ID == id));
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
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = true, PublishedOn = DateTime.Now, Author = "Menno Schilthuizen", Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/slider_image/public/slider/arcticternb1_markus_varesvuo-2.jpg" });
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = false, PublishedOn = DateTime.Now.AddDays(-1), Author = "Menno Schilthuizen", Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/little_spiderhunter_c_noicherrybeans_shutterstock_smaller_1.jpg" });
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-2), Author = "Menno Schilthuizen", Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/canada_warbler_c_jayne_gulbrand_smaller.jpg" });
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-3), Author = "Menno Schilthuizen", Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://cdn.images.express.co.uk/img/dynamic/13/590x/549233_1.jpg" });
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = true, PublishedOn = DateTime.Now.AddDays(-4), Author = "Menno Schilthuizen", Category = "The Wilds", Title = "Why we need to save the scavengers?", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/full_620x295/public/news/rufous_hummingbird_selasphorus_rufus_c_ryan_bushby_1.jpg" });
            _stories.Add(new Story() { ID = Guid.NewGuid(), IsFeatured = false, PublishedOn = DateTime.Now.AddDays(-5), Author = "Menno Schilthuizen", Category = "Science", Title = "Drunk birds? What is happening...", ImageUrl = "http://www.birdlife.org/sites/default/files/styles/third_thumbnail_360x170/public/news/blossomcrown_c_martin_mecnarowski_shutterstock_2.jpg" });

            foreach (var story in _stories)
                story.Content = "A crumbling concrete wall, a ramp and a vast expanse of asphalt on which identical silvery-grey sedans are slowly circling and zigzagging between traffic cones. It does not seem like much but, to urban biologists, the Kadan driving school in the Japanese city of Sendai is hallowed ground. The four of us (the biology students Minoru Chiba and Yawara Takeda, the biologist Iva Njunjić, and I) have been sitting on that crumbling wall for several hours now, hoping to observe what this place is famous for.\r\n\r\nIt was here that, in 1975, the local carrion crows (Corvus corone) discovered how to use cars as nutcrackers. The crows have a predilection for the Japanese walnut (Juglans ailantifolia) that grows abundantly in the city. The pretty nuts (a bit smaller than commercial walnuts";
        }
    }
}
