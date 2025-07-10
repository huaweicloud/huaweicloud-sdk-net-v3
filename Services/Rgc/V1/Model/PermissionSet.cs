using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rgc.V1.Model
{
    /// <summary>
    /// IAM身份中心的权限集相关信息。
    /// </summary>
    public class PermissionSet 
    {

        /// <summary>
        /// 权限集ID。
        /// </summary>
        [JsonProperty("permission_set_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionSetId { get; set; }

        /// <summary>
        /// 权限集名称。
        /// </summary>
        [JsonProperty("permission_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionSetName { get; set; }

        /// <summary>
        /// 权限集描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PermissionSet {\n");
            sb.Append("  permissionSetId: ").Append(PermissionSetId).Append("\n");
            sb.Append("  permissionSetName: ").Append(PermissionSetName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PermissionSet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PermissionSet input)
        {
            if (input == null) return false;
            if (this.PermissionSetId != input.PermissionSetId || (this.PermissionSetId != null && !this.PermissionSetId.Equals(input.PermissionSetId))) return false;
            if (this.PermissionSetName != input.PermissionSetName || (this.PermissionSetName != null && !this.PermissionSetName.Equals(input.PermissionSetName))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.PermissionSetId != null) hashCode = hashCode * 59 + this.PermissionSetId.GetHashCode();
                if (this.PermissionSetName != null) hashCode = hashCode * 59 + this.PermissionSetName.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
