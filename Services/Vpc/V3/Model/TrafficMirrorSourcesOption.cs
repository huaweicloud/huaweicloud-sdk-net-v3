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
    public class TrafficMirrorSourcesOption 
    {

        /// <summary>
        /// 功能说明：镜像源ID列表
        /// </summary>
        [JsonProperty("traffic_mirror_sources", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> TrafficMirrorSources { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrafficMirrorSourcesOption {\n");
            sb.Append("  trafficMirrorSources: ").Append(TrafficMirrorSources).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TrafficMirrorSourcesOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TrafficMirrorSourcesOption input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorSources != input.TrafficMirrorSources || (this.TrafficMirrorSources != null && input.TrafficMirrorSources != null && !this.TrafficMirrorSources.SequenceEqual(input.TrafficMirrorSources))) return false;

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
                if (this.TrafficMirrorSources != null) hashCode = hashCode * 59 + this.TrafficMirrorSources.GetHashCode();
                return hashCode;
            }
        }
    }
}
