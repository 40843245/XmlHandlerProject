using System;
using System.IO;
using System.IO.Packaging;

namespace XmlHandlerProject.Extensions
{
    public static class FileExtensions
    {
        public static string GetXmlContent(
            this string fileName,
            Uri relativeUri
        )
        {
            using (Package package = Package.Open(fileName, FileMode.Open, FileAccess.Read))
            {
                string xmlContent = package.GetXmlContent(relativeUri);
                return xmlContent;
            }
        }
    }
}
