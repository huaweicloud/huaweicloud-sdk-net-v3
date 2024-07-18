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
    /// 退订包周期云硬盘的请求body体
    /// </summary>
    public class UnsubscribeVolumeRequestBody 
    {

        /// <summary>
        /// 退订包周期云硬盘的结果。
        /// </summary>
        [JsonProperty("volume_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> VolumeIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnsubscribeVolumeRequestBody {\n");
            sb.Append("  volumeIds: ").Append(VolumeIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnsubscribeVolumeRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnsubscribeVolumeRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VolumeIds == input.VolumeIds ||
                    this.VolumeIds != null &&
                    input.VolumeIds != null &&
                    this.VolumeIds.SequenceEqual(input.VolumeIds)
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
                if (this.VolumeIds != null)
                    hashCode = hashCode * 59 + this.VolumeIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
