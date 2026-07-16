using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateInferDeploymentScaleResponse : SdkResponse
    {

        /// <summary>
        /// 参数解释： 部署ID，在[添加部署](CreateInferDeployment.xml)时即可在返回体中获取，也可通过[查询服务部署列表](ListInferDeployments.xml)获取当前用户拥有的部署，其中deployment_id字段即为部署ID。 约束限制： 不涉及。 取值范围： 部署ID。 默认取值： 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 服务部署名字
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 参数解释： 部署id（废弃字段）。 取值范围： 不涉及。
        /// </summary>
        [JsonProperty("infer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InferName { get; set; }

        /// <summary>
        /// **参数解释：** 创建时间，根据创建时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreateAt { get; set; }

        /// <summary>
        /// 参数解释： 描述 取值范围： 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 专属资源池ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释：** 算法框架。 **取值范围：** - COMMON： 普通在线服务。
        /// </summary>
        [JsonProperty("framework", NullValueHandling = NullValueHandling.Ignore)]
        public string Framework { get; set; }

        /// <summary>
        /// **参数解释：** 服务优先级。 **约束限制：** 不涉及。 **取值范围：** [1, 3]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public string Priority { get; set; }

        /// <summary>
        /// **参数解释：** 凭证类型相关配置，用户可以在此处选择使用的凭证类型（dew，agency） **约束限制：** 不涉及。 **取值范围：** - [dew：DEW密钥。](tag:hws,hws_hk,fcs) - agency：临时委托凭证。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// **参数解释：** 服务部署状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例数
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释：** 高可用开关，开启后不同实例的pod将尽量均匀分布到不同的节点上。 **约束限制：** 不涉及 **取值范围：** 不涉及 **默认取值：** true
        /// </summary>
        [JsonProperty("high_avail_switch", NullValueHandling = NullValueHandling.Ignore)]
        public string HighAvailSwitch { get; set; }

        /// <summary>
        /// **参数解释：** 系统日志转储开关。 **约束限制：** 只有NPU资源池有，且逻辑池是没有的 **取值范围：** 不涉及 **默认取值：** false
        /// </summary>
        [JsonProperty("system_log_dump_enable", NullValueHandling = NullValueHandling.Ignore)]
        public string SystemLogDumpEnable { get; set; }

        /// <summary>
        /// **参数解释：** 实例单元配置。 **约束限制：** 单机推理时，个数只会为1；如果是分布式推理时，根据不同框架，实例单元配置可灵活配置。
        /// </summary>
        [JsonProperty("unit_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnitConfig> UnitConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，根据更新时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 当前服务版本信息。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("version_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionCount { get; set; }

        /// <summary>
        /// **参数解释：** 权重百分比，分配到此模型的流量权重，仅当模型部署为在线服务时需要配置。 **约束限制：** 不涉及。 **取值范围：** [0, 100]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advanced_config", NullValueHandling = NullValueHandling.Ignore)]
        public AdvancedConfig AdvancedConfig { get; set; }

        /// <summary>
        /// **参数解释：** 巫山工作流ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 参数解释： 服务部署名字。
        /// </summary>
        [JsonProperty("deployment_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// **参数解释：** 当服务或者部署被冻结时返回的冻结类型信息。
        /// </summary>
        [JsonProperty("frozen_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<FrozenInfo> FrozenInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInferDeploymentScaleResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  inferName: ").Append(InferName).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  framework: ").Append(Framework).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  highAvailSwitch: ").Append(HighAvailSwitch).Append("\n");
            sb.Append("  systemLogDumpEnable: ").Append(SystemLogDumpEnable).Append("\n");
            sb.Append("  unitConfigs: ").Append(UnitConfigs).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionCount: ").Append(VersionCount).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  advancedConfig: ").Append(AdvancedConfig).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  deploymentName: ").Append(DeploymentName).Append("\n");
            sb.Append("  frozenInfos: ").Append(FrozenInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInferDeploymentScaleResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInferDeploymentScaleResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InferName != input.InferName || (this.InferName != null && !this.InferName.Equals(input.InferName))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Framework != input.Framework || (this.Framework != null && !this.Framework.Equals(input.Framework))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.SecretType != input.SecretType || (this.SecretType != null && !this.SecretType.Equals(input.SecretType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.HighAvailSwitch != input.HighAvailSwitch || (this.HighAvailSwitch != null && !this.HighAvailSwitch.Equals(input.HighAvailSwitch))) return false;
            if (this.SystemLogDumpEnable != input.SystemLogDumpEnable || (this.SystemLogDumpEnable != null && !this.SystemLogDumpEnable.Equals(input.SystemLogDumpEnable))) return false;
            if (this.UnitConfigs != input.UnitConfigs || (this.UnitConfigs != null && input.UnitConfigs != null && !this.UnitConfigs.SequenceEqual(input.UnitConfigs))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionCount != input.VersionCount || (this.VersionCount != null && !this.VersionCount.Equals(input.VersionCount))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.AdvancedConfig != input.AdvancedConfig || (this.AdvancedConfig != null && !this.AdvancedConfig.Equals(input.AdvancedConfig))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.DeploymentName != input.DeploymentName || (this.DeploymentName != null && !this.DeploymentName.Equals(input.DeploymentName))) return false;
            if (this.FrozenInfos != input.FrozenInfos || (this.FrozenInfos != null && input.FrozenInfos != null && !this.FrozenInfos.SequenceEqual(input.FrozenInfos))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InferName != null) hashCode = hashCode * 59 + this.InferName.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Framework != null) hashCode = hashCode * 59 + this.Framework.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.SecretType != null) hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.HighAvailSwitch != null) hashCode = hashCode * 59 + this.HighAvailSwitch.GetHashCode();
                if (this.SystemLogDumpEnable != null) hashCode = hashCode * 59 + this.SystemLogDumpEnable.GetHashCode();
                if (this.UnitConfigs != null) hashCode = hashCode * 59 + this.UnitConfigs.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionCount != null) hashCode = hashCode * 59 + this.VersionCount.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.AdvancedConfig != null) hashCode = hashCode * 59 + this.AdvancedConfig.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.DeploymentName != null) hashCode = hashCode * 59 + this.DeploymentName.GetHashCode();
                if (this.FrozenInfos != null) hashCode = hashCode * 59 + this.FrozenInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
