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
    public class HyperinstanceGroupsCapacityRequest 
    {

        /// <summary>
        /// **参数解释**：hyperinstance-group ID列表。 **默认取值**：不涉及。 **取值范围**：1-5
        /// </summary>
        [JsonProperty("hyperinstance_group_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HyperinstanceGroupIds { get; set; }

        /// <summary>
        /// **参数解释**：可用区。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// **参数解释**：规格名称。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HyperinstanceGroupsCapacityRequest {\n");
            sb.Append("  hyperinstanceGroupIds: ").Append(HyperinstanceGroupIds).Append("\n");
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
            return this.Equals(input as HyperinstanceGroupsCapacityRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HyperinstanceGroupsCapacityRequest input)
        {
            if (input == null) return false;
            if (this.HyperinstanceGroupIds != input.HyperinstanceGroupIds || (this.HyperinstanceGroupIds != null && input.HyperinstanceGroupIds != null && !this.HyperinstanceGroupIds.SequenceEqual(input.HyperinstanceGroupIds))) return false;
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
                if (this.HyperinstanceGroupIds != null) hashCode = hashCode * 59 + this.HyperinstanceGroupIds.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
