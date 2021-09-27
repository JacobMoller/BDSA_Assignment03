using System;
using System.Text.RegularExpressions;

namespace BDSA2020.Assignment03
{
    public static class Extensions
    {
        public static bool IsSecure(this Uri inputUri)
        {
            return inputUri.Scheme == "https";
        }

        public static int WordCount(this string s)
        {
            return Regex.Matches(s, @"\b[^\d\W]+\b", RegexOptions.Multiline).Count;
        }
    }
}
