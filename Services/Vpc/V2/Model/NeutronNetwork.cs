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
    /// network对象列表
    /// </summary>
    public class NeutronNetwork 
    {
        /// <summary>
        /// 功能说明：网络状态 取值范围：ACTIVE，DOWN，BUILD或ERROR
        /// </summary>
        /// <value>功能说明：网络状态 取值范围：ACTIVE，DOWN，BUILD或ERROR</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE");

            /// <summary>
            /// Enum DOWN for value: DOWN
            /// </summary>
            public static readonly StatusEnum DOWN = new StatusEnum("DOWN");

            /// <summary>
            /// Enum BUILD for value: BUILD
            /// </summary>
            public static readonly StatusEnum BUILD = new StatusEnum("BUILD");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "DOWN", DOWN },
                { "BUILD", BUILD },
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
        /// 网络ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 功能说明：网络状态 取值范围：ACTIVE，DOWN，BUILD或ERROR
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 功能说明：网络名称 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 功能说明：网络关联的子网ID列表 约束：一个network仅支持关联一个 subnet。
        /// </summary>
        [JsonProperty("subnets", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Subnets { get; set; }

        /// <summary>
        /// 功能说明：扩展属性，是否外部网络 取值范围：true、false 约束：不支持设置和更新
        /// </summary>
        [JsonProperty("router:external", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Routerexternal { get; set; }

        /// <summary>
        /// 功能说明：资源的管理状态 取值范围：true、false 约束：只支持true
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 功能说明：是否支持跨租户共享此资源 取值范围：true(共享)、false(非共享) 约束：不支持设置和更新
        /// </summary>
        [JsonProperty("shared", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shared { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 功能说明：扩展属性，网络类型（支持vxlan, geneve） 取值范围：vxlan，geneve
        /// </summary>
        [JsonProperty("provider:network_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ProvidernetworkType { get; set; }

        /// <summary>
        /// 功能说明：本网络的候选可用域
        /// </summary>
        [JsonProperty("availability_zone_hints", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZoneHints { get; set; }

        /// <summary>
        /// 功能说明：本网络的可用域。 取值范围：当前region下的可用域
        /// </summary>
        [JsonProperty("availability_zones", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZones { get; set; }

        /// <summary>
        /// 功能说明：端口安全使能标记 取值范围：true（启用）、false（禁用） 约束：如果不使能，则network下所有虚机的安全组和dhcp防欺骗不生效
        /// </summary>
        [JsonProperty("port_security_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortSecurityEnabled { get; set; }

        /// <summary>
        /// 功能说明：默认内网DNS域地址 约束：系统自动生成维护，不支持设置和更新
        /// </summary>
        [JsonProperty("dns_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string DnsDomain { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

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
            sb.Append("class NeutronNetwork {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  subnets: ").Append(Subnets).Append("\n");
            sb.Append("  routerexternal: ").Append(Routerexternal).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  shared: ").Append(Shared).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  providernetworkType: ").Append(ProvidernetworkType).Append("\n");
            sb.Append("  availabilityZoneHints: ").Append(AvailabilityZoneHints).Append("\n");
            sb.Append("  availabilityZones: ").Append(AvailabilityZones).Append("\n");
            sb.Append("  portSecurityEnabled: ").Append(PortSecurityEnabled).Append("\n");
            sb.Append("  dnsDomain: ").Append(DnsDomain).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
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
            return this.Equals(input as NeutronNetwork);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NeutronNetwork input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Subnets != input.Subnets || (this.Subnets != null && input.Subnets != null && !this.Subnets.SequenceEqual(input.Subnets))) return false;
            if (this.Routerexternal != input.Routerexternal || (this.Routerexternal != null && !this.Routerexternal.Equals(input.Routerexternal))) return false;
            if (this.AdminStateUp != input.AdminStateUp || (this.AdminStateUp != null && !this.AdminStateUp.Equals(input.AdminStateUp))) return false;
            if (this.Shared != input.Shared || (this.Shared != null && !this.Shared.Equals(input.Shared))) return false;
            if (this.TenantId != input.TenantId || (this.TenantId != null && !this.TenantId.Equals(input.TenantId))) return false;
            if (this.ProvidernetworkType != input.ProvidernetworkType || (this.ProvidernetworkType != null && !this.ProvidernetworkType.Equals(input.ProvidernetworkType))) return false;
            if (this.AvailabilityZoneHints != input.AvailabilityZoneHints || (this.AvailabilityZoneHints != null && input.AvailabilityZoneHints != null && !this.AvailabilityZoneHints.SequenceEqual(input.AvailabilityZoneHints))) return false;
            if (this.AvailabilityZones != input.AvailabilityZones || (this.AvailabilityZones != null && input.AvailabilityZones != null && !this.AvailabilityZones.SequenceEqual(input.AvailabilityZones))) return false;
            if (this.PortSecurityEnabled != input.PortSecurityEnabled || (this.PortSecurityEnabled != null && !this.PortSecurityEnabled.Equals(input.PortSecurityEnabled))) return false;
            if (this.DnsDomain != input.DnsDomain || (this.DnsDomain != null && !this.DnsDomain.Equals(input.DnsDomain))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;

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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Subnets != null) hashCode = hashCode * 59 + this.Subnets.GetHashCode();
                if (this.Routerexternal != null) hashCode = hashCode * 59 + this.Routerexternal.GetHashCode();
                if (this.AdminStateUp != null) hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.Shared != null) hashCode = hashCode * 59 + this.Shared.GetHashCode();
                if (this.TenantId != null) hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.ProvidernetworkType != null) hashCode = hashCode * 59 + this.ProvidernetworkType.GetHashCode();
                if (this.AvailabilityZoneHints != null) hashCode = hashCode * 59 + this.AvailabilityZoneHints.GetHashCode();
                if (this.AvailabilityZones != null) hashCode = hashCode * 59 + this.AvailabilityZones.GetHashCode();
                if (this.PortSecurityEnabled != null) hashCode = hashCode * 59 + this.PortSecurityEnabled.GetHashCode();
                if (this.DnsDomain != null) hashCode = hashCode * 59 + this.DnsDomain.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}
