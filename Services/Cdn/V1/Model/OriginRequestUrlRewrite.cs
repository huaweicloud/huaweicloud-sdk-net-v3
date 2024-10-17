using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V1.Model
{
    /// <summary>
    /// 改写回源URL，最多配置20条。
    /// </summary>
    public class OriginRequestUrlRewrite 
    {

        /// <summary>
        /// 回源URL改写规则的优先级。 优先级设置具有唯一性，不支持多条回源URL改写规则设置同一优先级，且优先级不能输入为空。 多条规则下，不同规则中的相同资源内容，CDN按照优先级高的规则执行URL改写。 取值为1~100之间的整数，数值越大优先级越高。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 匹配类型， all：所有文件， file_path：URL路径， wildcard：通配符， full_path: 全路径。
        /// </summary>
        [JsonProperty("match_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MatchType { get; set; }

        /// <summary>
        /// 需要替换的URI。 以正斜线（/）开头的URI，不含http(s)://头及域名。 长度不超过512个字符。 支持通配符\\*匹配，如：/test/\\*_/\\*.mp4。 匹配方式为“所有文件”时，不支持配置参数。
        /// </summary>
        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// 以正斜线（/）开头的URI，不含http(s)://头及域名。 长度不超过256个字符。 通配符 * 可通过$n捕获（n&#x3D;1,2,3...，例如：/newtest/$1/$2.jpg）。
        /// </summary>
        [JsonProperty("target_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginRequestUrlRewrite {\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  matchType: ").Append(MatchType).Append("\n");
            sb.Append("  sourceUrl: ").Append(SourceUrl).Append("\n");
            sb.Append("  targetUrl: ").Append(TargetUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OriginRequestUrlRewrite);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OriginRequestUrlRewrite input)
        {
            if (input == null) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.MatchType != input.MatchType || (this.MatchType != null && !this.MatchType.Equals(input.MatchType))) return false;
            if (this.SourceUrl != input.SourceUrl || (this.SourceUrl != null && !this.SourceUrl.Equals(input.SourceUrl))) return false;
            if (this.TargetUrl != input.TargetUrl || (this.TargetUrl != null && !this.TargetUrl.Equals(input.TargetUrl))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.MatchType != null) hashCode = hashCode * 59 + this.MatchType.GetHashCode();
                if (this.SourceUrl != null) hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.TargetUrl != null) hashCode = hashCode * 59 + this.TargetUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
