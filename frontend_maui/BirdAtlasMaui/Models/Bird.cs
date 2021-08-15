using System;
using System.Text.Json.Serialization;

namespace BirdAtlasMaui.API.Models
{
    public class Bird
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("binomial")]
        public string Binomial { get; set; }

        [JsonPropertyName("familyId")]
        public Guid FamilyId { get; set; }

        [JsonPropertyName("family")]
        public string Family { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("habitat")]
        public int Habitat { get; set; }

        [JsonPropertyName("diet")]
        public string Diet { get; set; }

        [JsonPropertyName("nesting")]
        public string Nesting { get; set; }

        [JsonPropertyName("population")]
        public string Population { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("recentSpottings")]
        public int RecentSpottings { get; set; }

        [JsonPropertyName("favorited")]
        public bool Favorited { get; set; }
    }
}