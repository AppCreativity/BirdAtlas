using System;
using System.Text.Json.Serialization;
using Refit;

namespace BirdAtlasMaui.API.Models
{
    public class Bird
    {
        [AliasAs("id")]
        public Guid Id { get; set; }

        [AliasAs("name")]
        public string Name { get; set; }

        [AliasAs("binomial")]
        public string Binomial { get; set; }

        [AliasAs("familyId")]
        public Guid FamilyId { get; set; }

        [AliasAs("family")]
        public string Family { get; set; }

        [AliasAs("description")]
        public string Description { get; set; }

        [AliasAs("imageUrl")]
        public string ImageUrl { get; set; }

        [AliasAs("habitat")]
        public string Habitat { get; set; }

        [AliasAs("diet")]
        public string Diet { get; set; }

        [AliasAs("nesting")]
        public string Nesting { get; set; }

        [AliasAs("population")]
        public string Population { get; set; }

        [AliasAs("location")]
        public string Location { get; set; }

        [AliasAs("recentSpottings")]
        public int RecentSpottings { get; set; }

        [AliasAs("favorited")]
        public bool Favorited { get; set; }
    }
}