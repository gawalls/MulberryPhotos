using System.Collections.Generic;
using MulberryPhotos.DataAccess.Enums;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebContentService
    {
        List<IWebPage> GetWebPages();

        IWebPage GetWebPage(WebPageNameEnum webPageName);
    }
}