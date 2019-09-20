using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "af44cd64-583c-4171-be86-da8232af9dd9", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual String Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}