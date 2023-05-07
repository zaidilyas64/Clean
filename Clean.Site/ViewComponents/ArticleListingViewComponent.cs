using Clean.Site.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.ViewComponents
{
    public class ArticleListingViewComponent : ViewComponent
    {
        private readonly IArticleListingService articleListingService;

        public ArticleListingViewComponent(IArticleListingService articleListingService)
        {
            this.articleListingService = articleListingService;
        }
        public IViewComponentResult Invoke(IPublishedContent source)
        {
            var model = articleListingService.Get(source);
            return View("~/Views/Partials/_ArticleListing.cshtml", model);
        }
    }
}
