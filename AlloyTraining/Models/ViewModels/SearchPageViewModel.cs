using System;
using System.ComponentModel.DataAnnotations;
using AlloyTraining.Models.Pages;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Find.UnifiedSearch;
using EPiServer.SpecializedProperties;

namespace AlloyTraining.Models.ViewModels
{
    public class SearchPageViewModel : DefaultPageViewModel<SearchPage>
    {
        public SearchPageViewModel(SearchPage currentPage, string searchQuery)
         : base(currentPage)
        {
            SearchQuery = searchQuery;
        }

        public string SearchQuery { get; private set; }
        public UnifiedSearchResults Results { get; set; }
    }
}