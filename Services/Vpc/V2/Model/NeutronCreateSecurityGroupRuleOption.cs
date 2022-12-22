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
    /// 
    /// </summary>
    public class NeutronCreateSecurityGroupRuleOption 
    {
        /// <summary>
        /// 功能说明：安全组规则方向 取值范围：ingress(入方向)或egress(出方向)
        /// </summary>
        /// <value>功能说明：安全组规则方向 取值范围：ingress(入方向)或egress(出方向)</value>
        [JsonConverter(typeof(EnumClassConverter<DirectionEnum>))]
        public class DirectionEnum
        {
            /// <summary>
            /// Enum INGRESS for value: ingress
            /// </summary>
            public static readonly DirectionEnum INGRESS = new DirectionEnum("ingress");

            /// <summary>
            /// Enum EGRESS for value: egress
            /// </summary>
            public static readonly DirectionEnum EGRESS = new DirectionEnum("egress");

            private static readonly Dictionary<string, DirectionEnum> StaticFields =
            new Dictionary<string, DirectionEnum>()
            {
                { "ingress", INGRESS },
                { "egress", EGRESS },
            };

            private string _value;

            public DirectionEnum()
            {

            }

            public DirectionEnum(string value)
            {
                _value = value;
            }

            public static DirectionEnum FromValue(string value)
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

                if (this.Equals(obj as DirectionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DirectionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DirectionEnum a, DirectionEnum b)
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

            public static bool operator !=(DirectionEnum a, DirectionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：安全组规则网络类型 取值范围：IPv4或IPv6
        /// </summary>
        /// <value>功能说明：安全组规则网络类型 取值范围：IPv4或IPv6</value>
        [JsonConverter(typeof(EnumClassConverter<EthertypeEnum>))]
        public class EthertypeEnum
        {
            /// <summary>
            /// Enum IPV4 for value: IPv4
            /// </summary>
            public static readonly EthertypeEnum IPV4 = new EthertypeEnum("IPv4");

            /// <summary>
            /// Enum IPV6 for value: IPv6
            /// </summary>
            public static readonly EthertypeEnum IPV6 = new EthertypeEnum("IPv6");

            private static readonly Dictionary<string, EthertypeEnum> StaticFields =
            new Dictionary<string, EthertypeEnum>()
            {
                { "IPv4", IPV4 },
                { "IPv6", IPV6 },
            };

            private string _value;

            public EthertypeEnum()
            {

            }

            public EthertypeEnum(string value)
            {
                _value = value;
            }

            public static EthertypeEnum FromValue(string value)
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

                if (this.Equals(obj as EthertypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EthertypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EthertypeEnum a, EthertypeEnum b)
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

            public static bool operator !=(EthertypeEnum a, EthertypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：安全组规则描述 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：安全组规则方向 取值范围：ingress(入方向)或egress(出方向)
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public DirectionEnum Direction { get; set; }
        /// <summary>
        /// 功能说明：安全组规则网络类型 取值范围：IPv4或IPv6
        /// </summary>
        [JsonProperty("ethertype", NullValueHandling = NullValueHandling.Ignore)]
        public EthertypeEnum Ethertype { get; set; }
        /// <summary>
        /// 最大端口，当协议类型为ICMP时，该值表示ICMP的code
        /// </summary>
        [JsonProperty("port_range_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMax { get; set; }

        /// <summary>
        /// 功能说明：最小端口，当协议类型为ICMP时，该值表示ICMP的type 约束：protocol为tcp和udp时，port_range_max和port_range_min必须同时输入，且port_range_max应大于等于port_range_min。protocol为icmp时，指定ICMP code（port_range_max）时，必须同时指定ICMP type（port_range_min）。
        /// </summary>
        [JsonProperty("port_range_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? PortRangeMin { get; set; }

        /// <summary>
        /// 功能说明：tcp/udp/icmp/icmpv6或IP协议编号（0~255） 约束：协议为icmpv6时，网络类型应该为IPv6；协议为icmp时，网络类型应该为IPv4
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// 功能说明：目的安全组的ID
        /// </summary>
        [JsonProperty("remote_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteGroupId { get; set; }

        /// <summary>
        /// 功能说明：目的端ip网段 取值范围：cidr格式，如10.10.0.0/16
        /// </summary>
        [JsonProperty("remote_ip_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string RemoteIpPrefix { get; set; }

        /// <summary>
        /// 所属安全组ID
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NeutronCreateSecurityGroupRuleOption {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  ethertype: ").Append(Ethertype).Append("\n");
            sb.Append("  portRangeMax: ").Append(PortRangeMax).Append("\n");
            sb.Append("  portRangeMin: ").Append(PortRangeMin).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  remoteGroupId: ").Append(RemoteGroupId).Append("\n");
            sb.Append("  remoteIpPrefix: ").Append(RemoteIpPrefix).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NeutronCreateSecurityGroupRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronCreateSecurityGroupRuleOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.Ethertype == input.Ethertype ||
                    (this.Ethertype != null &&
                    this.Ethertype.Equals(input.Ethertype))
                ) && 
                (
                    this.PortRangeMax == input.PortRangeMax ||
                    (this.PortRangeMax != null &&
                    this.PortRangeMax.Equals(input.PortRangeMax))
                ) && 
                (
                    this.PortRangeMin == input.PortRangeMin ||
                    (this.PortRangeMin != null &&
                    this.PortRangeMin.Equals(input.PortRangeMin))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.RemoteGroupId == input.RemoteGroupId ||
                    (this.RemoteGroupId != null &&
                    this.RemoteGroupId.Equals(input.RemoteGroupId))
                ) && 
                (
                    this.RemoteIpPrefix == input.RemoteIpPrefix ||
                    (this.RemoteIpPrefix != null &&
                    this.RemoteIpPrefix.Equals(input.RemoteIpPrefix))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Ethertype != null)
                    hashCode = hashCode * 59 + this.Ethertype.GetHashCode();
                if (this.PortRangeMax != null)
                    hashCode = hashCode * 59 + this.PortRangeMax.GetHashCode();
                if (this.PortRangeMin != null)
                    hashCode = hashCode * 59 + this.PortRangeMin.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.RemoteGroupId != null)
                    hashCode = hashCode * 59 + this.RemoteGroupId.GetHashCode();
                if (this.RemoteIpPrefix != null)
                    hashCode = hashCode * 59 + this.RemoteIpPrefix.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                return hashCode;
            }
        }
    }
}
