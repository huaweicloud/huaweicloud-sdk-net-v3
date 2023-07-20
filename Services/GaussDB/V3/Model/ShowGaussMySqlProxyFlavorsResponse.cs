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
    public class ShowGaussMySqlProxyFlavorsResponse : SdkResponse
    {

        /// <summary>
        /// 规格组信息。
        /// </summary>
        [JsonProperty("proxy_flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlProxyFlavorGroups> ProxyFlavorGroups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlProxyFlavorsResponse {\n");
            sb.Append("  proxyFlavorGroups: ").Append(ProxyFlavorGroups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlProxyFlavorsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlProxyFlavorsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProxyFlavorGroups == input.ProxyFlavorGroups ||
                    this.ProxyFlavorGroups != null &&
                    input.ProxyFlavorGroups != null &&
                    this.ProxyFlavorGroups.SequenceEqual(input.ProxyFlavorGroups)
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
                if (this.ProxyFlavorGroups != null)
                    hashCode = hashCode * 59 + this.ProxyFlavorGroups.GetHashCode();
                return hashCode;
            }
        }
    }
}
