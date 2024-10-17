using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AttachInternetBandwidth 
    {

        /// <summary>
        /// 全域弹性公网IP段的ID
        /// </summary>
        [JsonProperty("global_eip_segment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipSegmentId { get; set; }

        /// <summary>
        /// 全域公网带宽的ID
        /// </summary>
        [JsonProperty("internet_bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InternetBandwidthId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachInternetBandwidth {\n");
            sb.Append("  globalEipSegmentId: ").Append(GlobalEipSegmentId).Append("\n");
            sb.Append("  internetBandwidthId: ").Append(InternetBandwidthId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachInternetBandwidth);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachInternetBandwidth input)
        {
            if (input == null) return false;
            if (this.GlobalEipSegmentId != input.GlobalEipSegmentId || (this.GlobalEipSegmentId != null && !this.GlobalEipSegmentId.Equals(input.GlobalEipSegmentId))) return false;
            if (this.InternetBandwidthId != input.InternetBandwidthId || (this.InternetBandwidthId != null && !this.InternetBandwidthId.Equals(input.InternetBandwidthId))) return false;

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
                if (this.GlobalEipSegmentId != null) hashCode = hashCode * 59 + this.GlobalEipSegmentId.GetHashCode();
                if (this.InternetBandwidthId != null) hashCode = hashCode * 59 + this.InternetBandwidthId.GetHashCode();
                return hashCode;
            }
        }
    }
}
