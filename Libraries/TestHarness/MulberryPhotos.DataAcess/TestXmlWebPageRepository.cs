using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MulberryPhotos.DataAccess.Interfaces;
using System.Collections.Generic;
using MulberryPhotos.DataAccess.Enums;
using MulberryPhotos.DataAccess.Repositories;

namespace TestHarness.MulberryPhotos.DataAcess
{
    [TestClass]
    public class TestXmlWebPageRepository
    {
        private string _filename = XmlFileHandler.WorkXmlFileLocation;

        private XmlWebPageRepository _repository => new XmlWebPageRepository(_filename);
        private WebPageNameEnum _webPageEnum = WebPageNameEnum.HomePage;
        
        [TestMethod]
        public void XmlSoureFileExists()
        {
            Assert.IsTrue(File.Exists(_filename));
        }

        [TestMethod]
        public void GetsWebPageName()
        {
            IWebPage webPage = _repository.GetSingle(_webPageEnum);
            Assert.IsTrue(!string.IsNullOrEmpty(webPage.Name));
            Console.WriteLine(webPage.Name);
        }

        [TestMethod]
        public void GetsWebPageTitle()
        {
            IWebPage webPage = _repository.GetSingle(_webPageEnum);
            Assert.IsTrue(!string.IsNullOrEmpty(webPage.Title));
            Console.WriteLine(webPage.Title);
        }

        [TestMethod]
        public void GetsWebPageMetaData()
        {
            IWebPage webPage = _repository.GetSingle(_webPageEnum);
            Assert.IsNotNull(webPage.MetaData);
            Assert.IsTrue(!string.IsNullOrEmpty(webPage.MetaData.MetaTitle));
            Console.WriteLine(webPage.MetaData.MetaTitle);
        }

        [TestMethod]
        public void GetsWebPageImageList()
        {
            IWebPage webPage = _repository.GetSingle(_webPageEnum);
            List<IWebImage> imageList = webPage.ImageList;
            Assert.IsNotNull(imageList);
            imageList.ForEach(i =>
            {
                Console.WriteLine($"Name: {i.Name} - located at... {i.FullFilename}");
            });
        }

        [TestMethod]
        public void GetsWebPageSectionContentList()
        {
            IWebPage webPage = _repository.GetSingle(_webPageEnum);
            List<IWebSectionContent> contentList = webPage.WebSections;
            Assert.IsNotNull(contentList);
            contentList.ForEach(c =>
            {
                Console.WriteLine($"{c.Name} - {c.Title}...");
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{ c.HtmlContent}");
            });
        }
    }
}
