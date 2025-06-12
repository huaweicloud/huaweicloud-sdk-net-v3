using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenterPortalAPI.V1.Model
{
    /// <summary>
    /// 包含委托或信任委托信息的对象
    /// </summary>
    public class AgencyInfo 
    {

        /// <summary>
        /// 分配给用户的账号的全局唯一标识符（ID）
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 分配给用户的委托或信任委托的名称
        /// </summary>
        [JsonProperty("agency_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyName { get; set; }

        /// <summary>
        /// 权限集名称
        /// </summary>
        [JsonProperty("permission_set_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionSetName { get; set; }

        /// <summary>
        /// 委托或信任委托的统一资源名称（URN）
        /// </summary>
        [JsonProperty("agency_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string AgencyUrn { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgencyInfo {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  agencyName: ").Append(AgencyName).Append("\n");
            sb.Append("  permissionSetName: ").Append(PermissionSetName).Append("\n");
            sb.Append("  agencyUrn: ").Append(AgencyUrn).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AgencyInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AgencyInfo input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AgencyName != input.AgencyName || (this.AgencyName != null && !this.AgencyName.Equals(input.AgencyName))) return false;
            if (this.PermissionSetName != input.PermissionSetName || (this.PermissionSetName != null && !this.PermissionSetName.Equals(input.PermissionSetName))) return false;
            if (this.AgencyUrn != input.AgencyUrn || (this.AgencyUrn != null && !this.AgencyUrn.Equals(input.AgencyUrn))) return false;
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
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AgencyName != null) hashCode = hashCode * 59 + this.AgencyName.GetHashCode();
                if (this.PermissionSetName != null) hashCode = hashCode * 59 + this.PermissionSetName.GetHashCode();
                if (this.AgencyUrn != null) hashCode = hashCode * 59 + this.AgencyUrn.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
