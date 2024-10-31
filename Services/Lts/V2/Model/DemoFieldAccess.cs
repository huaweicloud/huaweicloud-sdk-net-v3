using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DemoFieldAccess 
    {

        /// <summary>
        /// 字段名称需和keys中字段保持一致
        /// </summary>
        [JsonProperty("field_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldName { get; set; }

        /// <summary>
        /// 字段值
        /// </summary>
        [JsonProperty("field_value", NullValueHandling = NullValueHandling.Ignore)]
        public string FieldValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemoFieldAccess {\n");
            sb.Append("  fieldName: ").Append(FieldName).Append("\n");
            sb.Append("  fieldValue: ").Append(FieldValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DemoFieldAccess);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DemoFieldAccess input)
        {
            if (input == null) return false;
            if (this.FieldName != input.FieldName || (this.FieldName != null && !this.FieldName.Equals(input.FieldName))) return false;
            if (this.FieldValue != input.FieldValue || (this.FieldValue != null && !this.FieldValue.Equals(input.FieldValue))) return false;

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
                if (this.FieldName != null) hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FieldValue != null) hashCode = hashCode * 59 + this.FieldValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
