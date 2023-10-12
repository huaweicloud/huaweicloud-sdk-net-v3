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
    public class CreateTrafficMirrorFilterRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("traffic_mirror_filter", NullValueHandling = NullValueHandling.Ignore)]
        public CreateTrafficMirrorFilterOption TrafficMirrorFilter { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTrafficMirrorFilterRequestBody {\n");
            sb.Append("  trafficMirrorFilter: ").Append(TrafficMirrorFilter).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTrafficMirrorFilterRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTrafficMirrorFilterRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrafficMirrorFilter == input.TrafficMirrorFilter ||
                    (this.TrafficMirrorFilter != null &&
                    this.TrafficMirrorFilter.Equals(input.TrafficMirrorFilter))
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
                if (this.TrafficMirrorFilter != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorFilter.GetHashCode();
                return hashCode;
            }
        }
    }
}
