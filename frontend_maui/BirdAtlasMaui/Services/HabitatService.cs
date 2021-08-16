using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Client;
using BirdAtlasMaui.API.Models;

namespace BirdAtlasMaui.API.Services
{
    public class HabitatService : IHabitatApi
    {
        private readonly IHabitatApi _habitatApi;

        public HabitatService()
        {
            _habitatApi = RestServiceFactory.CreateService<IHabitatApi>();
        }

        public Task<List<Habitat>> Habitats()
        {
            return _habitatApi.Habitats();
        }
    }
}
