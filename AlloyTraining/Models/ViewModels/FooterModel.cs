﻿using AlloyTraining.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.Filters;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace AlloyTraining.Models.ViewModels
{
    public class FooterModel
    {
        public bool loggedIn;
        public PageDataCollection productPages;
        public string LoginUrl;

        public FooterModel(SitePageData currentPage)
        {
            LoginUrl = GetLoginUrl(currentPage.ContentLink);
            loggedIn = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
            RetrieveSiteProductPages();
        }
        private string GetLoginUrl(ContentReference returnToContentLink)
        {
            UrlResolver urlResolver = ServiceLocator.Current.GetInstance<UrlResolver>();
            string returnurl = urlResolver.GetUrl(returnToContentLink);
            return string.Format(
                "{0}?ReturnUrl={1}",
                FormsAuthentication.LoginUrl,
                returnurl);
        }
        private void RetrieveSiteProductPages()
        {
            PropertyCriteriaCollection criteria = new PropertyCriteriaCollection();
            var pageTypeId =
    ServiceLocator.Current.GetInstance<IContentTypeRepository>()
    .Load<ProductPage>().ID;

            PropertyCriteria prodpagecriterion = new PropertyCriteria();
            prodpagecriterion.Condition = CompareCondition.Equal;
            prodpagecriterion.Name = "PageTypeID";
            prodpagecriterion.Type = PropertyDataType.PageType;
            // prodpagecriterion.Value = PageType.get("ProductPage").ID.ToString();
            prodpagecriterion.Value = pageTypeId.ToString();
            prodpagecriterion.Required = true;
            criteria.Add(prodpagecriterion);

            productPages = DataFactory.Instance.FindPagesWithCriteria(PageReference.StartPage, criteria);

        }
    }
}