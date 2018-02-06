using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MulberryPhotos.DataAccess.Enums;
using MulberryPhotos.DataAccess.Interfaces;
using MvcWideSite.Enums;
using MvcWideSite.Models;
using MvcWideSite.ViewModels;

namespace MvcWideSite.Services
{
    public class WebSiteViewModelService
    {
        private IWebContentService _webContentService;

        public WebSiteViewModelService(IWebContentService webContentService)
        {
            _webContentService = webContentService;
        }

        public WebPageViewModel GetViewModel(string routeName)
        {
            RoutingValue routingValue = RoutingValue.Get(routeName);
            if (routingValue == null)
            {
                return null;
            }

            IWebPage page = _webContentService.GetWebPage(routingValue.PageNameEnum);
            if (page == null)
            {
                return null;
            }

            return GetWebPageViewModel(page);
        }

        #region helpers
        
        private WebPageViewModel GetWebPageViewModel(IWebPage webPage)
        {
            List<ImageViewModel> imageViewModels = new List<ImageViewModel>();
            foreach (IWebImage image in webPage.ImageList)
            {
                imageViewModels.Add(new ImageViewModel(image.Name, image.FullFilename));
            }
                
            List<ContentSectionViewModel> contentViewModels = new List<ContentSectionViewModel>();
            foreach (IWebSectionContent content in webPage.WebSections)
            {
                contentViewModels.Add(new ContentSectionViewModel(content.Name, content.Title, content.HtmlContent));
            }

            return new WebPageViewModel(
                webPage.Name, 
                webPage.Title, 
                new MetaDataViewModel(webPage.MetaData.MetaTitle),
                imageViewModels,
                contentViewModels
            );
        }

        
        #endregion

    }
}