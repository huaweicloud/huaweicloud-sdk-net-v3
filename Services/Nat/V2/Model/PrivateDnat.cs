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
    /// DNAT规则的响应体。
    /// </summary>
    public class PrivateDnat 
    {
        /// <summary>
        /// 协议类型。 目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。
        /// </summary>
        /// <value>协议类型。 目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。</value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum TCP for value: tcp
            /// </summary>
            public static readonly ProtocolEnum TCP = new ProtocolEnum("tcp");

            /// <summary>
            /// Enum UDP for value: udp
            /// </summary>
            public static readonly ProtocolEnum UDP = new ProtocolEnum("udp");

            /// <summary>
            /// Enum ANY for value: any
            /// </summary>
            public static readonly ProtocolEnum ANY = new ProtocolEnum("any");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "tcp", TCP },
                { "udp", UDP },
                { "any", ANY },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// DNAT规则的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目的ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// DNAT规则的描述。长度范围小于等于255个字符，不能包含&lt;&gt;
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 中转IP的ID。
        /// </summary>
        [JsonProperty("transit_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitIpId { get; set; }

        /// <summary>
        /// 私网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayId { get; set; }

        /// <summary>
        /// 网络接口ID，支持计算、ELB、VIP等实例的端口。
        /// </summary>
        [JsonProperty("network_interface_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// DNAT规则后端的类型。 取值：     COMPUTE：后端为计算实例。     VIP：后端为VIP的实例。     ELB：后端为ELB的实例。     ELBv3：后端为ELBv3的实例。     CUSTOMIZE：后端为自定义IP。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 协议类型。 目前支持TCP/tcp、UDP/udp、ANY/any。 对应协议号6、17、0。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 后端实例的私网IP地址。
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// 后端实例的端口号。
        /// </summary>
        [JsonProperty("internal_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public string InternalServicePort { get; set; }

        /// <summary>
        /// 中转IP的端口号。
        /// </summary>
        [JsonProperty("transit_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public string TransitServicePort { get; set; }

        /// <summary>
        /// 企业项目ID。创建DNAT规则时，关联的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// DNAT规则的创建时间，遵循UTC时间，格式是yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// DNAT规则的更新时间，遵循UTC时间，格式是yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrivateDnat {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  transitIpId: ").Append(TransitIpId).Append("\n");
            sb.Append("  gatewayId: ").Append(GatewayId).Append("\n");
            sb.Append("  networkInterfaceId: ").Append(NetworkInterfaceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  internalServicePort: ").Append(InternalServicePort).Append("\n");
            sb.Append("  transitServicePort: ").Append(TransitServicePort).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PrivateDnat);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PrivateDnat input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.TransitIpId == input.TransitIpId ||
                    (this.TransitIpId != null &&
                    this.TransitIpId.Equals(input.TransitIpId))
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
                ) && 
                (
                    this.NetworkInterfaceId == input.NetworkInterfaceId ||
                    (this.NetworkInterfaceId != null &&
                    this.NetworkInterfaceId.Equals(input.NetworkInterfaceId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    (this.PrivateIpAddress != null &&
                    this.PrivateIpAddress.Equals(input.PrivateIpAddress))
                ) && 
                (
                    this.InternalServicePort == input.InternalServicePort ||
                    (this.InternalServicePort != null &&
                    this.InternalServicePort.Equals(input.InternalServicePort))
                ) && 
                (
                    this.TransitServicePort == input.TransitServicePort ||
                    (this.TransitServicePort != null &&
                    this.TransitServicePort.Equals(input.TransitServicePort))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.TransitIpId != null)
                    hashCode = hashCode * 59 + this.TransitIpId.GetHashCode();
                if (this.GatewayId != null)
                    hashCode = hashCode * 59 + this.GatewayId.GetHashCode();
                if (this.NetworkInterfaceId != null)
                    hashCode = hashCode * 59 + this.NetworkInterfaceId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.InternalServicePort != null)
                    hashCode = hashCode * 59 + this.InternalServicePort.GetHashCode();
                if (this.TransitServicePort != null)
                    hashCode = hashCode * 59 + this.TransitServicePort.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
