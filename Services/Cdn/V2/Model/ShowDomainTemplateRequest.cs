using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowDomainTemplateRequest 
    {

        /// <summary>
        /// **参数解释：** 域名模板名称 **约束限制：** 不涉及 **取值范围：** - 1-100个字符 - 仅支持字母、数字、中文、下划线（_）、中横线（-） **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("tml_name", IsQuery = true)]
        [JsonProperty("tml_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TmlName { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板ID，可以通过本接口获取 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("tml_id", IsQuery = true)]
        [JsonProperty("tml_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TmlId { get; set; }

        /// <summary>
        /// **参数解释：** 域名模板类型 **约束限制：** 不涉及 **取值范围：** - 1: 系统预置模板 - 2: 租户自定义模板 **默认取值：** 不涉及
        /// </summary>
        [SDKProperty("tml_type", IsQuery = true)]
        [JsonProperty("tml_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? TmlType { get; set; }

        /// <summary>
        /// **参数解释：** 分页大小 **约束限制：** 不涉及 **取值范围：** 1-10000 **默认取值：** 30
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public string Limit { get; set; }

        /// <summary>
        /// **参数解释：** 查询的页码 **约束限制：** 不涉及 **取值范围：** 0-65535 **默认取值：** 0
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDomainTemplateRequest {\n");
            sb.Append("  tmlName: ").Append(TmlName).Append("\n");
            sb.Append("  tmlId: ").Append(TmlId).Append("\n");
            sb.Append("  tmlType: ").Append(TmlType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDomainTemplateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDomainTemplateRequest input)
        {
            if (input == null) return false;
            if (this.TmlName != input.TmlName || (this.TmlName != null && !this.TmlName.Equals(input.TmlName))) return false;
            if (this.TmlId != input.TmlId || (this.TmlId != null && !this.TmlId.Equals(input.TmlId))) return false;
            if (this.TmlType != input.TmlType || (this.TmlType != null && !this.TmlType.Equals(input.TmlType))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;

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
                if (this.TmlName != null) hashCode = hashCode * 59 + this.TmlName.GetHashCode();
                if (this.TmlId != null) hashCode = hashCode * 59 + this.TmlId.GetHashCode();
                if (this.TmlType != null) hashCode = hashCode * 59 + this.TmlType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                return hashCode;
            }
        }
    }
}
