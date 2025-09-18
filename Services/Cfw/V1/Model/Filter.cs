using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Filter 
    {
        /// <summary>
        /// **参数解释**： 操作符 **约束限制**： 不涉及 **取值范围**： equal 等于 not_equal 不等于 contain 包含 starts_with 以开始 **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 操作符 **约束限制**： 不涉及 **取值范围**： equal 等于 not_equal 不等于 contain 包含 starts_with 以开始 **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<OperatorEnum>))]
        public class OperatorEnum
        {
            /// <summary>
            /// Enum EQUAL for value: equal
            /// </summary>
            public static readonly OperatorEnum EQUAL = new OperatorEnum("equal");

            /// <summary>
            /// Enum NOT_EQUAL for value: not_equal
            /// </summary>
            public static readonly OperatorEnum NOT_EQUAL = new OperatorEnum("not_equal");

            /// <summary>
            /// Enum CONTAIN for value: contain
            /// </summary>
            public static readonly OperatorEnum CONTAIN = new OperatorEnum("contain");

            /// <summary>
            /// Enum STARTS_WITH for value: starts_with
            /// </summary>
            public static readonly OperatorEnum STARTS_WITH = new OperatorEnum("starts_with");

            private static readonly Dictionary<string, OperatorEnum> StaticFields =
            new Dictionary<string, OperatorEnum>()
            {
                { "equal", EQUAL },
                { "not_equal", NOT_EQUAL },
                { "contain", CONTAIN },
                { "starts_with", STARTS_WITH },
            };

            private string _value;

            public OperatorEnum()
            {

            }

            public OperatorEnum(string value)
            {
                _value = value;
            }

            public static OperatorEnum FromValue(string value)
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

                if (this.Equals(obj as OperatorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperatorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperatorEnum a, OperatorEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(OperatorEnum a, OperatorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 日志字段，如src_ip **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public string Field { get; set; }

        /// <summary>
        /// **参数解释**： 值 **约束限制**： 不涉及 **取值范围**： 不涉及 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }

        /// <summary>
        /// **参数解释**： 操作符 **约束限制**： 不涉及 **取值范围**： equal 等于 not_equal 不等于 contain 包含 starts_with 以开始 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public OperatorEnum Operator { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  field: ").Append(Field).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Filter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Filter input)
        {
            if (input == null) return false;
            if (this.Field != input.Field || (this.Field != null && !this.Field.Equals(input.Field))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;
            if (this.Operator != input.Operator) return false;

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
                if (this.Field != null) hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                return hashCode;
            }
        }
    }
}
