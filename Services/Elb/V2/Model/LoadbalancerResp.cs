using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Elb.V2.Model
{
    /// <summary>
    /// 负载均衡器响应体
    /// </summary>
    public class LoadbalancerResp 
    {
        /// <summary>
        /// 负载均衡器的操作状态
        /// </summary>
        /// <value>负载均衡器的操作状态</value>
        [JsonConverter(typeof(EnumClassConverter<OperatingStatusEnum>))]
        public class OperatingStatusEnum
        {
            /// <summary>
            /// Enum ONLINE for value: ONLINE
            /// </summary>
            public static readonly OperatingStatusEnum ONLINE = new OperatingStatusEnum("ONLINE");

            /// <summary>
            /// Enum OFFLINE for value: OFFLINE
            /// </summary>
            public static readonly OperatingStatusEnum OFFLINE = new OperatingStatusEnum("OFFLINE");

            /// <summary>
            /// Enum DEGRADED for value: DEGRADED
            /// </summary>
            public static readonly OperatingStatusEnum DEGRADED = new OperatingStatusEnum("DEGRADED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly OperatingStatusEnum DISABLED = new OperatingStatusEnum("DISABLED");

            /// <summary>
            /// Enum NO_MONITOR for value: NO_MONITOR
            /// </summary>
            public static readonly OperatingStatusEnum NO_MONITOR = new OperatingStatusEnum("NO_MONITOR");

            private static readonly Dictionary<string, OperatingStatusEnum> StaticFields =
            new Dictionary<string, OperatingStatusEnum>()
            {
                { "ONLINE", ONLINE },
                { "OFFLINE", OFFLINE },
                { "DEGRADED", DEGRADED },
                { "DISABLED", DISABLED },
                { "NO_MONITOR", NO_MONITOR },
            };

            private string _value;

            public OperatingStatusEnum()
            {

            }

            public OperatingStatusEnum(string value)
            {
                _value = value;
            }

            public static OperatingStatusEnum FromValue(string value)
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

                if (this.Equals(obj as OperatingStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperatingStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperatingStatusEnum a, OperatingStatusEnum b)
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

            public static bool operator !=(OperatingStatusEnum a, OperatingStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 负载均衡器的配置状态
        /// </summary>
        /// <value>负载均衡器的配置状态</value>
        [JsonConverter(typeof(EnumClassConverter<ProvisioningStatusEnum>))]
        public class ProvisioningStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            public static readonly ProvisioningStatusEnum ACTIVE = new ProvisioningStatusEnum("ACTIVE");

            /// <summary>
            /// Enum PENDING_CREATE for value: PENDING_CREATE
            /// </summary>
            public static readonly ProvisioningStatusEnum PENDING_CREATE = new ProvisioningStatusEnum("PENDING_CREATE");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly ProvisioningStatusEnum ERROR = new ProvisioningStatusEnum("ERROR");

            private static readonly Dictionary<string, ProvisioningStatusEnum> StaticFields =
            new Dictionary<string, ProvisioningStatusEnum>()
            {
                { "ACTIVE", ACTIVE },
                { "PENDING_CREATE", PENDING_CREATE },
                { "ERROR", ERROR },
            };

            private string _value;

            public ProvisioningStatusEnum()
            {

            }

            public ProvisioningStatusEnum(string value)
            {
                _value = value;
            }

            public static ProvisioningStatusEnum FromValue(string value)
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

                if (this.Equals(obj as ProvisioningStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProvisioningStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
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

            public static bool operator !=(ProvisioningStatusEnum a, ProvisioningStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 负载均衡器ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 负载均衡器所在的项目ID。
        /// </summary>
        [JsonProperty("tenant_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantId { get; set; }

        /// <summary>
        /// 负载均衡器名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 负载均衡器的描述信息
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 负载均衡器所在的子网的IPv4子网ID。仅支持内网类型。
        /// </summary>
        [JsonProperty("vip_subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipSubnetId { get; set; }

        /// <summary>
        /// 负载均衡器虚拟IP对应的端口ID
        /// </summary>
        [JsonProperty("vip_port_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VipPortId { get; set; }

        /// <summary>
        /// 负载均衡器的虚拟IP。
        /// </summary>
        [JsonProperty("vip_address", NullValueHandling = NullValueHandling.Ignore)]
        public string VipAddress { get; set; }

        /// <summary>
        /// 负载均衡器关联的监听器ID的列表
        /// </summary>
        [JsonProperty("listeners", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceList> Listeners { get; set; }

        /// <summary>
        /// 负载均衡器关联的后端云服务器组ID的列表。
        /// </summary>
        [JsonProperty("pools", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceList> Pools { get; set; }

        /// <summary>
        /// 负载均衡器的供应者名称。只支持vlb
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 负载均衡器的操作状态
        /// </summary>
        [JsonProperty("operating_status", NullValueHandling = NullValueHandling.Ignore)]
        public OperatingStatusEnum OperatingStatus { get; set; }
        /// <summary>
        /// 负载均衡器的配置状态
        /// </summary>
        [JsonProperty("provisioning_status", NullValueHandling = NullValueHandling.Ignore)]
        public ProvisioningStatusEnum ProvisioningStatus { get; set; }
        /// <summary>
        /// 负载均衡器的管理状态。只支持设定为true，该字段的值无实际意义。
        /// </summary>
        [JsonProperty("admin_state_up", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminStateUp { get; set; }

        /// <summary>
        /// 负载均衡器的创建时间
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 负载均衡器的更新时间
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 负载均衡器的企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 负载均衡器所在的项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 负载均衡器的标签列表
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 负载均衡器绑定的公网IP。只支持绑定一个公网IP。
        /// </summary>
        [JsonProperty("publicips", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpInfo> Publicips { get; set; }

        /// <summary>
        /// 收费模式。取值：  flavor：按规格计费 lcu：按使用量计费 说明：不影响弹性扩缩容实例、包周期实例的计费方式
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 负载均衡器的冻结场景。若负载均衡器有多个冻结场景，用逗号分隔。取值：  POLICE：公安冻结场景。 ILLEGAL：违规冻结场景。 VERIFY：客户未实名认证冻结场景。 PARTNER：合作伙伴冻结（合作伙伴冻结子客户资源）。 AREAR：欠费冻结场景。
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenScene { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoadbalancerResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  tenantId: ").Append(TenantId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  vipSubnetId: ").Append(VipSubnetId).Append("\n");
            sb.Append("  vipPortId: ").Append(VipPortId).Append("\n");
            sb.Append("  vipAddress: ").Append(VipAddress).Append("\n");
            sb.Append("  listeners: ").Append(Listeners).Append("\n");
            sb.Append("  pools: ").Append(Pools).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  operatingStatus: ").Append(OperatingStatus).Append("\n");
            sb.Append("  provisioningStatus: ").Append(ProvisioningStatus).Append("\n");
            sb.Append("  adminStateUp: ").Append(AdminStateUp).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  publicips: ").Append(Publicips).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  frozenScene: ").Append(FrozenScene).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoadbalancerResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LoadbalancerResp input)
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
                    this.VipSubnetId == input.VipSubnetId ||
                    (this.VipSubnetId != null &&
                    this.VipSubnetId.Equals(input.VipSubnetId))
                ) && 
                (
                    this.VipPortId == input.VipPortId ||
                    (this.VipPortId != null &&
                    this.VipPortId.Equals(input.VipPortId))
                ) && 
                (
                    this.VipAddress == input.VipAddress ||
                    (this.VipAddress != null &&
                    this.VipAddress.Equals(input.VipAddress))
                ) && 
                (
                    this.Listeners == input.Listeners ||
                    this.Listeners != null &&
                    input.Listeners != null &&
                    this.Listeners.SequenceEqual(input.Listeners)
                ) && 
                (
                    this.Pools == input.Pools ||
                    this.Pools != null &&
                    input.Pools != null &&
                    this.Pools.SequenceEqual(input.Pools)
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.OperatingStatus == input.OperatingStatus ||
                    (this.OperatingStatus != null &&
                    this.OperatingStatus.Equals(input.OperatingStatus))
                ) && 
                (
                    this.ProvisioningStatus == input.ProvisioningStatus ||
                    (this.ProvisioningStatus != null &&
                    this.ProvisioningStatus.Equals(input.ProvisioningStatus))
                ) && 
                (
                    this.AdminStateUp == input.AdminStateUp ||
                    (this.AdminStateUp != null &&
                    this.AdminStateUp.Equals(input.AdminStateUp))
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
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.Publicips == input.Publicips ||
                    this.Publicips != null &&
                    input.Publicips != null &&
                    this.Publicips.SequenceEqual(input.Publicips)
                ) && 
                (
                    this.ChargeMode == input.ChargeMode ||
                    (this.ChargeMode != null &&
                    this.ChargeMode.Equals(input.ChargeMode))
                ) && 
                (
                    this.FrozenScene == input.FrozenScene ||
                    (this.FrozenScene != null &&
                    this.FrozenScene.Equals(input.FrozenScene))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VipSubnetId != null)
                    hashCode = hashCode * 59 + this.VipSubnetId.GetHashCode();
                if (this.VipPortId != null)
                    hashCode = hashCode * 59 + this.VipPortId.GetHashCode();
                if (this.VipAddress != null)
                    hashCode = hashCode * 59 + this.VipAddress.GetHashCode();
                if (this.Listeners != null)
                    hashCode = hashCode * 59 + this.Listeners.GetHashCode();
                if (this.Pools != null)
                    hashCode = hashCode * 59 + this.Pools.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.OperatingStatus != null)
                    hashCode = hashCode * 59 + this.OperatingStatus.GetHashCode();
                if (this.ProvisioningStatus != null)
                    hashCode = hashCode * 59 + this.ProvisioningStatus.GetHashCode();
                if (this.AdminStateUp != null)
                    hashCode = hashCode * 59 + this.AdminStateUp.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Publicips != null)
                    hashCode = hashCode * 59 + this.Publicips.GetHashCode();
                if (this.ChargeMode != null)
                    hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.FrozenScene != null)
                    hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                return hashCode;
            }
        }
    }
}
