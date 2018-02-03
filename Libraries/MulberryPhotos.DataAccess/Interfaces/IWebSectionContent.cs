using System;
using System.Collections.Generic;
using System.Text;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebSectionContent
    {
        string Name { get; }

        string Title { get;  }

        string HtmlContent { get; }
    }
}
