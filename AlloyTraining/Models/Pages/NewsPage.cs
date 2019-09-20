using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "968293c5-22f2-4f57-bd5a-b5448fa21e62", Description = "")]
    public class NewsPage : StandardPage
    {
      
        [Display(
           Name = "Main Listing",
           Description = "A listing of news pages",
           GroupName = SystemTabNames.Content,
           Order = 315)]
        public virtual ListingBlock MainListing { get; set; }

    }
}