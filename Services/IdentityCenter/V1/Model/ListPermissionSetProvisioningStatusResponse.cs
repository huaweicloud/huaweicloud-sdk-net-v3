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
    public class ListPermissionSetProvisioningStatusResponse : SdkResponse
    {

        /// <summary>
        /// 权限集授权状态
        /// </summary>
        [JsonProperty("permission_sets_provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public List<PermissionSetProvisioningStatusMetadataDto> PermissionSetsProvisioningStatus { get; set; }

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
            sb.Append("class ListPermissionSetProvisioningStatusResponse {\n");
            sb.Append("  permissionSetsProvisioningStatus: ").Append(PermissionSetsProvisioningStatus).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPermissionSetProvisioningStatusResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPermissionSetProvisioningStatusResponse input)
        {
            if (input == null) return false;
            if (this.PermissionSetsProvisioningStatus != input.PermissionSetsProvisioningStatus || (this.PermissionSetsProvisioningStatus != null && input.PermissionSetsProvisioningStatus != null && !this.PermissionSetsProvisioningStatus.SequenceEqual(input.PermissionSetsProvisioningStatus))) return false;
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
                if (this.PermissionSetsProvisioningStatus != null) hashCode = hashCode * 59 + this.PermissionSetsProvisioningStatus.GetHashCode();
                if (this.PageInfo != null) hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
