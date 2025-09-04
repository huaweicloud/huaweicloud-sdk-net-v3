using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowProxyFlavorsByAzCodeResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  代理规格分组信息。
        /// </summary>
        [JsonProperty("proxy_flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProxyFlavorGroup> ProxyFlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowProxyFlavorsByAzCodeResponse {\n");
            sb.Append("  proxyFlavorGroups: ").Append(ProxyFlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowProxyFlavorsByAzCodeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowProxyFlavorsByAzCodeResponse input)
        {
            if (input == null) return false;
            if (this.ProxyFlavorGroups != input.ProxyFlavorGroups || (this.ProxyFlavorGroups != null && input.ProxyFlavorGroups != null && !this.ProxyFlavorGroups.SequenceEqual(input.ProxyFlavorGroups))) return false;

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
                if (this.ProxyFlavorGroups != null) hashCode = hashCode * 59 + this.ProxyFlavorGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
