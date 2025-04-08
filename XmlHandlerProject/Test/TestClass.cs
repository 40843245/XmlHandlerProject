using System;
using System.IO;
using XmlHandlerProject.Globals.constants;
using static XmlHandlerProject.Extensions.StringExtensions;
using static XmlHandlerProject.Extensions.PackagePartExtensions;
using static XmlHandlerProject.Extensions.FileExtensions;

namespace XmlHandlerProject.Test
{
    public static class TestClass
    {
        public static void TestGetXmlContentMethod1()
        {
            string prettyMessageForMethodName = "TestGetXmlContentMethod1".GetPrettyMessageByMethodName(
                SeperatorConstants.EQUAL_SIGN_SEP_BY_LINE,
                SeperatorConstants.DASH_SEP_BY_LINE
            );
            Console.WriteLine(prettyMessageForMethodName);
            string fullDirectory = FilePathConstants.DirectoryConstants.Test.Document.ROOT_DIRECTORY;
            string fileName1 = @"OnlyOneFigureExample.docx";
            string fullPath1 = Path.Combine(fullDirectory, fileName1);
            string relativePath = UriConstants.RelativeUriConstants.DOCUMENT_PART;
            Uri relativeUri = new Uri(relativePath,UriKind.Relative);
            string xmlContent = fullPath1.GetXmlContent(
                relativeUri    
            );
            Console.WriteLine(xmlContent);
        }

        public static void TestGetXmlContentMethod2()
        {
            string prettyMessageForMethodName = "TestGetXmlContentMethod2".GetPrettyMessageByMethodName(
                SeperatorConstants.EQUAL_SIGN_SEP_BY_LINE,
                SeperatorConstants.DASH_SEP_BY_LINE
            );
            Console.WriteLine(prettyMessageForMethodName);
            string fullDirectory = FilePathConstants.DirectoryConstants.Test.Document.ROOT_DIRECTORY;
            string fileName1 = @"OnlyOneFigureExample2.docx";
            string fullPath1 = Path.Combine(fullDirectory, fileName1);
            string relativePath = UriConstants.RelativeUriConstants.DOCUMENT_PART;
            Uri relativeUri = new Uri(relativePath, UriKind.Relative);
            string xmlContent = fullPath1.GetXmlContent(
                relativeUri
            );
            Console.WriteLine(xmlContent);
        }
    }
}
