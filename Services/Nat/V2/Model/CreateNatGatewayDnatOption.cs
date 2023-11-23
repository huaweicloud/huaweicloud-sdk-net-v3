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
    /// 创建DNAT规则的请求体。
    /// </summary>
    public class CreateNatGatewayDnatOption 
    {

        /// <summary>
        /// DNAT规则的描述，长度范围小于等于255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 虚拟机或者裸机的Port ID，对应虚拟私有云场景，与private_ip参数二选一。
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 用户私有IP地址，对应专线、云连接场景，与port_id参数二选一。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 公网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// 虚拟机或者裸机对外提供服务的协议端口号。 取值范围：0~65535。
        /// </summary>
        [JsonProperty("internal_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalServicePort { get; set; }

        /// <summary>
        /// 弹性公网IP的id。
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// Floatingip对外提供服务的端口号。 取值范围：0~65535。
        /// </summary>
        [JsonProperty("external_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalServicePort { get; set; }

        /// <summary>
        /// 协议类型，目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

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
        /// 全域弹性公网IP的id。
        /// </summary>
        [JsonProperty("global_eip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GlobalEipId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNatGatewayDnatOption {\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  internalServicePort: ").Append(InternalServicePort).Append("\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  externalServicePort: ").Append(ExternalServicePort).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  internalServicePortRange: ").Append(InternalServicePortRange).Append("\n");
            sb.Append("  externalServicePortRange: ").Append(ExternalServicePortRange).Append("\n");
            sb.Append("  globalEipId: ").Append(GlobalEipId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNatGatewayDnatOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNatGatewayDnatOption input)
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
                    this.NatGatewayId == input.NatGatewayId ||
                    (this.NatGatewayId != null &&
                    this.NatGatewayId.Equals(input.NatGatewayId))
                ) && 
                (
                    this.InternalServicePort == input.InternalServicePort ||
                    (this.InternalServicePort != null &&
                    this.InternalServicePort.Equals(input.InternalServicePort))
                ) && 
                (
                    this.FloatingIpId == input.FloatingIpId ||
                    (this.FloatingIpId != null &&
                    this.FloatingIpId.Equals(input.FloatingIpId))
                ) && 
                (
                    this.ExternalServicePort == input.ExternalServicePort ||
                    (this.ExternalServicePort != null &&
                    this.ExternalServicePort.Equals(input.ExternalServicePort))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
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
                ) && 
                (
                    this.GlobalEipId == input.GlobalEipId ||
                    (this.GlobalEipId != null &&
                    this.GlobalEipId.Equals(input.GlobalEipId))
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
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.InternalServicePort != null)
                    hashCode = hashCode * 59 + this.InternalServicePort.GetHashCode();
                if (this.FloatingIpId != null)
                    hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.ExternalServicePort != null)
                    hashCode = hashCode * 59 + this.ExternalServicePort.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.InternalServicePortRange != null)
                    hashCode = hashCode * 59 + this.InternalServicePortRange.GetHashCode();
                if (this.ExternalServicePortRange != null)
                    hashCode = hashCode * 59 + this.ExternalServicePortRange.GetHashCode();
                if (this.GlobalEipId != null)
                    hashCode = hashCode * 59 + this.GlobalEipId.GetHashCode();
                return hashCode;
            }
        }
    }
}
