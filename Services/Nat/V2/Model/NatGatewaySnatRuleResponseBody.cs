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
    /// SNAT规则的响应体。
    /// </summary>
    public class NatGatewaySnatRuleResponseBody 
    {
        /// <summary>
        /// 功能说明：SNAT规则的状态。
        /// </summary>
        /// <value>功能说明：SNAT规则的状态。</value>
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
        /// SNAT规则的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 项目的ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 公网NAT网关实例的ID。
        /// </summary>
        [JsonProperty("nat_gateway_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NatGatewayId { get; set; }

        /// <summary>
        /// cidr，可以是网段或者主机格式，与network_id参数二选一。 Source_type&#x3D;0时，cidr必须是vpc 子网网段的子集(不能相等）; Source_type&#x3D;1时，cidr必须指定专线侧网段。
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 0：VPC侧，可以指定network_id 或者cidr 1：专线侧，只能指定cidr 不输入默认为0（VPC）
        /// </summary>
        [JsonProperty("source_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SourceType { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP的id，多个弹性公网IP使用逗号分隔。 取值范围：最大长度4096字节。
        /// </summary>
        [JsonProperty("floating_ip_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpId { get; set; }

        /// <summary>
        /// SNAT规则的描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：SNAT规则的状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// SNAT规则的创建时间，遵循UTC时间，格式是yyyy-mm-ddThh:mm:ssZ。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 规则使用的网络id。与cidr参数二选一。
        /// </summary>
        [JsonProperty("network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NetworkId { get; set; }

        /// <summary>
        /// 解冻/冻结状态。 取值范围： - \&quot;true\&quot;：解冻 - \&quot;false\&quot;：冻结
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP，多个弹性公网IP使用逗号分隔。 取值范围：最大长度1024字节。
        /// </summary>
        [JsonProperty("floating_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatingIpAddress { get; set; }

        /// <summary>
        /// 功能说明：冻结的弹性公网IP，多个冻结的弹性公网IP使用逗号分隔。 取值范围：最大长度1024字节。
        /// </summary>
        [JsonProperty("freezed_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezedIpAddress { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NatGatewaySnatRuleResponseBody {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  natGatewayId: ").Append(NatGatewayId).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  sourceType: ").Append(SourceType).Append("\n");
            sb.Append("  floatingIpId: ").Append(FloatingIpId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  networkId: ").Append(NetworkId).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  floatingIpAddress: ").Append(FloatingIpAddress).Append("\n");
            sb.Append("  freezedIpAddress: ").Append(FreezedIpAddress).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NatGatewaySnatRuleResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NatGatewaySnatRuleResponseBody input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.NatGatewayId == input.NatGatewayId ||
                    (this.NatGatewayId != null &&
                    this.NatGatewayId.Equals(input.NatGatewayId))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    (this.SourceType != null &&
                    this.SourceType.Equals(input.SourceType))
                ) && 
                (
                    this.FloatingIpId == input.FloatingIpId ||
                    (this.FloatingIpId != null &&
                    this.FloatingIpId.Equals(input.FloatingIpId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.NetworkId == input.NetworkId ||
                    (this.NetworkId != null &&
                    this.NetworkId.Equals(input.NetworkId))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
                ) && 
                (
                    this.FloatingIpAddress == input.FloatingIpAddress ||
                    (this.FloatingIpAddress != null &&
                    this.FloatingIpAddress.Equals(input.FloatingIpAddress))
                ) && 
                (
                    this.FreezedIpAddress == input.FreezedIpAddress ||
                    (this.FreezedIpAddress != null &&
                    this.FreezedIpAddress.Equals(input.FreezedIpAddress))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.NatGatewayId != null)
                    hashCode = hashCode * 59 + this.NatGatewayId.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.SourceType != null)
                    hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.FloatingIpId != null)
                    hashCode = hashCode * 59 + this.FloatingIpId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.NetworkId != null)
                    hashCode = hashCode * 59 + this.NetworkId.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.FloatingIpAddress != null)
                    hashCode = hashCode * 59 + this.FloatingIpAddress.GetHashCode();
                if (this.FreezedIpAddress != null)
                    hashCode = hashCode * 59 + this.FreezedIpAddress.GetHashCode();
                return hashCode;
            }
        }
    }
}
