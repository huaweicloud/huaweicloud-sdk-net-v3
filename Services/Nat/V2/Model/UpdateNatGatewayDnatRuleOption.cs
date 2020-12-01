using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Nat.V2.Model
{
    /// <summary>
    /// 更新DNAT规则的请求体。
    /// </summary>
    public class UpdateNatGatewayDnatRuleOption 
    {
        /// <summary>
        /// 协议类型，目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。
        /// </summary>
        /// <value>协议类型，目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum TCP for value: TCP
            /// </summary>
            public static readonly ProtocolEnum TCP = new ProtocolEnum("TCP");

            /// <summary>
            /// Enum UDP for value: UDP
            /// </summary>
            public static readonly ProtocolEnum UDP = new ProtocolEnum("UDP");

            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            public static readonly ProtocolEnum ANY = new ProtocolEnum("ANY");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "TCP", TCP },
                { "UDP", UDP },
                { "ANY", ANY },
            };

            private string Value;

            public ProtocolEnum(string value)
            {
                Value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// NAT网关的id。
        /// </summary>
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// DNAT规则的描述，长度限制为255。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 虚拟机或者裸机的Port ID，与private_ip参数二选一。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 用户私有IP地址，例如专线连接的私有云地址，与port_id参数二选一。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 协议类型，目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 弹性公网IP的id。
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// 虚拟机或者裸机对外提供服务的协议端口号。 取值范围：0~65535。
        /// </summary>
        [JsonProperty("internal_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalServicePort { get; set; }

        /// <summary>
        /// Floatingip对外提供服务的端口号。 取值范围：0~65535。
        /// </summary>
        [JsonProperty("external_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalServicePort { get; set; }

        /// <summary>
        /// 虚拟机或者裸机对外提供服务的协议端口号范围。 功能说明：该端口范围与external _service_port_range按顺序实现1:1映射。 取值范围：1~65535。 约束：只能以’-’字符连接端口范围。
        /// </summary>
        [JsonProperty("internal_service_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalServicePortRange { get; set; }

        /// <summary>
        /// Floatingip对外提供服务的端口号范围。 功能说明：该端口范围与internal _service_port_range按顺序实现1:1映射。 取值范围：1~65535。 约束：只能以’-’字符连接端口范围。
        /// </summary>
        [JsonProperty("external_service_port_range", NullValueHandling = NullValueHandling.Ignore)]
        public string ExternalServicePortRange { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNatGatewayDnatRuleOption {\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  internalServicePort: ").Append(InternalServicePort).Append("\n");
            sb.Append("  externalServicePort: ").Append(ExternalServicePort).Append("\n");
            sb.Append("  internalServicePortRange: ").Append(InternalServicePortRange).Append("\n");
            sb.Append("  externalServicePortRange: ").Append(ExternalServicePortRange).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNatGatewayDnatRuleOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNatGatewayDnatRuleOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NatGatewayId == input.NatGatewayId ||
                    (this.NatGatewayId != null &&
                    this.NatGatewayId.Equals(input.NatGatewayId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.PrivateIp == input.PrivateIp ||
                    (this.PrivateIp != null &&
                    this.PrivateIp.Equals(input.PrivateIp))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.FloatingIpId == input.FloatingIpId ||
                    (this.FloatingIpId != null &&
                    this.FloatingIpId.Equals(input.FloatingIpId))
                ) && 
                (
                    this.InternalServicePort == input.InternalServicePort ||
                    (this.InternalServicePort != null &&
                    this.InternalServicePort.Equals(input.InternalServicePort))
                ) && 
                (
                    this.ExternalServicePort == input.ExternalServicePort ||
                    (this.ExternalServicePort != null &&
                    this.ExternalServicePort.Equals(input.ExternalServicePort))
                ) && 
                (
                    this.InternalServicePortRange == input.InternalServicePortRange ||
                    (this.InternalServicePortRange != null &&
                    this.InternalServicePortRange.Equals(input.InternalServicePortRange))
                ) && 
                (
                    this.ExternalServicePortRange == input.ExternalServicePortRange ||
                    (this.ExternalServicePortRange != null &&
                    this.ExternalServicePortRange.Equals(input.ExternalServicePortRange))
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
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.FloatingIpId != null)
                    hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.InternalServicePort != null)
                    hashCode = hashCode * 59 + this.InternalServicePort.GetHashCode();
                if (this.ExternalServicePort != null)
                    hashCode = hashCode * 59 + this.ExternalServicePort.GetHashCode();
                if (this.InternalServicePortRange != null)
                    hashCode = hashCode * 59 + this.InternalServicePortRange.GetHashCode();
                if (this.ExternalServicePortRange != null)
                    hashCode = hashCode * 59 + this.ExternalServicePortRange.GetHashCode();
                return hashCode;
            }
        }
    }
}
