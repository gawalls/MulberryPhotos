using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulberryPhotos.DataAccess.Enums;
using MulberryPhotos.DataAccess.Interfaces;

namespace MulberryPhotos.DataAccess.Services
{
    public abstract class WebContentService : IWebContentService
    {
        private IWebPageRepository _webPageRepository;

        protected abstract IWebPageRepository SetWebPageRepository();

        private void SetRepositories()
        {
            _webPageRepository = SetWebPageRepository();
        }

        public List<IWebPage> GetWebPages()
        {
            if (_webPageRepository == null)
            {
                SetRepositories();
            }

            return _webPageRepository.GetAll();
        }

        public IWebPage GetWebPage(WebPageNameEnum webPageName)
        {
            if (_webPageRepository == null)
            {
                SetRepositories();
            }

            return _webPageRepository.GetSingle(webPageName);
        }
    }
}
