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
    /// 工作项字段配置
    /// </summary>
    public class WorkItemFlowFieldConfigVO 
    {

        /// <summary>
        /// 字段编码
        /// </summary>
        [JsonProperty("field_code", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldCode { get; set; }

        /// <summary>
        /// 字段值类型
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueType { get; set; }

        /// <summary>
        /// 字段操作类型
        /// </summary>
        [JsonProperty("field_operation", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldOperation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("field_value", NullValueHandling = NullValueHandling.Ignore)]
        public WorkItemFlowFieldValueVO FieldValue { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Required { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("field_range", NullValueHandling = NullValueHandling.Ignore)]
        public WorkItemFlowFieldRangeVO FieldRange { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkItemFlowFieldConfigVO {\n");
            sb.Append("  fieldCode: ").Append(FieldCode).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  fieldOperation: ").Append(FieldOperation).Append("\n");
            sb.Append("  fieldValue: ").Append(FieldValue).Append("\n");
            sb.Append("  required: ").Append(Required).Append("\n");
            sb.Append("  fieldRange: ").Append(FieldRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WorkItemFlowFieldConfigVO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WorkItemFlowFieldConfigVO input)
        {
            if (input == null) return false;
            if (this.FieldCode != input.FieldCode || (this.FieldCode != null && !this.FieldCode.Equals(input.FieldCode))) return false;
            if (this.ValueType != input.ValueType || (this.ValueType != null && !this.ValueType.Equals(input.ValueType))) return false;
            if (this.FieldOperation != input.FieldOperation || (this.FieldOperation != null && !this.FieldOperation.Equals(input.FieldOperation))) return false;
            if (this.FieldValue != input.FieldValue || (this.FieldValue != null && !this.FieldValue.Equals(input.FieldValue))) return false;
            if (this.Required != input.Required || (this.Required != null && !this.Required.Equals(input.Required))) return false;
            if (this.FieldRange != input.FieldRange || (this.FieldRange != null && !this.FieldRange.Equals(input.FieldRange))) return false;

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
                if (this.FieldCode != null) hashCode = hashCode * 59 + this.FieldCode.GetHashCode();
                if (this.ValueType != null) hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.FieldOperation != null) hashCode = hashCode * 59 + this.FieldOperation.GetHashCode();
                if (this.FieldValue != null) hashCode = hashCode * 59 + this.FieldValue.GetHashCode();
                if (this.Required != null) hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.FieldRange != null) hashCode = hashCode * 59 + this.FieldRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
