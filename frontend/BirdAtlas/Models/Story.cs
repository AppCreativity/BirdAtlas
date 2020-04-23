using System;

namespace BirdAtlas.Models
{
    public class Story
    {
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime Published { get; set; }
    }
}