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
    public class CreateTrafficMirrorSessionRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_mirror_session", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTrafficMirrorSessionOption TrafficMirrorSession { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficMirrorSessionRequestBody {\n");
            sb.Append("  trafficMirrorSession: ").Append(TrafficMirrorSession).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficMirrorSessionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficMirrorSessionRequestBody input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorSession != input.TrafficMirrorSession || (this.TrafficMirrorSession != null && !this.TrafficMirrorSession.Equals(input.TrafficMirrorSession))) return false;

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
                if (this.TrafficMirrorSession != null) hashCode = hashCode * 59 + this.TrafficMirrorSession.GetHashCode();
                return hashCode;
            }
        }
    }
}
