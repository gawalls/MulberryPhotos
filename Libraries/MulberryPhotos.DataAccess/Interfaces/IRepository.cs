using System;
using System.Collections.Generic;
using System.Text;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IRepository
    {
        string GetWebPageName();

        string GetWebPageTitle();

        IMetaData GetWebPageMetaData();

        List<IWebImage> GetWebPageImageList();

        List<IWebSectionContent> GetWebPageSectionContentList();
    }
}
