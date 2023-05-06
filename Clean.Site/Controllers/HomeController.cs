using Clean.Site.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Logging;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace Clean.Site.Controllers
{
    public class HomeController : RenderController
    {
        private readonly IHomeService homeService;

        public HomeController(ILogger<RenderController> logger, 
            ICompositeViewEngine compositeViewEngine, 
            IUmbracoContextAccessor umbracoContextAccessor,
            IHomeService homeService)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        {
            this.homeService = homeService;
        }

        public override IActionResult Index()
        {
            var model = homeService.Get(CurrentPage);
            return View("~/Views/Home.cshtml", model);
        }
    }
}
