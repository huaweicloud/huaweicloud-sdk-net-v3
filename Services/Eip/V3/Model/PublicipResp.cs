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
    /// 弹性公网IP对象返回模板
    /// </summary>
    public class PublicipResp 
    {
        /// <summary>
        /// - 功能说明: 弹性公网IP版本号 - 取值范围: 4、6   - 4表示公网IP地址为public_ip_address地址   - 6表示公网IP地址为public_ipv6_address地址
        /// </summary>
        /// <value>- 功能说明: 弹性公网IP版本号 - 取值范围: 4、6   - 4表示公网IP地址为public_ip_address地址   - 6表示公网IP地址为public_ipv6_address地址</value>
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

            public static bool operator !=(IpVersionEnum a, IpVersionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// - 功能说明：弹性公网IP的状态 - 取值范围：FREEZED，DOWN，ACTIVE，ERROR。   - FREEZED表示弹性公网IP处于冻结状态   - DOWN表示弹性公网IP未绑定实例   - ACTIVE表示弹性公网IP绑定实例，正在使用中   - ERROR表示弹性公网IP状态异常
        /// </summary>
        /// <value>- 功能说明：弹性公网IP的状态 - 取值范围：FREEZED，DOWN，ACTIVE，ERROR。   - FREEZED表示弹性公网IP处于冻结状态   - DOWN表示弹性公网IP未绑定实例   - ACTIVE表示弹性公网IP绑定实例，正在使用中   - ERROR表示弹性公网IP状态异常</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: FREEZED
            /// </summary>
            public static readonly StatusEnum FREEZED = new StatusEnum("FREEZED");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "FREEZED", FREEZED },
                { "DOWN", DOWN },
                { "ACTIVE", ACTIVE },
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
        /// - 功能说明：弹性公网IP的类型 - 取值范围：EIP，DUALSTACK
        /// </summary>
        /// <value>- 功能说明：弹性公网IP的类型 - 取值范围：EIP，DUALSTACK</value>
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

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "EIP", EIP },
                { "DUALSTACK", DUALSTACK },
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// - 功能说明：弹性公网IP绑定的实例类型 - 取值范围：PORT、NATGW、ELB、ELBV1、VPN 
        /// </summary>
        /// <value>- 功能说明：弹性公网IP绑定的实例类型 - 取值范围：PORT、NATGW、ELB、ELBV1、VPN </value>
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

            public static bool operator !=(AssociateInstanceTypeEnum a, AssociateInstanceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// - 功能说明：弹性公网IP的唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// - 功能说明：项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// - 功能说明: 弹性公网IP版本号 - 取值范围: 4、6   - 4表示公网IP地址为public_ip_address地址   - 6表示公网IP地址为public_ipv6_address地址
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public IpVersionEnum IpVersion { get; set; }
        /// <summary>
        /// - 功能说明: 弹性公网IPv4地址
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// - 功能说明: 弹性公网IPv6地址
        /// </summary>
        [JsonProperty("public_ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6Address { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的状态 - 取值范围：FREEZED，DOWN，ACTIVE，ERROR。   - FREEZED表示弹性公网IP处于冻结状态   - DOWN表示弹性公网IP未绑定实例   - ACTIVE表示弹性公网IP绑定实例，正在使用中   - ERROR表示弹性公网IP状态异常
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// - 功能说明：弹性公网IP的描述信息 - 约束：用户以自定义方式标识资源，系统不感知
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的创建时间 - 约束：UTC时间格式（2018-12-25T10:07:24Z）
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP最近的更新时间 - 约束：UTC时间格式（2018-12-25T10:09:20Z）
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的类型 - 取值范围：EIP，DUALSTACK
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("vnic", NullValueHandling = NullValueHandling.Ignore)]
        public VnicResp Vnic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthResp Bandwidth { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的订单信息 - 约束：包周期才会有订单信息，按需资源此字段为空
        /// </summary>
        [JsonProperty("billing_info", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingInfo { get; set; }

        /// <summary>
        /// - 功能说明：记录弹性公网IP当前的冻结状态 - 约束：metadata类型，标识欠费冻结、公安冻结
        /// </summary>
        [JsonProperty("lock_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LockStatus { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP绑定的实例类型 - 取值范围：PORT、NATGW、ELB、ELBV1、VPN 
        /// </summary>
        [JsonProperty("associate_instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public AssociateInstanceTypeEnum AssociateInstanceType { get; set; }
        /// <summary>
        /// - 功能说明：弹性公网IP绑定的实例ID
        /// </summary>
        [JsonProperty("associate_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociateInstanceId { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP所属网络的ID。publicip_pool_name对应的网络ID
        /// </summary>
        [JsonProperty("publicip_pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipPoolId { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP的网络类型， 包括公共池类型，如5_bgp/5_sbgp...，和用户购买的专属池。专属池见publcip_pool相关接口
        /// </summary>
        [JsonProperty("publicip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicipPoolName { get; set; }

        /// <summary>
        /// - 功能说明：弹性公网IP别名
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }

        /// <summary>
        /// - 功能说明：中心还是边缘。中心CENTER，边缘为各边缘az名称
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  publicIpv6Address: ").Append(PublicIpv6Address).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
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
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.IpVersion != input.IpVersion) return false;
            if (this.PublicIpAddress != input.PublicIpAddress || (this.PublicIpAddress != null && !this.PublicIpAddress.Equals(input.PublicIpAddress))) return false;
            if (this.PublicIpv6Address != input.PublicIpv6Address || (this.PublicIpv6Address != null && !this.PublicIpv6Address.Equals(input.PublicIpv6Address))) return false;
            if (this.Status != input.Status) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.Type != input.Type) return false;
            if (this.Vnic != input.Vnic || (this.Vnic != null && !this.Vnic.Equals(input.Vnic))) return false;
            if (this.Bandwidth != input.Bandwidth || (this.Bandwidth != null && !this.Bandwidth.Equals(input.Bandwidth))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.BillingInfo != input.BillingInfo || (this.BillingInfo != null && !this.BillingInfo.Equals(input.BillingInfo))) return false;
            if (this.LockStatus != input.LockStatus || (this.LockStatus != null && !this.LockStatus.Equals(input.LockStatus))) return false;
            if (this.AssociateInstanceType != input.AssociateInstanceType) return false;
            if (this.AssociateInstanceId != input.AssociateInstanceId || (this.AssociateInstanceId != null && !this.AssociateInstanceId.Equals(input.AssociateInstanceId))) return false;
            if (this.PublicipPoolId != input.PublicipPoolId || (this.PublicipPoolId != null && !this.PublicipPoolId.Equals(input.PublicipPoolId))) return false;
            if (this.PublicipPoolName != input.PublicipPoolName || (this.PublicipPoolName != null && !this.PublicipPoolName.Equals(input.PublicipPoolName))) return false;
            if (this.Alias != input.Alias || (this.Alias != null && !this.Alias.Equals(input.Alias))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PublicIpAddress != null) hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.PublicIpv6Address != null) hashCode = hashCode * 59 + this.PublicIpv6Address.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Vnic != null) hashCode = hashCode * 59 + this.Vnic.GetHashCode();
                if (this.Bandwidth != null) hashCode = hashCode * 59 + this.Bandwidth.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.BillingInfo != null) hashCode = hashCode * 59 + this.BillingInfo.GetHashCode();
                if (this.LockStatus != null) hashCode = hashCode * 59 + this.LockStatus.GetHashCode();
                hashCode = hashCode * 59 + this.AssociateInstanceType.GetHashCode();
                if (this.AssociateInstanceId != null) hashCode = hashCode * 59 + this.AssociateInstanceId.GetHashCode();
                if (this.PublicipPoolId != null) hashCode = hashCode * 59 + this.PublicipPoolId.GetHashCode();
                if (this.PublicipPoolName != null) hashCode = hashCode * 59 + this.PublicipPoolName.GetHashCode();
                if (this.Alias != null) hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
