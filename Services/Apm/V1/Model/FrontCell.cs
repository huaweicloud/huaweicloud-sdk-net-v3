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
    /// 数据单元。
    /// </summary>
    public class FrontCell 
    {

        /// <summary>
        /// 数据类型。
        /// </summary>
        [JsonProperty("data_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DataType { get; set; }

        /// <summary>
        /// 函数。
        /// </summary>
        [JsonProperty("function", NullValueHandling = NullValueHandling.Ignore)]
        public string Function { get; set; }

        /// <summary>
        /// 是否调用链。
        /// </summary>
        [JsonProperty("trace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trace { get; set; }

        /// <summary>
        /// 是否是span信息，如果是就跳到调用链搜索页面。
        /// </summary>
        [JsonProperty("span", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Span { get; set; }

        /// <summary>
        /// span字段。
        /// </summary>
        [JsonProperty("span_field", NullValueHandling = NullValueHandling.Ignore)]
        public string SpanField { get; set; }

        /// <summary>
        /// 小数点位数。
        /// </summary>
        [JsonProperty("precision", NullValueHandling = NullValueHandling.Ignore)]
        public int? Precision { get; set; }

        /// <summary>
        /// 文本信息。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

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
            sb.Append("class FrontCell {\n");
            sb.Append("  dataType: ").Append(DataType).Append("\n");
            sb.Append("  function: ").Append(Function).Append("\n");
            sb.Append("  trace: ").Append(Trace).Append("\n");
            sb.Append("  span: ").Append(Span).Append("\n");
            sb.Append("  spanField: ").Append(SpanField).Append("\n");
            sb.Append("  precision: ").Append(Precision).Append("\n");
            sb.Append("  text: ").Append(Text).Append("\n");
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
            return this.Equals(input as FrontCell);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FrontCell input)
        {
            if (input == null) return false;
            if (this.DataType != input.DataType || (this.DataType != null && !this.DataType.Equals(input.DataType))) return false;
            if (this.Function != input.Function || (this.Function != null && !this.Function.Equals(input.Function))) return false;
            if (this.Trace != input.Trace || (this.Trace != null && !this.Trace.Equals(input.Trace))) return false;
            if (this.Span != input.Span || (this.Span != null && !this.Span.Equals(input.Span))) return false;
            if (this.SpanField != input.SpanField || (this.SpanField != null && !this.SpanField.Equals(input.SpanField))) return false;
            if (this.Precision != input.Precision || (this.Precision != null && !this.Precision.Equals(input.Precision))) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
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
                if (this.DataType != null) hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Function != null) hashCode = hashCode * 59 + this.Function.GetHashCode();
                if (this.Trace != null) hashCode = hashCode * 59 + this.Trace.GetHashCode();
                if (this.Span != null) hashCode = hashCode * 59 + this.Span.GetHashCode();
                if (this.SpanField != null) hashCode = hashCode * 59 + this.SpanField.GetHashCode();
                if (this.Precision != null) hashCode = hashCode * 59 + this.Precision.GetHashCode();
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Unit != null) hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Visible != null) hashCode = hashCode * 59 + this.Visible.GetHashCode();
                return hashCode;
            }
        }
    }
}
