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
    public class HyperinstanceClustersCapacityRequest 
    {

        /// <summary>
        /// **参数解释**：超节点集群ID列表。 **约束限制**：数组长度0-5，每个元素长度1-128字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("hyperinstance_cluster_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HyperinstanceClusterIds { get; set; }

        /// <summary>
        /// **参数解释**：规格名称。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释**：可用区。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**：资源规格。 **约束限制**：长度1-65536个字符。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperinstanceClustersCapacityRequest {\n");
            sb.Append("  hyperinstanceClusterIds: ").Append(HyperinstanceClusterIds).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HyperinstanceClustersCapacityRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperinstanceClustersCapacityRequest input)
        {
            if (input == null) return false;
            if (this.HyperinstanceClusterIds != input.HyperinstanceClusterIds || (this.HyperinstanceClusterIds != null && input.HyperinstanceClusterIds != null && !this.HyperinstanceClusterIds.SequenceEqual(input.HyperinstanceClusterIds))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;

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
                if (this.HyperinstanceClusterIds != null) hashCode = hashCode * 59 + this.HyperinstanceClusterIds.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
