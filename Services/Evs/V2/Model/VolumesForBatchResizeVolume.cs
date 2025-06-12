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
    /// 
    /// </summary>
    public class VolumesForBatchResizeVolume 
    {

        /// <summary>
        /// The disk ID.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// The new disk size, in GiB. This parameter value must be greater than the original disk size and less than the maximum size allowed for a disk. The maximum disk size: - Data disk: 32,768 GiB - System disk: 1,024 GiB
        /// </summary>
        [JsonProperty("new_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VolumesForBatchResizeVolume {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  newSize: ").Append(NewSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VolumesForBatchResizeVolume);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VolumesForBatchResizeVolume input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.NewSize != input.NewSize || (this.NewSize != null && !this.NewSize.Equals(input.NewSize))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NewSize != null) hashCode = hashCode * 59 + this.NewSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
