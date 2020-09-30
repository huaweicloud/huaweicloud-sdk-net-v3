using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 配置云服务器的弹性IP信息
    /// </summary>
    public class Eip 
    {
        /// <summary>
        /// 弹性IP地址类型。类型枚举值：5_bgp：全动态BGP;5_sbgp：静态BGP;5_telcom：中国电信;5_union：中国联通;详情请参见《虚拟私有云接口参考》“申请弹性公网IP”章节的“publicip”字段说明。
        /// </summary>
        /// <value>弹性IP地址类型。类型枚举值：5_bgp：全动态BGP;5_sbgp：静态BGP;5_telcom：中国电信;5_union：中国联通;详情请参见《虚拟私有云接口参考》“申请弹性公网IP”章节的“publicip”字段说明。</value>
        [JsonConverter(typeof(EnumClassConverter<IpTypeEnum>))]
        public class IpTypeEnum
        {
            /// <summary>
            /// Enum _5_BGP for value: 5_bgp
            /// </summary>
            public static readonly IpTypeEnum _5_BGP = new IpTypeEnum("5_bgp");

            /// <summary>
            /// Enum _5_SBGP for value: 5_sbgp
            /// </summary>
            public static readonly IpTypeEnum _5_SBGP = new IpTypeEnum("5_sbgp");

            /// <summary>
            /// Enum _5_TELCOM for value: 5_telcom
            /// </summary>
            public static readonly IpTypeEnum _5_TELCOM = new IpTypeEnum("5_telcom");

            /// <summary>
            /// Enum _5_UNION for value: 5_union
            /// </summary>
            public static readonly IpTypeEnum _5_UNION = new IpTypeEnum("5_union");

            private static readonly Dictionary<string, IpTypeEnum> StaticFields =
            new Dictionary<string, IpTypeEnum>()
            {
                { "5_bgp", _5_BGP },
                { "5_sbgp", _5_SBGP },
                { "5_telcom", _5_TELCOM },
                { "5_union", _5_UNION },
            };

            private string Value;

            private IpTypeEnum(string value)
            {
                this.Value = value;
            }

            public static IpTypeEnum FromValue(string value)
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

                if (this.Equals(obj as IpTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(IpTypeEnum a, IpTypeEnum b)
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

            public static bool operator !=(IpTypeEnum a, IpTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性IP地址类型。类型枚举值：5_bgp：全动态BGP;5_sbgp：静态BGP;5_telcom：中国电信;5_union：中国联通;详情请参见《虚拟私有云接口参考》“申请弹性公网IP”章节的“publicip”字段说明。
        /// </summary>
        [JsonProperty("ip_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpTypeEnum IpType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public Bandwidth Bandwidth { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Eip {\n");
            sb.Append("  ipType: ").Append(IpType).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Eip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Eip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IpType == input.IpType ||
                    (this.IpType != null &&
                    this.IpType.Equals(input.IpType))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
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
                if (this.IpType != null)
                    hashCode = hashCode * 59 + this.IpType.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                return hashCode;
            }
        }
    }
}
