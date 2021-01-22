using System.Text.RegularExpressions;

namespace CommonLibrary
{
    public class StringHandler
    {
        public string InsertSpace(string source)
        {
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
