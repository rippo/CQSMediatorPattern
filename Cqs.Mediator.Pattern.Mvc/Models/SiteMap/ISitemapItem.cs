using System;
using Cqs.Mediator.Pattern.Mvc.Controllers;

namespace Cqs.Mediator.Pattern.Mvc.Models.SiteMap
{
    public interface ISitemapItem
    {
        string Url { get; }
        DateTime? LastModified { get; }
        SitemapChangeFrequency? ChangeFrequency { get; }
        double? Priority { get; }
    }
}