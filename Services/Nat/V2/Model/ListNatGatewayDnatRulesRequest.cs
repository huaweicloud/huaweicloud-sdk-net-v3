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
    /// Request Object
    /// </summary>
    public class ListNatGatewayDnatRulesRequest 
    {
        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly StatusEnum PENDING_CREATE = new StatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum PENDING_UPDATE for value: PENDING_UPDATE
            /// </summary>
            public static readonly StatusEnum PENDING_UPDATE = new StatusEnum("PENDING_UPDATE");

            /// <summary>
            /// Enum PENDING_DELETE for value: PENDING_DELETE
            /// </summary>
            public static readonly StatusEnum PENDING_DELETE = new StatusEnum("PENDING_DELETE");

            /// <summary>
            /// Enum EIP_FREEZED for value: EIP_FREEZED
            /// </summary>
            public static readonly StatusEnum EIP_FREEZED = new StatusEnum("EIP_FREEZED");

            /// <summary>
            /// Enum INACTIVE for value: INACTIVE
            /// </summary>
            public static readonly StatusEnum INACTIVE = new StatusEnum("INACTIVE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "PENDING_CREATE", PENDING_CREATE },
                { "PENDING_UPDATE", PENDING_UPDATE },
                { "PENDING_DELETE", PENDING_DELETE },
                { "EIP_FREEZED", EIP_FREEZED },
                { "INACTIVE", INACTIVE },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("admin_state_up", IsQuery = true)]
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("external_service_port", IsQuery = true)]
        [JsonProperty("external_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalServicePort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("floating_ip_address", IsQuery = true)]
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("floating_ip_id", IsQuery = true)]
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("internal_service_port", IsQuery = true)]
        [JsonProperty("internal_service_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalServicePort { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("description", IsQuery = true)]
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("created_at", IsQuery = true)]
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("nat_gateway_id", IsQuery = true)]
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> NatGatewayId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("port_id", IsQuery = true)]
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("private_ip", IsQuery = true)]
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("protocol", IsQuery = true)]
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Protocol { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListNatGatewayDnatRulesRequest {\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  externalServicePort: ").Append(ExternalServicePort).Append("\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  internalServicePort: ").Append(InternalServicePort).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListNatGatewayDnatRulesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListNatGatewayDnatRulesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.ExternalServicePort == input.ExternalServicePort ||
                    (this.ExternalServicePort != null &&
                    this.ExternalServicePort.Equals(input.ExternalServicePort))
                ) && 
                (
                    this.FloatingIpAddress == input.FloatingIpAddress ||
                    (this.FloatingIpAddress != null &&
                    this.FloatingIpAddress.Equals(input.FloatingIpAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status != null &&
                    input.Status != null &&
                    this.Status.SequenceEqual(input.Status)
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
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.NatGatewayId == input.NatGatewayId ||
                    this.NatGatewayId != null &&
                    input.NatGatewayId != null &&
                    this.NatGatewayId.SequenceEqual(input.NatGatewayId)
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
                    this.Protocol != null &&
                    input.Protocol != null &&
                    this.Protocol.SequenceEqual(input.Protocol)
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
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.ExternalServicePort != null)
                    hashCode = hashCode * 59 + this.ExternalServicePort.GetHashCode();
                if (this.FloatingIpAddress != null)
                    hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.FloatingIpId != null)
                    hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.InternalServicePort != null)
                    hashCode = hashCode * 59 + this.InternalServicePort.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PrivateIp != null)
                    hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
