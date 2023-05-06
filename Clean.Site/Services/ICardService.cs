using Clean.Site.Extensions;
using Clean.Site.Models.Components;
using Umbraco.Cms.Core.Models.PublishedContent;

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
            model.Image = source.GetFieldValue("image") as string;

            return model;
        }
    }
}
