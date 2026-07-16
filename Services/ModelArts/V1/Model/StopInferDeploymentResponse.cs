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
    public class StopInferDeploymentResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 部署ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 部署名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 资源池ID，查询指定资源池下的服务，默认不过滤。可通过[查询资源池列表](ShowPool.xml)获取。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// **参数解释：** 部署场景下，服务实例数量。 **约束限制：** 不涉及。 **取值范围：** [1, 128]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释：** 系统日志转储开关。 **约束限制：** 只有NPU资源池有，且逻辑池是没有的。 **取值范围：** 不涉及。 **默认取值：** false。
        /// </summary>
        [JsonProperty("system_log_dump_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SystemLogDumpEnable { get; set; }

        /// <summary>
        /// **参数解释：** 推理单元配置。
        /// </summary>
        [JsonProperty("unit_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnitConfigResponse> UnitConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 权重百分比，分配到此模型的流量权重，仅当模型部署为在线服务时需要配置。 **取值范围：** [0, 100]。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// **参数解释：** 流量比例，单个部署实例预期接收用户的流量与总流量比值，是由流量权重配置和部署状态计算所得的值。 **取值范围：** 0.00%~100.00%。
        /// </summary>
        [JsonProperty("traffic_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public string TrafficRatio { get; set; }

        /// <summary>
        /// **参数解释：** 凭证类型相关配置，用户可以在此处选择使用的凭证类型（dew，agency） **约束限制：** 不涉及。 **取值范围：** - [dew：DEW密钥。](tag:hws,hws_hk,fcs) - agency：临时委托凭证。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// **参数解释：** 凭证名称，用户使用dew类型凭证时可以在此处选择使用的凭证。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// **参数解释：** 服务优先级。 **约束限制：** 不涉及。 **取值范围：** [1, 3]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 高可用开关，开启后不同实例的pod将尽量均匀分布到不同的节点上。（准备下线，请使用schedule_strategy字段） **取值范围：** - true: 高可用开启 - false: 高可用关闭。
        /// </summary>
        [JsonProperty("high_avail_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighAvailSwitch { get; set; }

        /// <summary>
        /// **参数解释：** 算法框架。 **取值范围：** - COMMON： 普通在线服务。
        /// </summary>
        [JsonProperty("framework", NullValueHandling = NullValueHandling.Ignore)]
        public string Framework { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本号，以数字及点号组成，形如1.0.1。 **约束限制：** 不涉及。 **取值范围：** 1.0.0 ~ 99.99.99，长度不超过8位。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 版本id，可通过查询version列表查询。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("version_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VersionId { get; set; }

        /// <summary>
        /// **参数解释：** 服务当前状态。 **取值范围：** - DEPLOYING：部署中。 - FAILED：失败。 - STOPPED：停止。 - RUNNING：运行中。 - DELETING：删除中。 - STOPPING：停止中。 - CONCERNING：告警。 - DELETED: 已删除。 - RESTARTING: 重启中。 - UPGRADING：升级中。 - ERROR：异常。 - INTERRUPTING：中断中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释：** 部署场景下，服务运行实例数量。 **约束限制：** 不涉及。 **取值范围：** [1, 128]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("running_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RunningCount { get; set; }

        /// <summary>
        /// **参数解释：** 部署类型。 **取值范围：** - SINGLE：单机单卡。 - MULTI：多机多卡。
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启镜像流量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("mirror_traffic_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? MirrorTrafficEnable { get; set; }

        /// <summary>
        /// **参数解释：** 镜像流量权重。 **取值范围：** 50。
        /// </summary>
        [JsonProperty("mirror_traffic_weight", NullValueHandling = NullValueHandling.Ignore)]
        public string MirrorTrafficWeight { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本数量。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("version_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionCount { get; set; }

        /// <summary>
        /// **参数解释：** 工作负载类型。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("workload_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，根据更新时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// **参数解释：** 部署对接lts状态。 **取值范围：** - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("lts_state", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsState { get; set; }

        /// <summary>
        /// **参数解释：** 部署ID。
        /// </summary>
        [JsonProperty("infer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InferName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public InferModelResponse Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advanced_config", NullValueHandling = NullValueHandling.Ignore)]
        public AdvancedConfig AdvancedConfig { get; set; }

        /// <summary>
        /// **参数解释：** 部署描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 参数解释： 创建时间，根据创建时的当前时间自动生成。 取值范围： 毫秒级时间戳，13位数字，如1609459200000。
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateAt { get; set; }

        /// <summary>
        /// **参数解释：** 调度策略。 **取值范围：** - HIGH_AVAILABILITY：高可用调度 - HIGH_UTILIZATION：紧凑调度 - HIGH_PERFORMANCE：高性能调度
        /// </summary>
        [JsonProperty("schedule_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StopInferDeploymentResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  systemLogDumpEnable: ").Append(SystemLogDumpEnable).Append("\n");
            sb.Append("  unitConfigs: ").Append(UnitConfigs).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  trafficRatio: ").Append(TrafficRatio).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  highAvailSwitch: ").Append(HighAvailSwitch).Append("\n");
            sb.Append("  framework: ").Append(Framework).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  runningCount: ").Append(RunningCount).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("  mirrorTrafficEnable: ").Append(MirrorTrafficEnable).Append("\n");
            sb.Append("  mirrorTrafficWeight: ").Append(MirrorTrafficWeight).Append("\n");
            sb.Append("  versionCount: ").Append(VersionCount).Append("\n");
            sb.Append("  workloadType: ").Append(WorkloadType).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  ltsState: ").Append(LtsState).Append("\n");
            sb.Append("  inferName: ").Append(InferName).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  advancedConfig: ").Append(AdvancedConfig).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  scheduleStrategy: ").Append(ScheduleStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StopInferDeploymentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StopInferDeploymentResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SystemLogDumpEnable != input.SystemLogDumpEnable || (this.SystemLogDumpEnable != null && !this.SystemLogDumpEnable.Equals(input.SystemLogDumpEnable))) return false;
            if (this.UnitConfigs != input.UnitConfigs || (this.UnitConfigs != null && input.UnitConfigs != null && !this.UnitConfigs.SequenceEqual(input.UnitConfigs))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.TrafficRatio != input.TrafficRatio || (this.TrafficRatio != null && !this.TrafficRatio.Equals(input.TrafficRatio))) return false;
            if (this.SecretType != input.SecretType || (this.SecretType != null && !this.SecretType.Equals(input.SecretType))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.HighAvailSwitch != input.HighAvailSwitch || (this.HighAvailSwitch != null && !this.HighAvailSwitch.Equals(input.HighAvailSwitch))) return false;
            if (this.Framework != input.Framework || (this.Framework != null && !this.Framework.Equals(input.Framework))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.RunningCount != input.RunningCount || (this.RunningCount != null && !this.RunningCount.Equals(input.RunningCount))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;
            if (this.MirrorTrafficEnable != input.MirrorTrafficEnable || (this.MirrorTrafficEnable != null && !this.MirrorTrafficEnable.Equals(input.MirrorTrafficEnable))) return false;
            if (this.MirrorTrafficWeight != input.MirrorTrafficWeight || (this.MirrorTrafficWeight != null && !this.MirrorTrafficWeight.Equals(input.MirrorTrafficWeight))) return false;
            if (this.VersionCount != input.VersionCount || (this.VersionCount != null && !this.VersionCount.Equals(input.VersionCount))) return false;
            if (this.WorkloadType != input.WorkloadType || (this.WorkloadType != null && !this.WorkloadType.Equals(input.WorkloadType))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.LtsState != input.LtsState || (this.LtsState != null && !this.LtsState.Equals(input.LtsState))) return false;
            if (this.InferName != input.InferName || (this.InferName != null && !this.InferName.Equals(input.InferName))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.AdvancedConfig != input.AdvancedConfig || (this.AdvancedConfig != null && !this.AdvancedConfig.Equals(input.AdvancedConfig))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateAt != input.CreateAt || (this.CreateAt != null && !this.CreateAt.Equals(input.CreateAt))) return false;
            if (this.ScheduleStrategy != input.ScheduleStrategy || (this.ScheduleStrategy != null && !this.ScheduleStrategy.Equals(input.ScheduleStrategy))) return false;

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
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.SystemLogDumpEnable != null) hashCode = hashCode * 59 + this.SystemLogDumpEnable.GetHashCode();
                if (this.UnitConfigs != null) hashCode = hashCode * 59 + this.UnitConfigs.GetHashCode();
                if (this.Weight != null) hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.TrafficRatio != null) hashCode = hashCode * 59 + this.TrafficRatio.GetHashCode();
                if (this.SecretType != null) hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.HighAvailSwitch != null) hashCode = hashCode * 59 + this.HighAvailSwitch.GetHashCode();
                if (this.Framework != null) hashCode = hashCode * 59 + this.Framework.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RunningCount != null) hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                if (this.MirrorTrafficEnable != null) hashCode = hashCode * 59 + this.MirrorTrafficEnable.GetHashCode();
                if (this.MirrorTrafficWeight != null) hashCode = hashCode * 59 + this.MirrorTrafficWeight.GetHashCode();
                if (this.VersionCount != null) hashCode = hashCode * 59 + this.VersionCount.GetHashCode();
                if (this.WorkloadType != null) hashCode = hashCode * 59 + this.WorkloadType.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.LtsState != null) hashCode = hashCode * 59 + this.LtsState.GetHashCode();
                if (this.InferName != null) hashCode = hashCode * 59 + this.InferName.GetHashCode();
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.AdvancedConfig != null) hashCode = hashCode * 59 + this.AdvancedConfig.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateAt != null) hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.ScheduleStrategy != null) hashCode = hashCode * 59 + this.ScheduleStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
