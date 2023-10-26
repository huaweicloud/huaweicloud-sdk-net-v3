using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 静默规则的匹配条件
    /// </summary>
    public class Match 
    {
        /// <summary>
        /// 指定匹配的方式：EXIST:存在，REGEX:正则，EQUALS:等于
        /// </summary>
        /// <value>指定匹配的方式：EXIST:存在，REGEX:正则，EQUALS:等于</value>
        [JsonConverter(typeof(EnumClassConverter<OperateEnum>))]
        public class OperateEnum
        {
            /// <summary>
            /// Enum EQUALS for value: EQUALS
            /// </summary>
            public static readonly OperateEnum EQUALS = new OperateEnum("EQUALS");

            /// <summary>
            /// Enum REGEX for value: REGEX
            /// </summary>
            public static readonly OperateEnum REGEX = new OperateEnum("REGEX");

            /// <summary>
            /// Enum EXIST for value: EXIST
            /// </summary>
            public static readonly OperateEnum EXIST = new OperateEnum("EXIST");

            private static readonly Dictionary<string, OperateEnum> StaticFields =
            new Dictionary<string, OperateEnum>()
            {
                { "EQUALS", EQUALS },
                { "REGEX", REGEX },
                { "EXIST", EXIST },
            };

            private string _value;

            public OperateEnum()
            {

            }

            public OperateEnum(string value)
            {
                _value = value;
            }

            public static OperateEnum FromValue(string value)
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

                if (this.Equals(obj as OperateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperateEnum a, OperateEnum b)
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

            public static bool operator !=(OperateEnum a, OperateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 指定按照Metadata中的key进行匹配
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 指定匹配的方式：EXIST:存在，REGEX:正则，EQUALS:等于
        /// </summary>
        [JsonProperty("operate", NullValueHandling = NullValueHandling.Ignore)]
        public OperateEnum Operate { get; set; }
        /// <summary>
        /// 要匹配的key对应的value，当operate为存在时，此值为空
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  operate: ").Append(Operate).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Match);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Match input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Operate == input.Operate ||
                    (this.Operate != null &&
                    this.Operate.Equals(input.Operate))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value != null &&
                    input.Value != null &&
                    this.Value.SequenceEqual(input.Value)
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Operate != null)
                    hashCode = hashCode * 59 + this.Operate.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
