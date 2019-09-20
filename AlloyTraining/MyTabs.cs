using EPiServer.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace AlloyTraining
{
    public class MyTabs
    {
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Specialized", Order = 40)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string Specialized = "Specialized";
            [Display(Name = "Site Settings", Order = 50)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string SiteSettings = "SiteSettings";

            [Display(Name = "Header Section", Order = 51)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string headerSection = "HeaderSection";

            [Display(Name = "Footer Section", Order = 52)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string footerSection = "footerSection";


            [Display(Name = "Left Menu", Order = 53)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string leftMenu = "LeftMenu";


            [Display(Name = "Right Menu", Order = 54)]
            [RequiredAccess(EPiServer.Security.AccessLevel.Publish)]
            public const string rightMenu = "RightMenu";


        }

        /// <summary>
        /// Virtual path to folder with static graphics, such as "~/Static/gfx/"
        /// </summary>
        public const string StaticGraphicsFolderPath = "~/Static/gfx/";
    }
}