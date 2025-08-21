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
    /// Response Object
    /// </summary>
    public class ShowLandingZoneIdentityCenterResponse : SdkResponse
    {

        /// <summary>
        /// Identity Center目录ID。
        /// </summary>
        [JsonProperty("identity_store_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Identity Center登录URL。
        /// </summary>
        [JsonProperty("user_portal_url", NullValueHandling = NullValueHandling.Ignore)]
        public string UserPortalUrl { get; set; }

        /// <summary>
        /// Identity Center权限集。
        /// </summary>
        [JsonProperty("permission_sets", NullValueHandling = NullValueHandling.Ignore)]
        public List<PermissionSet> PermissionSets { get; set; }

        /// <summary>
        /// Identity Center用户组。
        /// </summary>
        [JsonProperty("groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdentityCenterGroup> Groups { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLandingZoneIdentityCenterResponse {\n");
            sb.Append("  identityStoreId: ").Append(IdentityStoreId).Append("\n");
            sb.Append("  userPortalUrl: ").Append(UserPortalUrl).Append("\n");
            sb.Append("  permissionSets: ").Append(PermissionSets).Append("\n");
            sb.Append("  groups: ").Append(Groups).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLandingZoneIdentityCenterResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLandingZoneIdentityCenterResponse input)
        {
            if (input == null) return false;
            if (this.IdentityStoreId != input.IdentityStoreId || (this.IdentityStoreId != null && !this.IdentityStoreId.Equals(input.IdentityStoreId))) return false;
            if (this.UserPortalUrl != input.UserPortalUrl || (this.UserPortalUrl != null && !this.UserPortalUrl.Equals(input.UserPortalUrl))) return false;
            if (this.PermissionSets != input.PermissionSets || (this.PermissionSets != null && input.PermissionSets != null && !this.PermissionSets.SequenceEqual(input.PermissionSets))) return false;
            if (this.Groups != input.Groups || (this.Groups != null && input.Groups != null && !this.Groups.SequenceEqual(input.Groups))) return false;

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
                if (this.IdentityStoreId != null) hashCode = hashCode * 59 + this.IdentityStoreId.GetHashCode();
                if (this.UserPortalUrl != null) hashCode = hashCode * 59 + this.UserPortalUrl.GetHashCode();
                if (this.PermissionSets != null) hashCode = hashCode * 59 + this.PermissionSets.GetHashCode();
                if (this.Groups != null) hashCode = hashCode * 59 + this.Groups.GetHashCode();
                return hashCode;
            }
        }
    }
}
