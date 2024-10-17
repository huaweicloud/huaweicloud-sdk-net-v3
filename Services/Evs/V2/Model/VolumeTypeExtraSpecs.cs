using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Evs.V2.Model
{
    /// <summary>
    /// 云硬盘类型的规格
    /// </summary>
    public class VolumeTypeExtraSpecs 
    {

        /// <summary>
        /// 支持当前云硬盘类型的可用区列表，列表的元素以逗号分隔。
        /// </summary>
        [JsonProperty("RESKEY:availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public string RESKEYavailabilityZones { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("availability-zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 当前云硬盘类型已售罄的可用区列表，列表的元素以逗号分隔。
        /// </summary>
        [JsonProperty("os-vendor-extended:sold_out_availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public string OsVendorExtendedsoldOutAvailabilityZones { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("volume_backend_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeBackendName { get; set; }

        /// <summary>
        /// 预留属性。
        /// </summary>
        [JsonProperty("HW:availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string HWavailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumeTypeExtraSpecs {\n");
            sb.Append("  rESKEYavailabilityZones: ").Append(RESKEYavailabilityZones).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  osVendorExtendedsoldOutAvailabilityZones: ").Append(OsVendorExtendedsoldOutAvailabilityZones).Append("\n");
            sb.Append("  volumeBackendName: ").Append(VolumeBackendName).Append("\n");
            sb.Append("  hWavailabilityZone: ").Append(HWavailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumeTypeExtraSpecs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumeTypeExtraSpecs input)
        {
            if (input == null) return false;
            if (this.RESKEYavailabilityZones != input.RESKEYavailabilityZones || (this.RESKEYavailabilityZones != null && !this.RESKEYavailabilityZones.Equals(input.RESKEYavailabilityZones))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.OsVendorExtendedsoldOutAvailabilityZones != input.OsVendorExtendedsoldOutAvailabilityZones || (this.OsVendorExtendedsoldOutAvailabilityZones != null && !this.OsVendorExtendedsoldOutAvailabilityZones.Equals(input.OsVendorExtendedsoldOutAvailabilityZones))) return false;
            if (this.VolumeBackendName != input.VolumeBackendName || (this.VolumeBackendName != null && !this.VolumeBackendName.Equals(input.VolumeBackendName))) return false;
            if (this.HWavailabilityZone != input.HWavailabilityZone || (this.HWavailabilityZone != null && !this.HWavailabilityZone.Equals(input.HWavailabilityZone))) return false;

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
                if (this.RESKEYavailabilityZones != null) hashCode = hashCode * 59 + this.RESKEYavailabilityZones.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.OsVendorExtendedsoldOutAvailabilityZones != null) hashCode = hashCode * 59 + this.OsVendorExtendedsoldOutAvailabilityZones.GetHashCode();
                if (this.VolumeBackendName != null) hashCode = hashCode * 59 + this.VolumeBackendName.GetHashCode();
                if (this.HWavailabilityZone != null) hashCode = hashCode * 59 + this.HWavailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
