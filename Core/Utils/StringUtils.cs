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
    }
}