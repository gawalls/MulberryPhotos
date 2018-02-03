using System;
using System.Collections.Generic;
using System.Text;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebSection
    {
        string Name { get; }

        string Title { get;  }

        string HtmlContent { get; }
    }
}
