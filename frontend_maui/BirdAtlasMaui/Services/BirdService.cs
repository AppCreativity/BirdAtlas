using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Client;
using BirdAtlasMaui.API.Models;

namespace BirdAtlasMaui.API.Services
{
    public class BirdService : IBirdApi
    {
        private readonly IBirdApi _birdApi;

        public BirdService()
        {
            _birdApi = RestServiceFactory.CreateService<IBirdApi>();
        }

        public Task<List<Bird>> Birds(int page = 0, int amount = 10)
        {
            return _birdApi.Birds(page, amount);
        }
    }
}