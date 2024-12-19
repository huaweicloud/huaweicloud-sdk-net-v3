using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 聚合合规规则。
    /// </summary>
    public class AggregatePolicyAssignments 
    {

        /// <summary>
        /// 合规规则ID
        /// </summary>
        [JsonProperty("policy_assignment_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentId { get; set; }

        /// <summary>
        /// 合规规则名称
        /// </summary>
        [JsonProperty("policy_assignment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyAssignmentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("compliance", NullValueHandling = NullValueHandling.Ignore)]
        public Compliance Compliance { get; set; }

        /// <summary>
        /// 源帐号ID。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 帐户名称
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AggregatePolicyAssignments {\n");
            sb.Append("  policyAssignmentId: ").Append(PolicyAssignmentId).Append("\n");
            sb.Append("  policyAssignmentName: ").Append(PolicyAssignmentName).Append("\n");
            sb.Append("  compliance: ").Append(Compliance).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregatePolicyAssignments);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AggregatePolicyAssignments input)
        {
            if (input == null) return false;
            if (this.PolicyAssignmentId != input.PolicyAssignmentId || (this.PolicyAssignmentId != null && !this.PolicyAssignmentId.Equals(input.PolicyAssignmentId))) return false;
            if (this.PolicyAssignmentName != input.PolicyAssignmentName || (this.PolicyAssignmentName != null && !this.PolicyAssignmentName.Equals(input.PolicyAssignmentName))) return false;
            if (this.Compliance != input.Compliance || (this.Compliance != null && !this.Compliance.Equals(input.Compliance))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;

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
                if (this.PolicyAssignmentId != null) hashCode = hashCode * 59 + this.PolicyAssignmentId.GetHashCode();
                if (this.PolicyAssignmentName != null) hashCode = hashCode * 59 + this.PolicyAssignmentName.GetHashCode();
                if (this.Compliance != null) hashCode = hashCode * 59 + this.Compliance.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                return hashCode;
            }
        }
    }
}
