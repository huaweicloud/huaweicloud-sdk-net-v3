using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowNetworkAvailableIpRequest 
    {

        /// <summary>
        /// **参数解释**：网络ID。取值自网络详情的metadata.name字段。 **约束限制**：1 - 64字符，字母、数字和中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("network_name", IsPath = true)]
        [JsonProperty("network_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkName { get; set; }

        /// <summary>
        /// **参数解释**：子网ID。取值自网络详情status.subnets字段中的networkId字段。 **约束限制**：1 - 64字符，字母、数字和中划线。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("network_id", IsQuery = true)]
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowNetworkAvailableIpRequest {\n");
            sb.Append("  networkName: ").Append(NetworkName).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowNetworkAvailableIpRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowNetworkAvailableIpRequest input)
        {
            if (input == null) return false;
            if (this.NetworkName != input.NetworkName || (this.NetworkName != null && !this.NetworkName.Equals(input.NetworkName))) return false;
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
                if (this.NetworkName != null) hashCode = hashCode * 59 + this.NetworkName.GetHashCode();
                if (this.NetworkId != null) hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                return hashCode;
            }
        }
    }
}
