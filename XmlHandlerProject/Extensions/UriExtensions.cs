using System;

namespace XmlHandlerProject.Extensions
{
    public static class UriExtensions
    {
        public static string GetPrettyPropertiesInfo(
            this Uri variable,
            string variableName
        )
        {
            string result = string.Empty;
            result += $"{variableName}:{variable}\n";
            return result;
        }
    }
}
