using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListTenantProfileResponse : SdkResponse
    {

        /// <summary>
        /// 租户ID 同tenant_id。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 租户名称。
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 租户的域ID。
        /// </summary>
        [JsonProperty("tenant_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantDomainId { get; set; }

        /// <summary>
        /// 服务状态 * &#x60;active&#x60; - 激活 * &#x60;inactive&#x60; - 未激活
        /// </summary>
        [JsonProperty("service_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 是否对接AD。 有AD的情况下，提示租户单会话模式和多会话模式都支持; 在没有AD的情况下，提示租户仅支持VDI单会话模式。
        /// </summary>
        [JsonProperty("open_with_ad", NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenWithAd { get; set; }

        /// <summary>
        /// 租户的域名称。
        /// </summary>
        [JsonProperty("tenant_domain_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantDomainName { get; set; }

        /// <summary>
        /// 租户信息创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantProfileResponse {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  tenantDomainId: ").Append(TenantDomainId).Append("\n");
            sb.Append("  serviceStatus: ").Append(ServiceStatus).Append("\n");
            sb.Append("  openWithAd: ").Append(OpenWithAd).Append("\n");
            sb.Append("  tenantDomainName: ").Append(TenantDomainName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantProfileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantProfileResponse input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ProjectName != input.ProjectName || (this.ProjectName != null && !this.ProjectName.Equals(input.ProjectName))) return false;
            if (this.TenantDomainId != input.TenantDomainId || (this.TenantDomainId != null && !this.TenantDomainId.Equals(input.TenantDomainId))) return false;
            if (this.ServiceStatus != input.ServiceStatus || (this.ServiceStatus != null && !this.ServiceStatus.Equals(input.ServiceStatus))) return false;
            if (this.OpenWithAd != input.OpenWithAd || (this.OpenWithAd != null && !this.OpenWithAd.Equals(input.OpenWithAd))) return false;
            if (this.TenantDomainName != input.TenantDomainName || (this.TenantDomainName != null && !this.TenantDomainName.Equals(input.TenantDomainName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null) hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.TenantDomainId != null) hashCode = hashCode * 59 + this.TenantDomainId.GetHashCode();
                if (this.ServiceStatus != null) hashCode = hashCode * 59 + this.ServiceStatus.GetHashCode();
                if (this.OpenWithAd != null) hashCode = hashCode * 59 + this.OpenWithAd.GetHashCode();
                if (this.TenantDomainName != null) hashCode = hashCode * 59 + this.TenantDomainName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
