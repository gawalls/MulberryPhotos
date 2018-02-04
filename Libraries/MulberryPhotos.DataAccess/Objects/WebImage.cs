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

        public WebImage(string name, string fullFilename)
        {
            Name = name;
            FullFilename = fullFilename;
        }
    }
}
