using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "SitePageData", GUID = "9ffb9cb0-c293-4134-80b8-c7491a434a2b", Description = "")]
    public abstract class SitePageData : EPiServer.Core.PageData
    {
        [Display(GroupName = "SEO", Order = 100)]
        public virtual String MetaTitle { get; set; }

        [Display(GroupName = "SEO", Order = 200)]
        public virtual String MetaKeywords { get; set; }

        [Display(GroupName = "SEO", Order = 300)]
        [UIHint(UIHint.Textarea)]
        public virtual String MetaDescription { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 100)]
        [UIHint(UIHint.Image)] //Displays an image instead of a ContentReference
        public virtual ContentReference PageImage { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 200)]
        [UIHint(UIHint.Textarea)]
        public virtual String TeaserText { get; set; }

    }
}