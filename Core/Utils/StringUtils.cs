using System.Linq;

namespace HuaweiCloud.SDK.Core
{
    public class StringUtils
    {
        public static string ToSnakeCase(string str)
        {
            return string.Concat(str.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x : x.ToString()))
                .ToLower();
        }

        public static string UnderscoreToCamel(string str)
        {
            var item = str;
            while (item.IndexOf('_') >= 0)
            {
                var newUpper = item.Substring(item.IndexOf('_'), 2);
                item = item.Replace(newUpper, newUpper.Trim('_').ToUpper());
                str = str.Replace(newUpper, newUpper.Trim('_').ToUpper());
            }
            return str;
        }
    }
}
