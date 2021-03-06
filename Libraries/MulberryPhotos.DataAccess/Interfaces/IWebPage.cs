﻿using MulberryPhotos.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MulberryPhotos.DataAccess.Interfaces
{
    public interface IWebPage
    {
        string Name { get; }

        string Title { get; }

        IMetaData MetaData { get; }

        List<IWebImage> ImageList { get;  }

        List<IWebSectionContent> WebSections { get; }        
    }
}
