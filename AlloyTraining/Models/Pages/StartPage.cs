using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "acad32bf-9971-4939-b370-9a332fd0079b", Description = "")]
    public class StartPage : SitePageData
    {

        //[CultureSpecific]
        //[Display(
        //    Name = "Heading",
        //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //    GroupName = SystemTabNames.Content,
        //    Order = 1)]

        [Display(Name="Heading", GroupName = MyTabs.GroupNames.headerSection, Order = 1)]
        public virtual string Heading { get; set; }

        //[CultureSpecific]
        //[Display(
        //    Name = "Heading",
        //    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
        //    GroupName = SystemTabNames.Content,
        //    Order = 1)]

        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = MyTabs.GroupNames.headerSection,//PropertyBind with MyOwnTabs
            Order = 1)]

        public virtual XhtmlString MainBody { get; set; }
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }
        [Display(
            GroupName = SystemTabNames.Settings)]
        public virtual PageReference SearchPageLink { get; set; }



    }
}