using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FlavorCategoryDetail 
    {

        /// <summary>
        /// **参数解释**: 计算规格组列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("compute_flavor_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<ComputeFlavorGroupDetail> ComputeFlavorGroups { get; set; }

        /// <summary>
        /// **参数解释**: 存储规格列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("volume_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeFlavorItemDetail> VolumeFlavors { get; set; }

        /// <summary>
        /// **参数解释**: DeC专属规格列表。 **取值范围**: 不涉及。
        /// </summary>
        [JsonProperty("dec_service_flavors", NullValueHandling = NullValueHandling.Ignore)]
        public List<DecServiceFlavorItemDetail> DecServiceFlavors { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlavorCategoryDetail {\n");
            sb.Append("  computeFlavorGroups: ").Append(ComputeFlavorGroups).Append("\n");
            sb.Append("  volumeFlavors: ").Append(VolumeFlavors).Append("\n");
            sb.Append("  decServiceFlavors: ").Append(DecServiceFlavors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FlavorCategoryDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FlavorCategoryDetail input)
        {
            if (input == null) return false;
            if (this.ComputeFlavorGroups != input.ComputeFlavorGroups || (this.ComputeFlavorGroups != null && input.ComputeFlavorGroups != null && !this.ComputeFlavorGroups.SequenceEqual(input.ComputeFlavorGroups))) return false;
            if (this.VolumeFlavors != input.VolumeFlavors || (this.VolumeFlavors != null && input.VolumeFlavors != null && !this.VolumeFlavors.SequenceEqual(input.VolumeFlavors))) return false;
            if (this.DecServiceFlavors != input.DecServiceFlavors || (this.DecServiceFlavors != null && input.DecServiceFlavors != null && !this.DecServiceFlavors.SequenceEqual(input.DecServiceFlavors))) return false;

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
                if (this.ComputeFlavorGroups != null) hashCode = hashCode * 59 + this.ComputeFlavorGroups.GetHashCode();
                if (this.VolumeFlavors != null) hashCode = hashCode * 59 + this.VolumeFlavors.GetHashCode();
                if (this.DecServiceFlavors != null) hashCode = hashCode * 59 + this.DecServiceFlavors.GetHashCode();
                return hashCode;
            }
        }
    }
}
