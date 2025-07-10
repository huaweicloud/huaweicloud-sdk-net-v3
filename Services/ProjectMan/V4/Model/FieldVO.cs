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
    public class FieldVO 
    {

        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
        [JsonProperty("created_by", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// 是否显示在新建页
        /// </summary>
        [JsonProperty("show_on_card", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOnCard { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("optional", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; }

        /// <summary>
        /// 字段选项
        /// </summary>
        [JsonProperty("all_options", NullValueHandling = NullValueHandling.Ignore)]
        public List<OptionEntity> AllOptions { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldVO {\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  createdBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  showOnCard: ").Append(ShowOnCard).Append("\n");
            sb.Append("  optional: ").Append(Optional).Append("\n");
            sb.Append("  allOptions: ").Append(AllOptions).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FieldVO input)
        {
            if (input == null) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.CreatedBy != input.CreatedBy || (this.CreatedBy != null && !this.CreatedBy.Equals(input.CreatedBy))) return false;
            if (this.FieldType != input.FieldType || (this.FieldType != null && !this.FieldType.Equals(input.FieldType))) return false;
            if (this.ShowOnCard != input.ShowOnCard || (this.ShowOnCard != null && !this.ShowOnCard.Equals(input.ShowOnCard))) return false;
            if (this.Optional != input.Optional || (this.Optional != null && !this.Optional.Equals(input.Optional))) return false;
            if (this.AllOptions != input.AllOptions || (this.AllOptions != null && input.AllOptions != null && !this.AllOptions.SequenceEqual(input.AllOptions))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;

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
                if (this.CreatedBy != null) hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.FieldType != null) hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.ShowOnCard != null) hashCode = hashCode * 59 + this.ShowOnCard.GetHashCode();
                if (this.Optional != null) hashCode = hashCode * 59 + this.Optional.GetHashCode();
                if (this.AllOptions != null) hashCode = hashCode * 59 + this.AllOptions.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
