using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQPage", GUID = "83d5b3b5-9f52-465c-9cec-ab256dbe184c", Description = "")]
   
        public class FAQPage : SitePageData
        {
            [Ignore] // ignored as a property for this page type (will not result in a property for this page type)
            public IList<FAQItem> FAQItems { get; set; }
        }
    
}