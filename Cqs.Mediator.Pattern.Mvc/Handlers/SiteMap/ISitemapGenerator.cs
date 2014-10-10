using System.Collections.Generic;
using System.Xml.Linq;
using Cqs.Mediator.Pattern.Mvc.Models.SiteMap;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.SiteMap
{
    public interface ISitemapGenerator
    {
        XDocument GenerateSiteMap(IEnumerable<ISitemapItem> items);
    }
}