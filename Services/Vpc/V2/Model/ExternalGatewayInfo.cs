using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalGatewayInfo 
    {

        /// <summary>
        /// 功能说明：是否启用SNAT 取值范围：true、false；默认为false。
        /// </summary>
        [JsonProperty("enable_snat", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSnat { get; set; }

        /// <summary>
        /// 外部网络的ID。
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalGatewayInfo {\n");
            sb.Append("  enableSnat: ").Append(EnableSnat).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalGatewayInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExternalGatewayInfo input)
        {
            if (input == null) return false;
            if (this.EnableSnat != input.EnableSnat || (this.EnableSnat != null && !this.EnableSnat.Equals(input.EnableSnat))) return false;
            if (this.NetworkId != input.NetworkId || (this.NetworkId != null && !this.NetworkId.Equals(input.NetworkId))) return false;

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
                if (this.EnableSnat != null) hashCode = hashCode * 59 + this.EnableSnat.GetHashCode();
                if (this.NetworkId != null) hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
