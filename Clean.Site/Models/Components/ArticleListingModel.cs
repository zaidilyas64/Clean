using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.Models.Components
{
    public class ArticleListingModel
    {
        public IEnumerable<ArticleModel> Children { get; set; }
    }
}
