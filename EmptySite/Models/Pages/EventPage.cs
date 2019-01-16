using System;
using System.ComponentModel.DataAnnotations;
using EmptySite.Models.Blocks;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EmptySite.Models.Pages
{
    [ContentType(DisplayName = "EventPage", GUID = "4cb3f848-8fb7-4595-8286-a364a2d3042d", Description = "")]
    public class EventPage : PageData
    {


        public virtual string Heading { get; set; }

        public virtual EventBlock EventInfo { get; set; }
    }
}