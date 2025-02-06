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
    /// the request body of PutCustomRoleToPermissionSet
    /// </summary>
    public class PutCustomRoleToPermissionSetReqBody 
    {

        /// <summary>
        /// 要附加到权限集的自定义策略
        /// </summary>
        [JsonProperty("custom_role", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomRole { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutCustomRoleToPermissionSetReqBody {\n");
            sb.Append("  customRole: ").Append(CustomRole).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutCustomRoleToPermissionSetReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutCustomRoleToPermissionSetReqBody input)
        {
            if (input == null) return false;
            if (this.CustomRole != input.CustomRole || (this.CustomRole != null && !this.CustomRole.Equals(input.CustomRole))) return false;

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
                if (this.CustomRole != null) hashCode = hashCode * 59 + this.CustomRole.GetHashCode();
                return hashCode;
            }
        }
    }
}
