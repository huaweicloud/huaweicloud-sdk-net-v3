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
    /// 
    /// </summary>
    public class GetFirewallInstanceResponseRecord 
    {

        /// <summary>
        /// **参数解释**： 防火墙实例id，创建云防火墙后用于标志防火墙由系统自动生成的标志id。可通过调用[查询防火墙实例接口](ListFirewallDetail.xml)获取 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**： 集群类型 **取值范围**： - 0：主备模式，包含四个节点，2个主节点构成集群，剩余两个节点为主节点的备节点 - 1：集群模式，仅拉起两个节点作为集群
        /// </summary>
        [JsonProperty("ha_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? HaType { get; set; }

        /// <summary>
        /// **参数解释**： 计费模式 **取值范围**： - 0：包年/包月 - 1：按需
        /// </summary>
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeMode { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙防护类型 **取值范围**： 目前仅支持0，互联网防护
        /// </summary>
        [JsonProperty("service_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceType { get; set; }

        /// <summary>
        /// **参数解释**： 引擎类型 **取值范围**： - 0：自研引擎 - 1：山石引擎 - 3：天融信引擎
        /// </summary>
        [JsonProperty("engine_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? EngineType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public Flavor Flavor { get; set; }

        /// <summary>
        /// **参数解释**： 防护对象列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("protect_objects", NullValueHandling = NullValueHandling.Ignore)]
        public List<ProtectObjectVO> ProtectObjects { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙状态列表 **取值范围**： - -1：等待支付 - 0：创建中 - 1，删除中 - 2：运行中 - 3：升级中 - 4：删除完成 - 5：冻结中 - 6：创建失败 - 7：删除失败 - 8：冻结失败 - 9：存储中 - 10：存储失败 - 11：升级失败
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }

        /// <summary>
        /// **参数解释**： 是否为旧引擎 **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("is_old_firewall_instance", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOldFirewallInstance { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持obs **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("is_available_obs", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAvailableObs { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持威胁情报标签 **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("is_support_threat_tags", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportThreatTags { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持ipv6 **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("support_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportIpv6 { get; set; }

        /// <summary>
        /// **参数解释**： 特性开关 **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("feature_toggle", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, bool?> FeatureToggle { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙资源列表 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("resources", NullValueHandling = NullValueHandling.Ignore)]
        public List<FirewallInstanceResource> Resources { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙名称 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("fw_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceName { get; set; }

        /// <summary>
        /// **参数解释**： 企业项目ID，用户根据组织规划企业项目，对应的ID为企业项目ID，可通过[如何获取企业项目ID](cfw_02_0027.xml)获取 **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// **参数解释**： 防火墙资源id，同fw_instance_id **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// **参数解释**： 是否支持url过滤 **取值范围**： - true：是 - false：不是
        /// </summary>
        [JsonProperty("support_url_filtering", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupportUrlFiltering { get; set; }

        /// <summary>
        /// **参数解释**： 标签列表，标签键值map转化的json字符串，如\&quot;{\\\&quot;key\\\&quot;:\\\&quot;value\\\&quot;}\&quot; **取值范围**： 不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFirewallInstanceResponseRecord {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  haType: ").Append(HaType).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  serviceType: ").Append(ServiceType).Append("\n");
            sb.Append("  engineType: ").Append(EngineType).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  protectObjects: ").Append(ProtectObjects).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  isOldFirewallInstance: ").Append(IsOldFirewallInstance).Append("\n");
            sb.Append("  isAvailableObs: ").Append(IsAvailableObs).Append("\n");
            sb.Append("  isSupportThreatTags: ").Append(IsSupportThreatTags).Append("\n");
            sb.Append("  supportIpv6: ").Append(SupportIpv6).Append("\n");
            sb.Append("  featureToggle: ").Append(FeatureToggle).Append("\n");
            sb.Append("  resources: ").Append(Resources).Append("\n");
            sb.Append("  fwInstanceName: ").Append(FwInstanceName).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  supportUrlFiltering: ").Append(SupportUrlFiltering).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetFirewallInstanceResponseRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetFirewallInstanceResponseRecord input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HaType != input.HaType || (this.HaType != null && !this.HaType.Equals(input.HaType))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.ServiceType != input.ServiceType || (this.ServiceType != null && !this.ServiceType.Equals(input.ServiceType))) return false;
            if (this.EngineType != input.EngineType || (this.EngineType != null && !this.EngineType.Equals(input.EngineType))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.ProtectObjects != input.ProtectObjects || (this.ProtectObjects != null && input.ProtectObjects != null && !this.ProtectObjects.SequenceEqual(input.ProtectObjects))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.IsOldFirewallInstance != input.IsOldFirewallInstance || (this.IsOldFirewallInstance != null && !this.IsOldFirewallInstance.Equals(input.IsOldFirewallInstance))) return false;
            if (this.IsAvailableObs != input.IsAvailableObs || (this.IsAvailableObs != null && !this.IsAvailableObs.Equals(input.IsAvailableObs))) return false;
            if (this.IsSupportThreatTags != input.IsSupportThreatTags || (this.IsSupportThreatTags != null && !this.IsSupportThreatTags.Equals(input.IsSupportThreatTags))) return false;
            if (this.SupportIpv6 != input.SupportIpv6 || (this.SupportIpv6 != null && !this.SupportIpv6.Equals(input.SupportIpv6))) return false;
            if (this.FeatureToggle != input.FeatureToggle || (this.FeatureToggle != null && input.FeatureToggle != null && !this.FeatureToggle.SequenceEqual(input.FeatureToggle))) return false;
            if (this.Resources != input.Resources || (this.Resources != null && input.Resources != null && !this.Resources.SequenceEqual(input.Resources))) return false;
            if (this.FwInstanceName != input.FwInstanceName || (this.FwInstanceName != null && !this.FwInstanceName.Equals(input.FwInstanceName))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.SupportUrlFiltering != input.SupportUrlFiltering || (this.SupportUrlFiltering != null && !this.SupportUrlFiltering.Equals(input.SupportUrlFiltering))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;

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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.HaType != null) hashCode = hashCode * 59 + this.HaType.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.ServiceType != null) hashCode = hashCode * 59 + this.ServiceType.GetHashCode();
                if (this.EngineType != null) hashCode = hashCode * 59 + this.EngineType.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ProtectObjects != null) hashCode = hashCode * 59 + this.ProtectObjects.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.IsOldFirewallInstance != null) hashCode = hashCode * 59 + this.IsOldFirewallInstance.GetHashCode();
                if (this.IsAvailableObs != null) hashCode = hashCode * 59 + this.IsAvailableObs.GetHashCode();
                if (this.IsSupportThreatTags != null) hashCode = hashCode * 59 + this.IsSupportThreatTags.GetHashCode();
                if (this.SupportIpv6 != null) hashCode = hashCode * 59 + this.SupportIpv6.GetHashCode();
                if (this.FeatureToggle != null) hashCode = hashCode * 59 + this.FeatureToggle.GetHashCode();
                if (this.Resources != null) hashCode = hashCode * 59 + this.Resources.GetHashCode();
                if (this.FwInstanceName != null) hashCode = hashCode * 59 + this.FwInstanceName.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.SupportUrlFiltering != null) hashCode = hashCode * 59 + this.SupportUrlFiltering.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }
}
