using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ShowGlobalEip 
    {
        /// <summary>
        /// 状态
        /// </summary>
        /// <value>状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly StatusEnum PENDING_CREATE = new StatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum IDLE for value: IDLE
            /// </summary>
            public static readonly StatusEnum IDLE = new StatusEnum("IDLE");

            /// <summary>
            /// Enum INUSE for value: INUSE
            /// </summary>
            public static readonly StatusEnum INUSE = new StatusEnum("INUSE");

            /// <summary>
            /// Enum PENDING_UPDATE for value: PENDING_UPDATE
            /// </summary>
            public static readonly StatusEnum PENDING_UPDATE = new StatusEnum("PENDING_UPDATE");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "PENDING_CREATE", PENDING_CREATE },
                { "IDLE", IDLE },
                { "INUSE", INUSE },
                { "PENDING_UPDATE", PENDING_UPDATE },
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
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户自定义的资源描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonProperty("domain_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DomainId { get; set; }

        /// <summary>
        /// 接入点信息
        /// </summary>
        [JsonProperty("access_site", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessSite { get; set; }

        /// <summary>
        /// 全域弹性公网IP池子名称
        /// </summary>
        [JsonProperty("geip_pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GeipPoolName { get; set; }

        /// <summary>
        /// 线路
        /// </summary>
        [JsonProperty("isp", NullValueHandling = NullValueHandling.Ignore)]
        public string Isp { get; set; }

        /// <summary>
        /// IPv4或IPv6
        /// </summary>
        [JsonProperty("ip_version", NullValueHandling = NullValueHandling.Ignore)]
        public int? IpVersion { get; set; }

        /// <summary>
        /// IPv4地址
        /// </summary>
        [JsonProperty("ip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddress { get; set; }

        /// <summary>
        /// IPv6地址
        /// </summary>
        [JsonProperty("ipv6_address", NullValueHandling = NullValueHandling.Ignore)]
        public string Ipv6Address { get; set; }

        /// <summary>
        /// 是否冻结
        /// </summary>
        [JsonProperty("freezen", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Freezen { get; set; }

        /// <summary>
        /// 冻结原因
        /// </summary>
        [JsonProperty("freezen_info", NullValueHandling = NullValueHandling.Ignore)]
        public string FreezenInfo { get; set; }

        /// <summary>
        /// 是否污染
        /// </summary>
        [JsonProperty("polluted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Polluted { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("internet_bandwidth_info", NullValueHandling = NullValueHandling.Ignore)]
        public InternetBandwidthInfo InternetBandwidthInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("global_connection_bandwidth_info", NullValueHandling = NullValueHandling.Ignore)]
        public GlobalConnectionBandwidthInfo GlobalConnectionBandwidthInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("associate_instance_info", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceInfo AssociateInstanceInfo { get; set; }

        /// <summary>
        /// 是否包周期
        /// </summary>
        [JsonProperty("is_pre_paid", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPrePaid { get; set; }

        /// <summary>
        /// 全域弹性公网IP标签
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 系统标签
        /// </summary>
        [JsonProperty("sys_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> SysTags { get; set; }

        /// <summary>
        /// 资源的企业项目id
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowGlobalEip {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  domainId: ").Append(DomainId).Append("\n");
            sb.Append("  accessSite: ").Append(AccessSite).Append("\n");
            sb.Append("  geipPoolName: ").Append(GeipPoolName).Append("\n");
            sb.Append("  isp: ").Append(Isp).Append("\n");
            sb.Append("  ipVersion: ").Append(IpVersion).Append("\n");
            sb.Append("  ipAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  ipv6Address: ").Append(Ipv6Address).Append("\n");
            sb.Append("  freezen: ").Append(Freezen).Append("\n");
            sb.Append("  freezenInfo: ").Append(FreezenInfo).Append("\n");
            sb.Append("  polluted: ").Append(Polluted).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  internetBandwidthInfo: ").Append(InternetBandwidthInfo).Append("\n");
            sb.Append("  globalConnectionBandwidthInfo: ").Append(GlobalConnectionBandwidthInfo).Append("\n");
            sb.Append("  associateInstanceInfo: ").Append(AssociateInstanceInfo).Append("\n");
            sb.Append("  isPrePaid: ").Append(IsPrePaid).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  sysTags: ").Append(SysTags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowGlobalEip);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowGlobalEip input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.AccessSite == input.AccessSite ||
                    (this.AccessSite != null &&
                    this.AccessSite.Equals(input.AccessSite))
                ) && 
                (
                    this.GeipPoolName == input.GeipPoolName ||
                    (this.GeipPoolName != null &&
                    this.GeipPoolName.Equals(input.GeipPoolName))
                ) && 
                (
                    this.Isp == input.Isp ||
                    (this.Isp != null &&
                    this.Isp.Equals(input.Isp))
                ) && 
                (
                    this.IpVersion == input.IpVersion ||
                    (this.IpVersion != null &&
                    this.IpVersion.Equals(input.IpVersion))
                ) && 
                (
                    this.IpAddress == input.IpAddress ||
                    (this.IpAddress != null &&
                    this.IpAddress.Equals(input.IpAddress))
                ) && 
                (
                    this.Ipv6Address == input.Ipv6Address ||
                    (this.Ipv6Address != null &&
                    this.Ipv6Address.Equals(input.Ipv6Address))
                ) && 
                (
                    this.Freezen == input.Freezen ||
                    (this.Freezen != null &&
                    this.Freezen.Equals(input.Freezen))
                ) && 
                (
                    this.FreezenInfo == input.FreezenInfo ||
                    (this.FreezenInfo != null &&
                    this.FreezenInfo.Equals(input.FreezenInfo))
                ) && 
                (
                    this.Polluted == input.Polluted ||
                    (this.Polluted != null &&
                    this.Polluted.Equals(input.Polluted))
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
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.InternetBandwidthInfo == input.InternetBandwidthInfo ||
                    (this.InternetBandwidthInfo != null &&
                    this.InternetBandwidthInfo.Equals(input.InternetBandwidthInfo))
                ) && 
                (
                    this.GlobalConnectionBandwidthInfo == input.GlobalConnectionBandwidthInfo ||
                    (this.GlobalConnectionBandwidthInfo != null &&
                    this.GlobalConnectionBandwidthInfo.Equals(input.GlobalConnectionBandwidthInfo))
                ) && 
                (
                    this.AssociateInstanceInfo == input.AssociateInstanceInfo ||
                    (this.AssociateInstanceInfo != null &&
                    this.AssociateInstanceInfo.Equals(input.AssociateInstanceInfo))
                ) && 
                (
                    this.IsPrePaid == input.IsPrePaid ||
                    (this.IsPrePaid != null &&
                    this.IsPrePaid.Equals(input.IsPrePaid))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.SysTags == input.SysTags ||
                    this.SysTags != null &&
                    input.SysTags != null &&
                    this.SysTags.SequenceEqual(input.SysTags)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.AccessSite != null)
                    hashCode = hashCode * 59 + this.AccessSite.GetHashCode();
                if (this.GeipPoolName != null)
                    hashCode = hashCode * 59 + this.GeipPoolName.GetHashCode();
                if (this.Isp != null)
                    hashCode = hashCode * 59 + this.Isp.GetHashCode();
                if (this.IpVersion != null)
                    hashCode = hashCode * 59 + this.IpVersion.GetHashCode();
                if (this.IpAddress != null)
                    hashCode = hashCode * 59 + this.IpAddress.GetHashCode();
                if (this.Ipv6Address != null)
                    hashCode = hashCode * 59 + this.Ipv6Address.GetHashCode();
                if (this.Freezen != null)
                    hashCode = hashCode * 59 + this.Freezen.GetHashCode();
                if (this.FreezenInfo != null)
                    hashCode = hashCode * 59 + this.FreezenInfo.GetHashCode();
                if (this.Polluted != null)
                    hashCode = hashCode * 59 + this.Polluted.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.InternetBandwidthInfo != null)
                    hashCode = hashCode * 59 + this.InternetBandwidthInfo.GetHashCode();
                if (this.GlobalConnectionBandwidthInfo != null)
                    hashCode = hashCode * 59 + this.GlobalConnectionBandwidthInfo.GetHashCode();
                if (this.AssociateInstanceInfo != null)
                    hashCode = hashCode * 59 + this.AssociateInstanceInfo.GetHashCode();
                if (this.IsPrePaid != null)
                    hashCode = hashCode * 59 + this.IsPrePaid.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.SysTags != null)
                    hashCode = hashCode * 59 + this.SysTags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
