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
    /// Response Object
    /// </summary>
    public class ShowAggregateComplianceDetailsByPolicyAssignmentResponse : SdkResponse
    {

        /// <summary>
        /// 合规结果查询返回值
        /// </summary>
        [JsonProperty("policy_states", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyState> PolicyStates { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAggregateComplianceDetailsByPolicyAssignmentResponse {\n");
            sb.Append("  policyStates: ").Append(PolicyStates).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAggregateComplianceDetailsByPolicyAssignmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAggregateComplianceDetailsByPolicyAssignmentResponse input)
        {
            if (input == null) return false;
            if (this.PolicyStates != input.PolicyStates || (this.PolicyStates != null && input.PolicyStates != null && !this.PolicyStates.SequenceEqual(input.PolicyStates))) return false;
            if (this.PageInfo != input.PageInfo || (this.PageInfo != null && !this.PageInfo.Equals(input.PageInfo))) return false;

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
                if (this.PolicyStates != null) hashCode = hashCode * 59 + this.PolicyStates.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
