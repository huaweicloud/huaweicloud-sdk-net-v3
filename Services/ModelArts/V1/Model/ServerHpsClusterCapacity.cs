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
    public class ServerHpsClusterCapacity 
    {

        /// <summary>
        /// **参数解释**：规格名称。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：可用区ID。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群ID。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceClusterId { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群名称。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceClusterName { get; set; }

        /// <summary>
        /// **参数解释**：资源规格。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }

        /// <summary>
        /// **参数解释**：售罄状态。 **约束限制**：布尔值（true/false）。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSoldOut { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerHpsClusterCapacity {\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  hyperinstanceClusterId: ").Append(HyperinstanceClusterId).Append("\n");
            sb.Append("  hyperinstanceClusterName: ").Append(HyperinstanceClusterName).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("  isSoldOut: ").Append(IsSoldOut).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerHpsClusterCapacity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerHpsClusterCapacity input)
        {
            if (input == null) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.HyperinstanceClusterId != input.HyperinstanceClusterId || (this.HyperinstanceClusterId != null && !this.HyperinstanceClusterId.Equals(input.HyperinstanceClusterId))) return false;
            if (this.HyperinstanceClusterName != input.HyperinstanceClusterName || (this.HyperinstanceClusterName != null && !this.HyperinstanceClusterName.Equals(input.HyperinstanceClusterName))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;
            if (this.IsSoldOut != input.IsSoldOut || (this.IsSoldOut != null && !this.IsSoldOut.Equals(input.IsSoldOut))) return false;

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
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.HyperinstanceClusterId != null) hashCode = hashCode * 59 + this.HyperinstanceClusterId.GetHashCode();
                if (this.HyperinstanceClusterName != null) hashCode = hashCode * 59 + this.HyperinstanceClusterName.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                if (this.IsSoldOut != null) hashCode = hashCode * 59 + this.IsSoldOut.GetHashCode();
                return hashCode;
            }
        }
    }
}
