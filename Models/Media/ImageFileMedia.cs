using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverCMS11.Models.Media
{
    [ContentType(DisplayName = "ImageFileMedia", GUID = "6b33da62-a395-4d4f-836c-567d66e9782d", Description = "")]
    [MediaDescriptor(ExtensionString = "png,jpg,jpeg")]
    public class ImageFileMedia : MediaData
    {
        /*
                [CultureSpecific]
                [Editable(true)]
                [Display(
                    Name = "Description",
                    Description = "Description field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Description { get; set; }
         */
    }
}