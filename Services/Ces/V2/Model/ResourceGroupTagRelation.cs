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
    public class ResourceGroupTagRelation 
    {
        /// <summary>
        /// tag操作符，含义是标签key与value的关系。   include表示包含   prefix表示前缀   suffix表示后缀   notInclude表示不包含   equal表示相等   当operator为equal，value为空字符串时表示为全部   all表示全部 
        /// </summary>
        /// <value>tag操作符，含义是标签key与value的关系。   include表示包含   prefix表示前缀   suffix表示后缀   notInclude表示不包含   equal表示相等   当operator为equal，value为空字符串时表示为全部   all表示全部 </value>
        [JsonConverter(typeof(EnumClassConverter<OperatorEnum>))]
        public class OperatorEnum
        {
            /// <summary>
            /// Enum INCLUDE for value: include
            /// </summary>
            public static readonly OperatorEnum INCLUDE = new OperatorEnum("include");

            /// <summary>
            /// Enum PREFIX for value: prefix
            /// </summary>
            public static readonly OperatorEnum PREFIX = new OperatorEnum("prefix");

            /// <summary>
            /// Enum SUFFIX for value: suffix
            /// </summary>
            public static readonly OperatorEnum SUFFIX = new OperatorEnum("suffix");

            /// <summary>
            /// Enum NOTINCLUDE for value: notInclude
            /// </summary>
            public static readonly OperatorEnum NOTINCLUDE = new OperatorEnum("notInclude");

            /// <summary>
            /// Enum EQUAL for value: equal
            /// </summary>
            public static readonly OperatorEnum EQUAL = new OperatorEnum("equal");

            /// <summary>
            /// Enum ALL for value: all
            /// </summary>
            public static readonly OperatorEnum ALL = new OperatorEnum("all");

            private static readonly Dictionary<string, OperatorEnum> StaticFields =
            new Dictionary<string, OperatorEnum>()
            {
                { "include", INCLUDE },
                { "prefix", PREFIX },
                { "suffix", SUFFIX },
                { "notInclude", NOTINCLUDE },
                { "equal", EQUAL },
                { "all", ALL },
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

            public static bool operator !=(OperatorEnum a, OperatorEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// TMS标签键规范。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// tag操作符，含义是标签key与value的关系。   include表示包含   prefix表示前缀   suffix表示后缀   notInclude表示不包含   equal表示相等   当operator为equal，value为空字符串时表示为全部   all表示全部 
        /// </summary>
        [JsonProperty("operator", NullValueHandling = NullValueHandling.Ignore)]
        public OperatorEnum Operator { get; set; }
        /// <summary>
        /// TMS标签值规范。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceGroupTagRelation {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceGroupTagRelation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceGroupTagRelation input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Operator != input.Operator) return false;
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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Operator.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
