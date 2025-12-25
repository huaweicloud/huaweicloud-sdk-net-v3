using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsArtifact.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ReleaseStorageVOV5 
    {

        /// <summary>
        /// **参数解释**: 已使用存储量 - --带单位。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("used_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedCapacity { get; set; }

        /// <summary>
        /// **参数解释**: 租户存储最大量 - --带单位。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total_capacity", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCapacity { get; set; }

        /// <summary>
        /// **参数解释**: 已使用存储量 - --字节。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("used_capacity_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? UsedCapacitySize { get; set; }

        /// <summary>
        /// **参数解释**: 租户存储最大量 - --字节。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total_capacity_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCapacitySize { get; set; }

        /// <summary>
        /// **参数解释**: 包周期套餐类型(0.no_package 1.basic 2.professional 3.platinum)。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("package_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PackageType { get; set; }

        /// <summary>
        /// **参数解释**: 项目仓库数量。 **取值范围**: 不涉及。 
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReleaseStorageVOV5 {\n");
            sb.Append("  usedCapacity: ").Append(UsedCapacity).Append("\n");
            sb.Append("  totalCapacity: ").Append(TotalCapacity).Append("\n");
            sb.Append("  usedCapacitySize: ").Append(UsedCapacitySize).Append("\n");
            sb.Append("  totalCapacitySize: ").Append(TotalCapacitySize).Append("\n");
            sb.Append("  packageType: ").Append(PackageType).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ReleaseStorageVOV5);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ReleaseStorageVOV5 input)
        {
            if (input == null) return false;
            if (this.UsedCapacity != input.UsedCapacity || (this.UsedCapacity != null && !this.UsedCapacity.Equals(input.UsedCapacity))) return false;
            if (this.TotalCapacity != input.TotalCapacity || (this.TotalCapacity != null && !this.TotalCapacity.Equals(input.TotalCapacity))) return false;
            if (this.UsedCapacitySize != input.UsedCapacitySize || (this.UsedCapacitySize != null && !this.UsedCapacitySize.Equals(input.UsedCapacitySize))) return false;
            if (this.TotalCapacitySize != input.TotalCapacitySize || (this.TotalCapacitySize != null && !this.TotalCapacitySize.Equals(input.TotalCapacitySize))) return false;
            if (this.PackageType != input.PackageType || (this.PackageType != null && !this.PackageType.Equals(input.PackageType))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;

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
                if (this.UsedCapacity != null) hashCode = hashCode * 59 + this.UsedCapacity.GetHashCode();
                if (this.TotalCapacity != null) hashCode = hashCode * 59 + this.TotalCapacity.GetHashCode();
                if (this.UsedCapacitySize != null) hashCode = hashCode * 59 + this.UsedCapacitySize.GetHashCode();
                if (this.TotalCapacitySize != null) hashCode = hashCode * 59 + this.TotalCapacitySize.GetHashCode();
                if (this.PackageType != null) hashCode = hashCode * 59 + this.PackageType.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
