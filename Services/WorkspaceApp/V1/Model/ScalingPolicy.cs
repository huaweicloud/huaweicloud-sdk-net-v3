using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 弹性伸缩策略。
    /// </summary>
    public class ScalingPolicy 
    {

        /// <summary>
        /// 是否启用策略,默认启用： &#39;true&#39;: 启用 &#39;false&#39;: 禁用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 最大扩容数量。
        /// </summary>
        [JsonProperty("max_scaling_amount", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxScalingAmount { get; set; }

        /// <summary>
        /// 单次扩容数量。
        /// </summary>
        [JsonProperty("single_expansion_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? SingleExpansionCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("scaling_policy_by_session", NullValueHandling = NullValueHandling.Ignore)]
        public ScalingPolicyBySession ScalingPolicyBySession { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScalingPolicy {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  maxScalingAmount: ").Append(MaxScalingAmount).Append("\n");
            sb.Append("  singleExpansionCount: ").Append(SingleExpansionCount).Append("\n");
            sb.Append("  scalingPolicyBySession: ").Append(ScalingPolicyBySession).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScalingPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScalingPolicy input)
        {
            if (input == null) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.MaxScalingAmount != input.MaxScalingAmount || (this.MaxScalingAmount != null && !this.MaxScalingAmount.Equals(input.MaxScalingAmount))) return false;
            if (this.SingleExpansionCount != input.SingleExpansionCount || (this.SingleExpansionCount != null && !this.SingleExpansionCount.Equals(input.SingleExpansionCount))) return false;
            if (this.ScalingPolicyBySession != input.ScalingPolicyBySession || (this.ScalingPolicyBySession != null && !this.ScalingPolicyBySession.Equals(input.ScalingPolicyBySession))) return false;

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
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.MaxScalingAmount != null) hashCode = hashCode * 59 + this.MaxScalingAmount.GetHashCode();
                if (this.SingleExpansionCount != null) hashCode = hashCode * 59 + this.SingleExpansionCount.GetHashCode();
                if (this.ScalingPolicyBySession != null) hashCode = hashCode * 59 + this.ScalingPolicyBySession.GetHashCode();
                return hashCode;
            }
        }
    }
}
