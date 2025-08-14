using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class GetPermissionSetSummaryResponse : SdkResponse
    {

        /// <summary>
        /// 已创建的权限集数量
        /// </summary>
        [JsonProperty("permission_sets", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermissionSets { get; set; }

        /// <summary>
        /// 权限集配额
        /// </summary>
        [JsonProperty("permission_sets_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermissionSetsQuota { get; set; }

        /// <summary>
        /// 允许权限集可绑定的策略配额
        /// </summary>
        [JsonProperty("permission_policy_count_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermissionPolicyCountQuota { get; set; }

        /// <summary>
        /// 允许权限集可绑定的身份策略配额
        /// </summary>
        [JsonProperty("permission_policy_quota", NullValueHandling = NullValueHandling.Ignore)]
        public long? PermissionPolicyQuota { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetPermissionSetSummaryResponse {\n");
            sb.Append("  permissionSets: ").Append(PermissionSets).Append("\n");
            sb.Append("  permissionSetsQuota: ").Append(PermissionSetsQuota).Append("\n");
            sb.Append("  permissionPolicyCountQuota: ").Append(PermissionPolicyCountQuota).Append("\n");
            sb.Append("  permissionPolicyQuota: ").Append(PermissionPolicyQuota).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetPermissionSetSummaryResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetPermissionSetSummaryResponse input)
        {
            if (input == null) return false;
            if (this.PermissionSets != input.PermissionSets || (this.PermissionSets != null && !this.PermissionSets.Equals(input.PermissionSets))) return false;
            if (this.PermissionSetsQuota != input.PermissionSetsQuota || (this.PermissionSetsQuota != null && !this.PermissionSetsQuota.Equals(input.PermissionSetsQuota))) return false;
            if (this.PermissionPolicyCountQuota != input.PermissionPolicyCountQuota || (this.PermissionPolicyCountQuota != null && !this.PermissionPolicyCountQuota.Equals(input.PermissionPolicyCountQuota))) return false;
            if (this.PermissionPolicyQuota != input.PermissionPolicyQuota || (this.PermissionPolicyQuota != null && !this.PermissionPolicyQuota.Equals(input.PermissionPolicyQuota))) return false;

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
                if (this.PermissionSets != null) hashCode = hashCode * 59 + this.PermissionSets.GetHashCode();
                if (this.PermissionSetsQuota != null) hashCode = hashCode * 59 + this.PermissionSetsQuota.GetHashCode();
                if (this.PermissionPolicyCountQuota != null) hashCode = hashCode * 59 + this.PermissionPolicyCountQuota.GetHashCode();
                if (this.PermissionPolicyQuota != null) hashCode = hashCode * 59 + this.PermissionPolicyQuota.GetHashCode();
                return hashCode;
            }
        }
    }
}
