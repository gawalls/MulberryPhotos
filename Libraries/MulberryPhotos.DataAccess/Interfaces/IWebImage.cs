using System;
using System.Collections.Generic;
using System.Text;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebImage
    {
        string Name { get; }

        string FullFilename { get; }
    }
}
