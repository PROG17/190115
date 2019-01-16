using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EmptySite.Models.Pages;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EmptySite.Controllers
{
    [TemplateDescriptor(Inherited = true)]
    public class PagePartialController : PartialContentController<PageData>
    {
        public override ActionResult Index(PageData currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return PartialView(currentPage);
        }
    }
}