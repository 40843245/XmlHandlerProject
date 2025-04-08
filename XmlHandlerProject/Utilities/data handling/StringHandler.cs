using System.Collections.Generic;
using System.Linq;

namespace XmlHandlerProject.Utilities.data_handling
{
    public static class StringHandler
    {
        public static string ReplaceString(
            string sourceString,
            Dictionary<string, string> replacePatterns
        )
        {
            if (replacePatterns.ContainsKey(sourceString))
            {
                return replacePatterns[sourceString];
            }
            return sourceString;
        }

        public static string Repeat(
            string sourceString,
            int repeatTimes
        )
        {
            IEnumerable<string> repeatedIEnumerable = Enumerable.Repeat(sourceString, repeatTimes);
            string repeatedText = string.Join("", repeatedIEnumerable);
            return repeatedText;
        }
    }
}
