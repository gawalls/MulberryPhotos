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

            if (rootNode != null)
            {
                XmlNodeList pageNodeList = rootNode.SelectNodes("/WebPages/WebPage");

                if (pageNodeList != null)
                {
                    foreach (XmlNode pageNode in pageNodeList)
                    {
                        //get name and title
                        string name = pageNode["Name"]?.InnerText;
                        string title = pageNode["Title"]?.InnerText;

                        //get metadata
                        XmlNode metaNode = pageNode["Meta"];
                        MetaData metaData = null;

                        if (metaNode != null)
                        {
                            string metaDataTitle = metaNode["MetaTitle"]?.InnerText;
                            metaData = new MetaData(metaDataTitle);
                        }

                        //get lists
                        List<IWebImage> webImageList = GetWebImageList(pageNode["Images"]);
                        List<IWebSectionContent> contentList = GetContentList(pageNode["Sections"]);

                        //now initialise the webPage class and add it to the list
                        WebPage page = new WebPage(name, title, metaData, webImageList, contentList);
                        webPageList.Add(page);
                    }
                }
                return webPageList;
            }

            return null;
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
                if (item.Attributes != null)
                {
                    string name = item.Attributes["Name"].Value;                
                    string filename = item.InnerText;
                    string imageType = item.Attributes["Type"]?.Value;
                    WebImage image = new WebImage(name, filename, imageType);

                    string rotationStrValue = item.Attributes["RotationOrder"]?.Value;
                    if (!string.IsNullOrEmpty(rotationStrValue))
                    {
                        int? rotationOrder = Convert.ToInt32(rotationStrValue);
                        image.RotationOrder = rotationOrder;
                    }                                        
                    images.Add(image);
                }
            }

            return images;
        }

        private List<IWebSectionContent> GetContentList(XmlNode pageNode)
        {
            List<IWebSectionContent> contentList = new List<IWebSectionContent>();

            foreach (XmlNode sectionNode in pageNode.ChildNodes)
            {
                if (sectionNode.Attributes != null)
                {
                    string name = sectionNode.Attributes["Name"].Value;
                    string title = sectionNode.Attributes["Title"].Value;
                    XmlNode elementNode = sectionNode.SelectSingleNode("element");
                    string htmlContent = "";

                    if (elementNode != null)
                    {
                        htmlContent = elementNode
                            .FirstChild.InnerText
                            .Trim("\r\n".ToCharArray())
                            .Trim();
                    }

                    contentList.Add(new WebSectionContent(name, title, htmlContent));
                }
            }

            return contentList;
        }

        #endregion
    }
}
