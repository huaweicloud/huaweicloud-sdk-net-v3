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
    public class ShowTrafficMirrorFilterRequest 
    {

        /// <summary>
        /// 流量镜像筛选条件ID
        /// </summary>
        [SDKProperty("traffic_mirror_filter_id", IsPath = true)]
        [JsonProperty("traffic_mirror_filter_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowTrafficMirrorFilterRequest {\n");
            sb.Append("  trafficMirrorFilterId: ").Append(TrafficMirrorFilterId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowTrafficMirrorFilterRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowTrafficMirrorFilterRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrafficMirrorFilterId == input.TrafficMirrorFilterId ||
                    (this.TrafficMirrorFilterId != null &&
                    this.TrafficMirrorFilterId.Equals(input.TrafficMirrorFilterId))
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
                if (this.TrafficMirrorFilterId != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorFilterId.GetHashCode();
                return hashCode;
            }
        }
    }
}
