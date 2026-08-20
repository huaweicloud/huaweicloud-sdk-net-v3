using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ProjectMan.V4.Model
{
    /// <summary>
    /// 工作项优先级
    /// </summary>
    public class ProcessInstanceResponseResultIssuePriority 
    {

        /// <summary>
        /// id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 显示名称
        /// </summary>
        [JsonProperty("display_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 值(拼音首字母)
        /// </summary>
        [JsonProperty("value_py", NullValueHandling = NullValueHandling.Ignore)]
        public string ValuePy { get; set; }

        /// <summary>
        /// 序列
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 所属定义级别
        /// </summary>
        [JsonProperty("belong_definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BelongDefinitionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInstanceResponseResultIssuePriority {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  displayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  valuePy: ").Append(ValuePy).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  belongDefinitionType: ").Append(BelongDefinitionType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProcessInstanceResponseResultIssuePriority);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProcessInstanceResponseResultIssuePriority input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.DisplayValue != input.DisplayValue || (this.DisplayValue != null && !this.DisplayValue.Equals(input.DisplayValue))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.ValuePy != input.ValuePy || (this.ValuePy != null && !this.ValuePy.Equals(input.ValuePy))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.BelongDefinitionType != input.BelongDefinitionType || (this.BelongDefinitionType != null && !this.BelongDefinitionType.Equals(input.BelongDefinitionType))) return false;

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
                if (this.DisplayValue != null) hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.ValuePy != null) hashCode = hashCode * 59 + this.ValuePy.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.BelongDefinitionType != null) hashCode = hashCode * 59 + this.BelongDefinitionType.GetHashCode();
                return hashCode;
            }
        }
    }
}
