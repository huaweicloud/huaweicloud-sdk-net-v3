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
    /// 字段参数返回体
    /// </summary>
    public class FieldLongDateVO 
    {

        /// <summary>
        /// 字段唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 字段编码。在项目中使用时一般使用code作为字段标识而不是字段ID。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 字段显示名称。
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 字段创建人ID。
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 字段创建时间。时间戳格式，单位毫秒。
        /// </summary>
        [JsonProperty("created_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreatedDate { get; set; }

        /// <summary>
        /// 字段最后修改人ID。
        /// </summary>
        [JsonProperty("modified_by", NullValueHandling = NullValueHandling.Ignore)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 字段最后修改时间。时间戳格式，单位毫秒。
        /// </summary>
        [JsonProperty("modified_date", NullValueHandling = NullValueHandling.Ignore)]
        public long? ModifiedDate { get; set; }

        /// <summary>
        /// 字段类型标识。
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// 字段类型ID。用于区分不同的字段类型。
        /// </summary>
        [JsonProperty("field_type_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldTypeId { get; set; }

        /// <summary>
        /// 字段类型名称。如单选列表、多选列表、多行文本等。
        /// </summary>
        [JsonProperty("field_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldTypeName { get; set; }

        /// <summary>
        /// 字段定义类型。用于区分系统字段和自定义字段。
        /// </summary>
        [JsonProperty("definition_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DefinitionType { get; set; }

        /// <summary>
        /// 是否显示在云服务类型的迭代看板卡片模式中。
        /// </summary>
        [JsonProperty("show_on_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnCard { get; set; }

        /// <summary>
        /// 字段是否为必填项。
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; }

        /// <summary>
        /// 字段是否受控。如果工作项已经基线，修改受控字段值时会触发变更评审。
        /// </summary>
        [JsonProperty("controlled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Controlled { get; set; }

        /// <summary>
        /// 字段是否不可变。更新接口无法更新不可变字段。
        /// </summary>
        [JsonProperty("immutable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Immutable { get; set; }

        /// <summary>
        /// 字段排序序号。数值越小越靠前显示。
        /// </summary>
        [JsonProperty("no", NullValueHandling = NullValueHandling.Ignore)]
        public int? No { get; set; }

        /// <summary>
        /// 字段默认值。创建工作项时自动填充。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 字段选项。单选列表类型字段的选项信息，包含选项ID、编码、显示名称等属性。
        /// </summary>
        [JsonProperty("option", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionEntity> Option { get; set; }

        /// <summary>
        /// 字段所有选项。多选列表类型字段的全部选项信息，数组元素包含选项ID、编码、显示名称等属性。
        /// </summary>
        [JsonProperty("all_options", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionEntity> AllOptions { get; set; }

        /// <summary>
        /// 是否存在同名字段。用于检测字段名称冲突。
        /// </summary>
        [JsonProperty("has_same_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasSameDisplayName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldLongDateVO {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  createdDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  modifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  modifiedDate: ").Append(ModifiedDate).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  fieldTypeId: ").Append(FieldTypeId).Append("\n");
            sb.Append("  fieldTypeName: ").Append(FieldTypeName).Append("\n");
            sb.Append("  definitionType: ").Append(DefinitionType).Append("\n");
            sb.Append("  showOnCard: ").Append(ShowOnCard).Append("\n");
            sb.Append("  optional: ").Append(Optional).Append("\n");
            sb.Append("  controlled: ").Append(Controlled).Append("\n");
            sb.Append("  immutable: ").Append(Immutable).Append("\n");
            sb.Append("  no: ").Append(No).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  option: ").Append(Option).Append("\n");
            sb.Append("  allOptions: ").Append(AllOptions).Append("\n");
            sb.Append("  hasSameDisplayName: ").Append(HasSameDisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldLongDateVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FieldLongDateVO input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.CreatedDate != input.CreatedDate || (this.CreatedDate != null && !this.CreatedDate.Equals(input.CreatedDate))) return false;
            if (this.ModifiedBy != input.ModifiedBy || (this.ModifiedBy != null && !this.ModifiedBy.Equals(input.ModifiedBy))) return false;
            if (this.ModifiedDate != input.ModifiedDate || (this.ModifiedDate != null && !this.ModifiedDate.Equals(input.ModifiedDate))) return false;
            if (this.FieldType != input.FieldType || (this.FieldType != null && !this.FieldType.Equals(input.FieldType))) return false;
            if (this.FieldTypeId != input.FieldTypeId || (this.FieldTypeId != null && !this.FieldTypeId.Equals(input.FieldTypeId))) return false;
            if (this.FieldTypeName != input.FieldTypeName || (this.FieldTypeName != null && !this.FieldTypeName.Equals(input.FieldTypeName))) return false;
            if (this.DefinitionType != input.DefinitionType || (this.DefinitionType != null && !this.DefinitionType.Equals(input.DefinitionType))) return false;
            if (this.ShowOnCard != input.ShowOnCard || (this.ShowOnCard != null && !this.ShowOnCard.Equals(input.ShowOnCard))) return false;
            if (this.Optional != input.Optional || (this.Optional != null && !this.Optional.Equals(input.Optional))) return false;
            if (this.Controlled != input.Controlled || (this.Controlled != null && !this.Controlled.Equals(input.Controlled))) return false;
            if (this.Immutable != input.Immutable || (this.Immutable != null && !this.Immutable.Equals(input.Immutable))) return false;
            if (this.No != input.No || (this.No != null && !this.No.Equals(input.No))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.Option != input.Option || (this.Option != null && input.Option != null && !this.Option.SequenceEqual(input.Option))) return false;
            if (this.AllOptions != input.AllOptions || (this.AllOptions != null && input.AllOptions != null && !this.AllOptions.SequenceEqual(input.AllOptions))) return false;
            if (this.HasSameDisplayName != input.HasSameDisplayName || (this.HasSameDisplayName != null && !this.HasSameDisplayName.Equals(input.HasSameDisplayName))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreatedDate != null) hashCode = hashCode * 59 + this.CreatedDate.GetHashCode();
                if (this.ModifiedBy != null) hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.ModifiedDate != null) hashCode = hashCode * 59 + this.ModifiedDate.GetHashCode();
                if (this.FieldType != null) hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldTypeId != null) hashCode = hashCode * 59 + this.FieldTypeId.GetHashCode();
                if (this.FieldTypeName != null) hashCode = hashCode * 59 + this.FieldTypeName.GetHashCode();
                if (this.DefinitionType != null) hashCode = hashCode * 59 + this.DefinitionType.GetHashCode();
                if (this.ShowOnCard != null) hashCode = hashCode * 59 + this.ShowOnCard.GetHashCode();
                if (this.Optional != null) hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.Controlled != null) hashCode = hashCode * 59 + this.Controlled.GetHashCode();
                if (this.Immutable != null) hashCode = hashCode * 59 + this.Immutable.GetHashCode();
                if (this.No != null) hashCode = hashCode * 59 + this.No.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Option != null) hashCode = hashCode * 59 + this.Option.GetHashCode();
                if (this.AllOptions != null) hashCode = hashCode * 59 + this.AllOptions.GetHashCode();
                if (this.HasSameDisplayName != null) hashCode = hashCode * 59 + this.HasSameDisplayName.GetHashCode();
                return hashCode;
            }
        }
    }
}
