namespace XmlHandlerProject.Extensions
{
    public static class StringExtensions
    {
        public static string GetPrettyMessageByMethodName(
            this string methodName,
            string prefix,
            string postfix
        )
        {
            string prettyMessage = $"{prefix}\nIn {methodName} method call:\n{postfix}";
            return prettyMessage;
        }
    }
}
