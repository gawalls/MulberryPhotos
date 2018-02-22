using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Objects
{
    public class WebImage : IWebImage
    {
        public string Name { get; set; }

        public string FullFilename { get; set; }
        public string ImageType { get; }
        public int? RotationOrder { get; set; }

        public WebImage(string name, string fullFilename, string imageType)
        {
            Name = name;
            FullFilename = fullFilename;
            ImageType = imageType;
        }

        public WebImage(string name, string fullFilename, string imageType, int rotationOrder)
        {
            Name = name;
            FullFilename = fullFilename;
            ImageType = imageType;
            RotationOrder = rotationOrder;
        }
    }
}
