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
    public class ShowGaussMySqlProxyListResponse : SdkResponse
    {

        /// <summary>
        /// Proxy实例信息列表。
        /// </summary>
        [JsonProperty("proxy_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MysqlShowProxyResponseV3> ProxyList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGaussMySqlProxyListResponse {\n");
            sb.Append("  proxyList: ").Append(ProxyList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGaussMySqlProxyListResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGaussMySqlProxyListResponse input)
        {
            if (input == null) return false;
            if (this.ProxyList != input.ProxyList || (this.ProxyList != null && input.ProxyList != null && !this.ProxyList.SequenceEqual(input.ProxyList))) return false;

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
                if (this.ProxyList != null) hashCode = hashCode * 59 + this.ProxyList.GetHashCode();
                return hashCode;
            }
        }
    }
}
