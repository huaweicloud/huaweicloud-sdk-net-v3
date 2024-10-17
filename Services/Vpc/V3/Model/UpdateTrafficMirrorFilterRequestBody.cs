using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTrafficMirrorFilterRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_mirror_filter", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrafficMirrorFilterOption TrafficMirrorFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrafficMirrorFilterRequestBody {\n");
            sb.Append("  trafficMirrorFilter: ").Append(TrafficMirrorFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrafficMirrorFilterRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrafficMirrorFilterRequestBody input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorFilter != input.TrafficMirrorFilter || (this.TrafficMirrorFilter != null && !this.TrafficMirrorFilter.Equals(input.TrafficMirrorFilter))) return false;

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
                if (this.TrafficMirrorFilter != null) hashCode = hashCode * 59 + this.TrafficMirrorFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
