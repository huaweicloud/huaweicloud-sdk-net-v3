using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V2.Model
{
    /// <summary>
    /// 子网配置的NTP地址或租约时间对象
    /// </summary>
    public class ExtraDhcpOption 
    {
        /// <summary>
        /// 功能说明：子网配置的NTP地址名称或子网配置的租约到期名称。 约束：目前只支持字段“ntp”或“addresstime”
        /// </summary>
        /// <value>功能说明：子网配置的NTP地址名称或子网配置的租约到期名称。 约束：目前只支持字段“ntp”或“addresstime”</value>
        [JsonConverter(typeof(EnumClassConverter<OptNameEnum>))]
        public class OptNameEnum
        {
            /// <summary>
            /// Enum NTP for value: ntp
            /// </summary>
            public static readonly OptNameEnum NTP = new OptNameEnum("ntp");

            /// <summary>
            /// Enum ADDRESSTIME for value: addresstime
            /// </summary>
            public static readonly OptNameEnum ADDRESSTIME = new OptNameEnum("addresstime");

            private static readonly Dictionary<string, OptNameEnum> StaticFields =
            new Dictionary<string, OptNameEnum>()
            {
                { "ntp", NTP },
                { "addresstime", ADDRESSTIME },
            };

            private string _value;

            public OptNameEnum()
            {

            }

            public OptNameEnum(string value)
            {
                _value = value;
            }

            public static OptNameEnum FromValue(string value)
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

                if (this.Equals(obj as OptNameEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OptNameEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OptNameEnum a, OptNameEnum b)
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

            public static bool operator !=(OptNameEnum a, OptNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：子网配置的NTP地址名称或子网配置的租约到期名称。 约束：目前只支持字段“ntp”或“addresstime”
        /// </summary>
        [JsonProperty("opt_name", NullValueHandling = NullValueHandling.Ignore)]
        public OptNameEnum OptName { get; set; }
        /// <summary>
        /// 功能说明：子网配置的NTP地址或子网配置的租约到期时间。 约束：opt_name配置为“ntp”，则表示是子网ntp地址，目前只支持IPv4地址，每个IP地址以逗号隔开，IP地址个数不能超过4个，不能存在相同地址。 该字段为null表示取消该子网NTP的设置，不能为””(空字符串)。 opt_name配置为“addresstime”，则该值表示是子网租约到期时间，取值格式有两种，取-1，表示无限租约；数字+h，数字范围是1~30000，比如5h。
        /// </summary>
        [JsonProperty("opt_value", NullValueHandling = NullValueHandling.Ignore)]
        public string OptValue { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExtraDhcpOption {\n");
            sb.Append("  optName: ").Append(OptName).Append("\n");
            sb.Append("  optValue: ").Append(OptValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExtraDhcpOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExtraDhcpOption input)
        {
            if (input == null) return false;
            if (this.OptName != input.OptName) return false;
            if (this.OptValue != input.OptValue || (this.OptValue != null && !this.OptValue.Equals(input.OptValue))) return false;

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
                hashCode = hashCode * 59 + this.OptName.GetHashCode();
                if (this.OptValue != null) hashCode = hashCode * 59 + this.OptValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
