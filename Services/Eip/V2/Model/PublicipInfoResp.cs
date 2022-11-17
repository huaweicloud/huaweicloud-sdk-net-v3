using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// PublicipInfo对象
    /// </summary>
    public class PublicipInfoResp 
    {
        /// <summary>
        /// IP版本信息  取值范围：  4：IPv4  6：IPv6
        /// </summary>
        /// <value>IP版本信息  取值范围：  4：IPv4  6：IPv6</value>
        [JsonConverter(typeof(EnumClassConverter<IpVersionEnum>))]
        public class IpVersionEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly IpVersionEnum NUMBER_4 = new IpVersionEnum(4);

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            public static readonly IpVersionEnum NUMBER_6 = new IpVersionEnum(6);

            private static readonly Dictionary<int?, IpVersionEnum> StaticFields =
            new Dictionary<int?, IpVersionEnum>()
            {
                { 4, NUMBER_4 },
                { 6, NUMBER_6 },
            };

            private int? Value;

            public IpVersionEnum(int? value)
            {
                Value = value;
            }

            public static IpVersionEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
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

                if (this.Equals(obj as IpVersionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpVersionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(IpVersionEnum a, IpVersionEnum b)
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

            public static bool operator !=(IpVersionEnum a, IpVersionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：弹性公网IP或者IPv6端口的地址
        /// </summary>
        [JsonProperty("publicip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipAddress { get; set; }

        /// <summary>
        /// 功能说明：带宽对应的弹性公网IP或者IPv6端口的唯一标识
        /// </summary>
        [JsonProperty("publicip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipId { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP或者IPv6端口的类型  取值范围：5_telcom（电信），5_union（联通），5_bgp（全动态BGP），5_sbgp（静态BGP），5_ipv6  东北-大连：5_telcom、5_union  华南-广州：5_bgp、5_sbgp  华东-上海二：5_bgp、5_sbgp  华北-北京一：5_bgp、5_sbgp、5_ipv6  亚太-香港：5_bgp  亚太-曼谷：5_bgp  亚太-新加坡：5_bgp  非洲-约翰内斯堡：5_bgp  西南-贵阳一：5_bgp、5_sbgp  华北-北京四：5_bgp、5_sbgp  约束：必须是系统具体支持的类型
        /// </summary>
        [JsonProperty("publicip_type", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipType { get; set; }

        /// <summary>
        /// 功能说明：IPv4时无此字段，IPv6时为申请到的弹性公网IP地址
        /// </summary>
        [JsonProperty("publicipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Publicipv6Address { get; set; }

        /// <summary>
        /// IP版本信息  取值范围：  4：IPv4  6：IPv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public IpVersionEnum IpVersion { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipInfoResp {\n");
            sb.Append("  publicipAddress: ").Append(PublicipAddress).Append("\n");
            sb.Append("  publicipId: ").Append(PublicipId).Append("\n");
            sb.Append("  publicipType: ").Append(PublicipType).Append("\n");
            sb.Append("  publicipv6Address: ").Append(Publicipv6Address).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipInfoResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipInfoResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublicipAddress == input.PublicipAddress ||
                    (this.PublicipAddress != null &&
                    this.PublicipAddress.Equals(input.PublicipAddress))
                ) && 
                (
                    this.PublicipId == input.PublicipId ||
                    (this.PublicipId != null &&
                    this.PublicipId.Equals(input.PublicipId))
                ) && 
                (
                    this.PublicipType == input.PublicipType ||
                    (this.PublicipType != null &&
                    this.PublicipType.Equals(input.PublicipType))
                ) && 
                (
                    this.Publicipv6Address == input.Publicipv6Address ||
                    (this.Publicipv6Address != null &&
                    this.Publicipv6Address.Equals(input.Publicipv6Address))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
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
                if (this.PublicipAddress != null)
                    hashCode = hashCode * 59 + this.PublicipAddress.GetHashCode();
                if (this.PublicipId != null)
                    hashCode = hashCode * 59 + this.PublicipId.GetHashCode();
                if (this.PublicipType != null)
                    hashCode = hashCode * 59 + this.PublicipType.GetHashCode();
                if (this.Publicipv6Address != null)
                    hashCode = hashCode * 59 + this.Publicipv6Address.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
