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
    /// 
    /// </summary>
    public class OptionVO 
    {

        /// <summary>
        /// **参数解释：**  选项Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：**  选项名称。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("display_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// **参数解释：**  选项的唯一标识，自定义的选项id和value相同。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// **参数解释：**  选项code。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释：**  选项名称的中文拼音首字母。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("value_py", NullValueHandling = NullValueHandling.Ignore)]
        public string ValuePy { get; set; }

        /// <summary>
        /// **参数解释：**  选项在选项列表中的排序。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }

        /// <summary>
        /// **参数解释：**  层级选项的分层标识，单选列表和多选列表值都为1，层级字段按照层级依次为1,2,3,4。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// **参数解释：**  选项所在的项目空间Id。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// **参数解释：**  选项归属的定义级别。1,2,3为系统级，4为租户自定义，5为项目自定义。 **取值范围：**  不涉及。
        /// </summary>
        [JsonProperty("belong_definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BelongDefinitionType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionVO {\n");
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
            return this.Equals(input as OptionVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OptionVO input)
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
