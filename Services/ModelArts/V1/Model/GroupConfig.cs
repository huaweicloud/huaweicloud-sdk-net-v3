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
    /// **参数解释：** 服务实例组配置，当推理方式为BATCH/EDGE时仅支持配置一个模型；当推理方式为REAL_TIME时，可根据业务需要配置多个服务实例并分配权重。 **约束限制：** 不涉及
    /// </summary>
    public class GroupConfig 
    {
        /// <summary>
        /// **参数解释：** 服务框架。 **约束限制：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **取值范围：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **默认取值：** COMMON。
        /// </summary>
        /// <value>**参数解释：** 服务框架。 **约束限制：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **取值范围：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **默认取值：** COMMON。</value>
        [JsonConverter(typeof(EnumClassConverter<FrameworkEnum>))]
        public class FrameworkEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly FrameworkEnum COMMON = new FrameworkEnum("COMMON");

            /// <summary>
            /// Enum VLLM for value: VLLM
            /// </summary>
            public static readonly FrameworkEnum VLLM = new FrameworkEnum("VLLM");

            /// <summary>
            /// Enum MINDIE for value: MINDIE
            /// </summary>
            public static readonly FrameworkEnum MINDIE = new FrameworkEnum("MINDIE");

            private static readonly Dictionary<string, FrameworkEnum> StaticFields =
            new Dictionary<string, FrameworkEnum>()
            {
                { "COMMON", COMMON },
                { "VLLM", VLLM },
                { "MINDIE", MINDIE },
            };

            private string _value;

            public FrameworkEnum()
            {

            }

            public FrameworkEnum(string value)
            {
                _value = value;
            }

            public static FrameworkEnum FromValue(string value)
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

                if (this.Equals(obj as FrameworkEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FrameworkEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FrameworkEnum a, FrameworkEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(FrameworkEnum a, FrameworkEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 部署ID。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 部署名称。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 资源池ID，查询指定资源池下的服务，默认不过滤。可通过[查询资源池列表](ShowPool.xml)获取。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
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
        /// **参数解释：** 推理单元配置。 **约束限制：** 单机推理时，个数只会为1；如果是分布式推理时，根据不同框架，实例单元配置可灵活配置。
        /// </summary>
        [JsonProperty("unit_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<UnitConfig> UnitConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 权重百分比，分配到此模型的流量权重，仅当模型部署为在线服务时需要配置。 **约束限制：** 不涉及。 **取值范围：** [0, 100]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("weight", NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; }

        /// <summary>
        /// **参数解释：** 凭证类型相关配置，用户可以在此处选择使用的凭证类型（dew，agency） **约束限制：** 1.使用临时委托凭证类型约束限制:集群已安装CCE容器存储（Everest）v2.4.204及以上版本，且集群版本为v1.28及以上且确保局点已启用IAM5服务。 2.若插件版本不足或集群不支持临时委托凭证，则需通过DEW服务挂载。 **取值范围：** - [dew：DEW密钥。](tag:hws,hws_hk,fcs) - agency：临时委托凭证。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("secret_type", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretType { get; set; }

        /// <summary>
        /// **参数解释**： 凭证名称，用户使用dew类型凭证时可以在此处选择使用的凭证。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("secret_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretName { get; set; }

        /// <summary>
        /// **参数解释：** 服务优先级。 **约束限制：** - 如服务处于\&quot;运行中\&quot;，priority字段为必要参数，且value必须与原服务的priority值相同； - 如服务处于\&quot;停止\&quot;，priority字段为非必要参数。 **取值范围：** [1, 3]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// **参数解释：** 高可用开关，开启后不同实例的pod将尽量均匀分布到不同的节点上。（准备下线，请使用schedule_strategy字段） **约束限制：** 不涉及。 **取值范围：** - true：高可用开启。 - false：高可用关闭。 **默认取值：** true。
        /// </summary>
        [JsonProperty("high_avail_switch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HighAvailSwitch { get; set; }

        /// <summary>
        /// **参数解释：** 调度策略。 **约束限制：** 不涉及。 **取值范围：** - HIGH_AVAILABILITY：高可用调度 - HIGH_UTILIZATION：紧凑调度 - HIGH_PERFORMANCE：高性能调度 **默认取值：** HIGH_AVAILABILITY。
        /// </summary>
        [JsonProperty("schedule_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleStrategy { get; set; }

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
        /// **参数解释：** 服务备注。 **约束限制：** 不涉及。 **取值范围：** 长度不可以超过512，不能包含大于号，小于号。 **默认取值：** 默认为空。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 服务框架。 **约束限制：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **取值范围：** 仅支持以下枚举值：COMMON | VLLM | MINDIE。 **默认取值：** COMMON。
        /// </summary>
        [JsonProperty("framework", NullValueHandling = NullValueHandling.Ignore)]
        public FrameworkEnum Framework { get; set; }
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
        /// **参数解释：** 工作负载类型。 **取值范围：** - DEPLOYMENT：DEPLOYMENT类型 - LWS：LWS类型
        /// </summary>
        [JsonProperty("workload_type", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkloadType { get; set; }

        /// <summary>
        /// **参数解释：** 更新时间，根据更新时的当前时间自动生成。 **取值范围：** 毫秒级时间戳，13位数字。
        /// </summary>
        [JsonProperty("update_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public ModelResource Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("advanced_config", NullValueHandling = NullValueHandling.Ignore)]
        public AdvancedConfig AdvancedConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  count: ").Append(Count).Append("\n");
            sb.Append("  systemLogDumpEnable: ").Append(SystemLogDumpEnable).Append("\n");
            sb.Append("  unitConfigs: ").Append(UnitConfigs).Append("\n");
            sb.Append("  weight: ").Append(Weight).Append("\n");
            sb.Append("  secretType: ").Append(SecretType).Append("\n");
            sb.Append("  secretName: ").Append(SecretName).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  highAvailSwitch: ").Append(HighAvailSwitch).Append("\n");
            sb.Append("  scheduleStrategy: ").Append(ScheduleStrategy).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  versionId: ").Append(VersionId).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  framework: ").Append(Framework).Append("\n");
            sb.Append("  runningCount: ").Append(RunningCount).Append("\n");
            sb.Append("  deployType: ").Append(DeployType).Append("\n");
            sb.Append("  mirrorTrafficEnable: ").Append(MirrorTrafficEnable).Append("\n");
            sb.Append("  mirrorTrafficWeight: ").Append(MirrorTrafficWeight).Append("\n");
            sb.Append("  versionCount: ").Append(VersionCount).Append("\n");
            sb.Append("  workloadType: ").Append(WorkloadType).Append("\n");
            sb.Append("  updateAt: ").Append(UpdateAt).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  advancedConfig: ").Append(AdvancedConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GroupConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GroupConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.Count != input.Count || (this.Count != null && !this.Count.Equals(input.Count))) return false;
            if (this.SystemLogDumpEnable != input.SystemLogDumpEnable || (this.SystemLogDumpEnable != null && !this.SystemLogDumpEnable.Equals(input.SystemLogDumpEnable))) return false;
            if (this.UnitConfigs != input.UnitConfigs || (this.UnitConfigs != null && input.UnitConfigs != null && !this.UnitConfigs.SequenceEqual(input.UnitConfigs))) return false;
            if (this.Weight != input.Weight || (this.Weight != null && !this.Weight.Equals(input.Weight))) return false;
            if (this.SecretType != input.SecretType || (this.SecretType != null && !this.SecretType.Equals(input.SecretType))) return false;
            if (this.SecretName != input.SecretName || (this.SecretName != null && !this.SecretName.Equals(input.SecretName))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.HighAvailSwitch != input.HighAvailSwitch || (this.HighAvailSwitch != null && !this.HighAvailSwitch.Equals(input.HighAvailSwitch))) return false;
            if (this.ScheduleStrategy != input.ScheduleStrategy || (this.ScheduleStrategy != null && !this.ScheduleStrategy.Equals(input.ScheduleStrategy))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.VersionId != input.VersionId || (this.VersionId != null && !this.VersionId.Equals(input.VersionId))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Framework != input.Framework) return false;
            if (this.RunningCount != input.RunningCount || (this.RunningCount != null && !this.RunningCount.Equals(input.RunningCount))) return false;
            if (this.DeployType != input.DeployType || (this.DeployType != null && !this.DeployType.Equals(input.DeployType))) return false;
            if (this.MirrorTrafficEnable != input.MirrorTrafficEnable || (this.MirrorTrafficEnable != null && !this.MirrorTrafficEnable.Equals(input.MirrorTrafficEnable))) return false;
            if (this.MirrorTrafficWeight != input.MirrorTrafficWeight || (this.MirrorTrafficWeight != null && !this.MirrorTrafficWeight.Equals(input.MirrorTrafficWeight))) return false;
            if (this.VersionCount != input.VersionCount || (this.VersionCount != null && !this.VersionCount.Equals(input.VersionCount))) return false;
            if (this.WorkloadType != input.WorkloadType || (this.WorkloadType != null && !this.WorkloadType.Equals(input.WorkloadType))) return false;
            if (this.UpdateAt != input.UpdateAt || (this.UpdateAt != null && !this.UpdateAt.Equals(input.UpdateAt))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.AdvancedConfig != input.AdvancedConfig || (this.AdvancedConfig != null && !this.AdvancedConfig.Equals(input.AdvancedConfig))) return false;

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
                if (this.SecretType != null) hashCode = hashCode * 59 + this.SecretType.GetHashCode();
                if (this.SecretName != null) hashCode = hashCode * 59 + this.SecretName.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.HighAvailSwitch != null) hashCode = hashCode * 59 + this.HighAvailSwitch.GetHashCode();
                if (this.ScheduleStrategy != null) hashCode = hashCode * 59 + this.ScheduleStrategy.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.VersionId != null) hashCode = hashCode * 59 + this.VersionId.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Framework.GetHashCode();
                if (this.RunningCount != null) hashCode = hashCode * 59 + this.RunningCount.GetHashCode();
                if (this.DeployType != null) hashCode = hashCode * 59 + this.DeployType.GetHashCode();
                if (this.MirrorTrafficEnable != null) hashCode = hashCode * 59 + this.MirrorTrafficEnable.GetHashCode();
                if (this.MirrorTrafficWeight != null) hashCode = hashCode * 59 + this.MirrorTrafficWeight.GetHashCode();
                if (this.VersionCount != null) hashCode = hashCode * 59 + this.VersionCount.GetHashCode();
                if (this.WorkloadType != null) hashCode = hashCode * 59 + this.WorkloadType.GetHashCode();
                if (this.UpdateAt != null) hashCode = hashCode * 59 + this.UpdateAt.GetHashCode();
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.AdvancedConfig != null) hashCode = hashCode * 59 + this.AdvancedConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
