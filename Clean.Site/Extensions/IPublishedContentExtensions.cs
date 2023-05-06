using Umbraco.Cms.Core.Models.PublishedContent;

namespace Clean.Site.Extensions
{
    public static class IPublishedContentExtensions
    {
        private static bool HasItemProperty(this IPublishedContent source, string propertyName)
        {
            return source != null && !string.IsNullOrWhiteSpace(propertyName) && source.GetProperty(propertyName) != null;
        }

        public static object GetFieldValue(this IPublishedContent source, string propertyName, bool isFallBack = false)
        {
            if (!source.HasItemProperty(propertyName))
                return null;

            return source.GetProperty(propertyName).GetValue();
            //if (isFallBack)
            //{
            //}
            //else
            //{
            //    return source.GetProperty(propertyName).GetValue(LanguageInfo.CultureInfo.Name);
            //}
        }
    }
}
