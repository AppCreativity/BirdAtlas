using System;
using System.Collections.Generic;
using BirdAtlasMaui.API.Models;
using Refit;

namespace BirdAtlasMaui.API.Models
{
    public class Story
    {
        [AliasAs("id")]
        public Guid Id { get; set; }

        [AliasAs("imageUrl")]
        public string ImageUrl { get; set; }

        [AliasAs("category")]
        public string Category { get; set; }

        [AliasAs("title")]
        public string Title { get; set; }

        [AliasAs("isFeatured")]
        public bool IsFeatured { get; set; }

        [AliasAs("publishedOn")]
        public DateTime PublishedOn { get; set; }

        [AliasAs("author")]
        public string Author { get; set; }

        [AliasAs("content")]
        public string Content { get; set; }

        [AliasAs("relatedBirds")]
        public List<Bird> RelatedBirds { get; set; }
    }
}
