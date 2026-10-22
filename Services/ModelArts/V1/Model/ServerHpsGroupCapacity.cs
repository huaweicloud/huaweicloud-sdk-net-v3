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
    public class ServerHpsGroupCapacity 
    {

        /// <summary>
        /// **参数解释**：可用区。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**：hyperinstance-group ID。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceGroupId { get; set; }

        /// <summary>
        /// **参数解释**：hyperinstance-group名称。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceGroupName { get; set; }

        /// <summary>
        /// **参数解释**：超节点集群ID。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HyperinstanceClusterId { get; set; }

        /// <summary>
        /// **参数解释**：规格名称。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }

        /// <summary>
        /// **参数解释**：是否售罄。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("is_sold_out", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSoldOut { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerHpsGroupCapacity {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  hyperinstanceGroupId: ").Append(HyperinstanceGroupId).Append("\n");
            sb.Append("  hyperinstanceGroupName: ").Append(HyperinstanceGroupName).Append("\n");
            sb.Append("  hyperinstanceClusterId: ").Append(HyperinstanceClusterId).Append("\n");
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
            return this.Equals(input as ServerHpsGroupCapacity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerHpsGroupCapacity input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.HyperinstanceGroupId != input.HyperinstanceGroupId || (this.HyperinstanceGroupId != null && !this.HyperinstanceGroupId.Equals(input.HyperinstanceGroupId))) return false;
            if (this.HyperinstanceGroupName != input.HyperinstanceGroupName || (this.HyperinstanceGroupName != null && !this.HyperinstanceGroupName.Equals(input.HyperinstanceGroupName))) return false;
            if (this.HyperinstanceClusterId != input.HyperinstanceClusterId || (this.HyperinstanceClusterId != null && !this.HyperinstanceClusterId.Equals(input.HyperinstanceClusterId))) return false;
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
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.HyperinstanceGroupId != null) hashCode = hashCode * 59 + this.HyperinstanceGroupId.GetHashCode();
                if (this.HyperinstanceGroupName != null) hashCode = hashCode * 59 + this.HyperinstanceGroupName.GetHashCode();
                if (this.HyperinstanceClusterId != null) hashCode = hashCode * 59 + this.HyperinstanceClusterId.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                if (this.IsSoldOut != null) hashCode = hashCode * 59 + this.IsSoldOut.GetHashCode();
                return hashCode;
            }
        }
    }
}
