using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EmptySite.Models.Pages
{
    [ContentType(DisplayName = "Start Page", 
        GUID = "a4d46991-9a21-4849-8c8e-d25a897a835c", 
        Description = "")]
    public class StartPage : PageData
    {


        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName ="SiteSettings")]
        public virtual string FooterText { get; set; }
    }
}