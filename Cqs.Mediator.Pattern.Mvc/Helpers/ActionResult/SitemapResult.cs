using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using System.Xml;
using Cqs.Mediator.Pattern.Mvc.Handlers.SiteMap;
using Cqs.Mediator.Pattern.Mvc.Models.SiteMap;

namespace Cqs.Mediator.Pattern.Mvc.Helpers.ActionResult
{
    public class SitemapResult : System.Web.Mvc.ActionResult
    {
        private readonly IEnumerable<ISitemapItem> _items;
        private readonly ISitemapGenerator _generator;

        public SitemapResult(IEnumerable<ISitemapItem> items)
            : this(items, new SitemapGenerator())
        {
        }

        public SitemapResult(IEnumerable<ISitemapItem> items, ISitemapGenerator generator)
        {
            _items = items;
            _generator = generator;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var response = context.HttpContext.Response;

            response.ContentType = "text/xml";
            response.ContentEncoding = Encoding.UTF8;

            using (var writer = new XmlTextWriter(response.Output))
            {
                writer.Formatting = Formatting.Indented;
                var sitemap = _generator.GenerateSiteMap(_items);

                sitemap.WriteTo(writer);
            }
        }
    }
}