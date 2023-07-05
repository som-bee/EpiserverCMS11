﻿using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiserverCMS11.Models.Pages;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EpiserverCMS11.Controllers
{
    public class ArticlePageController : PageController<ArticlePage>
    {
        public ActionResult Index(ArticlePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}