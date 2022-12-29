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
    public class Subnet 
    {
        /// <summary>
        /// 功能说明：子网的状态 取值范围： - ACTIVE：表示子网已挂载到ROUTER上 - UNKNOWN：表示子网还未挂载到ROUTER上 - ERROR：表示子网状态故障
        /// </summary>
        /// <value>功能说明：子网的状态 取值范围： - ACTIVE：表示子网已挂载到ROUTER上 - UNKNOWN：表示子网还未挂载到ROUTER上 - ERROR：表示子网状态故障</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly StatusEnum UNKNOWN = new StatusEnum("UNKNOWN");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "UNKNOWN", UNKNOWN },
                { "ERROR", ERROR },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 子网ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：子网名称 取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：子网描述 取值范围：0-255个字符，不能包含“&lt;”和“&gt;”。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：子网的网段 取值范围：必须在vpc对应cidr范围内 约束：必须是cidr格式。掩码长度不能大于28
        /// </summary>
        [JsonProperty("cidr", NullValueHandling = NullValueHandling.Ignore)]
        public string Cidr { get; set; }

        /// <summary>
        /// 功能说明：子网的网关 取值范围：子网网段中的IP地址 约束：必须是ip格式
        /// </summary>
        [JsonProperty("gateway_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIp { get; set; }

        /// <summary>
        /// 功能说明：是否创建cidr_v6 取值范围：true（开启），false（关闭）
        /// </summary>
        [JsonProperty("ipv6_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ipv6Enable { get; set; }

        /// <summary>
        /// IPv6子网的网段，如果子网为IPv4子网，则不返回此参数
        /// </summary>
        [JsonProperty("cidr_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string CidrV6 { get; set; }

        /// <summary>
        /// IPv6子网的网关，如果子网为IPv4子网，则不返回此参数
        /// </summary>
        [JsonProperty("gateway_ip_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string GatewayIpV6 { get; set; }

        /// <summary>
        /// 子网是否开启dhcp功能
        /// </summary>
        [JsonProperty("dhcp_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DhcpEnable { get; set; }

        /// <summary>
        /// 子网dns服务器地址1
        /// </summary>
        [JsonProperty("primary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDns { get; set; }

        /// <summary>
        /// 子网dns服务器地址2
        /// </summary>
        [JsonProperty("secondary_dns", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryDns { get; set; }

        /// <summary>
        /// 子网dns服务器地址列表
        /// </summary>
        [JsonProperty("dnsList", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DnsList { get; set; }

        /// <summary>
        /// 子网所在的可用区标识
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// 子网所在VPC标识
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 功能说明：子网的状态 取值范围： - ACTIVE：表示子网已挂载到ROUTER上 - UNKNOWN：表示子网还未挂载到ROUTER上 - ERROR：表示子网状态故障
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 对应网络（OpenStack Neutron接口）id
        /// </summary>
        [JsonProperty("neutron_network_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NeutronNetworkId { get; set; }

        /// <summary>
        /// 对应子网（OpenStack Neutron接口）id
        /// </summary>
        [JsonProperty("neutron_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NeutronSubnetId { get; set; }

        /// <summary>
        /// 对应IPv6子网（OpenStack Neutron接口）id，如果子网为IPv4子网，则不返回此参数
        /// </summary>
        [JsonProperty("neutron_subnet_id_v6", NullValueHandling = NullValueHandling.Ignore)]
        public string NeutronSubnetIdV6 { get; set; }

        /// <summary>
        /// 子网配置的NTP地址或DHCP租约时间
        /// </summary>
        [JsonProperty("extra_dhcp_opts", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtraDhcpOption> ExtraDhcpOpts { get; set; }

        /// <summary>
        /// 功能说明：子网作用域 取值范围：center-表示作用域为中心；{azId}表示作用域为具体的AZ
        /// </summary>
        [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
        public string Scope { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：资源创建UTC时间 格式：yyyy-MM-ddTHH:mm:ss
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 功能说明：资源更新UTC时间 格式：yyyy-MM-ddTHH:mm:ss
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subnet {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  cidr: ").Append(Cidr).Append("\n");
            sb.Append("  gatewayIp: ").Append(GatewayIp).Append("\n");
            sb.Append("  ipv6Enable: ").Append(Ipv6Enable).Append("\n");
            sb.Append("  cidrV6: ").Append(CidrV6).Append("\n");
            sb.Append("  gatewayIpV6: ").Append(GatewayIpV6).Append("\n");
            sb.Append("  dhcpEnable: ").Append(DhcpEnable).Append("\n");
            sb.Append("  primaryDns: ").Append(PrimaryDns).Append("\n");
            sb.Append("  secondaryDns: ").Append(SecondaryDns).Append("\n");
            sb.Append("  dnsList: ").Append(DnsList).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  neutronNetworkId: ").Append(NeutronNetworkId).Append("\n");
            sb.Append("  neutronSubnetId: ").Append(NeutronSubnetId).Append("\n");
            sb.Append("  neutronSubnetIdV6: ").Append(NeutronSubnetIdV6).Append("\n");
            sb.Append("  extraDhcpOpts: ").Append(ExtraDhcpOpts).Append("\n");
            sb.Append("  scope: ").Append(Scope).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
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
            return this.Equals(input as Subnet);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Subnet input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Cidr == input.Cidr ||
                    (this.Cidr != null &&
                    this.Cidr.Equals(input.Cidr))
                ) && 
                (
                    this.GatewayIp == input.GatewayIp ||
                    (this.GatewayIp != null &&
                    this.GatewayIp.Equals(input.GatewayIp))
                ) && 
                (
                    this.Ipv6Enable == input.Ipv6Enable ||
                    (this.Ipv6Enable != null &&
                    this.Ipv6Enable.Equals(input.Ipv6Enable))
                ) && 
                (
                    this.CidrV6 == input.CidrV6 ||
                    (this.CidrV6 != null &&
                    this.CidrV6.Equals(input.CidrV6))
                ) && 
                (
                    this.GatewayIpV6 == input.GatewayIpV6 ||
                    (this.GatewayIpV6 != null &&
                    this.GatewayIpV6.Equals(input.GatewayIpV6))
                ) && 
                (
                    this.DhcpEnable == input.DhcpEnable ||
                    (this.DhcpEnable != null &&
                    this.DhcpEnable.Equals(input.DhcpEnable))
                ) && 
                (
                    this.PrimaryDns == input.PrimaryDns ||
                    (this.PrimaryDns != null &&
                    this.PrimaryDns.Equals(input.PrimaryDns))
                ) && 
                (
                    this.SecondaryDns == input.SecondaryDns ||
                    (this.SecondaryDns != null &&
                    this.SecondaryDns.Equals(input.SecondaryDns))
                ) && 
                (
                    this.DnsList == input.DnsList ||
                    this.DnsList != null &&
                    input.DnsList != null &&
                    this.DnsList.SequenceEqual(input.DnsList)
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    (this.AvailabilityZone != null &&
                    this.AvailabilityZone.Equals(input.AvailabilityZone))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.NeutronNetworkId == input.NeutronNetworkId ||
                    (this.NeutronNetworkId != null &&
                    this.NeutronNetworkId.Equals(input.NeutronNetworkId))
                ) && 
                (
                    this.NeutronSubnetId == input.NeutronSubnetId ||
                    (this.NeutronSubnetId != null &&
                    this.NeutronSubnetId.Equals(input.NeutronSubnetId))
                ) && 
                (
                    this.NeutronSubnetIdV6 == input.NeutronSubnetIdV6 ||
                    (this.NeutronSubnetIdV6 != null &&
                    this.NeutronSubnetIdV6.Equals(input.NeutronSubnetIdV6))
                ) && 
                (
                    this.ExtraDhcpOpts == input.ExtraDhcpOpts ||
                    this.ExtraDhcpOpts != null &&
                    input.ExtraDhcpOpts != null &&
                    this.ExtraDhcpOpts.SequenceEqual(input.ExtraDhcpOpts)
                ) && 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Cidr != null)
                    hashCode = hashCode * 59 + this.Cidr.GetHashCode();
                if (this.GatewayIp != null)
                    hashCode = hashCode * 59 + this.GatewayIp.GetHashCode();
                if (this.Ipv6Enable != null)
                    hashCode = hashCode * 59 + this.Ipv6Enable.GetHashCode();
                if (this.CidrV6 != null)
                    hashCode = hashCode * 59 + this.CidrV6.GetHashCode();
                if (this.GatewayIpV6 != null)
                    hashCode = hashCode * 59 + this.GatewayIpV6.GetHashCode();
                if (this.DhcpEnable != null)
                    hashCode = hashCode * 59 + this.DhcpEnable.GetHashCode();
                if (this.PrimaryDns != null)
                    hashCode = hashCode * 59 + this.PrimaryDns.GetHashCode();
                if (this.SecondaryDns != null)
                    hashCode = hashCode * 59 + this.SecondaryDns.GetHashCode();
                if (this.DnsList != null)
                    hashCode = hashCode * 59 + this.DnsList.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.NeutronNetworkId != null)
                    hashCode = hashCode * 59 + this.NeutronNetworkId.GetHashCode();
                if (this.NeutronSubnetId != null)
                    hashCode = hashCode * 59 + this.NeutronSubnetId.GetHashCode();
                if (this.NeutronSubnetIdV6 != null)
                    hashCode = hashCode * 59 + this.NeutronSubnetIdV6.GetHashCode();
                if (this.ExtraDhcpOpts != null)
                    hashCode = hashCode * 59 + this.ExtraDhcpOpts.GetHashCode();
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
