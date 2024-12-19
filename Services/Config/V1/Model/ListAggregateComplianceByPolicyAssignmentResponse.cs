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
    public class ListAggregateComplianceByPolicyAssignmentResponse : SdkResponse
    {

        /// <summary>
        /// 聚合合规规则的列表。
        /// </summary>
        [JsonProperty("aggregate_policy_assignments", NullValueHandling = NullValueHandling.Ignore)]
        public List<AggregatePolicyAssignments> AggregatePolicyAssignments { get; set; }

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
            sb.Append("class ListAggregateComplianceByPolicyAssignmentResponse {\n");
            sb.Append("  aggregatePolicyAssignments: ").Append(AggregatePolicyAssignments).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAggregateComplianceByPolicyAssignmentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAggregateComplianceByPolicyAssignmentResponse input)
        {
            if (input == null) return false;
            if (this.AggregatePolicyAssignments != input.AggregatePolicyAssignments || (this.AggregatePolicyAssignments != null && input.AggregatePolicyAssignments != null && !this.AggregatePolicyAssignments.SequenceEqual(input.AggregatePolicyAssignments))) return false;
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
                if (this.AggregatePolicyAssignments != null) hashCode = hashCode * 59 + this.AggregatePolicyAssignments.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
