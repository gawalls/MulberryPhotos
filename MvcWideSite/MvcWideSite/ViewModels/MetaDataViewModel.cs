using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWideSite.ViewModels
{
    public class MetaDataViewModel
    {
        public string MetaDataTitle { get; set; }

        public MetaDataViewModel()
        {
        }

        public MetaDataViewModel(string metaDataTitle)
        {
            MetaDataTitle = metaDataTitle;
        }
    }
}