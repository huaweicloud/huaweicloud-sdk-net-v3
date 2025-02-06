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
    public class ListManagedPoliciesInPermissionSetResponse : SdkResponse
    {

        /// <summary>
        /// IAM系统身份策略列表
        /// </summary>
        [JsonProperty("attached_managed_policies", NullValueHandling = NullValueHandling.Ignore)]
        public List<AttachedManagedPolicyDto> AttachedManagedPolicies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfoDto PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListManagedPoliciesInPermissionSetResponse {\n");
            sb.Append("  attachedManagedPolicies: ").Append(AttachedManagedPolicies).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListManagedPoliciesInPermissionSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListManagedPoliciesInPermissionSetResponse input)
        {
            if (input == null) return false;
            if (this.AttachedManagedPolicies != input.AttachedManagedPolicies || (this.AttachedManagedPolicies != null && input.AttachedManagedPolicies != null && !this.AttachedManagedPolicies.SequenceEqual(input.AttachedManagedPolicies))) return false;
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
                if (this.AttachedManagedPolicies != null) hashCode = hashCode * 59 + this.AttachedManagedPolicies.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
