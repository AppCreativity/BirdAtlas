using Refit;

namespace BirdAtlasMaui.API.Models
{
    public class Habitat
    {
        [AliasAs("type")]
        public HabitatType HabitatType { get; set; }

        [AliasAs("name")]
        public string Name { get; set; }

        [AliasAs("birdCount")]
        public int BirdCount { get; set; }

        public string Amount => $"{BirdCount} birds";
    }
}