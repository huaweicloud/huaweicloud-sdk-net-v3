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
    public class DescribePermissionSetProvisioningStatusResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission_set_provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionSetProvisioningStatusDto PermissionSetProvisioningStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DescribePermissionSetProvisioningStatusResponse {\n");
            sb.Append("  permissionSetProvisioningStatus: ").Append(PermissionSetProvisioningStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DescribePermissionSetProvisioningStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DescribePermissionSetProvisioningStatusResponse input)
        {
            if (input == null) return false;
            if (this.PermissionSetProvisioningStatus != input.PermissionSetProvisioningStatus || (this.PermissionSetProvisioningStatus != null && !this.PermissionSetProvisioningStatus.Equals(input.PermissionSetProvisioningStatus))) return false;

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
                if (this.PermissionSetProvisioningStatus != null) hashCode = hashCode * 59 + this.PermissionSetProvisioningStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
