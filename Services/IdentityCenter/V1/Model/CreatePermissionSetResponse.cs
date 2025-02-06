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
    public class CreatePermissionSetResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission_set", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionSetDto PermissionSet { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePermissionSetResponse {\n");
            sb.Append("  permissionSet: ").Append(PermissionSet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePermissionSetResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePermissionSetResponse input)
        {
            if (input == null) return false;
            if (this.PermissionSet != input.PermissionSet || (this.PermissionSet != null && !this.PermissionSet.Equals(input.PermissionSet))) return false;

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
                if (this.PermissionSet != null) hashCode = hashCode * 59 + this.PermissionSet.GetHashCode();
                return hashCode;
            }
        }
    }
}
