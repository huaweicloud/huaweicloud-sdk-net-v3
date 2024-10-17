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
    public class UpdateTrafficMirrorFilterRuleRequest 
    {

        /// <summary>
        /// 流量镜像筛选条件规则ID
        /// </summary>
        [SDKProperty("traffic_mirror_filter_rule_id", IsPath = true)]
        [JsonProperty("traffic_mirror_filter_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterRuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateTrafficMirrorFilterRuleRequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTrafficMirrorFilterRuleRequest {\n");
            sb.Append("  trafficMirrorFilterRuleId: ").Append(TrafficMirrorFilterRuleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTrafficMirrorFilterRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTrafficMirrorFilterRuleRequest input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorFilterRuleId != input.TrafficMirrorFilterRuleId || (this.TrafficMirrorFilterRuleId != null && !this.TrafficMirrorFilterRuleId.Equals(input.TrafficMirrorFilterRuleId))) return false;
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
                if (this.TrafficMirrorFilterRuleId != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterRuleId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
