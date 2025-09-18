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
    public class MultiQueryConditionOption 
    {
        /// <summary>
        /// **参数解释**: 组合条件类型。 **约束限制**: 不涉及。 **取值范围**: 仅限字符串：\&quot;AND\&quot;、\&quot;OR\&quot;。 **默认取值**: 不涉及。
        /// </summary>
        /// <value>**参数解释**: 组合条件类型。 **约束限制**: 不涉及。 **取值范围**: 仅限字符串：\&quot;AND\&quot;、\&quot;OR\&quot;。 **默认取值**: 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ConditionEnum>))]
        public class ConditionEnum
        {
            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly ConditionEnum OR = new ConditionEnum("OR");

            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly ConditionEnum AND = new ConditionEnum("AND");

            private static readonly Dictionary<string, ConditionEnum> StaticFields =
            new Dictionary<string, ConditionEnum>()
            {
                { "OR", OR },
                { "AND", AND },
            };

            private string _value;

            public ConditionEnum()
            {

            }

            public ConditionEnum(string value)
            {
                _value = value;
            }

            public static ConditionEnum FromValue(string value)
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

                if (this.Equals(obj as ConditionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConditionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ConditionEnum a, ConditionEnum b)
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

            public static bool operator !=(ConditionEnum a, ConditionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 查询字段名称。 **约束限制**： 只支持字符串\&quot;query\&quot;。 **取值范围**： 由英文字母（大小写）、数字或下划线组成，长度为 1 至 128 个字符。 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**: 组合条件类型。 **约束限制**: 不涉及。 **取值范围**: 仅限字符串：\&quot;AND\&quot;、\&quot;OR\&quot;。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionEnum Condition { get; set; }
        /// <summary>
        /// **参数解释**: 多个过滤检索条件内容集合。 **约束限制**: 只支持为true进行模糊查询。 **取值范围**: - true：模糊查询。 - false：精确匹配。  **默认取值**: true 
        /// </summary>
        [JsonProperty("is_fuzzy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFuzzy { get; set; }

        /// <summary>
        /// **参数解释**: 多个过滤检索条件内容集合。由 1 至 5 个字符串组成的列表。 **约束限制**: 不涉及。 **取值范围**: 不涉及。 **默认取值**: 不涉及。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiQueryConditionOption {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  isFuzzy: ").Append(IsFuzzy).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MultiQueryConditionOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiQueryConditionOption input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Condition != input.Condition) return false;
            if (this.IsFuzzy != input.IsFuzzy || (this.IsFuzzy != null && !this.IsFuzzy.Equals(input.IsFuzzy))) return false;
            if (this.Values != input.Values || (this.Values != null && input.Values != null && !this.Values.SequenceEqual(input.Values))) return false;

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
                hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.IsFuzzy != null) hashCode = hashCode * 59 + this.IsFuzzy.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
