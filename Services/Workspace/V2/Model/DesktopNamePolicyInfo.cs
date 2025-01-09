using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 桌面名称策略信息。
    /// </summary>
    public class DesktopNamePolicyInfo 
    {

        /// <summary>
        /// 策略id。
        /// </summary>
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 策略名称。
        /// </summary>
        [JsonProperty("policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyName { get; set; }

        /// <summary>
        /// 策略前缀。
        /// </summary>
        [JsonProperty("name_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// 策略后缀有效位数。
        /// </summary>
        [JsonProperty("digit_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? DigitNumber { get; set; }

        /// <summary>
        /// 策略后缀起始数字。
        /// </summary>
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 是否单用户名递增。 - 1 单用户名递增。 - 0 租户递增。
        /// </summary>
        [JsonProperty("single_domain_user_inc", NullValueHandling = NullValueHandling.Ignore)]
        public int? SingleDomainUserInc { get; set; }

        /// <summary>
        /// 是否为默认策略，true默认策略。
        /// </summary>
        [JsonProperty("is_default_policy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefaultPolicy { get; set; }

        /// <summary>
        /// 是否包含用户名的桌面名称策略，true包含。
        /// </summary>
        [JsonProperty("is_contain_user", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsContainUser { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DesktopNamePolicyInfo {\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  policyName: ").Append(PolicyName).Append("\n");
            sb.Append("  namePrefix: ").Append(NamePrefix).Append("\n");
            sb.Append("  digitNumber: ").Append(DigitNumber).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  singleDomainUserInc: ").Append(SingleDomainUserInc).Append("\n");
            sb.Append("  isDefaultPolicy: ").Append(IsDefaultPolicy).Append("\n");
            sb.Append("  isContainUser: ").Append(IsContainUser).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DesktopNamePolicyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DesktopNamePolicyInfo input)
        {
            if (input == null) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.PolicyName != input.PolicyName || (this.PolicyName != null && !this.PolicyName.Equals(input.PolicyName))) return false;
            if (this.NamePrefix != input.NamePrefix || (this.NamePrefix != null && !this.NamePrefix.Equals(input.NamePrefix))) return false;
            if (this.DigitNumber != input.DigitNumber || (this.DigitNumber != null && !this.DigitNumber.Equals(input.DigitNumber))) return false;
            if (this.StartNumber != input.StartNumber || (this.StartNumber != null && !this.StartNumber.Equals(input.StartNumber))) return false;
            if (this.SingleDomainUserInc != input.SingleDomainUserInc || (this.SingleDomainUserInc != null && !this.SingleDomainUserInc.Equals(input.SingleDomainUserInc))) return false;
            if (this.IsDefaultPolicy != input.IsDefaultPolicy || (this.IsDefaultPolicy != null && !this.IsDefaultPolicy.Equals(input.IsDefaultPolicy))) return false;
            if (this.IsContainUser != input.IsContainUser || (this.IsContainUser != null && !this.IsContainUser.Equals(input.IsContainUser))) return false;

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
                if (this.PolicyName != null) hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.NamePrefix != null) hashCode = hashCode * 59 + this.NamePrefix.GetHashCode();
                if (this.DigitNumber != null) hashCode = hashCode * 59 + this.DigitNumber.GetHashCode();
                if (this.StartNumber != null) hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.SingleDomainUserInc != null) hashCode = hashCode * 59 + this.SingleDomainUserInc.GetHashCode();
                if (this.IsDefaultPolicy != null) hashCode = hashCode * 59 + this.IsDefaultPolicy.GetHashCode();
                if (this.IsContainUser != null) hashCode = hashCode * 59 + this.IsContainUser.GetHashCode();
                return hashCode;
            }
        }
    }
}