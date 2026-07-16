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
    /// **参数解释：** 创建服务请求体。 **取值范围：** 不涉及。
    /// </summary>
    public class ServiceCreateRequest 
    {

        /// <summary>
        /// **参数解释：** 服务名，用户在[创建服务](CreateInferService.xml)时自定义的名称。 **约束限制：** 服务在删除之前名字不能重复。 **取值范围：** 支持1-64位字符，可包含字母、中文、数字、中划线、下划线。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 服务版本号，以数字及点号组成，形如1.0.1。 **约束限制：** 不涉及。 **取值范围：** 1.0.0 ~ 99.99.99，长度不超过8位。 **默认取值：** 前端可不传默认设置为1.0.0。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 服务备注。 **约束限制：** 不涉及。 **取值范围：** 长度不可以超过512，不能包含大于号，小于号。 **默认取值：** 默认为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 推理服务类型。 **约束限制：** 不涉及。 **取值范围：** - REAL_TIME：在线服务。 - ASYNC_REAL_TIME：异步服务。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释：** 部署类型。 **约束限制：** 不涉及。 **取值范围：** - SINGLE：单机单卡。 - MULTI：多机多卡。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("deploy_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployType { get; set; }

        /// <summary>
        /// **参数解释：** 服务实例组配置。 **约束限制：** 仅创建服务时group_configs可传[]空数组，group_configs的最大元素数量为1。
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
        /// **参数解释：** 日志配置。 **约束限制：** 当开启LTS日志的时候，STDOUT类型为必填。 数量上限为2个。
        /// </summary>
        [JsonProperty("log_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LtsConfig> LogConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 服务标签。 **约束限制：** 上限20个。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ServiceCreateRequestTags> Tags { get; set; }

        /// <summary>
        /// **参数解释：** 工作空间ID。 **约束限制：** 不涉及。 **取值范围：** - 0：默认空间ID。 - 由数字和小写字母组成的32位字符：其他空间ID，可参考[工作空间创建](CreateWorkspace.xml)。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("workspace_id", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// **参数解释：** 定时停止配置。 **约束限制：** 最多支持一个定时任务。
        /// </summary>
        [JsonProperty("schedule", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScheduleConfig> Schedule { get; set; }

        /// <summary>
        /// **参数解释：** 该参数值由英文逗号隔开的协议、端口号、地址组成，比如：[http,8080,metrics]，其中地址长度不超过255 ，且需要与镜像给定的协议、地址、端口一致，否则指标无法上报。 **约束限制：** 长度不超过255。 **取值范围：** - 协议范围：http/https。 - 端口范围：1-65535。 - 地址范围：仅包含字母、数字、点号（.）、中划线（-)、下划线（_）、斜杠（/）的路径，非斜杠（/）开头。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("custom_metrics_path", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomMetricsPath { get; set; }

        /// <summary>
        /// **参数解释：** 服务部署超时时间，integer类型，取值在1~300 （860版本该参数在服务层级做保留兼容）。 **约束限制：** 不涉及。 **取值范围：** [0, 300]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("deploy_timeout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployTimeoutMinutes { get; set; }

        /// <summary>
        /// **参数解释：** 模型类型。 **取值范围：** - TEXT_GENERATION：文本生成 - IMAGE_UNDERSTANDING：图像理解 - VIDEO_GENERATION：视频生成 - IMAGE_GENERATION：图像生成 - RERANK：重排序 - VECTOR_MODEL：向量模型 - EMBEDDING：Embedding嵌入
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// **参数解释：** 工作负载类型。 **取值范围：** - DEPLOYMENT：DEPLOYMENT类型 - LWS：LWS类型
        /// </summary>
        [JsonProperty("workload_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceCreateRequest {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("  groupConfigs: ").Append(GroupConfigs).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("  upgradeConfig: ").Append(UpgradeConfig).Append("\n");
            sb.Append("  ltsStrategy: ").Append(LtsStrategy).Append("\n");
            sb.Append("  logConfigs: ").Append(LogConfigs).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  workspaceId: ").Append(WorkspaceId).Append("\n");
            sb.Append("  schedule: ").Append(Schedule).Append("\n");
            sb.Append("  customMetricsPath: ").Append(CustomMetricsPath).Append("\n");
            sb.Append("  deployTimeoutMinutes: ").Append(DeployTimeoutMinutes).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  workloadType: ").Append(WorkloadType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceCreateRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceCreateRequest input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;
            if (this.GroupConfigs != input.GroupConfigs || (this.GroupConfigs != null && input.GroupConfigs != null && !this.GroupConfigs.SequenceEqual(input.GroupConfigs))) return false;
            if (this.RuntimeConfig != input.RuntimeConfig || (this.RuntimeConfig != null && !this.RuntimeConfig.Equals(input.RuntimeConfig))) return false;
            if (this.UpgradeConfig != input.UpgradeConfig || (this.UpgradeConfig != null && !this.UpgradeConfig.Equals(input.UpgradeConfig))) return false;
            if (this.LtsStrategy != input.LtsStrategy || (this.LtsStrategy != null && !this.LtsStrategy.Equals(input.LtsStrategy))) return false;
            if (this.LogConfigs != input.LogConfigs || (this.LogConfigs != null && input.LogConfigs != null && !this.LogConfigs.SequenceEqual(input.LogConfigs))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.WorkspaceId != input.WorkspaceId || (this.WorkspaceId != null && !this.WorkspaceId.Equals(input.WorkspaceId))) return false;
            if (this.Schedule != input.Schedule || (this.Schedule != null && input.Schedule != null && !this.Schedule.SequenceEqual(input.Schedule))) return false;
            if (this.CustomMetricsPath != input.CustomMetricsPath || (this.CustomMetricsPath != null && !this.CustomMetricsPath.Equals(input.CustomMetricsPath))) return false;
            if (this.DeployTimeoutMinutes != input.DeployTimeoutMinutes || (this.DeployTimeoutMinutes != null && !this.DeployTimeoutMinutes.Equals(input.DeployTimeoutMinutes))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.WorkloadType != input.WorkloadType || (this.WorkloadType != null && !this.WorkloadType.Equals(input.WorkloadType))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                if (this.GroupConfigs != null) hashCode = hashCode * 59 + this.GroupConfigs.GetHashCode();
                if (this.RuntimeConfig != null) hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                if (this.UpgradeConfig != null) hashCode = hashCode * 59 + this.UpgradeConfig.GetHashCode();
                if (this.LtsStrategy != null) hashCode = hashCode * 59 + this.LtsStrategy.GetHashCode();
                if (this.LogConfigs != null) hashCode = hashCode * 59 + this.LogConfigs.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.WorkspaceId != null) hashCode = hashCode * 59 + this.WorkspaceId.GetHashCode();
                if (this.Schedule != null) hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.CustomMetricsPath != null) hashCode = hashCode * 59 + this.CustomMetricsPath.GetHashCode();
                if (this.DeployTimeoutMinutes != null) hashCode = hashCode * 59 + this.DeployTimeoutMinutes.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.WorkloadType != null) hashCode = hashCode * 59 + this.WorkloadType.GetHashCode();
                return hashCode;
            }
        }
    }
}
