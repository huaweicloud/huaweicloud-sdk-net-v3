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
    public class IssueDetailCustomField 
    {

        /// <summary>
        /// 自定义字段
        /// </summary>
        [JsonProperty("custom_field", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomField { get; set; }

        /// <summary>
        /// 自定义字段名称
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 自定义属性对应的值，多个值以英文逗号区分开
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 自定义字段类型， textArea 多行文本，text 单行文本，select 下拉框，number 数字，time_date 日期，checkbox 多选框，radio 单选框
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// 自定义字段描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueDetailCustomField {\n");
            sb.Append("  customField: ").Append(CustomField).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IssueDetailCustomField);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IssueDetailCustomField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomField == input.CustomField ||
                    (this.CustomField != null &&
                    this.CustomField.Equals(input.CustomField))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CustomField != null)
                    hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
