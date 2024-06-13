using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V3.Model
{
    /// <summary>
    /// 公网IP字段信息
    /// </summary>
    public class PublicipUpdateResp 
    {
        /// <summary>
        /// 功能说明：IP版本信息 取值范围：4表示公网IP地址为public_ip_address地址;6表示公网IP地址为public_ipv6_address地址\&quot;
        /// </summary>
        /// <value>功能说明：IP版本信息 取值范围：4表示公网IP地址为public_ip_address地址;6表示公网IP地址为public_ipv6_address地址\&quot;</value>
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

            private int? _value;

            public IpVersionEnum()
            {

            }

            public IpVersionEnum(int? value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 功能说明：弹性公网IP的状态  取值范围：冻结FREEZED，绑定失败BIND_ERROR，绑定中BINDING，释放中PENDING_DELETE， 创建中PENDING_CREATE，创建中NOTIFYING，释放中NOTIFY_DELETE，更新中PENDING_UPDATE， 未绑定DOWN ，绑定ACTIVE，绑定ELB，绑定VPN，失败ERROR。
        /// </summary>
        /// <value>功能说明：弹性公网IP的状态  取值范围：冻结FREEZED，绑定失败BIND_ERROR，绑定中BINDING，释放中PENDING_DELETE， 创建中PENDING_CREATE，创建中NOTIFYING，释放中NOTIFY_DELETE，更新中PENDING_UPDATE， 未绑定DOWN ，绑定ACTIVE，绑定ELB，绑定VPN，失败ERROR。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly StatusEnum FREEZED = new StatusEnum("FREEZED");

            /// <summary>
            /// Enum BIND_ERROR for value: BIND_ERROR
            /// </summary>
            public static readonly StatusEnum BIND_ERROR = new StatusEnum("BIND_ERROR");

            /// <summary>
            /// Enum BINDING for value: BINDING
            /// </summary>
            public static readonly StatusEnum BINDING = new StatusEnum("BINDING");

            /// <summary>
            /// Enum PENDING_DELETE for value: PENDING_DELETE
            /// </summary>
            public static readonly StatusEnum PENDING_DELETE = new StatusEnum("PENDING_DELETE");

            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly StatusEnum PENDING_CREATE = new StatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum NOTIFYING for value: NOTIFYING
            /// </summary>
            public static readonly StatusEnum NOTIFYING = new StatusEnum("NOTIFYING");

            /// <summary>
            /// Enum NOTIFY_DELETE for value: NOTIFY_DELETE
            /// </summary>
            public static readonly StatusEnum NOTIFY_DELETE = new StatusEnum("NOTIFY_DELETE");

            /// <summary>
            /// Enum PENDING_UPDATE for value: PENDING_UPDATE
            /// </summary>
            public static readonly StatusEnum PENDING_UPDATE = new StatusEnum("PENDING_UPDATE");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum ELB for value: ELB
            /// </summary>
            public static readonly StatusEnum ELB = new StatusEnum("ELB");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            /// <summary>
            /// Enum VPN for value: VPN
            /// </summary>
            public static readonly StatusEnum VPN = new StatusEnum("VPN");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "FREEZED", FREEZED },
                { "BIND_ERROR", BIND_ERROR },
                { "BINDING", BINDING },
                { "PENDING_DELETE", PENDING_DELETE },
                { "PENDING_CREATE", PENDING_CREATE },
                { "NOTIFYING", NOTIFYING },
                { "NOTIFY_DELETE", NOTIFY_DELETE },
                { "PENDING_UPDATE", PENDING_UPDATE },
                { "DOWN", DOWN },
                { "ACTIVE", ACTIVE },
                { "ELB", ELB },
                { "ERROR", ERROR },
                { "VPN", VPN },
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
        /// 功能说明：弹性公网IP类型
        /// </summary>
        /// <value>功能说明：弹性公网IP类型</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum EIP for value: EIP
            /// </summary>
            public static readonly TypeEnum EIP = new TypeEnum("EIP");

            /// <summary>
            /// Enum DUALSTACK for value: DUALSTACK
            /// </summary>
            public static readonly TypeEnum DUALSTACK = new TypeEnum("DUALSTACK");

            /// <summary>
            /// Enum DUALSTACK_SUBNET for value: DUALSTACK_SUBNET
            /// </summary>
            public static readonly TypeEnum DUALSTACK_SUBNET = new TypeEnum("DUALSTACK_SUBNET");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EIP", EIP },
                { "DUALSTACK", DUALSTACK },
                { "DUALSTACK_SUBNET", DUALSTACK_SUBNET },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 功能说明：公网IP绑定的实例类型 取值范围：PORT、NATGW、ELB、ELBV1、VPN、null
        /// </summary>
        /// <value>功能说明：公网IP绑定的实例类型 取值范围：PORT、NATGW、ELB、ELBV1、VPN、null</value>
        [JsonConverter(typeof(EnumClassConverter<AssociateInstanceTypeEnum>))]
        public class AssociateInstanceTypeEnum
        {
            /// <summary>
            /// Enum PORT for value: PORT
            /// </summary>
            public static readonly AssociateInstanceTypeEnum PORT = new AssociateInstanceTypeEnum("PORT");

            /// <summary>
            /// Enum NATGW for value: NATGW
            /// </summary>
            public static readonly AssociateInstanceTypeEnum NATGW = new AssociateInstanceTypeEnum("NATGW");

            /// <summary>
            /// Enum ELB for value: ELB
            /// </summary>
            public static readonly AssociateInstanceTypeEnum ELB = new AssociateInstanceTypeEnum("ELB");

            /// <summary>
            /// Enum ELBV1 for value: ELBV1
            /// </summary>
            public static readonly AssociateInstanceTypeEnum ELBV1 = new AssociateInstanceTypeEnum("ELBV1");

            /// <summary>
            /// Enum VPN for value: VPN
            /// </summary>
            public static readonly AssociateInstanceTypeEnum VPN = new AssociateInstanceTypeEnum("VPN");

            private static readonly Dictionary<string, AssociateInstanceTypeEnum> StaticFields =
            new Dictionary<string, AssociateInstanceTypeEnum>()
            {
                { "PORT", PORT },
                { "NATGW", NATGW },
                { "ELB", ELB },
                { "ELBV1", ELBV1 },
                { "VPN", VPN },
            };

            private string _value;

            public AssociateInstanceTypeEnum()
            {

            }

            public AssociateInstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static AssociateInstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AssociateInstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AssociateInstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
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

            public static bool operator !=(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 功能说明：弹性公网IP唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 功能说明：IP版本信息 取值范围：4表示公网IP地址为public_ip_address地址;6表示公网IP地址为public_ipv6_address地址\&quot;
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public IpVersionEnum IpVersion { get; set; }
        /// <summary>
        /// 功能说明：弹性公网IP或者IPv6端口的地址
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// 功能说明：IPv4时无此字段，IPv6时为申请到的弹性公网IP地址
        /// </summary>
        [JsonProperty("public_ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6Address { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP的状态  取值范围：冻结FREEZED，绑定失败BIND_ERROR，绑定中BINDING，释放中PENDING_DELETE， 创建中PENDING_CREATE，创建中NOTIFYING，释放中NOTIFY_DELETE，更新中PENDING_UPDATE， 未绑定DOWN ，绑定ACTIVE，绑定ELB，绑定VPN，失败ERROR。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 功能说明：弹性公网IP描述信息 约束：用户以自定义方式标识资源，系统不感知
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 功能说明：表示中心站点资源或者边缘站点资源 取值范围： center、边缘站点名称 约束：publicip只能绑定该字段相同的资源
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 功能说明：资源创建UTC时间 格式:yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 功能说明：资源更新UTC时间 格式:yyyy-MM-ddTHH:mm:ssZ
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vnic", NullValueHandling = NullValueHandling.Ignore)]
        public VnicInfo Vnic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public PublicipBandwidthInfo Bandwidth { get; set; }

        /// <summary>
        /// 功能说明：企业项目ID。最大长度36字节,带“-”连字符的UUID格式,或者是字符串“0”。创建弹性公网IP时,给弹性公网IP绑定企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 功能说明：公网IP的订单信息 约束：包周期才会有订单信息，按需资源此字段为空
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// 功能说明：记录公网IP当前的冻结状态 约束：metadata类型，标识欠费冻结、公安冻结 取值范围：police，locked
        /// </summary>
        [JsonProperty("lock_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LockStatus { get; set; }

        /// <summary>
        /// 功能说明：公网IP绑定的实例类型 取值范围：PORT、NATGW、ELB、ELBV1、VPN、null
        /// </summary>
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceTypeEnum AssociateInstanceType { get; set; }
        /// <summary>
        /// 功能说明：公网IP绑定的实例ID
        /// </summary>
        [JsonProperty("associate_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateInstanceId { get; set; }

        /// <summary>
        /// 功能说明：公网IP所属网络的ID。publicip_pool_name对应的网络ID
        /// </summary>
        [JsonProperty("publicip_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipPoolId { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP的网络类型, 包括公共池类型，如5_bgp/5_sbgp...，和用户购买的专属池。 专属池见publcip_pool相关接口
        /// </summary>
        [JsonProperty("publicip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipPoolName { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP名称
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// 默认不显示。开启支持直通模式后展示，表示直通模式的标识。
        /// </summary>
        [JsonProperty("associate_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateMode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipUpdateResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  publicIpv6Address: ").Append(PublicIpv6Address).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  vnic: ").Append(Vnic).Append("\n");
            sb.Append("  bandwidth: ").Append(Bandwidth).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  billingInfo: ").Append(BillingInfo).Append("\n");
            sb.Append("  lockStatus: ").Append(LockStatus).Append("\n");
            sb.Append("  associateInstanceType: ").Append(AssociateInstanceType).Append("\n");
            sb.Append("  associateInstanceId: ").Append(AssociateInstanceId).Append("\n");
            sb.Append("  publicipPoolId: ").Append(PublicipPoolId).Append("\n");
            sb.Append("  publicipPoolName: ").Append(PublicipPoolName).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("  associateMode: ").Append(AssociateMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipUpdateResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipUpdateResp input)
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
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.PublicIpAddress == input.PublicIpAddress ||
                    (this.PublicIpAddress != null &&
                    this.PublicIpAddress.Equals(input.PublicIpAddress))
                ) && 
                (
                    this.PublicIpv6Address == input.PublicIpv6Address ||
                    (this.PublicIpv6Address != null &&
                    this.PublicIpv6Address.Equals(input.PublicIpv6Address))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
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
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Vnic == input.Vnic ||
                    (this.Vnic != null &&
                    this.Vnic.Equals(input.Vnic))
                ) && 
                (
                    this.Bandwidth == input.Bandwidth ||
                    (this.Bandwidth != null &&
                    this.Bandwidth.Equals(input.Bandwidth))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.BillingInfo == input.BillingInfo ||
                    (this.BillingInfo != null &&
                    this.BillingInfo.Equals(input.BillingInfo))
                ) && 
                (
                    this.LockStatus == input.LockStatus ||
                    (this.LockStatus != null &&
                    this.LockStatus.Equals(input.LockStatus))
                ) && 
                (
                    this.AssociateInstanceType == input.AssociateInstanceType ||
                    (this.AssociateInstanceType != null &&
                    this.AssociateInstanceType.Equals(input.AssociateInstanceType))
                ) && 
                (
                    this.AssociateInstanceId == input.AssociateInstanceId ||
                    (this.AssociateInstanceId != null &&
                    this.AssociateInstanceId.Equals(input.AssociateInstanceId))
                ) && 
                (
                    this.PublicipPoolId == input.PublicipPoolId ||
                    (this.PublicipPoolId != null &&
                    this.PublicipPoolId.Equals(input.PublicipPoolId))
                ) && 
                (
                    this.PublicipPoolName == input.PublicipPoolName ||
                    (this.PublicipPoolName != null &&
                    this.PublicipPoolName.Equals(input.PublicipPoolName))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.AssociateMode == input.AssociateMode ||
                    (this.AssociateMode != null &&
                    this.AssociateMode.Equals(input.AssociateMode))
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
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PublicIpAddress != null)
                    hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.PublicIpv6Address != null)
                    hashCode = hashCode * 59 + this.PublicIpv6Address.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vnic != null)
                    hashCode = hashCode * 59 + this.Vnic.GetHashCode();
                if (this.Bandwidth != null)
                    hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.BillingInfo != null)
                    hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.LockStatus != null)
                    hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                if (this.AssociateInstanceType != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.AssociateInstanceId != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceId.GetHashCode();
                if (this.PublicipPoolId != null)
                    hashCode = hashCode * 59 + this.PublicipPoolId.GetHashCode();
                if (this.PublicipPoolName != null)
                    hashCode = hashCode * 59 + this.PublicipPoolName.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.AssociateMode != null)
                    hashCode = hashCode * 59 + this.AssociateMode.GetHashCode();
                return hashCode;
            }
        }
    }
}
