using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SetPrivateZoneProxyPatternRequestBody 
    {

        /// <summary>
        /// **参数解释：** 内网域名的子域名递归解析代理模式。 **约束限制：** 不涉及。 **取值范围：** - AUTHORITY：当前域名未开启递归解析代理 - RECURSIVE：当前域名已开启递归解析代理  **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("proxy_pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyPattern { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPrivateZoneProxyPatternRequestBody {\n");
            sb.Append("  proxyPattern: ").Append(ProxyPattern).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SetPrivateZoneProxyPatternRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SetPrivateZoneProxyPatternRequestBody input)
        {
            if (input == null) return false;
            if (this.ProxyPattern != input.ProxyPattern || (this.ProxyPattern != null && !this.ProxyPattern.Equals(input.ProxyPattern))) return false;

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
                if (this.ProxyPattern != null) hashCode = hashCode * 59 + this.ProxyPattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
