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
    /// This is a auto create Body Object
    /// </summary>
    public class BatchResizeVolumeRequestBody 
    {

        /// <summary>
        /// The list of disks to be expanded.
        /// </summary>
        [JsonProperty("volumes", NullValueHandling = NullValueHandling.Ignore)]
        public List<VolumesForBatchResizeVolume> Volumes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bss_param", NullValueHandling = NullValueHandling.Ignore)]
        public PrepaidParamForBatchResizeVolume BssParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchResizeVolumeRequestBody {\n");
            sb.Append("  volumes: ").Append(Volumes).Append("\n");
            sb.Append("  bssParam: ").Append(BssParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchResizeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchResizeVolumeRequestBody input)
        {
            if (input == null) return false;
            if (this.Volumes != input.Volumes || (this.Volumes != null && input.Volumes != null && !this.Volumes.SequenceEqual(input.Volumes))) return false;
            if (this.BssParam != input.BssParam || (this.BssParam != null && !this.BssParam.Equals(input.BssParam))) return false;

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
                if (this.Volumes != null) hashCode = hashCode * 59 + this.Volumes.GetHashCode();
                if (this.BssParam != null) hashCode = hashCode * 59 + this.BssParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
