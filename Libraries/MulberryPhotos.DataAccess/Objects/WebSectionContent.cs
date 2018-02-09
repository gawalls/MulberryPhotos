using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Objects
{
    public class WebSectionContent : IWebSectionContent
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public string HtmlContent { get; set; }

        public WebSectionContent(string name, string title, string htmlContent)
        {
            Name = name;
            Title = title;
            HtmlContent = htmlContent;
        }
    }
}
