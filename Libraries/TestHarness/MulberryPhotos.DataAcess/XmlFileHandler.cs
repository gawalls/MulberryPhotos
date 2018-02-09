using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHarness.MulberryPhotos.DataAcess
{
    public static class XmlFileHandler
    {
        private static string homePcFolderLocation = @"D:\GithubRepositories\";
        private static string workPcLocation = @"D:\ConceptProjects";
        private static string filenameOnly = @"MulberryPhotos\Content\WebsiteContent.xml";
        
        public static string WorkXmlFileLocation
        {
            get { return Path.Combine(workPcLocation, filenameOnly); }
        }

        public static string HomeXmlFileLocation
        {
            get { return Path.Combine(homePcFolderLocation, filenameOnly); }
        }
    }
}
