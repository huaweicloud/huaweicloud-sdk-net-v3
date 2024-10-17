using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 规格信息
    /// </summary>
    public class CreateFirewallReqFlavor 
    {
        /// <summary>
        /// 防火墙版本 “charge_mode”为“prePaid”时，仅支持专业版。 “charge_mode”为“postPaid”时，支持标准版、专业版。  Standard - 标准版 Professional - 专业版
        /// </summary>
        /// <value>防火墙版本 “charge_mode”为“prePaid”时，仅支持专业版。 “charge_mode”为“postPaid”时，支持标准版、专业版。  Standard - 标准版 Professional - 专业版</value>
        [JsonConverter(typeof(EnumClassConverter<VersionEnum>))]
        public class VersionEnum
        {
            /// <summary>
            /// Enum STANDARD for value: Standard
            /// </summary>
            public static readonly VersionEnum STANDARD = new VersionEnum("Standard");

            /// <summary>
            /// Enum PROFESSIONAL for value: Professional
            /// </summary>
            public static readonly VersionEnum PROFESSIONAL = new VersionEnum("Professional");

            private static readonly Dictionary<string, VersionEnum> StaticFields =
            new Dictionary<string, VersionEnum>()
            {
                { "Standard", STANDARD },
                { "Professional", PROFESSIONAL },
            };

            private string _value;

            public VersionEnum()
            {

            }

            public VersionEnum(string value)
            {
                _value = value;
            }

            public static VersionEnum FromValue(string value)
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

                if (this.Equals(obj as VersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VersionEnum a, VersionEnum b)
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

            public static bool operator !=(VersionEnum a, VersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防火墙版本 “charge_mode”为“prePaid”时，仅支持专业版。 “charge_mode”为“postPaid”时，支持标准版、专业版。  Standard - 标准版 Professional - 专业版
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public VersionEnum Version { get; set; }
        /// <summary>
        /// 扩展EIP数量，仅包周期场景下生效
        /// </summary>
        [JsonProperty("extend_eip_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendEipCount { get; set; }

        /// <summary>
        /// 扩展带宽，步长为5，仅包周期场景下生效
        /// </summary>
        [JsonProperty("extend_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendBandwidth { get; set; }

        /// <summary>
        /// 扩展VPC数量，仅包周期场景下生效
        /// </summary>
        [JsonProperty("extend_vpc_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExtendVpcCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFirewallReqFlavor {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  extendEipCount: ").Append(ExtendEipCount).Append("\n");
            sb.Append("  extendBandwidth: ").Append(ExtendBandwidth).Append("\n");
            sb.Append("  extendVpcCount: ").Append(ExtendVpcCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFirewallReqFlavor);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFirewallReqFlavor input)
        {
            if (input == null) return false;
            if (this.Version != input.Version) return false;
            if (this.ExtendEipCount != input.ExtendEipCount || (this.ExtendEipCount != null && !this.ExtendEipCount.Equals(input.ExtendEipCount))) return false;
            if (this.ExtendBandwidth != input.ExtendBandwidth || (this.ExtendBandwidth != null && !this.ExtendBandwidth.Equals(input.ExtendBandwidth))) return false;
            if (this.ExtendVpcCount != input.ExtendVpcCount || (this.ExtendVpcCount != null && !this.ExtendVpcCount.Equals(input.ExtendVpcCount))) return false;

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
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ExtendEipCount != null) hashCode = hashCode * 59 + this.ExtendEipCount.GetHashCode();
                if (this.ExtendBandwidth != null) hashCode = hashCode * 59 + this.ExtendBandwidth.GetHashCode();
                if (this.ExtendVpcCount != null) hashCode = hashCode * 59 + this.ExtendVpcCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
