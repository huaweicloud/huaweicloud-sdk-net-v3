using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// 条件键。
    /// </summary>
    public class Condition 
    {
        /// <summary>
        /// 条件值的数据类型。
        /// </summary>
        /// <value>条件值的数据类型。</value>
        [JsonConverter(typeof(EnumClassConverter<ValueTypeEnum>))]
        public class ValueTypeEnum
        {
            /// <summary>
            /// Enum STRING for value: string
            /// </summary>
            public static readonly ValueTypeEnum STRING = new ValueTypeEnum("string");

            /// <summary>
            /// Enum NUMERIC for value: numeric
            /// </summary>
            public static readonly ValueTypeEnum NUMERIC = new ValueTypeEnum("numeric");

            /// <summary>
            /// Enum DATE for value: date
            /// </summary>
            public static readonly ValueTypeEnum DATE = new ValueTypeEnum("date");

            /// <summary>
            /// Enum BOOLEAN for value: boolean
            /// </summary>
            public static readonly ValueTypeEnum BOOLEAN = new ValueTypeEnum("boolean");

            /// <summary>
            /// Enum IP_ADDRESS for value: ip_address
            /// </summary>
            public static readonly ValueTypeEnum IP_ADDRESS = new ValueTypeEnum("ip_address");

            private static readonly Dictionary<string, ValueTypeEnum> StaticFields =
            new Dictionary<string, ValueTypeEnum>()
            {
                { "string", STRING },
                { "numeric", NUMERIC },
                { "date", DATE },
                { "boolean", BOOLEAN },
                { "ip_address", IP_ADDRESS },
            };

            private string _value;

            public ValueTypeEnum()
            {

            }

            public ValueTypeEnum(string value)
            {
                _value = value;
            }

            public static ValueTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ValueTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ValueTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ValueTypeEnum a, ValueTypeEnum b)
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

            public static bool operator !=(ValueTypeEnum a, ValueTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 条件键的名称。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 条件值的数据类型。
        /// </summary>
        [JsonProperty("value_type", NullValueHandling = NullValueHandling.Ignore)]
        public ValueTypeEnum ValueType { get; set; }
        /// <summary>
        /// 条件值是否为多值。
        /// </summary>
        [JsonProperty("multi_valued", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultiValued { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public Description Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Condition {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  valueType: ").Append(ValueType).Append("\n");
            sb.Append("  multiValued: ").Append(MultiValued).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Condition);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Condition input)
        {
            if (input == null) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.ValueType != input.ValueType) return false;
            if (this.MultiValued != input.MultiValued || (this.MultiValued != null && !this.MultiValued.Equals(input.MultiValued))) return false;
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
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.ValueType.GetHashCode();
                if (this.MultiValued != null) hashCode = hashCode * 59 + this.MultiValued.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
