using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Find;
using EPiServer.Find.Framework;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    [TemplateDescriptor(Default = true)]
    public class SearchPageController : PageControllerBase<SearchPage>
    {
        public ActionResult Index(SearchPage currentPage, string q)
        {
            var model = new SearchPageViewModel(currentPage, q);

            if (String.IsNullOrEmpty(q))
            {
                return View(model);
            }
            var unifiedSearch = SearchClient.Instance.UnifiedSearchFor(q);
            model.Results = unifiedSearch.GetResult();
            return View(model);
        }
    }
}