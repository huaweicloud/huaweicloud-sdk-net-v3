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
    /// 业务数据结构。
    /// </summary>
    public class BusinessNodeModel 
    {

        /// <summary>
        /// 默认应用。
        /// </summary>
        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        /// <summary>
        /// 应用展示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 企业项目的id。
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

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
        /// 应用id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 内部租户id。
        /// </summary>
        [JsonProperty("inner_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? InnerDomainId { get; set; }

        /// <summary>
        /// 是否是默认的应用。
        /// </summary>
        [JsonProperty("is_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 应用的英文名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessNodeModel {\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  innerDomainId: ").Append(InnerDomainId).Append("\n");
            sb.Append("  isDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BusinessNodeModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BusinessNodeModel input)
        {
            if (input == null) return false;
            if (this.Default != input.Default || (this.Default != null && !this.Default.Equals(input.Default))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InnerDomainId != input.InnerDomainId || (this.InnerDomainId != null && !this.InnerDomainId.Equals(input.InnerDomainId))) return false;
            if (this.IsDefault != input.IsDefault || (this.IsDefault != null && !this.IsDefault.Equals(input.IsDefault))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;

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
                if (this.Default != null) hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.GmtCreate != null) hashCode = hashCode * 59 + this.GmtCreate.GetHashCode();
                if (this.GmtModify != null) hashCode = hashCode * 59 + this.GmtModify.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InnerDomainId != null) hashCode = hashCode * 59 + this.InnerDomainId.GetHashCode();
                if (this.IsDefault != null) hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }
    }
}
