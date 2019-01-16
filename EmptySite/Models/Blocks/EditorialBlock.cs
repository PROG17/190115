using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EmptySite.Models.Blocks
{
    [ContentType(DisplayName = "Editorial Block",
        GUID = "90e66c20-3fb8-4402-acd3-5ba0365782db",
        Description = "")]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]

        public virtual XhtmlString MainBody { get; set; }

    }
}