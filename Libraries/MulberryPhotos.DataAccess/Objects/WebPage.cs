using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Objects
{
    public class WebPage : IWebPage
    {
        public string Name { get; private set; }

        public string Title { get; private set; }

        public IMetaData MetaData { get; private set; }

        public List<IWebImage> ImageList { get; private set; }

        public List<IWebSectionContent> WebSections { get; private set; }

        internal WebPage(string name, string title, IMetaData metaData, List<IWebImage> imageList, List<IWebSectionContent> webSections)
        {
            Name = name;
            Title = title;
            MetaData = metaData;
            ImageList = imageList;
            WebSections = webSections;
        }
    }
}
