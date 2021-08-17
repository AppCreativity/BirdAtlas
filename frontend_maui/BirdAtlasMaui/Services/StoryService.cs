using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Client;
using BirdAtlasMaui.API.Models;

namespace BirdAtlasMaui.API.Services
{
    public class StoryService : IStoryApi
    {
        private readonly IStoryApi _storyApi;
        private int _retry = 0;

        public StoryService()
        {
            _storyApi = RestServiceFactory.CreateService<IStoryApi>();
        }

        public Task<List<Story>> Stories(int page = 0, int amount = 10)
        {
            if (amount == 10)
                ++_retry;

            if (_retry < 3)
                return _storyApi.Stories(page, amount);
            else
            {
                _retry = 0;
                throw new WebException("Return dummy exception for debugging purpose");
            }
        }

        public Task<List<Story>> FeaturedStories(int amount = 10)
        {
            return _storyApi.FeaturedStories(amount);
        }
    }
}