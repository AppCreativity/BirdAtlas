using System;
using System.Net.Http;
using Refit;

namespace BirdAtlasMaui.API.Client
{
    /// <summary>
    /// Factory to create Refit REST services.
    /// </summary>
    public static class RestServiceFactory
    {
        /// <summary>
        /// Creates a new Refit RestService with the provided authentication.
        /// </summary>
        /// <typeparam name="T">Interface type of service</typeparam>
        /// <returns>A Refit REST service instance for the requested API</returns>
        public static T CreateService<T>()
            where T : class
        {
            return RestService.For<T>(
                client: new HttpClient()
                {
                    BaseAddress = new Uri(Constants.Constants.ApiHostUrl)
                });
        }
    }
}