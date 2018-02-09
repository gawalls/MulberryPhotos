using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulberryPhotos.DataAccess.Enums;
using MulberryPhotos.DataAccess.Interfaces;
using MulberryPhotos.DataAccess.Repositories;

namespace MulberryPhotos.DataAccess.Services
{
    public class XmlWebContentService : WebContentService
    {
        private string _xmlFullFilename;

        public XmlWebContentService(string xmlFullFilename)
        {
            _xmlFullFilename = xmlFullFilename;
        }
        
        protected override IWebPageRepository SetWebPageRepository()
        {
            return new XmlWebPageRepository(_xmlFullFilename);
        }        
    }
}
