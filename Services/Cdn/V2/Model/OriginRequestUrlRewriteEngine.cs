using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 改写回源URL **约束限制：** 最多配置20条
    /// </summary>
    public class OriginRequestUrlRewriteEngine 
    {

        /// <summary>
        /// **参数解释：** 改写方式 **约束限制：** 不涉及 **取值范围：** - simple: 精确改写 - wildcard: 捕获改写 - regex: 正则改写（白名单功能，请提交工单开放该配置） **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("rewrite_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RewriteType { get; set; }

        /// <summary>
        /// **参数解释：** 需要替换的URI **约束限制：** 当rewrite_type为wildcard或regex时，该参数必填 当rewrite_type为regex时，该参数必填必须以“^/”开始，如：^/test **取值范围：** - 1-512个字符 - 支持通配符\\*匹配，如：/test/\\*_/\\*.mp4 - 以正斜线（/）开头的URI，不含http(s)://头及域名 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("source_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// **参数解释：** 替换后的URI **约束限制：** **取值范围：** - 1-256个字符 - 以正斜线（/）开头的URI，不含http(s)://头及域名  &gt; 通配符 * 可通过$n捕获（n&#x3D;1,2,3...，例如：/newtest/$1/$2.jpg）  **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("target_url", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginRequestUrlRewriteEngine {\n");
            sb.Append("  rewriteType: ").Append(RewriteType).Append("\n");
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
            return this.Equals(input as OriginRequestUrlRewriteEngine);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OriginRequestUrlRewriteEngine input)
        {
            if (input == null) return false;
            if (this.RewriteType != input.RewriteType || (this.RewriteType != null && !this.RewriteType.Equals(input.RewriteType))) return false;
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
                if (this.RewriteType != null) hashCode = hashCode * 59 + this.RewriteType.GetHashCode();
                if (this.SourceUrl != null) hashCode = hashCode * 59 + this.SourceUrl.GetHashCode();
                if (this.TargetUrl != null) hashCode = hashCode * 59 + this.TargetUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
