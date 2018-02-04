using MulberryPhotos.DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MulberryPhotos.DataAccess.Enums;
using System.Xml;
using MulberryPhotos.DataAccess.Objects;

namespace MulberryPhotos.DataAccess.Repositories
{
    public class XmlWebPageRepository : IWebPageRepository
    {
        private string _filename; 
        
        public XmlWebPageRepository(string filename)
        {
            _filename = filename;
        }

        public List<IWebPage> GetAll()
        {
            List<IWebPage> webPageList = new List<IWebPage>();

            XmlDocument document = new XmlDocument();
            document.Load(_filename);
            XmlNode rootNode = document.DocumentElement;
            XmlNodeList pageNodeList = rootNode.SelectNodes("/WebPages/WebPage");

            foreach (XmlNode pageNode in pageNodeList)
            {
                //get name and title
                string name = pageNode["Name"].InnerText;
                string title = pageNode["Title"].InnerText;

                //get metadata
                XmlNode metaNode = pageNode["Meta"];
                string metaDataTitle = metaNode["MetaTitle"].InnerText; 
                MetaData metaData = new MetaData(metaDataTitle);

                //get lists
                List<IWebImage> webImageList = GetWebImageList(pageNode["Images"]);
                List<IWebSectionContent> contentList = GetContentList(pageNode["Sections"]);

                //now initialise the webPage class and add it to the list
                WebPage page = new WebPage(name, title, metaData, webImageList, contentList);
                webPageList.Add(page);
            }
            return webPageList;
        }

        public IWebPage GetSingle(WebPageNameEnum pageName)
        {
            return GetAll().FirstOrDefault(p => p.Name.ToUpper() == pageName.ToString().ToUpper());
        }


        #region helpers

        private List<IWebImage> GetWebImageList(XmlNode pageNode)
        {
            List<IWebImage> images = new List<IWebImage>();

            foreach (XmlNode item in pageNode.ChildNodes)
            {
                string imageType = item.Attributes["Name"].Value;                
                string filename = item.InnerText;

                WebImage image = new WebImage(imageType, filename);
                images.Add(image);
            }

            return images;
        }

        private List<IWebSectionContent> GetContentList(XmlNode pageNode)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
