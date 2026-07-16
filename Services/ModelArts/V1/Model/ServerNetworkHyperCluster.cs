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
    /// **参数解释**：创建服务器的参数面网络信息。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
    /// </summary>
    public class ServerNetworkHyperCluster 
    {

        /// <summary>
        /// 参数解释：HyperCluster的id。 约束限制：不涉及。 取值范围：不涉及。 默认取值：不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数解释：HyperCluster的子网id。 约束限制：不涉及。 取值范围：不涉及。 默认取值：不涉及。
        /// </summary>
        [JsonProperty("hyper_cluster_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperClusterSubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerNetworkHyperCluster {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  hyperClusterSubnetId: ").Append(HyperClusterSubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerNetworkHyperCluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerNetworkHyperCluster input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.HyperClusterSubnetId != input.HyperClusterSubnetId || (this.HyperClusterSubnetId != null && !this.HyperClusterSubnetId.Equals(input.HyperClusterSubnetId))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.HyperClusterSubnetId != null) hashCode = hashCode * 59 + this.HyperClusterSubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
