using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Config.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Match 
    {
        /// <summary>
        /// 键。第一期限定为resource_name,后续扩展。
        /// </summary>
        /// <value>键。第一期限定为resource_name,后续扩展。</value>
        [JsonConverter(typeof(EnumClassConverter<KeyEnum>))]
        public class KeyEnum
        {
            /// <summary>
            /// Enum RESOURCE_NAME for value: resource_name
            /// </summary>
            public static readonly KeyEnum RESOURCE_NAME = new KeyEnum("resource_name");

            private static readonly Dictionary<string, KeyEnum> StaticFields =
            new Dictionary<string, KeyEnum>()
            {
                { "resource_name", RESOURCE_NAME },
            };

            private string _value;

            public KeyEnum()
            {

            }

            public KeyEnum(string value)
            {
                _value = value;
            }

            public static KeyEnum FromValue(string value)
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

                if (this.Equals(obj as KeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(KeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(KeyEnum a, KeyEnum b)
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

            public static bool operator !=(KeyEnum a, KeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 键。第一期限定为resource_name,后续扩展。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public KeyEnum Key { get; set; }
        /// <summary>
        /// 值。每个值最大长度255个unicode字符 。不校验字符集范。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  key: ").Append(Key).Append("\n");
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
            if (input == null) return false;
            if (this.Key != input.Key) return false;
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
                hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
