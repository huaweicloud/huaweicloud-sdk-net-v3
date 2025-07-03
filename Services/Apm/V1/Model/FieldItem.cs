using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// 所需展示的字段列表模型。
    /// </summary>
    public class FieldItem 
    {

        /// <summary>
        /// 表达式。
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// 作为。
        /// </summary>
        [JsonProperty("as", NullValueHandling = NullValueHandling.Ignore)]
        public string As { get; set; }

        /// <summary>
        /// 默认值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 是否是trace。
        /// </summary>
        [JsonProperty("trace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trace { get; set; }

        /// <summary>
        /// 百分比。
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Precision { get; set; }

        /// <summary>
        /// 单位。
        /// </summary>
        [JsonProperty("unit", NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        /// <summary>
        /// 是否可见。
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldItem {\n");
            sb.Append("  function: ").Append(Function).Append("\n");
            sb.Append("  As: ").Append(As).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  trace: ").Append(Trace).Append("\n");
            sb.Append("  precision: ").Append(Precision).Append("\n");
            sb.Append("  unit: ").Append(Unit).Append("\n");
            sb.Append("  visible: ").Append(Visible).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FieldItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FieldItem input)
        {
            if (input == null) return false;
            if (this.Function != input.Function || (this.Function != null && !this.Function.Equals(input.Function))) return false;
            if (this.As != input.As || (this.As != null && !this.As.Equals(input.As))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.Trace != input.Trace || (this.Trace != null && !this.Trace.Equals(input.Trace))) return false;
            if (this.Precision != input.Precision || (this.Precision != null && !this.Precision.Equals(input.Precision))) return false;
            if (this.Unit != input.Unit || (this.Unit != null && !this.Unit.Equals(input.Unit))) return false;
            if (this.Visible != input.Visible || (this.Visible != null && !this.Visible.Equals(input.Visible))) return false;

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
                if (this.Function != null) hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.As != null) hashCode = hashCode * 59 + this.As.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.Trace != null) hashCode = hashCode * 59 + this.Trace.GetHashCode();
                if (this.Precision != null) hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                return hashCode;
            }
        }
    }
}
