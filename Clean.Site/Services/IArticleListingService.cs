using Clean.Site.Extensions;
using Clean.Site.Models.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.Services
{
    public interface IArticleListingService
    {
        public ArticleListingModel Get(IPublishedContent source);
    }

    public class ArticleListingService : IArticleListingService
    {
        public ArticleListingModel Get(IPublishedContent source)
        {
            if (source == null) return null;
            ArticleListingModel model = new ArticleListingModel();
            var items = source.GetFieldValue("source") as IPublishedContent;
            model.Children = MapChildren(items.Children);
            return model;
        }

        private IEnumerable<ArticleModel> MapChildren(IEnumerable<IPublishedContent> children)
        {
            if (children == null || !children.Any())
            {
                return null;
            }
            IList<ArticleModel> list = new List<ArticleModel>();
            foreach (var child in children)
            {
                ArticleModel model = new ArticleModel();
                model.Title = child.GetFieldValue("title") as string;
                model.Subtitle = child.GetFieldValue("subtitle") as string;
                model.Author = child.GetFieldValue("author") as string;
                list.Add(model);
            }
            return list;
        }
    }
}
