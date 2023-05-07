using Clean.Site.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.ViewComponents
{
    [ViewComponent]
    public class CardViewComponent : ViewComponent
    {
        private readonly ICardService cardService;

        public CardViewComponent(ICardService cardService)
        {
            this.cardService = cardService;
        }
        public IViewComponentResult Invoke(IPublishedContent source)
        {
            var model = cardService.Get(source);
            return View("~/Views/Partials/_Card.cshtml", model);
        }
    }
}
