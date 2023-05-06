using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.Models
{
    public class HomeModel
    {
        public string Title { get; set; }
        public IEnumerable<IPublishedContent> Components { get; set; }
    }
}
