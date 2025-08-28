using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 创建域间带宽的详情信息。
    /// </summary>
    public class CreateInterRegionBandwidth 
    {

        /// <summary>
        /// 云连接实例ID。
        /// </summary>
        [JsonProperty("cloud_connection_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CloudConnectionId { get; set; }

        /// <summary>
        /// 带宽包实例ID。
        /// </summary>
        [JsonProperty("bandwidth_package_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// 域间带宽值。
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// 域间RegionID。
        /// </summary>
        [JsonProperty("inter_region_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InterRegionIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateInterRegionBandwidth {\n");
            sb.Append("  cloudConnectionId: ").Append(CloudConnectionId).Append("\n");
            sb.Append("  bandwidthPackageId: ").Append(BandwidthPackageId).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  interRegionIds: ").Append(InterRegionIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateInterRegionBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateInterRegionBandwidth input)
        {
            if (input == null) return false;
            if (this.CloudConnectionId != input.CloudConnectionId || (this.CloudConnectionId != null && !this.CloudConnectionId.Equals(input.CloudConnectionId))) return false;
            if (this.BandwidthPackageId != input.BandwidthPackageId || (this.BandwidthPackageId != null && !this.BandwidthPackageId.Equals(input.BandwidthPackageId))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.InterRegionIds != input.InterRegionIds || (this.InterRegionIds != null && input.InterRegionIds != null && !this.InterRegionIds.SequenceEqual(input.InterRegionIds))) return false;

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
                if (this.CloudConnectionId != null) hashCode = hashCode * 59 + this.CloudConnectionId.GetHashCode();
                if (this.BandwidthPackageId != null) hashCode = hashCode * 59 + this.BandwidthPackageId.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.InterRegionIds != null) hashCode = hashCode * 59 + this.InterRegionIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
