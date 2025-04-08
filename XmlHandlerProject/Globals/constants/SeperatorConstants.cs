using XmlHandlerProject.Utilities.data_handling;

namespace XmlHandlerProject.Globals.constants
{
    public static class SeperatorConstants
    {
        public static readonly int REPEAT_TIMES = 20;

        public static readonly string DASH_SEP_BY_LINE = StringHandler.Repeat(StringConstants.DASH, REPEAT_TIMES);
        public static readonly string EQUAL_SIGN_SEP_BY_LINE = StringHandler.Repeat(StringConstants.EQUAL_SIGN, REPEAT_TIMES);
    }
}
