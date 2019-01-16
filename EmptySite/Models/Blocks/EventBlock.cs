using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EmptySite.Models.Blocks
{
    [ContentType(DisplayName = "Event Block", 
        GUID = "96a23b0d-9457-415f-b622-fa9e24b0f949", 
        Description = "")]
    public class EventBlock : BlockData
    {
        public virtual string EventName { get; set; }
        public virtual string EventLocation { get; set; }
        public virtual DateTime EventDateTime { get; set; }
    }
}