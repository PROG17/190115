using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EmptySite.Models.Pages;
using EmptySite.Models.ViewModel;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EmptySite.Controllers
{
    public class EventPageController : PageController<EventPage>
    {
        private readonly IContentLoader loader;

        public EventPageController(IContentLoader loader)
        {
            this.loader = loader;
        }
        public ActionResult Index(EventPage currentPage)
        {
            var model = new PageViewModel<EventPage>(currentPage);
            var startpage = loader.Get<StartPage>(ContentReference.StartPage);
            model.Layout.SiteName = "XYZ";
            model.Layout.FooterText = startpage.FooterText;

            return View(model);
        }
    }
}