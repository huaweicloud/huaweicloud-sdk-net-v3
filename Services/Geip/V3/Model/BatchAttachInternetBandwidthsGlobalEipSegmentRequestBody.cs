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
    public class BatchAttachInternetBandwidthsGlobalEipSegmentRequestBody 
    {

        /// <summary>
        /// 请求列表
        /// </summary>
        [JsonProperty("global_eip_segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachInternetBandwidth> GlobalEipSegments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchAttachInternetBandwidthsGlobalEipSegmentRequestBody {\n");
            sb.Append("  globalEipSegments: ").Append(GlobalEipSegments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchAttachInternetBandwidthsGlobalEipSegmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchAttachInternetBandwidthsGlobalEipSegmentRequestBody input)
        {
            if (input == null) return false;
            if (this.GlobalEipSegments != input.GlobalEipSegments || (this.GlobalEipSegments != null && input.GlobalEipSegments != null && !this.GlobalEipSegments.SequenceEqual(input.GlobalEipSegments))) return false;

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
                if (this.GlobalEipSegments != null) hashCode = hashCode * 59 + this.GlobalEipSegments.GetHashCode();
                return hashCode;
            }
        }
    }
}
