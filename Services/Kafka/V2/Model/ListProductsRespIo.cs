using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ListProductsRespIo 
    {

        /// <summary>
        /// **参数解释**： IO类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("io_type", NullValueHandling = NullValueHandling.Ignore)]
        public string IoType { get; set; }

        /// <summary>
        /// **参数解释**： IO规格。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("storage_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageSpecCode { get; set; }

        /// <summary>
        /// **参数解释**： IO未售罄的可用区列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("available_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// **参数解释**： IO已售罄的不可用区列表。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("unavailable_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UnavailableZones { get; set; }

        /// <summary>
        /// **参数解释**： 磁盘类型。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListProductsRespIo {\n");
            sb.Append("  ioType: ").Append(IoType).Append("\n");
            sb.Append("  storageSpecCode: ").Append(StorageSpecCode).Append("\n");
            sb.Append("  availableZones: ").Append(AvailableZones).Append("\n");
            sb.Append("  unavailableZones: ").Append(UnavailableZones).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListProductsRespIo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListProductsRespIo input)
        {
            if (input == null) return false;
            if (this.IoType != input.IoType || (this.IoType != null && !this.IoType.Equals(input.IoType))) return false;
            if (this.StorageSpecCode != input.StorageSpecCode || (this.StorageSpecCode != null && !this.StorageSpecCode.Equals(input.StorageSpecCode))) return false;
            if (this.AvailableZones != input.AvailableZones || (this.AvailableZones != null && input.AvailableZones != null && !this.AvailableZones.SequenceEqual(input.AvailableZones))) return false;
            if (this.UnavailableZones != input.UnavailableZones || (this.UnavailableZones != null && input.UnavailableZones != null && !this.UnavailableZones.SequenceEqual(input.UnavailableZones))) return false;
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
                if (this.IoType != null) hashCode = hashCode * 59 + this.IoType.GetHashCode();
                if (this.StorageSpecCode != null) hashCode = hashCode * 59 + this.StorageSpecCode.GetHashCode();
                if (this.AvailableZones != null) hashCode = hashCode * 59 + this.AvailableZones.GetHashCode();
                if (this.UnavailableZones != null) hashCode = hashCode * 59 + this.UnavailableZones.GetHashCode();
                if (this.VolumeType != null) hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                return hashCode;
            }
        }
    }
}
