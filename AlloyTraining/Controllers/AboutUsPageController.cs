using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AlloyTraining.Models.Pages;
using AlloyTraining.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace AlloyTraining.Controllers
{
    public class AboutUsPageController : PageControllerBase<AboutUsPage>
    {
        public ActionResult Index(AboutUsPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<AboutUsPage> model = new DefaultPageViewModel<AboutUsPage>(currentPage);

            return View(model);
        }
    }
}