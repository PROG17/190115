using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EmptySite.Models.Pages
{
    [ContentType(DisplayName = "Standard Page",
        GUID = "11767fb4-4f6d-49d5-9c91-3b2193275666",
        Description = "")]
    public class StandardPage : PageData
    {

        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        public virtual ContentArea MainContentArea { get; set; }
    }
}