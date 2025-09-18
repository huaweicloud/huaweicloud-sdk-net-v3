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
    /// **参数解释** 资源名称匹配参数 **约束限制** 不涉及 
    /// </summary>
    public class Instance 
    {
        /// <summary>
        /// **参数解释** 逻辑运算符 **约束限制** 不涉及 **取值范围** - ALL: 所有条件匹配成功 - ANY: 任意条件匹配成功 **默认取值** 不涉及 
        /// </summary>
        /// <value>**参数解释** 逻辑运算符 **约束限制** 不涉及 **取值范围** - ALL: 所有条件匹配成功 - ANY: 任意条件匹配成功 **默认取值** 不涉及 </value>
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

            public static bool operator !=(LogicalOperatorEnum a, LogicalOperatorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释** 云产品名称 **约束限制** 不涉及 **取值范围** 长度为[1,16]个字符 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// **参数解释** 逻辑运算符 **约束限制** 不涉及 **取值范围** - ALL: 所有条件匹配成功 - ANY: 任意条件匹配成功 **默认取值** 不涉及 
        /// </summary>
        [JsonProperty("logical_operator", NullValueHandling = NullValueHandling.Ignore)]
        public LogicalOperatorEnum LogicalOperator { get; set; }
        /// <summary>
        /// **参数解释** 资源名称匹配参数数组 **约束限制** 不超过10个名称 
        /// </summary>
        [JsonProperty("instance_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceNameItem> InstanceNames { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Instance {\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  logicalOperator: ").Append(LogicalOperator).Append("\n");
            sb.Append("  instanceNames: ").Append(InstanceNames).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Instance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Instance input)
        {
            if (input == null) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.LogicalOperator != input.LogicalOperator) return false;
            if (this.InstanceNames != input.InstanceNames || (this.InstanceNames != null && input.InstanceNames != null && !this.InstanceNames.SequenceEqual(input.InstanceNames))) return false;

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
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                hashCode = hashCode * 59 + this.LogicalOperator.GetHashCode();
                if (this.InstanceNames != null) hashCode = hashCode * 59 + this.InstanceNames.GetHashCode();
                return hashCode;
            }
        }
    }
}
