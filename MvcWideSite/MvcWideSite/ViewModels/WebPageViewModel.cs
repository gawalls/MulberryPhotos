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

        public ImageListViewModel Images { get; set; } = new ImageListViewModel();

        public List<ContentSectionViewModel> ContentList { get; set; } = new List<ContentSectionViewModel>();

        public EnquiryViewModel Enquiry { get; set; }
                   
        public WebPageViewModel()
        {
            
        }

        public WebPageViewModel(string name, string title, MetaDataViewModel metaData, ImageListViewModel images, List<ContentSectionViewModel> contentList)
        {
            Name = name;
            Title = title;
            MetaData = metaData;
            Images = images;
            ContentList = contentList;
        }
    }
}