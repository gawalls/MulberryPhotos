using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulberryPhotos.DataAccess.Objects
{
    public abstract class BaseWebPage 
    {
        private string _filePathAndName;
        private string _pageName;
        private string _pageTitle;
        private IMetaData _pageMetaData;
        private List<IWebImage> _pageImages;
        private List<IWebSectionContent> _pageSectionContents;
        
        protected BaseWebPage()
        {
            
        }        
    }
}
