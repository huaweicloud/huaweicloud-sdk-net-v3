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
    /// 组件信息。
    /// </summary>
    public class AppNodeModel 
    {

        /// <summary>
        /// 组件id。
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
        /// 组件名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 子应用id。
        /// </summary>
        [JsonProperty("sub_business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? SubBusinessId { get; set; }

        /// <summary>
        /// 租户id。
        /// </summary>
        [JsonProperty("inner_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? InnerDomainId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppNodeModel {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  gmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  gmtModify: ").Append(GmtModify).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  subBusinessId: ").Append(SubBusinessId).Append("\n");
            sb.Append("  innerDomainId: ").Append(InnerDomainId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AppNodeModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AppNodeModel input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GmtCreate != input.GmtCreate || (this.GmtCreate != null && !this.GmtCreate.Equals(input.GmtCreate))) return false;
            if (this.GmtModify != input.GmtModify || (this.GmtModify != null && !this.GmtModify.Equals(input.GmtModify))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.SubBusinessId != input.SubBusinessId || (this.SubBusinessId != null && !this.SubBusinessId.Equals(input.SubBusinessId))) return false;
            if (this.InnerDomainId != input.InnerDomainId || (this.InnerDomainId != null && !this.InnerDomainId.Equals(input.InnerDomainId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.SubBusinessId != null) hashCode = hashCode * 59 + this.SubBusinessId.GetHashCode();
                if (this.InnerDomainId != null) hashCode = hashCode * 59 + this.InnerDomainId.GetHashCode();
                return hashCode;
            }
        }
    }
}
