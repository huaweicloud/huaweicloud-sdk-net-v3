using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 命中条件定义
    /// </summary>
    public class HitConditionTag 
    {
        /// <summary>
        /// **参数解释**： 字段取值处理 **约束限制**： 不涉及 **取值范围**： * SUM：累计 * AVG：平均 * COUNT：计数 * NONE：无处理
        /// </summary>
        /// <value>**参数解释**： 字段取值处理 **约束限制**： 不涉及 **取值范围**： * SUM：累计 * AVG：平均 * COUNT：计数 * NONE：无处理</value>
        [JsonConverter(typeof(EnumClassConverter<OperationEnum>))]
        public class OperationEnum
        {
            /// <summary>
            /// Enum SUM for value: SUM
            /// </summary>
            public static readonly OperationEnum SUM = new OperationEnum("SUM");

            /// <summary>
            /// Enum AVG for value: AVG
            /// </summary>
            public static readonly OperationEnum AVG = new OperationEnum("AVG");

            /// <summary>
            /// Enum COUNT for value: COUNT
            /// </summary>
            public static readonly OperationEnum COUNT = new OperationEnum("COUNT");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly OperationEnum NONE = new OperationEnum("NONE");

            private static readonly Dictionary<string, OperationEnum> StaticFields =
            new Dictionary<string, OperationEnum>()
            {
                { "SUM", SUM },
                { "AVG", AVG },
                { "COUNT", COUNT },
                { "NONE", NONE },
            };

            private string _value;

            public OperationEnum()
            {

            }

            public OperationEnum(string value)
            {
                _value = value;
            }

            public static OperationEnum FromValue(string value)
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

                if (this.Equals(obj as OperationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationEnum a, OperationEnum b)
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

            public static bool operator !=(OperationEnum a, OperationEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 匹配类型。关键词匹配建议使用REGEX。 **约束限制**： 不涉及。 **取值范围**： * EQUAL: 完全相等 * REGEX：正则匹配 * MATH_GT：数值大于 * MATH_GE：数值大于等于  * MATH_LT：数值小于 * MATH_LE：数值小于等于 * MATH_EQ：数值相等  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 匹配类型。关键词匹配建议使用REGEX。 **约束限制**： 不涉及。 **取值范围**： * EQUAL: 完全相等 * REGEX：正则匹配 * MATH_GT：数值大于 * MATH_GE：数值大于等于  * MATH_LT：数值小于 * MATH_LE：数值小于等于 * MATH_EQ：数值相等  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<MatchEnum>))]
        public class MatchEnum
        {
            /// <summary>
            /// Enum EQUAL for value: EQUAL
            /// </summary>
            public static readonly MatchEnum EQUAL = new MatchEnum("EQUAL");

            /// <summary>
            /// Enum REGEX for value: REGEX
            /// </summary>
            public static readonly MatchEnum REGEX = new MatchEnum("REGEX");

            /// <summary>
            /// Enum MATH_GT for value: MATH_GT
            /// </summary>
            public static readonly MatchEnum MATH_GT = new MatchEnum("MATH_GT");

            /// <summary>
            /// Enum MATH_GE for value: MATH_GE
            /// </summary>
            public static readonly MatchEnum MATH_GE = new MatchEnum("MATH_GE");

            /// <summary>
            /// Enum MATH_LT for value: MATH_LT
            /// </summary>
            public static readonly MatchEnum MATH_LT = new MatchEnum("MATH_LT");

            /// <summary>
            /// Enum MATH_LE for value: MATH_LE
            /// </summary>
            public static readonly MatchEnum MATH_LE = new MatchEnum("MATH_LE");

            /// <summary>
            /// Enum MATH_EQ for value: MATH_EQ
            /// </summary>
            public static readonly MatchEnum MATH_EQ = new MatchEnum("MATH_EQ");

            private static readonly Dictionary<string, MatchEnum> StaticFields =
            new Dictionary<string, MatchEnum>()
            {
                { "EQUAL", EQUAL },
                { "REGEX", REGEX },
                { "MATH_GT", MATH_GT },
                { "MATH_GE", MATH_GE },
                { "MATH_LT", MATH_LT },
                { "MATH_LE", MATH_LE },
                { "MATH_EQ", MATH_EQ },
            };

            private string _value;

            public MatchEnum()
            {

            }

            public MatchEnum(string value)
            {
                _value = value;
            }

            public static MatchEnum FromValue(string value)
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

                if (this.Equals(obj as MatchEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(MatchEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(MatchEnum a, MatchEnum b)
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

            public static bool operator !=(MatchEnum a, MatchEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 事件内容关键字段 &gt; * event_type为1,2,3,4：与LiveEventReport中event.content中反序列化后的JSON字段对应。如：弹幕事件上报事件。   {     \&quot;timestamp\&quot;: 1694481224245,     \&quot;type\&quot;: 1,     \&quot;content\&quot;: \&quot;{\\\&quot;user\\\&quot;:{\\\&quot;userId\\\&quot;:\\\&quot;2027271526\\\&quot;,\\\&quot;name\\\&quot;:\\\&quot;***\\\&quot;,\\\&quot;level\\\&quot;:17,\\\&quot;badge\\\&quot;:\\\&quot;\\\&quot;,\\\&quot;badgeLevel\\\&quot;:0},\\\&quot;content\\\&quot;:\\\&quot;***\\\&quot;}\&quot;   }   匹配弹幕内容，填写content；匹配用户平台等级，填写level。 &gt; * 10：固定填写content即可。  **约束限制**： 不涉及 **取值范围**： 字符长度0-256位 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// **参数解释**： 字段取值处理 **约束限制**： 不涉及 **取值范围**： * SUM：累计 * AVG：平均 * COUNT：计数 * NONE：无处理
        /// </summary>
        [JsonProperty("operation", NullValueHandling = NullValueHandling.Ignore)]
        public OperationEnum Operation { get; set; }
        /// <summary>
        /// **参数解释**： 匹配类型。关键词匹配建议使用REGEX。 **约束限制**： 不涉及。 **取值范围**： * EQUAL: 完全相等 * REGEX：正则匹配 * MATH_GT：数值大于 * MATH_GE：数值大于等于  * MATH_LT：数值小于 * MATH_LE：数值小于等于 * MATH_EQ：数值相等  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("match", NullValueHandling = NullValueHandling.Ignore)]
        public MatchEnum Match { get; set; }
        /// <summary>
        /// **参数解释**： 匹配值。 **约束限制**： 不涉及 **取值范围**： 字符长度0-1024 **默认取值**： 不涉及。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HitConditionTag {\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  operation: ").Append(Operation).Append("\n");
            sb.Append("  match: ").Append(Match).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HitConditionTag);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HitConditionTag input)
        {
            if (input == null) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.Operation != input.Operation) return false;
            if (this.Match != input.Match) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;

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
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                hashCode = hashCode * 59 + this.Operation.GetHashCode();
                hashCode = hashCode * 59 + this.Match.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
