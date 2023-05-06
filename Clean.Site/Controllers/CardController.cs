using Clean.Site.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Clean.Site.Controllers
{
    public class CardController : SurfaceController
    {
        private readonly ICardService cardService;

        public CardController(IUmbracoContextAccessor umbracoContextAccessor,
            IUmbracoDatabaseFactory databaseFactory,
            ServiceContext services,
            AppCaches appCaches,
            IProfilingLogger profilingLogger,
            IPublishedUrlProvider publishedUrlProvider,
            ICardService cardService) :
            base(umbracoContextAccessor,
                databaseFactory,
                services,
                appCaches,
                profilingLogger,
                publishedUrlProvider)
        {
            this.cardService = cardService;
        }

        public IActionResult Index()
        {
            var model = cardService.Get(CurrentPage);
            return View("~/Views/Partials/Card.cshtml", model);
        }
    }
}
