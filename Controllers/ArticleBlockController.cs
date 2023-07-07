using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EpiserverCMS11.Models.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpiserverCMS11.Controllers
{
    public class ArticleBlockController : BlockController<ArticleBlock>
    {
        public override ActionResult Index(ArticleBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
