using Clean.Site.Extensions;
using Clean.Site.Models;
using System.Collections;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.Services
{
    public interface IHomeService
    {
        public HomeModel Get(IPublishedContent source);
    }

    public class HomeService : IHomeService
    {
        public HomeModel Get(IPublishedContent source)
        {
            if (source == null) return null;

            HomeModel model = new HomeModel();
            model.Title = source.GetFieldValue("title") as string;
            model.Components = source.GetFieldValue("componentPicker") as IEnumerable<IPublishedContent>;

            return model;
        }
    }
}
