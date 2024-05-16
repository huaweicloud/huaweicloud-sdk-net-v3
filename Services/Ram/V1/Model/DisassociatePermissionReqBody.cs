using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// The request body of the DisassociateResourceSharePermission operation.
    /// </summary>
    public class DisassociatePermissionReqBody 
    {

        /// <summary>
        /// 共享资源权限的ID。
        /// </summary>
        [JsonProperty("permission_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisassociatePermissionReqBody {\n");
            sb.Append("  permissionId: ").Append(PermissionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisassociatePermissionReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisassociatePermissionReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PermissionId == input.PermissionId ||
                    (this.PermissionId != null &&
                    this.PermissionId.Equals(input.PermissionId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.PermissionId != null)
                    hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
