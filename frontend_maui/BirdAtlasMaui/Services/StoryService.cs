using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Client;
using BirdAtlasMaui.API.Models;

namespace BirdAtlasMaui.API.Services
{
    public class StoryService : IStoryApi
    {
        private readonly IStoryApi _storyApi;

        public StoryService()
        {
            _storyApi = RestServiceFactory.CreateService<IStoryApi>();
        }

        public Task<List<Story>> Stories(int page = 0, int amount = 10)
        {
            return _storyApi.Stories(page, amount);
        }

        public Task<List<Story>> FeaturedStories(int amount = 10)
        {
            return _storyApi.FeaturedStories(amount);
        }
    }
}