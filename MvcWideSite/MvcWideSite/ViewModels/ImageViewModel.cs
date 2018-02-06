using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWideSite.ViewModels
{
    public class ImageViewModel
    {
        public string Name { get; set; }

        public string FullFilename { get; set; }

        public ImageViewModel()
        {
        }

        public ImageViewModel(string name, string fullFilename)
        {
            Name = name;
            FullFilename = fullFilename;
        }
    }
}