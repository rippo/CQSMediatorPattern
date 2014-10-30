using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Cqs.Mediator.Pattern.Mvc.Handlers.Commands;
using Cqs.Mediator.Pattern.Mvc.Handlers.Repository;
using Cqs.Mediator.Pattern.Mvc.Helpers.ActionResult;
using Cqs.Mediator.Pattern.Mvc.Helpers.Url;
using Cqs.Mediator.Pattern.Mvc.Models.SiteMap;
using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _repo;
        private readonly ICommandHandler<MoveCustomerViewModel> _handler;

        public HomeController(IUserRepository repo, ICommandHandler<MoveCustomerViewModel> handler)
        {
            _repo = repo;
            _handler = handler;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Home Controller: Index: " + _repo.GetMe();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Home Controller: Contact";
            return View("Index");
        }

        public ContentResult Test()
        {
            var command = new MoveCustomerViewModel
            {
                CustomerName = "My Customer"
            };

            _handler.Handle(command);

            return Content("done, new Id: " + command.CustomerId);
        }

        public ActionResult SiteMapXml()
        {
            var sitemapItems = new List<SitemapItem>
        {
            new SitemapItem(Url.QualifiedAction("index", "home"), changeFrequency: SitemapChangeFrequency.Always, priority: 1.0),
            new SitemapItem(Url.QualifiedAction("Contact", "home"), lastModified: DateTime.Now),
            //new SitemapItem(PathUtils.CombinePaths(Request.Url.GetLeftPart(UriPartial.Authority), "/home/list"))
        };

            return new SitemapResult(sitemapItems);
        }

        //Catch all for any CMS type page
        public ActionResult Cms(string id)
        {
            ViewBag.Message = "Home Controller: Cms : " + id;
            return View("Index");
        }


    }
}