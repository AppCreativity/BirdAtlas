using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlas.Models;

namespace BirdAtlas.Services
{
    public interface IBirdAtlasAPI
    {
        Task<List<Story>> GetStoriesAsync();
        Task<List<Habitat>> GetHabitatsAsync();
        Task<List<Nearby>> GetNearbiesAsync();
    }
}
