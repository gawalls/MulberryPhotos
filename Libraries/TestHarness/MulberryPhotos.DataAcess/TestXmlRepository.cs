using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MulberryPhotos.DataAccess.Objects;
using System.IO;
using MulberryPhotos.DataAccess.Interfaces;
using System.Collections.Generic;

namespace TestHarness.MulberryPhotos.DataAcess
{
    [TestClass]
    public class TestXmlRepository
    {
        //string _filename = @"D:\GithubRepositories\MulberryPhotos\Content\WebsiteContent.xml";
        //private BaseRepository _repository => new BaseRepository(_filename); 

        //[TestMethod]
        //public void XmlSoureFileExists()
        //{
        //    Assert.IsTrue(File.Exists(_filename));
        //}

        //[TestMethod]
        //public void GetsWebPageName()
        //{
        //    string name = _repository.GetWebPageName();
        //    Assert.IsTrue(!string.IsNullOrEmpty(name));
        //    Console.WriteLine(name);
        //}

        //[TestMethod]
        //public void GetsWebPageTitle()
        //{
        //    string title = _repository.GetWebPageName();
        //    Assert.IsTrue(!string.IsNullOrEmpty(title));
        //    Console.WriteLine(title);
        //}

        //[TestMethod]
        //public void GetsWebPageMetaData()
        //{
        //    IMetaData metaData = _repository.GetWebPageMetaData();
        //    Assert.IsNotNull(metaData);
        //    Assert.IsTrue(!string.IsNullOrEmpty(metaData.MetaTitle));
        //    Console.WriteLine(metaData);
        //}

        //[TestMethod]
        //public void GetsWebPageImageList()
        //{
        //    List<IWebImage> imageList = _repository.GetWebPageImageList();
        //    Assert.IsNotNull(imageList);
        //    imageList.ForEach(i =>
        //    {
        //        Console.WriteLine($"Name: {i.Name} - located at... {i.FullFilename}");
        //    });
        //}

        //[TestMethod]
        //public void GetsWebPageSectionContentList()
        //{
        //    List<IWebSectionContent> contentList = _repository.GetWebPageSectionContentList();
        //    Assert.IsNotNull(contentList);
        //    contentList.ForEach(c =>
        //    {
        //        Console.WriteLine($"{c.Name} - {c.Title}...");
        //        Console.WriteLine("---------------------------");
        //        Console.WriteLine($"{ c.HtmlContent}");
        //    });
        //}
    }
}
