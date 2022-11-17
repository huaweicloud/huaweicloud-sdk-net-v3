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
    /// Response Object
    /// </summary>
    public class CinderListVolumeTypesResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("volume_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumeType> VolumeTypes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CinderListVolumeTypesResponse {\n");
            sb.Append("  volumeTypes: ").Append(VolumeTypes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CinderListVolumeTypesResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CinderListVolumeTypesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeTypes == input.VolumeTypes ||
                    this.VolumeTypes != null &&
                    input.VolumeTypes != null &&
                    this.VolumeTypes.SequenceEqual(input.VolumeTypes)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.VolumeTypes != null)
                    hashCode = hashCode * 59 + this.VolumeTypes.GetHashCode();
                return hashCode;
            }
        }
    }
}
