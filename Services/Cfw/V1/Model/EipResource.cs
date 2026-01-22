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
    /// EIP资源防护信息
    /// </summary>
    public class EipResource 
    {
        /// <summary>
        /// EIP防护状态，0表示防护中，1表示未防护
        /// </summary>
        /// <value>EIP防护状态，0表示防护中，1表示未防护</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly StatusEnum NUMBER_0 = new StatusEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly StatusEnum NUMBER_1 = new StatusEnum(1);

            private static readonly Dictionary<int?, StatusEnum> StaticFields =
            new Dictionary<int?, StatusEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public StatusEnum()
            {

            }

            public StatusEnum(int? value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(int? value)
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
                if (ReferenceEquals(a, b))
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
        /// 弹性公网ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性公网IP
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// EIP防护状态，0表示防护中，1表示未防护
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 弹性公网IP,IPV6类型
        /// </summary>
        [JsonProperty("public_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6 { get; set; }

        /// <summary>
        /// Eip所在账户企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// EIP绑定设备（如ecs，nat）id
        /// </summary>
        [JsonProperty("device_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceId { get; set; }

        /// <summary>
        /// EIP绑定设备（如ecs，nat）名称
        /// </summary>
        [JsonProperty("device_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceName { get; set; }

        /// <summary>
        /// EIP绑定设备（如ecs，nat）拥有者
        /// </summary>
        [JsonProperty("device_owner", NullValueHandling = NullValueHandling.Ignore)]
        public string DeviceOwner { get; set; }

        /// <summary>
        /// **参数解释**： 关联实例类型 **约束限制**： 不涉及 **取值范围**： PORT：IPV4云服务器 NATGW：NAT网关 ELB： 负载均衡器 VPN： 虚拟专用网络 EVPN： 虚拟专用网络 IPV6_PORT：IPV6云服务器 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateInstanceType { get; set; }

        /// <summary>
        /// 防火墙名称
        /// </summary>
        [JsonProperty("fw_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceName { get; set; }

        /// <summary>
        /// 防火墙实例id，创建云防火墙后用于标志防火墙由系统自动生成的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)。
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// Eip绑定的防火墙企业项目id
        /// </summary>
        [JsonProperty("fw_enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwEnterpriseProjectId { get; set; }

        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获得，通过返回值中的data.records.protect_objects.object_id（.表示各对象之间层级的区分）获得，type为0时，object_id为互联网边界防护对象ID，type为1时，object_id为VPC边界防护对象ID。此处仅取type为0的防护对象id，可通过data.records.protect_objects.type（.表示各对象之间层级的区分）获得。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// EIP所属用户id，可通过[获取账号、IAM用户、项目、用户组、区域、委托的名称和ID](cfw_02_0030.xml)获取。
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 防火墙所属用户，可通过[获取账号、IAM用户、项目、用户组、区域、委托的名称和ID](cfw_02_0030.xml)获取。
        /// </summary>
        [JsonProperty("fw_domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwDomainId { get; set; }

        /// <summary>
        /// bypass状态，0: 未bypass, 1: 已bypass, 2: 失败
        /// </summary>
        [JsonProperty("bypass_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? BypassStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EipResource {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  publicIpv6: ").Append(PublicIpv6).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  deviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  deviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  deviceOwner: ").Append(DeviceOwner).Append("\n");
            sb.Append("  associateInstanceType: ").Append(AssociateInstanceType).Append("\n");
            sb.Append("  fwInstanceName: ").Append(FwInstanceName).Append("\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  fwEnterpriseProjectId: ").Append(FwEnterpriseProjectId).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  fwDomainId: ").Append(FwDomainId).Append("\n");
            sb.Append("  bypassStatus: ").Append(BypassStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EipResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EipResource input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.Status != input.Status) return false;
            if (this.PublicIpv6 != input.PublicIpv6 || (this.PublicIpv6 != null && !this.PublicIpv6.Equals(input.PublicIpv6))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DeviceId != input.DeviceId || (this.DeviceId != null && !this.DeviceId.Equals(input.DeviceId))) return false;
            if (this.DeviceName != input.DeviceName || (this.DeviceName != null && !this.DeviceName.Equals(input.DeviceName))) return false;
            if (this.DeviceOwner != input.DeviceOwner || (this.DeviceOwner != null && !this.DeviceOwner.Equals(input.DeviceOwner))) return false;
            if (this.AssociateInstanceType != input.AssociateInstanceType || (this.AssociateInstanceType != null && !this.AssociateInstanceType.Equals(input.AssociateInstanceType))) return false;
            if (this.FwInstanceName != input.FwInstanceName || (this.FwInstanceName != null && !this.FwInstanceName.Equals(input.FwInstanceName))) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.FwEnterpriseProjectId != input.FwEnterpriseProjectId || (this.FwEnterpriseProjectId != null && !this.FwEnterpriseProjectId.Equals(input.FwEnterpriseProjectId))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.DomainId != input.DomainId || (this.DomainId != null && !this.DomainId.Equals(input.DomainId))) return false;
            if (this.FwDomainId != input.FwDomainId || (this.FwDomainId != null && !this.FwDomainId.Equals(input.FwDomainId))) return false;
            if (this.BypassStatus != input.BypassStatus || (this.BypassStatus != null && !this.BypassStatus.Equals(input.BypassStatus))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PublicIpv6 != null) hashCode = hashCode * 59 + this.PublicIpv6.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DeviceId != null) hashCode = hashCode * 59 + this.DeviceId.GetHashCode();
                if (this.DeviceName != null) hashCode = hashCode * 59 + this.DeviceName.GetHashCode();
                if (this.DeviceOwner != null) hashCode = hashCode * 59 + this.DeviceOwner.GetHashCode();
                if (this.AssociateInstanceType != null) hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.FwInstanceName != null) hashCode = hashCode * 59 + this.FwInstanceName.GetHashCode();
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.FwEnterpriseProjectId != null) hashCode = hashCode * 59 + this.FwEnterpriseProjectId.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.DomainId != null) hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.FwDomainId != null) hashCode = hashCode * 59 + this.FwDomainId.GetHashCode();
                if (this.BypassStatus != null) hashCode = hashCode * 59 + this.BypassStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
