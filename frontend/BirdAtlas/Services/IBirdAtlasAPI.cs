using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlas.Models;

namespace BirdAtlas.Services
{
    public interface IBirdAtlasAPI
    {
        Task<Story> GetStoryAsync(Guid id);
        Task<IEnumerable<Story>> GetStoriesAsync();
        Task<IEnumerable<Habitat>> GetHabitatsAsync();
        Task<IEnumerable<Nearby>> GetNearbiesAsync();

        Task<IEnumerable<Story>> GetFeaturedStories(int amount);
        Task<IEnumerable<Story>> GetNewestStories(int amount);        
    }
}
