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
    public class GetAccountSummaryV5Response : SdkResponse
    {

        /// <summary>
        /// 附加到委托或信任委托上的身份策略的最大数量。
        /// </summary>
        [JsonProperty("attached_policies_per_agency_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachedPoliciesPerAgencyQuota { get; set; }

        /// <summary>
        /// 附加到用户组上的身份策略的最大数量。
        /// </summary>
        [JsonProperty("attached_policies_per_group_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachedPoliciesPerGroupQuota { get; set; }

        /// <summary>
        /// 附加到IAM用户上的身份策略的最大数量。
        /// </summary>
        [JsonProperty("attached_policies_per_user_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachedPoliciesPerUserQuota { get; set; }

        /// <summary>
        /// 自定义身份策略的最大数量。
        /// </summary>
        [JsonProperty("policies_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? PoliciesQuota { get; set; }

        /// <summary>
        /// 身份策略及信任策略的策略文档的最大字符数，不包括空格。
        /// </summary>
        [JsonProperty("policy_size_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? PolicySizeQuota { get; set; }

        /// <summary>
        /// 自定义身份策略同一时刻保留的最大版本数量。
        /// </summary>
        [JsonProperty("versions_per_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionsPerPolicyQuota { get; set; }

        /// <summary>
        /// 此账号中当前创建的自定义身份策略数量。
        /// </summary>
        [JsonProperty("policies", NullValueHandling = NullValueHandling.Ignore)]
        public int? Policies { get; set; }

        /// <summary>
        /// 此账号中当前创建的委托及信任委托的总数量。
        /// </summary>
        [JsonProperty("agencies", NullValueHandling = NullValueHandling.Ignore)]
        public int? Agencies { get; set; }

        /// <summary>
        /// 此账号能够创建的委托及信任委托的总数上限。
        /// </summary>
        [JsonProperty("agencies_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? AgenciesQuota { get; set; }

        /// <summary>
        /// 此账号当前创建的IAM用户数量，包括根用户。
        /// </summary>
        [JsonProperty("users", NullValueHandling = NullValueHandling.Ignore)]
        public int? Users { get; set; }

        /// <summary>
        /// 此账号能够创建的IAM用户数上限，包括根用户。
        /// </summary>
        [JsonProperty("users_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? UsersQuota { get; set; }

        /// <summary>
        /// 此账号当前创建的用户组数量。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public int? Groups { get; set; }

        /// <summary>
        /// 此账号能够创建的用户组数上限。
        /// </summary>
        [JsonProperty("groups_quota", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupsQuota { get; set; }

        /// <summary>
        /// 根用户绑定的已启用MFA的数量。
        /// </summary>
        [JsonProperty("root_user_mfa_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public int? RootUserMfaEnabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAccountSummaryV5Response {\n");
            sb.Append("  attachedPoliciesPerAgencyQuota: ").Append(AttachedPoliciesPerAgencyQuota).Append("\n");
            sb.Append("  attachedPoliciesPerGroupQuota: ").Append(AttachedPoliciesPerGroupQuota).Append("\n");
            sb.Append("  attachedPoliciesPerUserQuota: ").Append(AttachedPoliciesPerUserQuota).Append("\n");
            sb.Append("  policiesQuota: ").Append(PoliciesQuota).Append("\n");
            sb.Append("  policySizeQuota: ").Append(PolicySizeQuota).Append("\n");
            sb.Append("  versionsPerPolicyQuota: ").Append(VersionsPerPolicyQuota).Append("\n");
            sb.Append("  policies: ").Append(Policies).Append("\n");
            sb.Append("  agencies: ").Append(Agencies).Append("\n");
            sb.Append("  agenciesQuota: ").Append(AgenciesQuota).Append("\n");
            sb.Append("  users: ").Append(Users).Append("\n");
            sb.Append("  usersQuota: ").Append(UsersQuota).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("  groupsQuota: ").Append(GroupsQuota).Append("\n");
            sb.Append("  rootUserMfaEnabled: ").Append(RootUserMfaEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetAccountSummaryV5Response);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetAccountSummaryV5Response input)
        {
            if (input == null) return false;
            if (this.AttachedPoliciesPerAgencyQuota != input.AttachedPoliciesPerAgencyQuota || (this.AttachedPoliciesPerAgencyQuota != null && !this.AttachedPoliciesPerAgencyQuota.Equals(input.AttachedPoliciesPerAgencyQuota))) return false;
            if (this.AttachedPoliciesPerGroupQuota != input.AttachedPoliciesPerGroupQuota || (this.AttachedPoliciesPerGroupQuota != null && !this.AttachedPoliciesPerGroupQuota.Equals(input.AttachedPoliciesPerGroupQuota))) return false;
            if (this.AttachedPoliciesPerUserQuota != input.AttachedPoliciesPerUserQuota || (this.AttachedPoliciesPerUserQuota != null && !this.AttachedPoliciesPerUserQuota.Equals(input.AttachedPoliciesPerUserQuota))) return false;
            if (this.PoliciesQuota != input.PoliciesQuota || (this.PoliciesQuota != null && !this.PoliciesQuota.Equals(input.PoliciesQuota))) return false;
            if (this.PolicySizeQuota != input.PolicySizeQuota || (this.PolicySizeQuota != null && !this.PolicySizeQuota.Equals(input.PolicySizeQuota))) return false;
            if (this.VersionsPerPolicyQuota != input.VersionsPerPolicyQuota || (this.VersionsPerPolicyQuota != null && !this.VersionsPerPolicyQuota.Equals(input.VersionsPerPolicyQuota))) return false;
            if (this.Policies != input.Policies || (this.Policies != null && !this.Policies.Equals(input.Policies))) return false;
            if (this.Agencies != input.Agencies || (this.Agencies != null && !this.Agencies.Equals(input.Agencies))) return false;
            if (this.AgenciesQuota != input.AgenciesQuota || (this.AgenciesQuota != null && !this.AgenciesQuota.Equals(input.AgenciesQuota))) return false;
            if (this.Users != input.Users || (this.Users != null && !this.Users.Equals(input.Users))) return false;
            if (this.UsersQuota != input.UsersQuota || (this.UsersQuota != null && !this.UsersQuota.Equals(input.UsersQuota))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && !this.Groups.Equals(input.Groups))) return false;
            if (this.GroupsQuota != input.GroupsQuota || (this.GroupsQuota != null && !this.GroupsQuota.Equals(input.GroupsQuota))) return false;
            if (this.RootUserMfaEnabled != input.RootUserMfaEnabled || (this.RootUserMfaEnabled != null && !this.RootUserMfaEnabled.Equals(input.RootUserMfaEnabled))) return false;

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
                if (this.AttachedPoliciesPerAgencyQuota != null) hashCode = hashCode * 59 + this.AttachedPoliciesPerAgencyQuota.GetHashCode();
                if (this.AttachedPoliciesPerGroupQuota != null) hashCode = hashCode * 59 + this.AttachedPoliciesPerGroupQuota.GetHashCode();
                if (this.AttachedPoliciesPerUserQuota != null) hashCode = hashCode * 59 + this.AttachedPoliciesPerUserQuota.GetHashCode();
                if (this.PoliciesQuota != null) hashCode = hashCode * 59 + this.PoliciesQuota.GetHashCode();
                if (this.PolicySizeQuota != null) hashCode = hashCode * 59 + this.PolicySizeQuota.GetHashCode();
                if (this.VersionsPerPolicyQuota != null) hashCode = hashCode * 59 + this.VersionsPerPolicyQuota.GetHashCode();
                if (this.Policies != null) hashCode = hashCode * 59 + this.Policies.GetHashCode();
                if (this.Agencies != null) hashCode = hashCode * 59 + this.Agencies.GetHashCode();
                if (this.AgenciesQuota != null) hashCode = hashCode * 59 + this.AgenciesQuota.GetHashCode();
                if (this.Users != null) hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.UsersQuota != null) hashCode = hashCode * 59 + this.UsersQuota.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                if (this.GroupsQuota != null) hashCode = hashCode * 59 + this.GroupsQuota.GetHashCode();
                if (this.RootUserMfaEnabled != null) hashCode = hashCode * 59 + this.RootUserMfaEnabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
