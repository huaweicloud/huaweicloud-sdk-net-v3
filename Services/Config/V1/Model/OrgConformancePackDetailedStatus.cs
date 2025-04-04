using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 组织合规规则包查询结果。
    /// </summary>
    public class OrgConformancePackDetailedStatus 
    {

        /// <summary>
        /// 成员帐号ID。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 合规规则包ID。
        /// </summary>
        [JsonProperty("conformance_pack_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConformancePackId { get; set; }

        /// <summary>
        /// 合规规则包名称。
        /// </summary>
        [JsonProperty("conformance_pack_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConformancePackName { get; set; }

        /// <summary>
        /// 合规规则包部署状态
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public string State { get; set; }

        /// <summary>
        /// 部署或删除组织合规规则包错误时的错误信息
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgConformancePackDetailedStatus {\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  conformancePackId: ").Append(ConformancePackId).Append("\n");
            sb.Append("  conformancePackName: ").Append(ConformancePackName).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrgConformancePackDetailedStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrgConformancePackDetailedStatus input)
        {
            if (input == null) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.ConformancePackId != input.ConformancePackId || (this.ConformancePackId != null && !this.ConformancePackId.Equals(input.ConformancePackId))) return false;
            if (this.ConformancePackName != input.ConformancePackName || (this.ConformancePackName != null && !this.ConformancePackName.Equals(input.ConformancePackName))) return false;
            if (this.State != input.State || (this.State != null && !this.State.Equals(input.State))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.ConformancePackId != null) hashCode = hashCode * 59 + this.ConformancePackId.GetHashCode();
                if (this.ConformancePackName != null) hashCode = hashCode * 59 + this.ConformancePackName.GetHashCode();
                if (this.State != null) hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
