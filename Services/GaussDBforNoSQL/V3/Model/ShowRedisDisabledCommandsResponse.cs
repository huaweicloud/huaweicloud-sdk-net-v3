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
    /// Response Object
    /// </summary>
    public class ShowRedisDisabledCommandsResponse : SdkResponse
    {
        /// <summary>
        /// 禁用类型。
        /// </summary>
        /// <value>禁用类型。</value>
        [JsonConverter(typeof(EnumClassConverter<DisabledTypeEnum>))]
        public class DisabledTypeEnum
        {
            /// <summary>
            /// Enum COMMAND for value: command
            /// </summary>
            public static readonly DisabledTypeEnum COMMAND = new DisabledTypeEnum("command");

            /// <summary>
            /// Enum KEY for value: key
            /// </summary>
            public static readonly DisabledTypeEnum KEY = new DisabledTypeEnum("key");

            private static readonly Dictionary<string, DisabledTypeEnum> StaticFields =
            new Dictionary<string, DisabledTypeEnum>()
            {
                { "command", COMMAND },
                { "key", KEY },
            };

            private string _value;

            public DisabledTypeEnum()
            {

            }

            public DisabledTypeEnum(string value)
            {
                _value = value;
            }

            public static DisabledTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DisabledTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisabledTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisabledTypeEnum a, DisabledTypeEnum b)
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

            public static bool operator !=(DisabledTypeEnum a, DisabledTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 总数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public string TotalCount { get; set; }

        /// <summary>
        /// 禁用类型。
        /// </summary>
        [JsonProperty("disabled_type", NullValueHandling = NullValueHandling.Ignore)]
        public DisabledTypeEnum DisabledType { get; set; }
        /// <summary>
        /// disabled_type为command时展示该参数。
        /// </summary>
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Commands { get; set; }

        /// <summary>
        /// disabled_type为key时展示该参数，最多20个。
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<RedisDisabledCommandsDetail> Keys { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowRedisDisabledCommandsResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  disabledType: ").Append(DisabledType).Append("\n");
            sb.Append("  commands: ").Append(Commands).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowRedisDisabledCommandsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowRedisDisabledCommandsResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.DisabledType != input.DisabledType) return false;
            if (this.Commands != input.Commands || (this.Commands != null && input.Commands != null && !this.Commands.SequenceEqual(input.Commands))) return false;
            if (this.Keys != input.Keys || (this.Keys != null && input.Keys != null && !this.Keys.SequenceEqual(input.Keys))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                hashCode = hashCode * 59 + this.DisabledType.GetHashCode();
                if (this.Commands != null) hashCode = hashCode * 59 + this.Commands.GetHashCode();
                if (this.Keys != null) hashCode = hashCode * 59 + this.Keys.GetHashCode();
                return hashCode;
            }
        }
    }
}
