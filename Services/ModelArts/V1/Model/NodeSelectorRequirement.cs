using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class NodeSelectorRequirement 
    {
        /// <summary>
        /// **参数解释**：表示键与一组值之间的关系。  **约束限制**：有效的运算符包括 In、NotIn、Exists、DoesNotExist、Gt 和 Lt。 **取值范围**： - In：表示键的值必须在给定的值列表中。例如，如果键是 color，值列表是 [\&quot;red\&quot;, \&quot;blue\&quot;]，那么 color In [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值必须是 red 或 blue。 - NotIn：表示键的值不能在给定的值列表中。例如，color NotIn [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值不能是 red 或 blue。 - Exists：表示键必须存在，但对其值没有特定要求。例如，color Exists 表示必须存在 color 这个键，无论其值是什么。 - DoesNotExist：表示键不能存在。例如，color DoesNotExist 表示不能存在 color 这个键。 - Gt：表示键的值必须大于给定的值。例如，如果键是 age，age Gt 18 表示 age 的值必须大于 18。 - Lt：表示键的值必须小于给定的值。例如，age Lt 18 表示 age 的值必须小于 18。 **默认取值**：不涉及。
        /// </summary>
        /// <value>**参数解释**：表示键与一组值之间的关系。  **约束限制**：有效的运算符包括 In、NotIn、Exists、DoesNotExist、Gt 和 Lt。 **取值范围**： - In：表示键的值必须在给定的值列表中。例如，如果键是 color，值列表是 [\&quot;red\&quot;, \&quot;blue\&quot;]，那么 color In [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值必须是 red 或 blue。 - NotIn：表示键的值不能在给定的值列表中。例如，color NotIn [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值不能是 red 或 blue。 - Exists：表示键必须存在，但对其值没有特定要求。例如，color Exists 表示必须存在 color 这个键，无论其值是什么。 - DoesNotExist：表示键不能存在。例如，color DoesNotExist 表示不能存在 color 这个键。 - Gt：表示键的值必须大于给定的值。例如，如果键是 age，age Gt 18 表示 age 的值必须大于 18。 - Lt：表示键的值必须小于给定的值。例如，age Lt 18 表示 age 的值必须小于 18。 **默认取值**：不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<OperatorEnum>))]
        public class OperatorEnum
        {
            /// <summary>
            /// Enum IN for value: In
            /// </summary>
            public static readonly OperatorEnum IN = new OperatorEnum("In");

            /// <summary>
            /// Enum NOTIN for value: NotIn
            /// </summary>
            public static readonly OperatorEnum NOTIN = new OperatorEnum("NotIn");

            /// <summary>
            /// Enum EXISTS for value: Exists
            /// </summary>
            public static readonly OperatorEnum EXISTS = new OperatorEnum("Exists");

            /// <summary>
            /// Enum DOESNOTEXIST for value: DoesNotExist
            /// </summary>
            public static readonly OperatorEnum DOESNOTEXIST = new OperatorEnum("DoesNotExist");

            /// <summary>
            /// Enum GT for value: Gt
            /// </summary>
            public static readonly OperatorEnum GT = new OperatorEnum("Gt");

            /// <summary>
            /// Enum LT for value: Lt
            /// </summary>
            public static readonly OperatorEnum LT = new OperatorEnum("Lt");

            private static readonly Dictionary<string, OperatorEnum> StaticFields =
            new Dictionary<string, OperatorEnum>()
            {
                { "In", IN },
                { "NotIn", NOTIN },
                { "Exists", EXISTS },
                { "DoesNotExist", DOESNOTEXIST },
                { "Gt", GT },
                { "Lt", LT },
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
        /// **参数解释**：选择器应用的标签键。 **约束限制**：不涉及。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// **参数解释**：表示键与一组值之间的关系。  **约束限制**：有效的运算符包括 In、NotIn、Exists、DoesNotExist、Gt 和 Lt。 **取值范围**： - In：表示键的值必须在给定的值列表中。例如，如果键是 color，值列表是 [\&quot;red\&quot;, \&quot;blue\&quot;]，那么 color In [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值必须是 red 或 blue。 - NotIn：表示键的值不能在给定的值列表中。例如，color NotIn [\&quot;red\&quot;, \&quot;blue\&quot;] 表示 color 的值不能是 red 或 blue。 - Exists：表示键必须存在，但对其值没有特定要求。例如，color Exists 表示必须存在 color 这个键，无论其值是什么。 - DoesNotExist：表示键不能存在。例如，color DoesNotExist 表示不能存在 color 这个键。 - Gt：表示键的值必须大于给定的值。例如，如果键是 age，age Gt 18 表示 age 的值必须大于 18。 - Lt：表示键的值必须小于给定的值。例如，age Lt 18 表示 age 的值必须小于 18。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public OperatorEnum Operator { get; set; }
        /// <summary>
        /// **参数解释**：一个字符串值数组。 **约束限制**：如果操作符是“In”或“NotIn”，则该值数组不能为空。如果操作符是“Exists”或“DoesNotExist”，则该值数组必须为空。如果操作符是“Gt”或“Lt”，则该值数组必须包含一个元素，该元素将被解释为整数。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [JsonProperty("values", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Values { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeSelectorRequirement {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  values: ").Append(Values).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeSelectorRequirement);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeSelectorRequirement input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Operator != input.Operator) return false;
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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Values != null) hashCode = hashCode * 59 + this.Values.GetHashCode();
                return hashCode;
            }
        }
    }
}
