using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MatchOption 
    {
        /// <summary>
        /// 取值为“instance_name”或“instance_id”，分别表示按实例名称或按实例ID匹配查询。
        /// </summary>
        /// <value>取值为“instance_name”或“instance_id”，分别表示按实例名称或按实例ID匹配查询。</value>
        [JsonConverter(typeof(EnumClassConverter<KeyEnum>))]
        public class KeyEnum
        {
            /// <summary>
            /// Enum INSTANCE_NAME for value: instance_name
            /// </summary>
            public static readonly KeyEnum INSTANCE_NAME = new KeyEnum("instance_name");

            /// <summary>
            /// Enum INSTANCE_ID for value: instance_id
            /// </summary>
            public static readonly KeyEnum INSTANCE_ID = new KeyEnum("instance_id");

            private static readonly Dictionary<string, KeyEnum> StaticFields =
            new Dictionary<string, KeyEnum>()
            {
                { "instance_name", INSTANCE_NAME },
                { "instance_id", INSTANCE_ID },
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

            public static bool operator !=(KeyEnum a, KeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 取值为“instance_name”或“instance_id”，分别表示按实例名称或按实例ID匹配查询。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public KeyEnum Key { get; set; }
        /// <summary>
        /// 待匹配的实例名称或实例ID。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MatchOption {\n");
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
            return this.Equals(input as MatchOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MatchOption input)
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
