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
    /// 自定义字段
    /// </summary>
    public class NewCustomField 
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
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewCustomField {\n");
            sb.Append("  customField: ").Append(CustomField).Append("\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NewCustomField);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NewCustomField input)
        {
            if (input == null) return false;
            if (this.CustomField != input.CustomField || (this.CustomField != null && !this.CustomField.Equals(input.CustomField))) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.CustomField != null) hashCode = hashCode * 59 + this.CustomField.GetHashCode();
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
