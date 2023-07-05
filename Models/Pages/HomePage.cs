using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverCMS11.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "ef279902-f74c-44a3-91c3-3b11d06761ee", Description = "home page")]
    public class HomePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Page Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string PageTitle { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString MainBody { get; set; }

    }
}