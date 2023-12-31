﻿using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverCMS11.Models.Pages
{
    [ContentType(DisplayName = "ArticlePage", GUID = "e90fc496-c2b8-4d68-932f-92733bf50230", Description = "")]
    public class ArticlePage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Page Title",
            Description = "page title",
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


        [CultureSpecific]
        [Display(
            Name = "Articles",
            Description = "contains articles",
            GroupName = SystemTabNames.Content,
            Order = 15)]
        public virtual ContentArea ArticlesArea { get; set; }


    }
}