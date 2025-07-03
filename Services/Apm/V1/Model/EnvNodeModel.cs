using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 环境信息。
    /// </summary>
    public class EnvNodeModel 
    {

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("gmt_create", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? GmtCreate { get; set; }

        /// <summary>
        /// 修改时间。
        /// </summary>
        [JsonProperty("gmt_modify", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? GmtModify { get; set; }

        /// <summary>
        /// 组件id。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? AppId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("business_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessName { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("inner_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? InnerDomainId { get; set; }

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否是默认环境。
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 组件名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvNodeModel {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  businessName: ").Append(BusinessName).Append("\n");
            sb.Append("  innerDomainId: ").Append(InnerDomainId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvNodeModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnvNodeModel input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.BusinessName != input.BusinessName || (this.BusinessName != null && !this.BusinessName.Equals(input.BusinessName))) return false;
            if (this.InnerDomainId != input.InnerDomainId || (this.InnerDomainId != null && !this.InnerDomainId.Equals(input.InnerDomainId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.BusinessName != null) hashCode = hashCode * 59 + this.BusinessName.GetHashCode();
                if (this.InnerDomainId != null) hashCode = hashCode * 59 + this.InnerDomainId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
