using MulberryPhotos.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebPageRepository
    {
        List<IWebPage> GetAll();

        IWebPage GetSingle(WebPageNameEnum pageName);
    }
}
