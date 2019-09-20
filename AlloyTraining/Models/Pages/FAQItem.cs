using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "FAQItem", GUID = "6cfc6ac3-8a6b-4425-95a4-0c6d962f417f", Description = "",AvailableInEditMode =false)]
    public class FAQItem : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual String Question { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Answer { get; set; }
    }
}