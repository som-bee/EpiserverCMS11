 using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EpiserverCMS11.Models.Media;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverCMS11.Models.Blocks
{
    [ContentType(DisplayName = "ArticleBlock", GUID = "fab1e50e-8710-43f4-9e30-5beca0acdeb7", Description = "")]
    public class ArticleBlock : BlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Article Title",
            Description = "Name of the Article",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string ArticleTitle { get; set; }

        [CultureSpecific]
        [Display(
           Name = "Article Description",
           Description = "Short description of the Article",
           GroupName = SystemTabNames.Content,
           Order = 5)]
        public virtual string ArticleDescription { get; set; }


        [CultureSpecific]
        [Display(
           Name = "Article Image",
           Description = "Image reference of the Article",
           GroupName = SystemTabNames.Content,
           Order = 10)]
        [UIHint(UIHint.Image)]
        [AllowedTypes(new [] {typeof(ImageFileMedia)})]
        public virtual ContentReference ArticleImage { get; set; }

    }
}