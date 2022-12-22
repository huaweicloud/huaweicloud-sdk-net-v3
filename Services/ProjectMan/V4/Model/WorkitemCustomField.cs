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
    /// 用户自定义字段
    /// </summary>
    public class WorkitemCustomField 
    {

        /// <summary>
        /// 自定义字段id
        /// </summary>
        [JsonProperty("field_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldId { get; set; }

        /// <summary>
        /// 自定义字段名称
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 自定义字段类型, \&quot;Date\&quot;,\&quot;Number\&quot;,\&quot;DateTime\&quot;, \&quot;MultiLineText\&quot;,\&quot;SingleLineText\&quot;, \&quot;Select\&quot;,  \&quot;Checkbox\&quot;
        /// </summary>
        [JsonProperty("field_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldType { get; set; }

        /// <summary>
        /// 自定义字段的选项源,CUSTOM，USER，DOMAIN，ITERATION，MODULE，TAG
        /// </summary>
        [JsonProperty("field_option_source", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldOptionSource { get; set; }

        /// <summary>
        /// 自定义字段值, (field_type为Date,Number,DateTime时,field_option_source为空，value值是数字的字符串)， (field_type为MultiLineText,SingleLineText时,field_option_source为空，value值是文本字符串)， (field_type为Select ,field_option_source为CUSTOM时，value值是文本字符串) (field_type为Select ,field_option_source为USER，DOMAIN，ITERATION，MODULE，TAG时，value值是Json格式{}), (field_type为Checkbox ,field_option_source为CUSTOM时，value值是字符串数组[\\\&quot;aaa\\\&quot;]), (field_type为\&quot;Checkbox\&quot; ,field_option_source为USER，DOMAIN，ITERATION，MODULE，TAG时，value值是Json的数组[{},{}])
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkitemCustomField {\n");
            sb.Append("  fieldId: ").Append(FieldId).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  fieldType: ").Append(FieldType).Append("\n");
            sb.Append("  fieldOptionSource: ").Append(FieldOptionSource).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkitemCustomField);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkitemCustomField input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldId == input.FieldId ||
                    (this.FieldId != null &&
                    this.FieldId.Equals(input.FieldId))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.FieldOptionSource == input.FieldOptionSource ||
                    (this.FieldOptionSource != null &&
                    this.FieldOptionSource.Equals(input.FieldOptionSource))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.FieldId != null)
                    hashCode = hashCode * 59 + this.FieldId.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.FieldOptionSource != null)
                    hashCode = hashCode * 59 + this.FieldOptionSource.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
