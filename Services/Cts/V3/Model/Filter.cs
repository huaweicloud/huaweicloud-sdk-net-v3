using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 关键操作通知高级筛选条件。
    /// </summary>
    public class Filter 
    {
        /// <summary>
        /// 多条件关系。 - AND 表示所有过滤条件满足后生效。 - OR 表示有任意一个条件满足时生效。
        /// </summary>
        /// <value>多条件关系。 - AND 表示所有过滤条件满足后生效。 - OR 表示有任意一个条件满足时生效。</value>
        [JsonConverter(typeof(EnumClassConverter<ConditionEnum>))]
        public class ConditionEnum
        {
            /// <summary>
            /// Enum AND for value: AND
            /// </summary>
            public static readonly ConditionEnum AND = new ConditionEnum("AND");

            /// <summary>
            /// Enum OR for value: OR
            /// </summary>
            public static readonly ConditionEnum OR = new ConditionEnum("OR");

            private static readonly Dictionary<string, ConditionEnum> StaticFields =
            new Dictionary<string, ConditionEnum>()
            {
                { "AND", AND },
                { "OR", OR },
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

            public static bool operator !=(ConditionEnum a, ConditionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 多条件关系。 - AND 表示所有过滤条件满足后生效。 - OR 表示有任意一个条件满足时生效。
        /// </summary>
        [JsonProperty("condition", NullValueHandling = NullValueHandling.Ignore)]
        public ConditionEnum Condition { get; set; }
        /// <summary>
        /// 是否打开高级筛选开关。
        /// </summary>
        [JsonProperty("is_support_filter", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportFilter { get; set; }

        /// <summary>
        /// 高级过滤条件规则，示例如下：\&quot;key !&#x3D; value\&quot;，格式为：字段 规则 值。 -字段取值范围：api_version,code,trace_rating,trace_type,resource_id,resource_name。 -规则：!&#x3D; 或 &#x3D;。 - 值：api_version正则约束：^(a-zA-Z0-9_-.){1,64}$；code：最小长度1，最大长度256；trace_rating枚举值：\&quot;normal\&quot;, \&quot;warning\&quot;, \&quot;incident\&quot;；trace_type枚举值：\&quot;ConsoleAction\&quot;, \&quot;ApiCall\&quot;, \&quot;SystemAction\&quot;；resource_id：最小长度1，最大长度350；resource_name：最小长度1，最大长度256
        /// </summary>
        [JsonProperty("rule", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Rule { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Filter {\n");
            sb.Append("  condition: ").Append(Condition).Append("\n");
            sb.Append("  isSupportFilter: ").Append(IsSupportFilter).Append("\n");
            sb.Append("  rule: ").Append(Rule).Append("\n");
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
            if (input == null)
                return false;

            return 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.IsSupportFilter == input.IsSupportFilter ||
                    (this.IsSupportFilter != null &&
                    this.IsSupportFilter.Equals(input.IsSupportFilter))
                ) && 
                (
                    this.Rule == input.Rule ||
                    this.Rule != null &&
                    input.Rule != null &&
                    this.Rule.SequenceEqual(input.Rule)
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.IsSupportFilter != null)
                    hashCode = hashCode * 59 + this.IsSupportFilter.GetHashCode();
                if (this.Rule != null)
                    hashCode = hashCode * 59 + this.Rule.GetHashCode();
                return hashCode;
            }
        }
    }
}
