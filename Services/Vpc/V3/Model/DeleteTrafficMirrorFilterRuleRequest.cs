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
    public class DeleteTrafficMirrorFilterRuleRequest 
    {

        /// <summary>
        /// 流量镜像筛选条件规则ID
        /// </summary>
        [SDKProperty("traffic_mirror_filter_rule_id", IsPath = true)]
        [JsonProperty("traffic_mirror_filter_rule_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficMirrorFilterRuleId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteTrafficMirrorFilterRuleRequest {\n");
            sb.Append("  trafficMirrorFilterRuleId: ").Append(TrafficMirrorFilterRuleId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteTrafficMirrorFilterRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteTrafficMirrorFilterRuleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrafficMirrorFilterRuleId == input.TrafficMirrorFilterRuleId ||
                    (this.TrafficMirrorFilterRuleId != null &&
                    this.TrafficMirrorFilterRuleId.Equals(input.TrafficMirrorFilterRuleId))
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
                if (this.TrafficMirrorFilterRuleId != null)
                    hashCode = hashCode * 59 + this.TrafficMirrorFilterRuleId.GetHashCode();
                return hashCode;
            }
        }
    }
}
