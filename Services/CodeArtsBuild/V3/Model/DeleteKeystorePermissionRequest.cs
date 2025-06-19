using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteKeystorePermissionRequest 
    {

        /// <summary>
        /// 文件管理权限ID
        /// </summary>
        [SDKProperty("permission_id", IsPath = true)]
        [JsonProperty("permission_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteKeystorePermissionRequest {\n");
            sb.Append("  permissionId: ").Append(PermissionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteKeystorePermissionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteKeystorePermissionRequest input)
        {
            if (input == null) return false;
            if (this.PermissionId != input.PermissionId || (this.PermissionId != null && !this.PermissionId.Equals(input.PermissionId))) return false;

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
                if (this.PermissionId != null) hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
