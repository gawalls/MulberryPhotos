using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace MvcWideSite.ViewModels
{
    public class WebPageViewModel
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public MetaDataViewModel MetaData { get; set; } = new MetaDataViewModel();

        public List<ImageViewModel> Images { get; set; } = new List<ImageViewModel>();

        public List<ContentSectionViewModel> ContentList { get; set; } = new List<ContentSectionViewModel>();

        public WebPageViewModel()
        {
            
        }

        public WebPageViewModel(string name, string title, MetaDataViewModel metaData, List<ImageViewModel> images, List<ContentSectionViewModel> contentList)
        {
            Name = name;
            Title = title;
            MetaData = metaData;
            Images = images;
            ContentList = contentList;
        }
    }
}