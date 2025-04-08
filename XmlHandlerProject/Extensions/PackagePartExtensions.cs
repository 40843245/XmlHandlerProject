using System.IO;
using System.IO.Packaging;

namespace XmlHandlerProject.Extensions
{
    public static class PackagePartExtensions
    {
        public static string GetXmlContent(
            this PackagePart packagePart
        )
        {
            using (StreamReader streamReader = new StreamReader(packagePart.GetStream(FileMode.Open, FileAccess.Read)))
            {
                string xmlContentText = streamReader.ReadToEnd();
                return xmlContentText;
            }
        }

        public static Package GetPackage(
           this Stream stream
        )
        {
            return Package.Open(stream);
        }

        public static Package GetPackage(
           this string fileName
        )
        {
            using (Stream stream = new FileStream(fileName, FileMode.Open))
            {
                return stream.GetPackage();
            }
        }
    }
}
