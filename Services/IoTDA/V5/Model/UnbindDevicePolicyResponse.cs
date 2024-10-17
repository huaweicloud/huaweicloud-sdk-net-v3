using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UnbindDevicePolicyResponse : SdkResponse
    {

        /// <summary>
        /// 策略ID。
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// **参数说明**：策略的目标类型。 **取值范围**：device|product|app，device表示设备，product表示产品，app表示整个资源空间。
        /// </summary>
        [JsonProperty("target_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetType { get; set; }

        /// <summary>
        /// 成功的目标id列表。
        /// </summary>
        [JsonProperty("success_targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SuccessTargets { get; set; }

        /// <summary>
        /// 失败的目标id列表 
        /// </summary>
        [JsonProperty("failure_targets", NullValueHandling = NullValueHandling.Ignore)]
        public List<DevicePolicyBindOrUnbindFailureDetail> FailureTargets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnbindDevicePolicyResponse {\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  targetType: ").Append(TargetType).Append("\n");
            sb.Append("  successTargets: ").Append(SuccessTargets).Append("\n");
            sb.Append("  failureTargets: ").Append(FailureTargets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnbindDevicePolicyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnbindDevicePolicyResponse input)
        {
            if (input == null) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.TargetType != input.TargetType || (this.TargetType != null && !this.TargetType.Equals(input.TargetType))) return false;
            if (this.SuccessTargets != input.SuccessTargets || (this.SuccessTargets != null && input.SuccessTargets != null && !this.SuccessTargets.SequenceEqual(input.SuccessTargets))) return false;
            if (this.FailureTargets != input.FailureTargets || (this.FailureTargets != null && input.FailureTargets != null && !this.FailureTargets.SequenceEqual(input.FailureTargets))) return false;

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
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                if (this.TargetType != null) hashCode = hashCode * 59 + this.TargetType.GetHashCode();
                if (this.SuccessTargets != null) hashCode = hashCode * 59 + this.SuccessTargets.GetHashCode();
                if (this.FailureTargets != null) hashCode = hashCode * 59 + this.FailureTargets.GetHashCode();
                return hashCode;
            }
        }
    }
}
