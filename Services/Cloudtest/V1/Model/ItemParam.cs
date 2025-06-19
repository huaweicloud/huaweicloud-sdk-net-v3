using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ItemParam 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basic_value", NullValueHandling = NullValueHandling.Ignore)]
        public AwParamBasicValue BasicValue { get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("defaultValue", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// 枚举类型
        /// </summary>
        [JsonProperty("enum_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnumType { get; set; }

        /// <summary>
        /// 当前选中的枚举类型
        /// </summary>
        [JsonProperty("enum_type_selected", NullValueHandling = NullValueHandling.Ignore)]
        public string EnumTypeSelected { get; set; }

        /// <summary>
        /// num和String有效
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 是否是大字段参数
        /// </summary>
        [JsonProperty("is_big_field", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBigField { get; set; }

        /// <summary>
        /// Array类型最大元素数
        /// </summary>
        [JsonProperty("maxItems", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// String类型最大长度
        /// </summary>
        [JsonProperty("maxLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
        public Number Maximum { get; set; }

        /// <summary>
        /// Array类型最小元素数
        /// </summary>
        [JsonProperty("minItems", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinItems { get; set; }

        /// <summary>
        /// String类型最小长度
        /// </summary>
        [JsonProperty("minLength", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinLength { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public Number Minimum { get; set; }

        /// <summary>
        /// num和String有效
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("validate_rule", NullValueHandling = NullValueHandling.Ignore)]
        public ValidateRule ValidateRule { get; set; }

        /// <summary>
        /// 参数值类型 0-基本类型，type字段为String,Integer等基本类型 1-基本类型数组,type字段为List&lt;String&gt;,List&lt;Integer&gt;等基本类型List 2-结构体，type字段为除了基本类型以外的结构体 3-结构体数组，type字段为List&lt;结构体&gt; 5-前端枚举类型
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueType { get; set; }

        /// <summary>
        /// choice选择关系
        /// </summary>
        [JsonProperty("xChoiceValue", NullValueHandling = NullValueHandling.Ignore)]
        public string XChoiceValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ItemParam {\n");
            sb.Append("  basicValue: ").Append(BasicValue).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  enumType: ").Append(EnumType).Append("\n");
            sb.Append("  enumTypeSelected: ").Append(EnumTypeSelected).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  isBigField: ").Append(IsBigField).Append("\n");
            sb.Append("  maxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  maximum: ").Append(Maximum).Append("\n");
            sb.Append("  minItems: ").Append(MinItems).Append("\n");
            sb.Append("  minLength: ").Append(MinLength).Append("\n");
            sb.Append("  minimum: ").Append(Minimum).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  validateRule: ").Append(ValidateRule).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  xChoiceValue: ").Append(XChoiceValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ItemParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ItemParam input)
        {
            if (input == null) return false;
            if (this.BasicValue != input.BasicValue || (this.BasicValue != null && !this.BasicValue.Equals(input.BasicValue))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.EnumType != input.EnumType || (this.EnumType != null && !this.EnumType.Equals(input.EnumType))) return false;
            if (this.EnumTypeSelected != input.EnumTypeSelected || (this.EnumTypeSelected != null && !this.EnumTypeSelected.Equals(input.EnumTypeSelected))) return false;
            if (this.Format != input.Format || (this.Format != null && !this.Format.Equals(input.Format))) return false;
            if (this.IsBigField != input.IsBigField || (this.IsBigField != null && !this.IsBigField.Equals(input.IsBigField))) return false;
            if (this.MaxItems != input.MaxItems || (this.MaxItems != null && !this.MaxItems.Equals(input.MaxItems))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;
            if (this.Maximum != input.Maximum || (this.Maximum != null && !this.Maximum.Equals(input.Maximum))) return false;
            if (this.MinItems != input.MinItems || (this.MinItems != null && !this.MinItems.Equals(input.MinItems))) return false;
            if (this.MinLength != input.MinLength || (this.MinLength != null && !this.MinLength.Equals(input.MinLength))) return false;
            if (this.Minimum != input.Minimum || (this.Minimum != null && !this.Minimum.Equals(input.Minimum))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.ValidateRule != input.ValidateRule || (this.ValidateRule != null && !this.ValidateRule.Equals(input.ValidateRule))) return false;
            if (this.ValueType != input.ValueType || (this.ValueType != null && !this.ValueType.Equals(input.ValueType))) return false;
            if (this.XChoiceValue != input.XChoiceValue || (this.XChoiceValue != null && !this.XChoiceValue.Equals(input.XChoiceValue))) return false;

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
                if (this.BasicValue != null) hashCode = hashCode * 59 + this.BasicValue.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.EnumType != null) hashCode = hashCode * 59 + this.EnumType.GetHashCode();
                if (this.EnumTypeSelected != null) hashCode = hashCode * 59 + this.EnumTypeSelected.GetHashCode();
                if (this.Format != null) hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.IsBigField != null) hashCode = hashCode * 59 + this.IsBigField.GetHashCode();
                if (this.MaxItems != null) hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.Maximum != null) hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.MinItems != null) hashCode = hashCode * 59 + this.MinItems.GetHashCode();
                if (this.MinLength != null) hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                if (this.Minimum != null) hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ValidateRule != null) hashCode = hashCode * 59 + this.ValidateRule.GetHashCode();
                if (this.ValueType != null) hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.XChoiceValue != null) hashCode = hashCode * 59 + this.XChoiceValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
