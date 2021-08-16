using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using Refit;

namespace BirdAtlasMaui.API.Services
{
    [Headers("Accept: application/json")]
    public interface IHabitatApi
    {
        [Get("/habitats")]
        Task<List<Habitat>> Habitats();
    }
}
