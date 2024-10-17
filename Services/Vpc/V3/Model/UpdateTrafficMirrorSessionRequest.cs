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
    /// Request Object
    /// </summary>
    public class UpdateTrafficMirrorSessionRequest 
    {

        /// <summary>
        /// 流量镜像会话ID
        /// </summary>
        [SDKProperty("traffic_mirror_session_id", IsPath = true)]
        [JsonProperty("traffic_mirror_session_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrafficMirrorSessionRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrafficMirrorSessionRequest {\n");
            sb.Append("  trafficMirrorSessionId: ").Append(TrafficMirrorSessionId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrafficMirrorSessionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrafficMirrorSessionRequest input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorSessionId != input.TrafficMirrorSessionId || (this.TrafficMirrorSessionId != null && !this.TrafficMirrorSessionId.Equals(input.TrafficMirrorSessionId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.TrafficMirrorSessionId != null) hashCode = hashCode * 59 + this.TrafficMirrorSessionId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
