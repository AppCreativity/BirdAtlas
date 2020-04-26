using System;

namespace BirdAtlas.Models
{
    public class Story
    {
        public Guid ID { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime PublishedOn { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
    }
}