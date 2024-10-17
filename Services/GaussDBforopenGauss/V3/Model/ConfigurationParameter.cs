using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ConfigurationParameter 
    {
        /// <summary>
        /// 参数类型，取值为“string”、“integer”、“boolean”、“list”或“float”之一。
        /// </summary>
        /// <value>参数类型，取值为“string”、“integer”、“boolean”、“list”或“float”之一。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly TypeEnum STRING = new TypeEnum("string");

            /// <summary>
            /// Enum INTEGER for value: integer
            /// </summary>
            public static readonly TypeEnum INTEGER = new TypeEnum("integer");

            /// <summary>
            /// Enum BOOLEAN for value: boolean
            /// </summary>
            public static readonly TypeEnum BOOLEAN = new TypeEnum("boolean");

            /// <summary>
            /// Enum LIST for value: list
            /// </summary>
            public static readonly TypeEnum LIST = new TypeEnum("list");

            /// <summary>
            /// Enum FLOAT for value: float
            /// </summary>
            public static readonly TypeEnum FLOAT = new TypeEnum("float");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "string", STRING },
                { "integer", INTEGER },
                { "boolean", BOOLEAN },
                { "list", LIST },
                { "float", FLOAT },
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
        /// 参数名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 修改该参数是否需要重启实例。
        /// </summary>
        [JsonProperty("restart_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestartRequired { get; set; }

        /// <summary>
        /// 参数取值范围。
        /// </summary>
        [JsonProperty("value_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ValueRange { get; set; }

        /// <summary>
        /// 参数类型，取值为“string”、“integer”、“boolean”、“list”或“float”之一。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 参数描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationParameter {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  restartRequired: ").Append(RestartRequired).Append("\n");
            sb.Append("  valueRange: ").Append(ValueRange).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConfigurationParameter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ConfigurationParameter input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.RestartRequired != input.RestartRequired || (this.RestartRequired != null && !this.RestartRequired.Equals(input.RestartRequired))) return false;
            if (this.ValueRange != input.ValueRange || (this.ValueRange != null && !this.ValueRange.Equals(input.ValueRange))) return false;
            if (this.Type != input.Type) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.RestartRequired != null) hashCode = hashCode * 59 + this.RestartRequired.GetHashCode();
                if (this.ValueRange != null) hashCode = hashCode * 59 + this.ValueRange.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
