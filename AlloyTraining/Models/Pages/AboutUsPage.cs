using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "AboutUsPage", GUID = "4dada5ef-f296-47f1-bbde-f1e1bf146898", Description = "")]
    public class AboutUsPage : SitePageData
    {
        [CultureSpecific]
        [Display(
                   Name = "Heading",
                   Description = "This is Heading",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual String Heading { get; set; }

        [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }


        [CultureSpecific]
        [Display(
              Name = "AboutUsImage",
              Description = "This is image",
              GroupName = SystemTabNames.Content,
              Order = 1)]
        public virtual ContentReference AboutUsImage { get; set; }
         
    }
}