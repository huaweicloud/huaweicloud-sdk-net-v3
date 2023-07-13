using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScalingV2PoliciesRequest 
    {

        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_resource_id", IsPath = true)]
        [JsonProperty("scaling_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingResourceId { get; set; }

        /// <summary>
        /// 伸缩策略名称。
        /// </summary>
        [SDKProperty("scaling_policy_name", IsQuery = true)]
        [JsonProperty("scaling_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyName { get; set; }

        /// <summary>
        /// 策略类型：  - 告警策略：ALARM - 定时策略：SCHEDULED - 周期策略：RECURRENCE
        /// </summary>
        [SDKProperty("scaling_policy_type", IsQuery = true)]
        [JsonProperty("scaling_policy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyType { get; set; }

        /// <summary>
        /// 伸缩策略ID。
        /// </summary>
        [SDKProperty("scaling_policy_id", IsQuery = true)]
        [JsonProperty("scaling_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingPolicyId { get; set; }

        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数，默认20，最大100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingV2PoliciesRequest {\n");
            sb.Append("  scalingResourceId: ").Append(ScalingResourceId).Append("\n");
            sb.Append("  scalingPolicyName: ").Append(ScalingPolicyName).Append("\n");
            sb.Append("  scalingPolicyType: ").Append(ScalingPolicyType).Append("\n");
            sb.Append("  scalingPolicyId: ").Append(ScalingPolicyId).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingV2PoliciesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingV2PoliciesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingResourceId == input.ScalingResourceId ||
                    (this.ScalingResourceId != null &&
                    this.ScalingResourceId.Equals(input.ScalingResourceId))
                ) && 
                (
                    this.ScalingPolicyName == input.ScalingPolicyName ||
                    (this.ScalingPolicyName != null &&
                    this.ScalingPolicyName.Equals(input.ScalingPolicyName))
                ) && 
                (
                    this.ScalingPolicyType == input.ScalingPolicyType ||
                    (this.ScalingPolicyType != null &&
                    this.ScalingPolicyType.Equals(input.ScalingPolicyType))
                ) && 
                (
                    this.ScalingPolicyId == input.ScalingPolicyId ||
                    (this.ScalingPolicyId != null &&
                    this.ScalingPolicyId.Equals(input.ScalingPolicyId))
                ) && 
                (
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.ScalingResourceId != null)
                    hashCode = hashCode * 59 + this.ScalingResourceId.GetHashCode();
                if (this.ScalingPolicyName != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyName.GetHashCode();
                if (this.ScalingPolicyType != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyType.GetHashCode();
                if (this.ScalingPolicyId != null)
                    hashCode = hashCode * 59 + this.ScalingPolicyId.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
