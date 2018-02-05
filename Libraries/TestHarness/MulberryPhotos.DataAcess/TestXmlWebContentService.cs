using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MulberryPhotos.DataAccess.Enums;
using MulberryPhotos.DataAccess.Interfaces;
using MulberryPhotos.DataAccess.Objects;
using MulberryPhotos.DataAccess.Services;

namespace TestHarness.MulberryPhotos.DataAcess
{
    [TestClass]
    public class TestXmlWebContentService
    {
        private string _filename = XmlFileHandler.WorkXmlFileLocation;

        [TestMethod]
        public void GetAllWebPages()
        {
            XmlWebContentService service = new XmlWebContentService(_filename);
            List<IWebPage> page = service.GetWebPages();
            Assert.IsNotNull(page);

            foreach (IWebPage webPage in page)
            {
                Console.WriteLine(webPage.Name);
            }
        }
    }
}
