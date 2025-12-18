using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListEntitiesForPolicyV5Response : SdkResponse
    {

        /// <summary>
        /// 委托及信任委托列表。
        /// </summary>
        [JsonProperty("policy_agencies", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyAgency> PolicyAgencies { get; set; }

        /// <summary>
        /// 用户组列表。
        /// </summary>
        [JsonProperty("policy_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyGroup> PolicyGroups { get; set; }

        /// <summary>
        /// IAM用户列表。
        /// </summary>
        [JsonProperty("policy_users", NullValueHandling = NullValueHandling.Ignore)]
        public List<PolicyUser> PolicyUsers { get; set; }

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
            sb.Append("class ListEntitiesForPolicyV5Response {\n");
            sb.Append("  policyAgencies: ").Append(PolicyAgencies).Append("\n");
            sb.Append("  policyGroups: ").Append(PolicyGroups).Append("\n");
            sb.Append("  policyUsers: ").Append(PolicyUsers).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEntitiesForPolicyV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEntitiesForPolicyV5Response input)
        {
            if (input == null) return false;
            if (this.PolicyAgencies != input.PolicyAgencies || (this.PolicyAgencies != null && input.PolicyAgencies != null && !this.PolicyAgencies.SequenceEqual(input.PolicyAgencies))) return false;
            if (this.PolicyGroups != input.PolicyGroups || (this.PolicyGroups != null && input.PolicyGroups != null && !this.PolicyGroups.SequenceEqual(input.PolicyGroups))) return false;
            if (this.PolicyUsers != input.PolicyUsers || (this.PolicyUsers != null && input.PolicyUsers != null && !this.PolicyUsers.SequenceEqual(input.PolicyUsers))) return false;
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
                if (this.PolicyAgencies != null) hashCode = hashCode * 59 + this.PolicyAgencies.GetHashCode();
                if (this.PolicyGroups != null) hashCode = hashCode * 59 + this.PolicyGroups.GetHashCode();
                if (this.PolicyUsers != null) hashCode = hashCode * 59 + this.PolicyUsers.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
