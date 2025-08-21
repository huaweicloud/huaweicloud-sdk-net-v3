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
    /// 控制策略合规性。
    /// </summary>
    public class ControlViolation 
    {

        /// <summary>
        /// 纳管账号ID。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 纳管账号名称。
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 控制策略显示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 控制策略名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 控制策略ID。
        /// </summary>
        [JsonProperty("control_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ControlId { get; set; }

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
        /// 区域名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 控制策略不合规资源。
        /// </summary>
        [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
        public string Resource { get; set; }

        /// <summary>
        /// 控制策略不合规资源的名称。
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 控制策略不合规资源类型。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 云服务名称。
        /// </summary>
        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ControlViolation {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  controlId: ").Append(ControlId).Append("\n");
            sb.Append("  parentOrganizationalUnitId: ").Append(ParentOrganizationalUnitId).Append("\n");
            sb.Append("  parentOrganizationalUnitName: ").Append(ParentOrganizationalUnitName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  resource: ").Append(Resource).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  service: ").Append(Service).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ControlViolation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ControlViolation input)
        {
            if (input == null) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccountName != input.AccountName || (this.AccountName != null && !this.AccountName.Equals(input.AccountName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ControlId != input.ControlId || (this.ControlId != null && !this.ControlId.Equals(input.ControlId))) return false;
            if (this.ParentOrganizationalUnitId != input.ParentOrganizationalUnitId || (this.ParentOrganizationalUnitId != null && !this.ParentOrganizationalUnitId.Equals(input.ParentOrganizationalUnitId))) return false;
            if (this.ParentOrganizationalUnitName != input.ParentOrganizationalUnitName || (this.ParentOrganizationalUnitName != null && !this.ParentOrganizationalUnitName.Equals(input.ParentOrganizationalUnitName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Resource != input.Resource || (this.Resource != null && !this.Resource.Equals(input.Resource))) return false;
            if (this.ResourceName != input.ResourceName || (this.ResourceName != null && !this.ResourceName.Equals(input.ResourceName))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.Service != input.Service || (this.Service != null && !this.Service.Equals(input.Service))) return false;

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
                if (this.AccountName != null) hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ControlId != null) hashCode = hashCode * 59 + this.ControlId.GetHashCode();
                if (this.ParentOrganizationalUnitId != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitId.GetHashCode();
                if (this.ParentOrganizationalUnitName != null) hashCode = hashCode * 59 + this.ParentOrganizationalUnitName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Resource != null) hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ResourceName != null) hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Service != null) hashCode = hashCode * 59 + this.Service.GetHashCode();
                return hashCode;
            }
        }
    }
}
