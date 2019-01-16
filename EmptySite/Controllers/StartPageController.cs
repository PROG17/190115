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
    public class StartPageController : PageController<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            var model = new PageViewModel<StartPage>(currentPage);
            model.Layout.SiteName = "XYZ";
            model.Layout.FooterText = currentPage.FooterText;

            return View(model);
        }
    }
}