using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CombRelation 
    {
        /// <summary>
        /// 逻辑运算符  ALL 所有条件匹配成功  ANY 任意条件匹配成功 
        /// </summary>
        /// <value>逻辑运算符  ALL 所有条件匹配成功  ANY 任意条件匹配成功 </value>
        [JsonConverter(typeof(EnumClassConverter<LogicalOperatorEnum>))]
        public class LogicalOperatorEnum
        {
            /// <summary>
            /// Enum ALL for value: ALL
            /// </summary>
            public static readonly LogicalOperatorEnum ALL = new LogicalOperatorEnum("ALL");

            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            public static readonly LogicalOperatorEnum ANY = new LogicalOperatorEnum("ANY");

            private static readonly Dictionary<string, LogicalOperatorEnum> StaticFields =
            new Dictionary<string, LogicalOperatorEnum>()
            {
                { "ALL", ALL },
                { "ANY", ANY },
            };

            private string _value;

            public LogicalOperatorEnum()
            {

            }

            public LogicalOperatorEnum(string value)
            {
                _value = value;
            }

            public static LogicalOperatorEnum FromValue(string value)
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

                if (this.Equals(obj as LogicalOperatorEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LogicalOperatorEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LogicalOperatorEnum a, LogicalOperatorEnum b)
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

            public static bool operator !=(LogicalOperatorEnum a, LogicalOperatorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 逻辑运算符  ALL 所有条件匹配成功  ANY 任意条件匹配成功 
        /// </summary>
        [JsonProperty("logical_operator", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperatorEnum LogicalOperator { get; set; }
        /// <summary>
        /// 组合匹配资源分组的匹配条件
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Condition> Conditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CombRelation {\n");
            sb.Append("  logicalOperator: ").Append(LogicalOperator).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CombRelation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CombRelation input)
        {
            if (input == null) return false;
            if (this.LogicalOperator != input.LogicalOperator) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;

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
                hashCode = hashCode * 59 + this.LogicalOperator.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
