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
    /// 字段对象
    /// </summary>
    public class FieldEntity 
    {

        /// <summary>
        /// **参数解释**： 字段名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// **参数解释**： 字段code。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// **参数解释**： 字段id。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 字段描述。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释**： 字段创建人名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// **参数解释**： 字段创建时间，时间戳格式，示例:1715305846000。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// **参数解释**： 字段最后更新人名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// **参数解释**： 字段级别。 **取值范围**： 1/2/3：系统预设字段。 4：租户自定义字段 5：项目自定义字段
        /// </summary>
        [JsonProperty("definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DefinitionType { get; set; }

        /// <summary>
        /// **参数解释**： 字段类型名称。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("field_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldTypeName { get; set; }

        /// <summary>
        /// **参数解释**： 字段在工作项中是否必填，和工作流配置不一致时以工作流为准。 **取值范围**： true（必填） false（非必填）
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// **参数解释**： 字段在工作项中是否受控，修改已基线的工作项受控字段需要走变更评审流程，和工作流配置不一致时以工作流为准。 **取值范围**： true（受控） false（非受控）
        /// </summary>
        [JsonProperty("controlled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Controlled { get; set; }

        /// <summary>
        /// **参数解释**： 字段在工作项中是否可修改，和工作流配置不一致时以工作流为准。 **取值范围**： true（不可修改） false（可修改）
        /// </summary>
        [JsonProperty("immutable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Immutable { get; set; }

        /// <summary>
        /// **参数解释**： 字段排序的序号。 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("no", NullValueHandling = NullValueHandling.Ignore)]
        public int? No { get; set; }

        /// <summary>
        /// **参数解释**： 字段选项。
        /// </summary>
        [JsonProperty("all_options", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionEntity> AllOptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldEntity {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  definitionType: ").Append(DefinitionType).Append("\n");
            sb.Append("  fieldTypeName: ").Append(FieldTypeName).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  controlled: ").Append(Controlled).Append("\n");
            sb.Append("  immutable: ").Append(Immutable).Append("\n");
            sb.Append("  no: ").Append(No).Append("\n");
            sb.Append("  allOptions: ").Append(AllOptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldEntity);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FieldEntity input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.DefinitionType != input.DefinitionType || (this.DefinitionType != null && !this.DefinitionType.Equals(input.DefinitionType))) return false;
            if (this.FieldTypeName != input.FieldTypeName || (this.FieldTypeName != null && !this.FieldTypeName.Equals(input.FieldTypeName))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.Controlled != input.Controlled || (this.Controlled != null && !this.Controlled.Equals(input.Controlled))) return false;
            if (this.Immutable != input.Immutable || (this.Immutable != null && !this.Immutable.Equals(input.Immutable))) return false;
            if (this.No != input.No || (this.No != null && !this.No.Equals(input.No))) return false;
            if (this.AllOptions != input.AllOptions || (this.AllOptions != null && input.AllOptions != null && !this.AllOptions.SequenceEqual(input.AllOptions))) return false;

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
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.DefinitionType != null) hashCode = hashCode * 59 + this.DefinitionType.GetHashCode();
                if (this.FieldTypeName != null) hashCode = hashCode * 59 + this.FieldTypeName.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.Controlled != null) hashCode = hashCode * 59 + this.Controlled.GetHashCode();
                if (this.Immutable != null) hashCode = hashCode * 59 + this.Immutable.GetHashCode();
                if (this.No != null) hashCode = hashCode * 59 + this.No.GetHashCode();
                if (this.AllOptions != null) hashCode = hashCode * 59 + this.AllOptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
