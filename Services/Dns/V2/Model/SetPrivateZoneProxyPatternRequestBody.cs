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
        /// 内网Zone的子域名递归解析代理模式。  取值范围：  AUTHORITY：当前Zone不进行递归解析 RECURSIVE：开启递归解析代理
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
            if (input == null)
                return false;

            return 
                (
                    this.ProxyPattern == input.ProxyPattern ||
                    (this.ProxyPattern != null &&
                    this.ProxyPattern.Equals(input.ProxyPattern))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ProxyPattern != null)
                    hashCode = hashCode * 59 + this.ProxyPattern.GetHashCode();
                return hashCode;
            }
        }
    }
}
