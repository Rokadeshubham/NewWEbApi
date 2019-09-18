using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "e0ffacab-4097-4237-9ec9-57df472e2a19", Description = "")]
    public class ProductPage : StandardPage
    {

        [Display(
    GroupName = SystemTabNames.Content,
    Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoints { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 330)]
        public virtual ContentArea RelatedContentArea { get; set; }

    }
}