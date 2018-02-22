using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcWideSite.Enums;

namespace MvcWideSite.ViewModels
{
    public class ImageViewModel
    {
        public string Name { get; set; }

        public ImageTypeEnum ImageType { get; set; }

        public string FullFilename { get; set; }

        public int? RotationOrder { get; set; }

        public ImageViewModel()
        {
        }

        public ImageViewModel(string name, string fullFilename, ImageTypeEnum imageType, int? rotationOrder = null)
        {
            Name = name;
            FullFilename = fullFilename;
            ImageType = imageType;
            RotationOrder = rotationOrder;
        }
    }
}