using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace AlloyTraining.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "81073bc7-35b8-4689-bd25-74158b44ba5c", Description = "")]
    public class EditorialBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "Main Body",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
        [Display(
           GroupName = SystemTabNames.Content,
           Order = 100)]
        [UIHint(UIHint.Image)]
       
        public virtual ContentReference PageImage { get; set; }

    }
}