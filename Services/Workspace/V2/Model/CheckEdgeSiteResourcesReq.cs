using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 校验边缘站点资源请求体。
    /// </summary>
    public class CheckEdgeSiteResourcesReq 
    {

        /// <summary>
        /// 可用区id。
        /// </summary>
        [JsonProperty("availability_zone_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneId { get; set; }

        /// <summary>
        /// 规格id。
        /// </summary>
        [JsonProperty("flavor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorId { get; set; }

        /// <summary>
        /// 需要的资源数量。
        /// </summary>
        [JsonProperty("resource_counts", NullValueHandling = NullValueHandling.Ignore)]
        public int? ResourceCounts { get; set; }

        /// <summary>
        /// 磁盘列表。包含系统盘。
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<CheckEdgeSiteResourcesVolume> Volumes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckEdgeSiteResourcesReq {\n");
            sb.Append("  availabilityZoneId: ").Append(AvailabilityZoneId).Append("\n");
            sb.Append("  flavorId: ").Append(FlavorId).Append("\n");
            sb.Append("  resourceCounts: ").Append(ResourceCounts).Append("\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckEdgeSiteResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckEdgeSiteResourcesReq input)
        {
            if (input == null) return false;
            if (this.AvailabilityZoneId != input.AvailabilityZoneId || (this.AvailabilityZoneId != null && !this.AvailabilityZoneId.Equals(input.AvailabilityZoneId))) return false;
            if (this.FlavorId != input.FlavorId || (this.FlavorId != null && !this.FlavorId.Equals(input.FlavorId))) return false;
            if (this.ResourceCounts != input.ResourceCounts || (this.ResourceCounts != null && !this.ResourceCounts.Equals(input.ResourceCounts))) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;

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
                if (this.AvailabilityZoneId != null) hashCode = hashCode * 59 + this.AvailabilityZoneId.GetHashCode();
                if (this.FlavorId != null) hashCode = hashCode * 59 + this.FlavorId.GetHashCode();
                if (this.ResourceCounts != null) hashCode = hashCode * 59 + this.ResourceCounts.GetHashCode();
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                return hashCode;
            }
        }
    }
}
