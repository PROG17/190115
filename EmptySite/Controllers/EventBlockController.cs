using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmptySite.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace EmptySite.Controllers
{
    public class EventBlockController : BlockController<EventBlock>
    {
        public override ActionResult Index(EventBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
