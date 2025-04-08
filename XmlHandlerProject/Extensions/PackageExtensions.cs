using System;
using System.IO.Packaging;

namespace XmlHandlerProject.Extensions
{
    public static class PackageExtensions
    {
        public static string GetXmlContent(
            this Package package,
            Uri relativeUri
        )
        {
            PackagePart packagePart = package.GetPart(relativeUri);
            string xmlContent = packagePart.GetXmlContent();
            return xmlContent;
        }
    }
}
