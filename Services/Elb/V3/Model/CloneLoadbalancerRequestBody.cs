using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V3.Model
{
    /// <summary>
    /// 复制负载均衡器接口请求体。
    /// </summary>
    public class CloneLoadbalancerRequestBody 
    {

        /// <summary>
        /// **参数解释**：单次最大复制数量。  **约束限制**：不涉及  **取值范围**：1-10  **默认取值**：1
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("target_loadbalancer_param", NullValueHandling = NullValueHandling.Ignore)]
        public TargetLoadbalancerParam TargetLoadbalancerParam { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneLoadbalancerRequestBody {\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  targetLoadbalancerParam: ").Append(TargetLoadbalancerParam).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CloneLoadbalancerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CloneLoadbalancerRequestBody input)
        {
            if (input == null) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.TargetLoadbalancerParam != input.TargetLoadbalancerParam || (this.TargetLoadbalancerParam != null && !this.TargetLoadbalancerParam.Equals(input.TargetLoadbalancerParam))) return false;

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
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.TargetLoadbalancerParam != null) hashCode = hashCode * 59 + this.TargetLoadbalancerParam.GetHashCode();
                return hashCode;
            }
        }
    }
}
