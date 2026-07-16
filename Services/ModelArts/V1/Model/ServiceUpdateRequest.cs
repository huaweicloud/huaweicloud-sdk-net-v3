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
    /// 
    /// </summary>
    public class ServiceUpdateRequest 
    {

        /// <summary>
        /// **参数解释：** 服务ID **约束限制：** 不涉及。 **取值范围：** 不涉及
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 服务名称。 **约束限制：** 不涉及。 **取值范围：** 支持1-128个字符，可以包含字母、汉字、数字、连字符和下划线。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 服务部署超时时间，integer类型，取值在1~300（860版本该参数做保留兼容）。 **约束限制：** 不涉及。 **取值范围：** [0, 300]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("deploy_timeout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployTimeoutMinutes { get; set; }

        /// <summary>
        /// **参数解释：** 必填，填了之后，数据库中如果存在相同版本号，将会报错（仅修改描述的场景除外）。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 非必填，仅更新描述的场景直接修改对应version的数据库字段，不新增版本号。 **约束限制：** 不涉及。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 仅修改服务时不需传，兼容部署分离之前版本。 **约束限制：** group_configs的最大元素数量为1。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("group_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupConfig> GroupConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime_config", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeConfig RuntimeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upgrade_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeConfig UpgradeConfig { get; set; }

        /// <summary>
        /// **参数解释：** 日志策略。 **约束限制：** 不涉及。 **取值范围：** - POOL：使用资源池日志插件配置的日志流。 - AUTO_CREATE：自动创建日志流。 - DEFAULT: 由系统决定日志策略 **默认取值：** AUTO_CREATE：自动创建日志流。
        /// </summary>
        [JsonProperty("lts_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStrategy { get; set; }

        /// <summary>
        /// **参数解释：** 日志配置，当开启LTS日志的时候，STDOUT类型为必填。 **约束限制：** 当开启LTS日志的时候，STDOUT类型为必填。 数量上限为2个。
        /// </summary>
        [JsonProperty("log_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LtsConfig> LogConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 服务标签,上限20个 **约束限制：** 不涉及。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间id，默认是“0” **约束限制：** 不涉及。 **取值范围：** 不涉及 **默认取值：** 不涉及
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 定时停止配置。 **约束限制：** 仅当body中另一个参数description为空时，此参数才生效。
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleConfig> Schedule { get; set; }

        /// <summary>
        /// **参数解释：** 该参数值由英文逗号隔开的协议、端口号、地址组成，其中地址长度不超过255 ，且需要与镜像给定的协议、地址、端口一致，否则指标无法上报。
        /// </summary>
        [JsonProperty("custom_metrics_path", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomMetricsPath { get; set; }

        /// <summary>
        /// **参数解释：** 模型类型。 **取值范围：** - TEXT_GENERATION：文本生成 - IMAGE_UNDERSTANDING：图像理解 - VIDEO_GENERATION：视频生成 - IMAGE_GENERATION：图像生成 - RERANK：重排序 - VECTOR_MODEL：向量模型 - EMBEDDING：Embedding嵌入
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceUpdateRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  deployTimeoutMinutes: ").Append(DeployTimeoutMinutes).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  groupConfigs: ").Append(GroupConfigs).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("  upgradeConfig: ").Append(UpgradeConfig).Append("\n");
            sb.Append("  ltsStrategy: ").Append(LtsStrategy).Append("\n");
            sb.Append("  logConfigs: ").Append(LogConfigs).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  customMetricsPath: ").Append(CustomMetricsPath).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceUpdateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceUpdateRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DeployTimeoutMinutes != input.DeployTimeoutMinutes || (this.DeployTimeoutMinutes != null && !this.DeployTimeoutMinutes.Equals(input.DeployTimeoutMinutes))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.GroupConfigs != input.GroupConfigs || (this.GroupConfigs != null && input.GroupConfigs != null && !this.GroupConfigs.SequenceEqual(input.GroupConfigs))) return false;
            if (this.RuntimeConfig != input.RuntimeConfig || (this.RuntimeConfig != null && !this.RuntimeConfig.Equals(input.RuntimeConfig))) return false;
            if (this.UpgradeConfig != input.UpgradeConfig || (this.UpgradeConfig != null && !this.UpgradeConfig.Equals(input.UpgradeConfig))) return false;
            if (this.LtsStrategy != input.LtsStrategy || (this.LtsStrategy != null && !this.LtsStrategy.Equals(input.LtsStrategy))) return false;
            if (this.LogConfigs != input.LogConfigs || (this.LogConfigs != null && input.LogConfigs != null && !this.LogConfigs.SequenceEqual(input.LogConfigs))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && !this.Tags.Equals(input.Tags))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Schedule != input.Schedule || (this.Schedule != null && input.Schedule != null && !this.Schedule.SequenceEqual(input.Schedule))) return false;
            if (this.CustomMetricsPath != input.CustomMetricsPath || (this.CustomMetricsPath != null && !this.CustomMetricsPath.Equals(input.CustomMetricsPath))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;

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
                if (this.DeployTimeoutMinutes != null) hashCode = hashCode * 59 + this.DeployTimeoutMinutes.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.GroupConfigs != null) hashCode = hashCode * 59 + this.GroupConfigs.GetHashCode();
                if (this.RuntimeConfig != null) hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                if (this.UpgradeConfig != null) hashCode = hashCode * 59 + this.UpgradeConfig.GetHashCode();
                if (this.LtsStrategy != null) hashCode = hashCode * 59 + this.LtsStrategy.GetHashCode();
                if (this.LogConfigs != null) hashCode = hashCode * 59 + this.LogConfigs.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Schedule != null) hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CustomMetricsPath != null) hashCode = hashCode * 59 + this.CustomMetricsPath.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                return hashCode;
            }
        }
    }
}
