using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcWideSite.ViewModels
{
    public class ContentSectionViewModel
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string HtmlContent { get; set; }

        public ContentSectionViewModel()
        {
        }

        public ContentSectionViewModel(string name, string title, string htmlContent)
        {
            Name = name;
            Title = title;
            HtmlContent = htmlContent;
        }
    }
}