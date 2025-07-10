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
    /// Request Object
    /// </summary>
    public class ListVolumeProductInfoRequest 
    {

        /// <summary>
        /// 可用分区。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 磁盘类型（多个磁盘类型用逗号隔开）： - SATA: 普通IO磁盘 - SAS：高IO磁盘 - SSD：超高IO磁盘
        /// </summary>
        [SDKProperty("volume_type", IsQuery = true)]
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListVolumeProductInfoRequest {\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListVolumeProductInfoRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListVolumeProductInfoRequest input)
        {
            if (input == null) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.VolumeType != input.VolumeType || (this.VolumeType != null && !this.VolumeType.Equals(input.VolumeType))) return false;

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
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
