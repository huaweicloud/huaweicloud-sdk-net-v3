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
    public class BatchCreateTrafficMirrorFilterRulesRequestBody 
    {

        /// <summary>
        /// 流量镜像筛选条件规则对象列表
        /// </summary>
        [JsonProperty("traffic_mirror_filter_rules", NullValueHandling = NullValueHandling.Ignore)]
        public List<BatchCreateTrafficMirrorFilterRuleOption> TrafficMirrorFilterRules { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateTrafficMirrorFilterRulesRequestBody {\n");
            sb.Append("  trafficMirrorFilterRules: ").Append(TrafficMirrorFilterRules).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateTrafficMirrorFilterRulesRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateTrafficMirrorFilterRulesRequestBody input)
        {
            if (input == null) return false;
            if (this.TrafficMirrorFilterRules != input.TrafficMirrorFilterRules || (this.TrafficMirrorFilterRules != null && input.TrafficMirrorFilterRules != null && !this.TrafficMirrorFilterRules.SequenceEqual(input.TrafficMirrorFilterRules))) return false;

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
                if (this.TrafficMirrorFilterRules != null) hashCode = hashCode * 59 + this.TrafficMirrorFilterRules.GetHashCode();
                return hashCode;
            }
        }
    }
}
