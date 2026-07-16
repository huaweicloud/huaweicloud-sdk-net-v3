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
    /// **参数解释：** 推理单元配置。 **约束限制：** 单机推理时，个数只会为1；如果是分布式推理时，根据不同框架，实例单元配置可灵活配置。
    /// </summary>
    public class UnitConfig 
    {

        /// <summary>
        /// **参数解释：** 实例单元ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 实例单元角色名称。 **约束限制：** 最大长度为16字符，且需满足正则：^\\[a-z0-9]([-a-z0-9]*[a-z0-9])?$ **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 实例单元角色。 **约束限制：** 不涉及。 **取值范围：** - COMMON：表示其他角色。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("custom_spec", NullValueHandling = NullValueHandling.Ignore)]
        public CustomResourceSpec CustomSpec { get; set; }

        /// <summary>
        /// **参数解释：** 资源规格，根据所提供版本选择适合业务的规格。当specification为custom为自定义规格。由custom_spec指定部署的规格配置。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// **参数解释：** 资源规格的显示名称。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("flavor_display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FlavorDisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("image", NullValueHandling = NullValueHandling.Ignore)]
        public ImageInfo Image { get; set; }

        /// <summary>
        /// **参数解释：** 废弃参数，推荐使用files进行模型相关配置。 模型相关配置，用户可以在此处选择模型及权重文件配合镜像使用。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("models", NullValueHandling = NullValueHandling.Ignore)]
        public List<ModelResource> Models { get; set; }

        /// <summary>
        /// **参数解释：** 废弃参数，推荐使用files进行代码相关配置。 代码相关配置，用户可以在此处选择代码所在的obs路径等。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("codes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Code> Codes { get; set; }

        /// <summary>
        /// **参数解释：** 模型和代码相关配置，用户可以在此处选择模型及权重文件配合镜像使用以及代码所在的obs路径等。 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("files", NullValueHandling = NullValueHandling.Ignore)]
        public List<FileInfo> Files { get; set; }

        /// <summary>
        /// **参数解释：** 用户转储配置，用户可以在此处选择要转储的目的obs。 **约束限制：** 最多配置20组。
        /// </summary>
        [JsonProperty("dumps", NullValueHandling = NullValueHandling.Ignore)]
        public List<Dump> Dumps { get; set; }

        /// <summary>
        /// **参数解释：** 配置实例个数。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("count", NullValueHandling = NullValueHandling.Ignore)]
        public int? Count { get; set; }

        /// <summary>
        /// **参数解释：** 启动命令。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("cmd", NullValueHandling = NullValueHandling.Ignore)]
        public string Cmd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("termination_grace", NullValueHandling = NullValueHandling.Ignore)]
        public TerminationGrace TerminationGrace { get; set; }

        /// <summary>
        /// **参数解释：** 环境变量。 **约束限制：** 变量键长度不大于64，由字母、数字、下划线、中划线、点组成，不能以数字开头。值的输入内容不能存在HTML标签，包括&lt;^&gt;。
        /// </summary>
        [JsonProperty("envs", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("readiness_health", NullValueHandling = NullValueHandling.Ignore)]
        public Health ReadinessHealth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("startup_health", NullValueHandling = NullValueHandling.Ignore)]
        public Health StartupHealth { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("liveness_health", NullValueHandling = NullValueHandling.Ignore)]
        public Health LivenessHealth { get; set; }

        /// <summary>
        /// **参数解释：** 端口。 **约束限制：** 不涉及。 **取值范围：** [1,65535]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数解释：** 自动重建策略，开启后，由于部署配置变更或者故障等原因导致Pod重启时，平台将按策略自动执行重建。若不开启，平台将不会主动干预处理。 **约束限制：** 不涉及。 **取值范围：** - Instance：部署副本重建，故障时重新拉起整个部署。 - Role：单元重建，当部署单元内的Pod出现故障时，重启该单元内的所有Pod。 - Pod：Pod重建，故障时重新拉起故障pod。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("recovery", NullValueHandling = NullValueHandling.Ignore)]
        public string Recovery { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启恢复策略。 **约束限制：** 不涉及。 **取值范围：** - true：开启恢复策略。 - false：不开启恢复策略。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("npu_reset_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NpuResetEnable { get; set; }

        /// <summary>
        /// **参数解释：** 单元副本数，当部署类型deploy_type为SINGLE或工作负载类型workload_type为DEPLOYMENT时，该参数无效。 **约束限制：** 不涉及。 **取值范围：** [1, 100] 或者为空。 **默认取值：** 默认值为1。
        /// </summary>
        [JsonProperty("group_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("affinity", NullValueHandling = NullValueHandling.Ignore)]
        public Affinity Affinity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("security_config", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// **参数解释：** 节点池资源规格。 **约束限制：** 只能包含字母、数字、点、中划线和下划线。 **取值范围：** 长度不超过128字符。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("pool_resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UnitConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  role: ").Append(Role).Append("\n");
            sb.Append("  customSpec: ").Append(CustomSpec).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  flavorDisplayName: ").Append(FlavorDisplayName).Append("\n");
            sb.Append("  image: ").Append(Image).Append("\n");
            sb.Append("  models: ").Append(Models).Append("\n");
            sb.Append("  codes: ").Append(Codes).Append("\n");
            sb.Append("  files: ").Append(Files).Append("\n");
            sb.Append("  dumps: ").Append(Dumps).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  cmd: ").Append(Cmd).Append("\n");
            sb.Append("  terminationGrace: ").Append(TerminationGrace).Append("\n");
            sb.Append("  envs: ").Append(Envs).Append("\n");
            sb.Append("  readinessHealth: ").Append(ReadinessHealth).Append("\n");
            sb.Append("  startupHealth: ").Append(StartupHealth).Append("\n");
            sb.Append("  livenessHealth: ").Append(LivenessHealth).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  recovery: ").Append(Recovery).Append("\n");
            sb.Append("  npuResetEnable: ").Append(NpuResetEnable).Append("\n");
            sb.Append("  groupCount: ").Append(GroupCount).Append("\n");
            sb.Append("  affinity: ").Append(Affinity).Append("\n");
            sb.Append("  securityConfig: ").Append(SecurityConfig).Append("\n");
            sb.Append("  poolResourceFlavor: ").Append(PoolResourceFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UnitConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UnitConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Role != input.Role || (this.Role != null && !this.Role.Equals(input.Role))) return false;
            if (this.CustomSpec != input.CustomSpec || (this.CustomSpec != null && !this.CustomSpec.Equals(input.CustomSpec))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.FlavorDisplayName != input.FlavorDisplayName || (this.FlavorDisplayName != null && !this.FlavorDisplayName.Equals(input.FlavorDisplayName))) return false;
            if (this.Image != input.Image || (this.Image != null && !this.Image.Equals(input.Image))) return false;
            if (this.Models != input.Models || (this.Models != null && input.Models != null && !this.Models.SequenceEqual(input.Models))) return false;
            if (this.Codes != input.Codes || (this.Codes != null && input.Codes != null && !this.Codes.SequenceEqual(input.Codes))) return false;
            if (this.Files != input.Files || (this.Files != null && input.Files != null && !this.Files.SequenceEqual(input.Files))) return false;
            if (this.Dumps != input.Dumps || (this.Dumps != null && input.Dumps != null && !this.Dumps.SequenceEqual(input.Dumps))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.Cmd != input.Cmd || (this.Cmd != null && !this.Cmd.Equals(input.Cmd))) return false;
            if (this.TerminationGrace != input.TerminationGrace || (this.TerminationGrace != null && !this.TerminationGrace.Equals(input.TerminationGrace))) return false;
            if (this.Envs != input.Envs || (this.Envs != null && input.Envs != null && !this.Envs.SequenceEqual(input.Envs))) return false;
            if (this.ReadinessHealth != input.ReadinessHealth || (this.ReadinessHealth != null && !this.ReadinessHealth.Equals(input.ReadinessHealth))) return false;
            if (this.StartupHealth != input.StartupHealth || (this.StartupHealth != null && !this.StartupHealth.Equals(input.StartupHealth))) return false;
            if (this.LivenessHealth != input.LivenessHealth || (this.LivenessHealth != null && !this.LivenessHealth.Equals(input.LivenessHealth))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Recovery != input.Recovery || (this.Recovery != null && !this.Recovery.Equals(input.Recovery))) return false;
            if (this.NpuResetEnable != input.NpuResetEnable || (this.NpuResetEnable != null && !this.NpuResetEnable.Equals(input.NpuResetEnable))) return false;
            if (this.GroupCount != input.GroupCount || (this.GroupCount != null && !this.GroupCount.Equals(input.GroupCount))) return false;
            if (this.Affinity != input.Affinity || (this.Affinity != null && !this.Affinity.Equals(input.Affinity))) return false;
            if (this.SecurityConfig != input.SecurityConfig || (this.SecurityConfig != null && !this.SecurityConfig.Equals(input.SecurityConfig))) return false;
            if (this.PoolResourceFlavor != input.PoolResourceFlavor || (this.PoolResourceFlavor != null && !this.PoolResourceFlavor.Equals(input.PoolResourceFlavor))) return false;

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
                if (this.Role != null) hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.CustomSpec != null) hashCode = hashCode * 59 + this.CustomSpec.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.FlavorDisplayName != null) hashCode = hashCode * 59 + this.FlavorDisplayName.GetHashCode();
                if (this.Image != null) hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.Models != null) hashCode = hashCode * 59 + this.Models.GetHashCode();
                if (this.Codes != null) hashCode = hashCode * 59 + this.Codes.GetHashCode();
                if (this.Files != null) hashCode = hashCode * 59 + this.Files.GetHashCode();
                if (this.Dumps != null) hashCode = hashCode * 59 + this.Dumps.GetHashCode();
                if (this.Count != null) hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.Cmd != null) hashCode = hashCode * 59 + this.Cmd.GetHashCode();
                if (this.TerminationGrace != null) hashCode = hashCode * 59 + this.TerminationGrace.GetHashCode();
                if (this.Envs != null) hashCode = hashCode * 59 + this.Envs.GetHashCode();
                if (this.ReadinessHealth != null) hashCode = hashCode * 59 + this.ReadinessHealth.GetHashCode();
                if (this.StartupHealth != null) hashCode = hashCode * 59 + this.StartupHealth.GetHashCode();
                if (this.LivenessHealth != null) hashCode = hashCode * 59 + this.LivenessHealth.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Recovery != null) hashCode = hashCode * 59 + this.Recovery.GetHashCode();
                if (this.NpuResetEnable != null) hashCode = hashCode * 59 + this.NpuResetEnable.GetHashCode();
                if (this.GroupCount != null) hashCode = hashCode * 59 + this.GroupCount.GetHashCode();
                if (this.Affinity != null) hashCode = hashCode * 59 + this.Affinity.GetHashCode();
                if (this.SecurityConfig != null) hashCode = hashCode * 59 + this.SecurityConfig.GetHashCode();
                if (this.PoolResourceFlavor != null) hashCode = hashCode * 59 + this.PoolResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
