using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using Refit;

namespace BirdAtlasMaui.API.Services
{
    [Headers("Accept: application/json")]
    public interface IStoryApi
    {
        [Get("/stories?page={page}&amount={amount}")]
        Task<List<Story>> Stories(int page = 0, int amount = 10);

        [Get("/stories/featured?amount={amount}")]
        Task<List<Story>> FeaturedStories(int amount = 10);
    }
}