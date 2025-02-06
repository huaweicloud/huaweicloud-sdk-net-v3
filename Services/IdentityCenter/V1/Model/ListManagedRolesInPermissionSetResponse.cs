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
    public class ListManagedRolesInPermissionSetResponse : SdkResponse
    {

        /// <summary>
        /// IAM系统策略列表
        /// </summary>
        [JsonProperty("attached_managed_roles", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceAttachedManagedPolicyDto> AttachedManagedRoles { get; set; }

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
            sb.Append("class ListManagedRolesInPermissionSetResponse {\n");
            sb.Append("  attachedManagedRoles: ").Append(AttachedManagedRoles).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListManagedRolesInPermissionSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListManagedRolesInPermissionSetResponse input)
        {
            if (input == null) return false;
            if (this.AttachedManagedRoles != input.AttachedManagedRoles || (this.AttachedManagedRoles != null && input.AttachedManagedRoles != null && !this.AttachedManagedRoles.SequenceEqual(input.AttachedManagedRoles))) return false;
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
                if (this.AttachedManagedRoles != null) hashCode = hashCode * 59 + this.AttachedManagedRoles.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
