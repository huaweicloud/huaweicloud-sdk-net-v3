using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ClientNetworkRequestBody 
    {

        /// <summary>
        /// 客户端所在网段。 跨网段访问配置只有在客户端与副本集实例部署在不同网段的情况下才需要配置，例如访问副本集的客户端所在网段为192.168.0.0/16，副本集所在的网段为172.16.0.0/24，则需要添加跨网段配置192.168.0.0/16才能正常访问。只有副本集有该功能。 注意：源端ECS连接实例的前提是与实例节点网络通信正常，如果网络不通，可以参考对等连接进行相关配置。
        /// </summary>
        [JsonProperty("client_network_ranges", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ClientNetworkRanges { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ClientNetworkRequestBody {\n");
            sb.Append("  clientNetworkRanges: ").Append(ClientNetworkRanges).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ClientNetworkRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ClientNetworkRequestBody input)
        {
            if (input == null) return false;
            if (this.ClientNetworkRanges != input.ClientNetworkRanges || (this.ClientNetworkRanges != null && input.ClientNetworkRanges != null && !this.ClientNetworkRanges.SequenceEqual(input.ClientNetworkRanges))) return false;

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
                if (this.ClientNetworkRanges != null) hashCode = hashCode * 59 + this.ClientNetworkRanges.GetHashCode();
                return hashCode;
            }
        }
    }
}
