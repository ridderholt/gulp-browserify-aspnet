using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace BrowserifyTest.Models
{
    public static class CustomHtmlHelper
    {
        public static IHtmlString Bundle(this HtmlHelper helper, string bundleName)
        {
            const string tag = "<script type=\"text/javascript\" src=\"{0}\"></script>";
#if DEBUG
            var folder = "build";
#else
            var folder = "dist";
#endif


            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            var contentPath = urlHelper.Content(string.Format("~/Scripts/{0}/{1}.js", folder, bundleName));

            return MvcHtmlString.Create(string.Format(tag, contentPath));
        }
    }
}