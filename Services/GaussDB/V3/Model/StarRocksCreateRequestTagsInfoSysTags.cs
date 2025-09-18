using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class StarRocksCreateRequestTagsInfoSysTags 
    {
        /// <summary>
        /// 标签键。
        /// </summary>
        /// <value>标签键。</value>
        [JsonConverter(typeof(EnumClassConverter<KeyEnum>))]
        public class KeyEnum
        {
            /// <summary>
            /// Enum _SYS_ENTERPRISE_PROJECT_ID for value: _sys_enterprise_project_id
            /// </summary>
            public static readonly KeyEnum _SYS_ENTERPRISE_PROJECT_ID = new KeyEnum("_sys_enterprise_project_id");

            private static readonly Dictionary<string, KeyEnum> StaticFields =
            new Dictionary<string, KeyEnum>()
            {
                { "_sys_enterprise_project_id", _SYS_ENTERPRISE_PROJECT_ID },
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
        /// 标签值。
        /// </summary>
        /// <value>标签值。</value>
        [JsonConverter(typeof(EnumClassConverter<ValueEnum>))]
        public class ValueEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly ValueEnum _0 = new ValueEnum("0");

            private static readonly Dictionary<string, ValueEnum> StaticFields =
            new Dictionary<string, ValueEnum>()
            {
                { "0", _0 },
            };

            private string _value;

            public ValueEnum()
            {

            }

            public ValueEnum(string value)
            {
                _value = value;
            }

            public static ValueEnum FromValue(string value)
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

                if (this.Equals(obj as ValueEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ValueEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ValueEnum a, ValueEnum b)
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

            public static bool operator !=(ValueEnum a, ValueEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 标签键。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public KeyEnum Key { get; set; }
        /// <summary>
        /// 标签值。
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public ValueEnum Value { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StarRocksCreateRequestTagsInfoSysTags {\n");
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
            return this.Equals(input as StarRocksCreateRequestTagsInfoSysTags);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StarRocksCreateRequestTagsInfoSysTags input)
        {
            if (input == null) return false;
            if (this.Key != input.Key) return false;
            if (this.Value != input.Value) return false;

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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }
    }
}
