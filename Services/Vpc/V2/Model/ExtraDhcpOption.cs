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
    /// 子网配置的NTP地址对象
    /// </summary>
    public class ExtraDhcpOption 
    {
        /// <summary>
        /// 功能说明：子网配置的NTP地址名称 约束：目前只支持字段“ntp”
        /// </summary>
        /// <value>功能说明：子网配置的NTP地址名称 约束：目前只支持字段“ntp”</value>
        [JsonConverter(typeof(EnumClassConverter<OptNameEnum>))]
        public class OptNameEnum
        {
            /// <summary>
            /// Enum NTP for value: ntp
            /// </summary>
            public static readonly OptNameEnum NTP = new OptNameEnum("ntp");

            public static readonly Dictionary<string, OptNameEnum> StaticFields =
            new Dictionary<string, OptNameEnum>()
            {
                {"ntp", NTP},
            };

            private string Value;

            public OptNameEnum(string Value)
            {
                this.Value = Value;
            }

            public static OptNameEnum FromValue(string Value)
            {
                if(Value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(Value))
                {
                    return StaticFields[Value];
                }

                return null;
            }

            public override string ToString()
            {
                return this.Value;
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(OptNameEnum a, OptNameEnum b)
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

            public static bool operator !=(OptNameEnum a, OptNameEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：子网配置的NTP地址名称 约束：目前只支持字段“ntp”
        /// </summary>
        [JsonProperty("opt_name", NullValueHandling = NullValueHandling.Ignore)]
        public OptNameEnum OptName { get; set; }
        /// <summary>
        /// 功能说明：子网配置的NTP地址 约束：目前只支持IPv4地址，每个IP地址以逗号隔开，IP地址个数不能超过4个，不能存在相同地址。该字段为null表示取消该子网NTP的设置，不能为””(空字符串)。
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
            if (input == null)
                return false;

            return 
                (
                    this.OptName == input.OptName ||
                    (this.OptName != null &&
                    this.OptName.Equals(input.OptName))
                ) && 
                (
                    this.OptValue == input.OptValue ||
                    (this.OptValue != null &&
                    this.OptValue.Equals(input.OptValue))
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
                if (this.OptName != null)
                    hashCode = hashCode * 59 + this.OptName.GetHashCode();
                if (this.OptValue != null)
                    hashCode = hashCode * 59 + this.OptValue.GetHashCode();
                return hashCode;
            }
        }
    }
}
