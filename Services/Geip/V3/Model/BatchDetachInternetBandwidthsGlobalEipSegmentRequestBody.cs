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
    public class BatchDetachInternetBandwidthsGlobalEipSegmentRequestBody 
    {

        /// <summary>
        /// 请求列表
        /// </summary>
        [JsonProperty("global_eip_segments", NullValueHandling = NullValueHandling.Ignore)]
        public List<DetachInternetBandwidth> GlobalEipSegments { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchDetachInternetBandwidthsGlobalEipSegmentRequestBody {\n");
            sb.Append("  globalEipSegments: ").Append(GlobalEipSegments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchDetachInternetBandwidthsGlobalEipSegmentRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchDetachInternetBandwidthsGlobalEipSegmentRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GlobalEipSegments == input.GlobalEipSegments ||
                    this.GlobalEipSegments != null &&
                    input.GlobalEipSegments != null &&
                    this.GlobalEipSegments.SequenceEqual(input.GlobalEipSegments)
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
                if (this.GlobalEipSegments != null)
                    hashCode = hashCode * 59 + this.GlobalEipSegments.GetHashCode();
                return hashCode;
            }
        }
    }
}
