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
    /// Request Object
    /// </summary>
    public class DeleteGlobalEipSegmentRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("global_eip_segment_id", IsPath = true)]
        [JsonProperty("global_eip_segment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipSegmentId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteGlobalEipSegmentRequest {\n");
            sb.Append("  globalEipSegmentId: ").Append(GlobalEipSegmentId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteGlobalEipSegmentRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteGlobalEipSegmentRequest input)
        {
            if (input == null) return false;
            if (this.GlobalEipSegmentId != input.GlobalEipSegmentId || (this.GlobalEipSegmentId != null && !this.GlobalEipSegmentId.Equals(input.GlobalEipSegmentId))) return false;

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
                return hashCode;
            }
        }
    }
}
