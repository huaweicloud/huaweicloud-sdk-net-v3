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
    /// 
    /// </summary>
    public class ServerRoceNetworkRequest 
    {

        /// <summary>
        /// **参数解释**：RoCE网络类型。 **约束限制**：不涉及。 **取值范围**：  - vxlan_roce  - roce_v2  **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkType { get; set; }

        /// <summary>
        /// **参数解释**：物理网络名称。 **约束限制**：^[-_.a-zA-Z0-9]{1,64}$。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("physical_network", NullValueHandling = NullValueHandling.Ignore)]
        public string PhysicalNetwork { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerRoceNetworkRequest {\n");
            sb.Append("  networkType: ").Append(NetworkType).Append("\n");
            sb.Append("  physicalNetwork: ").Append(PhysicalNetwork).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerRoceNetworkRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerRoceNetworkRequest input)
        {
            if (input == null) return false;
            if (this.NetworkType != input.NetworkType || (this.NetworkType != null && !this.NetworkType.Equals(input.NetworkType))) return false;
            if (this.PhysicalNetwork != input.PhysicalNetwork || (this.PhysicalNetwork != null && !this.PhysicalNetwork.Equals(input.PhysicalNetwork))) return false;

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
                if (this.NetworkType != null) hashCode = hashCode * 59 + this.NetworkType.GetHashCode();
                if (this.PhysicalNetwork != null) hashCode = hashCode * 59 + this.PhysicalNetwork.GetHashCode();
                return hashCode;
            }
        }
    }
}
