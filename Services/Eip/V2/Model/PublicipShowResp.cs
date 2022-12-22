using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Eip.V2.Model
{
    /// <summary>
    /// 弹性公网IP列表返回体
    /// </summary>
    public class PublicipShowResp 
    {
        /// <summary>
        /// 表示共享带宽或者独享带宽  取值范围：PER，WHOLE。  WHOLE表示共享带宽  PER表示独享带宽  约束：其中IPv6暂不支持WHOLE类型带宽。
        /// </summary>
        /// <value>表示共享带宽或者独享带宽  取值范围：PER，WHOLE。  WHOLE表示共享带宽  PER表示独享带宽  约束：其中IPv6暂不支持WHOLE类型带宽。</value>
        [JsonConverter(typeof(EnumClassConverter<BandwidthShareTypeEnum>))]
        public class BandwidthShareTypeEnum
        {
            /// <summary>
            /// Enum WHOLE for value: WHOLE
            /// </summary>
            public static readonly BandwidthShareTypeEnum WHOLE = new BandwidthShareTypeEnum("WHOLE");

            /// <summary>
            /// Enum PER for value: PER
            /// </summary>
            public static readonly BandwidthShareTypeEnum PER = new BandwidthShareTypeEnum("PER");

            private static readonly Dictionary<string, BandwidthShareTypeEnum> StaticFields =
            new Dictionary<string, BandwidthShareTypeEnum>()
            {
                { "WHOLE", WHOLE },
                { "PER", PER },
            };

            private string _value;

            public BandwidthShareTypeEnum()
            {

            }

            public BandwidthShareTypeEnum(string value)
            {
                _value = value;
            }

            public static BandwidthShareTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BandwidthShareTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BandwidthShareTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BandwidthShareTypeEnum a, BandwidthShareTypeEnum b)
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

            public static bool operator !=(BandwidthShareTypeEnum a, BandwidthShareTypeEnum b)
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
        /// IP版本信息，取值范围是4和6  4：表示IPv4  6：表示IPv6
        /// </summary>
        /// <value>IP版本信息，取值范围是4和6  4：表示IPv4  6：表示IPv6</value>
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
        /// 弹性公网IP对应带宽ID
        /// </summary>
        [JsonProperty("bandwidth_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthId { get; set; }

        /// <summary>
        /// 带宽名称
        /// </summary>
        [JsonProperty("bandwidth_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BandwidthName { get; set; }

        /// <summary>
        /// 表示共享带宽或者独享带宽  取值范围：PER，WHOLE。  WHOLE表示共享带宽  PER表示独享带宽  约束：其中IPv6暂不支持WHOLE类型带宽。
        /// </summary>
        [JsonProperty("bandwidth_share_type", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthShareTypeEnum BandwidthShareType { get; set; }
        /// <summary>
        /// 带宽大小，单位为Mbit/s。
        /// </summary>
        [JsonProperty("bandwidth_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? BandwidthSize { get; set; }

        /// <summary>
        /// 弹性公网IP申请时间（UTC）
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 企业项目ID。最大长度36字节，带“-”连字符的UUID格式，或者是字符串“0”。  创建弹性公网IP时，给弹性公网IP绑定企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 弹性公网IP唯一标识
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：端口id。  约束：只有绑定了的弹性公网IP查询才会返回该参数
        /// </summary>
        [JsonProperty("port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PortId { get; set; }

        /// <summary>
        /// 功能说明：绑定弹性公网IP的私有IP地址  约束：只有绑定了的弹性公网IP查询才会返回该参数
        /// </summary>
        [JsonProperty("private_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public ProfileResp Profile { get; set; }

        /// <summary>
        /// IPv4时是申请到的弹性公网IP地址，IPv6时是IPv6地址对应的IPv4地址
        /// </summary>
        [JsonProperty("public_ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpAddress { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP的状态  取值范围：冻结FREEZED，绑定失败BIND_ERROR，绑定中BINDING，释放中PENDING_DELETE， 创建中PENDING_CREATE，创建中NOTIFYING，释放中NOTIFY_DELETE，更新中PENDING_UPDATE， 未绑定DOWN ，绑定ACTIVE，绑定ELB，绑定VPN，失败ERROR。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 弹性公网IP的类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// IPv4时无此字段，IPv6时为申请到的弹性公网IP地址
        /// </summary>
        [JsonProperty("public_ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIpv6Address { get; set; }

        /// <summary>
        /// IP版本信息，取值范围是4和6  4：表示IPv4  6：表示IPv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public IpVersionEnum IpVersion { get; set; }
        /// <summary>
        /// 功能说明：表示中心站点资源或者边缘站点资源 取值范围： center、边缘站点名称 约束：publicip只能绑定该字段相同的资源
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }

        /// <summary>
        /// 功能说明：表示此publicip可以加入的共享带宽类型列表，如果为空列表，则表示该           publicip不能加入任何共享带宽 约束：publicip只能加入到有该带宽类型的共享带宽中
        /// </summary>
        [JsonProperty("allow_share_bandwidth_types", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowShareBandwidthTypes { get; set; }

        /// <summary>
        /// 功能说明：弹性公网IP名称 取值范围：1-64个字符，支持数字、字母、中文、_(下划线)、-（中划线）、.（点）
        /// </summary>
        [JsonProperty("alias", NullValueHandling = NullValueHandling.Ignore)]
        public string Alias { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipShowResp {\n");
            sb.Append("  bandwidthId: ").Append(BandwidthId).Append("\n");
            sb.Append("  bandwidthName: ").Append(BandwidthName).Append("\n");
            sb.Append("  bandwidthShareType: ").Append(BandwidthShareType).Append("\n");
            sb.Append("  bandwidthSize: ").Append(BandwidthSize).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  portId: ").Append(PortId).Append("\n");
            sb.Append("  privateIpAddress: ").Append(PrivateIpAddress).Append("\n");
            sb.Append("  profile: ").Append(Profile).Append("\n");
            sb.Append("  publicIpAddress: ").Append(PublicIpAddress).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  publicIpv6Address: ").Append(PublicIpv6Address).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("  allowShareBandwidthTypes: ").Append(AllowShareBandwidthTypes).Append("\n");
            sb.Append("  alias: ").Append(Alias).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipShowResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipShowResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BandwidthId == input.BandwidthId ||
                    (this.BandwidthId != null &&
                    this.BandwidthId.Equals(input.BandwidthId))
                ) && 
                (
                    this.BandwidthName == input.BandwidthName ||
                    (this.BandwidthName != null &&
                    this.BandwidthName.Equals(input.BandwidthName))
                ) && 
                (
                    this.BandwidthShareType == input.BandwidthShareType ||
                    (this.BandwidthShareType != null &&
                    this.BandwidthShareType.Equals(input.BandwidthShareType))
                ) && 
                (
                    this.BandwidthSize == input.BandwidthSize ||
                    (this.BandwidthSize != null &&
                    this.BandwidthSize.Equals(input.BandwidthSize))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PortId == input.PortId ||
                    (this.PortId != null &&
                    this.PortId.Equals(input.PortId))
                ) && 
                (
                    this.PrivateIpAddress == input.PrivateIpAddress ||
                    (this.PrivateIpAddress != null &&
                    this.PrivateIpAddress.Equals(input.PrivateIpAddress))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.PublicIpAddress == input.PublicIpAddress ||
                    (this.PublicIpAddress != null &&
                    this.PublicIpAddress.Equals(input.PublicIpAddress))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.PublicIpv6Address == input.PublicIpv6Address ||
                    (this.PublicIpv6Address != null &&
                    this.PublicIpv6Address.Equals(input.PublicIpv6Address))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.PublicBorderGroup == input.PublicBorderGroup ||
                    (this.PublicBorderGroup != null &&
                    this.PublicBorderGroup.Equals(input.PublicBorderGroup))
                ) && 
                (
                    this.AllowShareBandwidthTypes == input.AllowShareBandwidthTypes ||
                    this.AllowShareBandwidthTypes != null &&
                    input.AllowShareBandwidthTypes != null &&
                    this.AllowShareBandwidthTypes.SequenceEqual(input.AllowShareBandwidthTypes)
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                if (this.BandwidthId != null)
                    hashCode = hashCode * 59 + this.BandwidthId.GetHashCode();
                if (this.BandwidthName != null)
                    hashCode = hashCode * 59 + this.BandwidthName.GetHashCode();
                if (this.BandwidthShareType != null)
                    hashCode = hashCode * 59 + this.BandwidthShareType.GetHashCode();
                if (this.BandwidthSize != null)
                    hashCode = hashCode * 59 + this.BandwidthSize.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PortId != null)
                    hashCode = hashCode * 59 + this.PortId.GetHashCode();
                if (this.PrivateIpAddress != null)
                    hashCode = hashCode * 59 + this.PrivateIpAddress.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.PublicIpAddress != null)
                    hashCode = hashCode * 59 + this.PublicIpAddress.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PublicIpv6Address != null)
                    hashCode = hashCode * 59 + this.PublicIpv6Address.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.PublicBorderGroup != null)
                    hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                if (this.AllowShareBandwidthTypes != null)
                    hashCode = hashCode * 59 + this.AllowShareBandwidthTypes.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                return hashCode;
            }
        }
    }
}
