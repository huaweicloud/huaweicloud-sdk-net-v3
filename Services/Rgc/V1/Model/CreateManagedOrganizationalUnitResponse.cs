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
    public class CreateManagedOrganizationalUnitResponse : SdkResponse
    {

        /// <summary>
        /// 管理员账号ID。
        /// </summary>
        [JsonProperty("manage_account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ManageAccountId { get; set; }

        /// <summary>
        /// 注册OU ID。
        /// </summary>
        [JsonProperty("organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitId { get; set; }

        /// <summary>
        /// 注册OU名称。
        /// </summary>
        [JsonProperty("organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitName { get; set; }

        /// <summary>
        /// 注册OU状态。
        /// </summary>
        [JsonProperty("organizational_unit_status", NullValueHandling = NullValueHandling.Ignore)]
        public string OrganizationalUnitStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("organizational_unit_type", NullValueHandling = NullValueHandling.Ignore)]
        public OrganizationalUnitType? OrganizationalUnitType { get; set; }

        /// <summary>
        /// 父注册OU ID。
        /// </summary>
        [JsonProperty("parent_organizational_unit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitId { get; set; }

        /// <summary>
        /// 父注册OU名称。
        /// </summary>
        [JsonProperty("parent_organizational_unit_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentOrganizationalUnitName { get; set; }

        /// <summary>
        /// 注册OU的创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 注册OU的Landing Zone版本。
        /// </summary>
        [JsonProperty("landing_zone_version", NullValueHandling = NullValueHandling.Ignore)]
        public string LandingZoneVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateManagedOrganizationalUnitResponse {\n");
            sb.Append("  manageAccountId: ").Append(ManageAccountId).Append("\n");
            sb.Append("  organizationalUnitId: ").Append(OrganizationalUnitId).Append("\n");
            sb.Append("  organizationalUnitName: ").Append(OrganizationalUnitName).Append("\n");
            sb.Append("  organizationalUnitStatus: ").Append(OrganizationalUnitStatus).Append("\n");
            sb.Append("  organizationalUnitType: ").Append(OrganizationalUnitType).Append("\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  parentOrganizationalUnitName: ").Append(ParentOrganizationalUnitName).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  landingZoneVersion: ").Append(LandingZoneVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateManagedOrganizationalUnitResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateManagedOrganizationalUnitResponse input)
        {
            if (input == null) return false;
            if (this.ManageAccountId != input.ManageAccountId || (this.ManageAccountId != null && !this.ManageAccountId.Equals(input.ManageAccountId))) return false;
            if (this.OrganizationalUnitId != input.OrganizationalUnitId || (this.OrganizationalUnitId != null && !this.OrganizationalUnitId.Equals(input.OrganizationalUnitId))) return false;
            if (this.OrganizationalUnitName != input.OrganizationalUnitName || (this.OrganizationalUnitName != null && !this.OrganizationalUnitName.Equals(input.OrganizationalUnitName))) return false;
            if (this.OrganizationalUnitStatus != input.OrganizationalUnitStatus || (this.OrganizationalUnitStatus != null && !this.OrganizationalUnitStatus.Equals(input.OrganizationalUnitStatus))) return false;
            if (this.OrganizationalUnitType != input.OrganizationalUnitType || (this.OrganizationalUnitType != null && !this.OrganizationalUnitType.Equals(input.OrganizationalUnitType))) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.ParentOrganizationalUnitName != input.ParentOrganizationalUnitName || (this.ParentOrganizationalUnitName != null && !this.ParentOrganizationalUnitName.Equals(input.ParentOrganizationalUnitName))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.LandingZoneVersion != input.LandingZoneVersion || (this.LandingZoneVersion != null && !this.LandingZoneVersion.Equals(input.LandingZoneVersion))) return false;

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
                if (this.ManageAccountId != null) hashCode = hashCode * 59 + this.ManageAccountId.GetHashCode();
                if (this.OrganizationalUnitId != null) hashCode = hashCode * 59 + this.OrganizationalUnitId.GetHashCode();
                if (this.OrganizationalUnitName != null) hashCode = hashCode * 59 + this.OrganizationalUnitName.GetHashCode();
                if (this.OrganizationalUnitStatus != null) hashCode = hashCode * 59 + this.OrganizationalUnitStatus.GetHashCode();
                if (this.OrganizationalUnitType != null) hashCode = hashCode * 59 + this.OrganizationalUnitType.GetHashCode();
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.ParentOrganizationalUnitName != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitName.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.LandingZoneVersion != null) hashCode = hashCode * 59 + this.LandingZoneVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
