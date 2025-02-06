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
    /// 请求体
    /// </summary>
    public class ResourceAttachManagedPolicyToPermissionSetReqBody 
    {

        /// <summary>
        /// IAM系统策略唯一标识
        /// </summary>
        [JsonProperty("managed_role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedRoleId { get; set; }

        /// <summary>
        /// IAM系统策略名称
        /// </summary>
        [JsonProperty("managed_role_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedRoleName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceAttachManagedPolicyToPermissionSetReqBody {\n");
            sb.Append("  managedRoleId: ").Append(ManagedRoleId).Append("\n");
            sb.Append("  managedRoleName: ").Append(ManagedRoleName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceAttachManagedPolicyToPermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceAttachManagedPolicyToPermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.ManagedRoleId != input.ManagedRoleId || (this.ManagedRoleId != null && !this.ManagedRoleId.Equals(input.ManagedRoleId))) return false;
            if (this.ManagedRoleName != input.ManagedRoleName || (this.ManagedRoleName != null && !this.ManagedRoleName.Equals(input.ManagedRoleName))) return false;

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
                if (this.ManagedRoleId != null) hashCode = hashCode * 59 + this.ManagedRoleId.GetHashCode();
                if (this.ManagedRoleName != null) hashCode = hashCode * 59 + this.ManagedRoleName.GetHashCode();
                return hashCode;
            }
        }
    }
}
