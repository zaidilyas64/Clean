using Clean.Site.Extensions;
using Clean.Site.Models.Components;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace Clean.Site.Services
{
    public interface ICardService
    {
        CardModel Get(IPublishedContent source);
    }

    public class CardService : ICardService
    {
        public CardModel Get(IPublishedContent source)
        {
            if (source == null) return null;

            CardModel model = new CardModel();
            model.Title = source.GetFieldValue("title") as string;
            model.Image = ((IPublishedContent)source.GetFieldValue("image")).MediaUrl();

            return model;
        }
    }
}
