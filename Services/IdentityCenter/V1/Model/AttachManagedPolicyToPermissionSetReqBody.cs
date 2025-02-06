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
    public class AttachManagedPolicyToPermissionSetReqBody 
    {

        /// <summary>
        /// IAM系统身份策略唯一标识
        /// </summary>
        [JsonProperty("managed_policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedPolicyId { get; set; }

        /// <summary>
        /// IAM系统身份策略名称
        /// </summary>
        [JsonProperty("managed_policy_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ManagedPolicyName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachManagedPolicyToPermissionSetReqBody {\n");
            sb.Append("  managedPolicyId: ").Append(ManagedPolicyId).Append("\n");
            sb.Append("  managedPolicyName: ").Append(ManagedPolicyName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachManagedPolicyToPermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachManagedPolicyToPermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.ManagedPolicyId != input.ManagedPolicyId || (this.ManagedPolicyId != null && !this.ManagedPolicyId.Equals(input.ManagedPolicyId))) return false;
            if (this.ManagedPolicyName != input.ManagedPolicyName || (this.ManagedPolicyName != null && !this.ManagedPolicyName.Equals(input.ManagedPolicyName))) return false;

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
                if (this.ManagedPolicyId != null) hashCode = hashCode * 59 + this.ManagedPolicyId.GetHashCode();
                if (this.ManagedPolicyName != null) hashCode = hashCode * 59 + this.ManagedPolicyName.GetHashCode();
                return hashCode;
            }
        }
    }
}
