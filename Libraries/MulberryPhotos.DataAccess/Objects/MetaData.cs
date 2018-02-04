using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Objects
{
    public class MetaData : IMetaData
    {
        public string MetaTitle { get; set; }

        public MetaData(string metaTitle)
        {
            MetaTitle = metaTitle;
        }
    }
}
