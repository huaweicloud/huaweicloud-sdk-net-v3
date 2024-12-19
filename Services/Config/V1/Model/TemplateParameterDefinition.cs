using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 预定义合规包模板参数详情。
    /// </summary>
    public class TemplateParameterDefinition 
    {
        /// <summary>
        /// 预定义合规包模板参数类型。
        /// </summary>
        /// <value>预定义合规包模板参数类型。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum ARRAY for value: Array
            /// </summary>
            public static readonly TypeEnum ARRAY = new TypeEnum("Array");

            /// <summary>
            /// Enum BOOLEAN for value: Boolean
            /// </summary>
            public static readonly TypeEnum BOOLEAN = new TypeEnum("Boolean");

            /// <summary>
            /// Enum INTEGER for value: Integer
            /// </summary>
            public static readonly TypeEnum INTEGER = new TypeEnum("Integer");

            /// <summary>
            /// Enum FLOAT for value: Float
            /// </summary>
            public static readonly TypeEnum FLOAT = new TypeEnum("Float");

            /// <summary>
            /// Enum STRING for value: String
            /// </summary>
            public static readonly TypeEnum STRING = new TypeEnum("String");

            /// <summary>
            /// Enum OBJECT for value: Object
            /// </summary>
            public static readonly TypeEnum OBJECT = new TypeEnum("Object");

            /// <summary>
            /// Enum DATE for value: Date
            /// </summary>
            public static readonly TypeEnum DATE = new TypeEnum("Date");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "Array", ARRAY },
                { "Boolean", BOOLEAN },
                { "Integer", INTEGER },
                { "Float", FLOAT },
                { "String", STRING },
                { "Object", OBJECT },
                { "Date", DATE },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 预定义合规包模板参数名字。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 预定义合规包模板参数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 预定义合规包模板参数默认值。
        /// </summary>
        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public Object DefaultValue { get; set; }

        /// <summary>
        /// 预定义合规包模板参数允许值列表。
        /// </summary>
        [JsonProperty("allowed_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<Object> AllowedValues { get; set; }

        /// <summary>
        /// 策略参数的最小值，当参数类型为Integer或Float时生效。
        /// </summary>
        [JsonProperty("minimum", NullValueHandling = NullValueHandling.Ignore)]
        public float? Minimum { get; set; }

        /// <summary>
        /// 策略参数的最大值，当参数类型为Integer或Float时生效。
        /// </summary>
        [JsonProperty("maximum", NullValueHandling = NullValueHandling.Ignore)]
        public float? Maximum { get; set; }

        /// <summary>
        /// 策略参数的最小项数，当参数类型为Array时生效。
        /// </summary>
        [JsonProperty("min_items", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinItems { get; set; }

        /// <summary>
        /// 策略参数的最大项数，当参数类型为Array时生效。
        /// </summary>
        [JsonProperty("max_items", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// 策略参数的最小字符串长度或每项的最小字符串长度，当参数类型为String或Array时生效。
        /// </summary>
        [JsonProperty("min_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinLength { get; set; }

        /// <summary>
        /// 策略参数的最大字符串长度或每项的最大字符串长度，当参数类型为String或Array时生效。
        /// </summary>
        [JsonProperty("max_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxLength { get; set; }

        /// <summary>
        /// 策略参数的字符串正则要求或每项的字符串正则要求，当参数类型为String或Array时生效。
        /// </summary>
        [JsonProperty("pattern", NullValueHandling = NullValueHandling.Ignore)]
        public string Pattern { get; set; }

        /// <summary>
        /// 预定义合规包模板参数类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateParameterDefinition {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  defaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  allowedValues: ").Append(AllowedValues).Append("\n");
            sb.Append("  minimum: ").Append(Minimum).Append("\n");
            sb.Append("  maximum: ").Append(Maximum).Append("\n");
            sb.Append("  minItems: ").Append(MinItems).Append("\n");
            sb.Append("  maxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  minLength: ").Append(MinLength).Append("\n");
            sb.Append("  maxLength: ").Append(MaxLength).Append("\n");
            sb.Append("  pattern: ").Append(Pattern).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TemplateParameterDefinition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TemplateParameterDefinition input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.DefaultValue != input.DefaultValue || (this.DefaultValue != null && !this.DefaultValue.Equals(input.DefaultValue))) return false;
            if (this.AllowedValues != input.AllowedValues || (this.AllowedValues != null && input.AllowedValues != null && !this.AllowedValues.SequenceEqual(input.AllowedValues))) return false;
            if (this.Minimum != input.Minimum || (this.Minimum != null && !this.Minimum.Equals(input.Minimum))) return false;
            if (this.Maximum != input.Maximum || (this.Maximum != null && !this.Maximum.Equals(input.Maximum))) return false;
            if (this.MinItems != input.MinItems || (this.MinItems != null && !this.MinItems.Equals(input.MinItems))) return false;
            if (this.MaxItems != input.MaxItems || (this.MaxItems != null && !this.MaxItems.Equals(input.MaxItems))) return false;
            if (this.MinLength != input.MinLength || (this.MinLength != null && !this.MinLength.Equals(input.MinLength))) return false;
            if (this.MaxLength != input.MaxLength || (this.MaxLength != null && !this.MaxLength.Equals(input.MaxLength))) return false;
            if (this.Pattern != input.Pattern || (this.Pattern != null && !this.Pattern.Equals(input.Pattern))) return false;
            if (this.Type != input.Type) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.DefaultValue != null) hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.AllowedValues != null) hashCode = hashCode * 59 + this.AllowedValues.GetHashCode();
                if (this.Minimum != null) hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Maximum != null) hashCode = hashCode * 59 + this.Maximum.GetHashCode();
                if (this.MinItems != null) hashCode = hashCode * 59 + this.MinItems.GetHashCode();
                if (this.MaxItems != null) hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
                if (this.MinLength != null) hashCode = hashCode * 59 + this.MinLength.GetHashCode();
                if (this.MaxLength != null) hashCode = hashCode * 59 + this.MaxLength.GetHashCode();
                if (this.Pattern != null) hashCode = hashCode * 59 + this.Pattern.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
