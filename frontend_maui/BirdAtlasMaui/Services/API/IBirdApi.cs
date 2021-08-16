using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BirdAtlasMaui.API.Models;
using Refit;

namespace BirdAtlasMaui.API.Services
{
    [Headers("Accept: application/json")]
    public interface IBirdApi
    {
        [Get("/birds?page={page}&amount={amount}")]
        Task<List<Bird>> Birds(int page = 0, int amount = 10);

        [Get("/birds/{id}")]
        Task<Bird> Bird(Guid id);

        [Put("/birds/{id}/favorite?favorite={favorite}")]
        Task Bird(Guid id, bool favorite);
    }
}