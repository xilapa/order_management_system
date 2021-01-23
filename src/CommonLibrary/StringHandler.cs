using System.Text.RegularExpressions;

namespace CommonLibrary
{
    public static class StringHandler
    {
        /// <summary>
        /// Insert spaces after upercase letters
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string InsertSpace(this string source)
        {
            if (string.IsNullOrEmpty(source)) source = string.Empty;

            var result = string.Empty;
            var pattern = "[A-Z][a-z]*";
            var matches = Regex.Matches(source,pattern);

            for(var i = 0; i < matches.Count; i++)
            {
                if (i == matches.Count-1)
                    result += matches[i].Value;
                else
                result += matches[i].Value + " ";
            }

            return result;
        }

    }
}
