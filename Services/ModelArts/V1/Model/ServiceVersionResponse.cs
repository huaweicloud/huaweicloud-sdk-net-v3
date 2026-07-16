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
    /// **参数解释：** 当前服务版本信息。
    /// </summary>
    public class ServiceVersionResponse 
    {

        /// <summary>
        /// **参数解释：** 版本id。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 版本号。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释：** 描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 推理请求的访问地址。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("predict_url", NullValueHandling = NullValueHandling.Ignore)]
        public string PredictUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("runtime_config", NullValueHandling = NullValueHandling.Ignore)]
        public RuntimeConfigResponse RuntimeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upgrade_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeConfigResponse UpgradeConfig { get; set; }

        /// <summary>
        /// **参数解释：** 服务部署信息。
        /// </summary>
        [JsonProperty("instance_groups", NullValueHandling = NullValueHandling.Ignore)]
        public List<GroupConfigResponse> InstanceGroups { get; set; }

        /// <summary>
        /// **参数解释：** 日志策略。 **取值范围：** - POOL：使用资源池日志插件配置的日志流。 - AUTO_CREATE：自动创建日志流。 - DEFAULT: 由系统决定日志策略
        /// </summary>
        [JsonProperty("lts_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStrategy { get; set; }

        /// <summary>
        /// **参数解释：** 部署对接lts状态。 **取值范围：** - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("lts_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStatus { get; set; }

        /// <summary>
        /// **参数解释：** 部署对接lts k8s事件状态。 **取值范围：** - ON：开启。 - OFF：关闭。
        /// </summary>
        [JsonProperty("lts_event_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsEventStatus { get; set; }

        /// <summary>
        /// **参数解释：** 服务日志配置信息。
        /// </summary>
        [JsonProperty("log_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<LogConfigResponse> LogConfigs { get; set; }

        /// <summary>
        /// **参数解释：** 部署超时时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("deploy_timeout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeployTimeoutMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceVersionResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  predictUrl: ").Append(PredictUrl).Append("\n");
            sb.Append("  runtimeConfig: ").Append(RuntimeConfig).Append("\n");
            sb.Append("  upgradeConfig: ").Append(UpgradeConfig).Append("\n");
            sb.Append("  instanceGroups: ").Append(InstanceGroups).Append("\n");
            sb.Append("  ltsStrategy: ").Append(LtsStrategy).Append("\n");
            sb.Append("  ltsStatus: ").Append(LtsStatus).Append("\n");
            sb.Append("  ltsEventStatus: ").Append(LtsEventStatus).Append("\n");
            sb.Append("  logConfigs: ").Append(LogConfigs).Append("\n");
            sb.Append("  deployTimeoutMinutes: ").Append(DeployTimeoutMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceVersionResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceVersionResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.PredictUrl != input.PredictUrl || (this.PredictUrl != null && !this.PredictUrl.Equals(input.PredictUrl))) return false;
            if (this.RuntimeConfig != input.RuntimeConfig || (this.RuntimeConfig != null && !this.RuntimeConfig.Equals(input.RuntimeConfig))) return false;
            if (this.UpgradeConfig != input.UpgradeConfig || (this.UpgradeConfig != null && !this.UpgradeConfig.Equals(input.UpgradeConfig))) return false;
            if (this.InstanceGroups != input.InstanceGroups || (this.InstanceGroups != null && input.InstanceGroups != null && !this.InstanceGroups.SequenceEqual(input.InstanceGroups))) return false;
            if (this.LtsStrategy != input.LtsStrategy || (this.LtsStrategy != null && !this.LtsStrategy.Equals(input.LtsStrategy))) return false;
            if (this.LtsStatus != input.LtsStatus || (this.LtsStatus != null && !this.LtsStatus.Equals(input.LtsStatus))) return false;
            if (this.LtsEventStatus != input.LtsEventStatus || (this.LtsEventStatus != null && !this.LtsEventStatus.Equals(input.LtsEventStatus))) return false;
            if (this.LogConfigs != input.LogConfigs || (this.LogConfigs != null && input.LogConfigs != null && !this.LogConfigs.SequenceEqual(input.LogConfigs))) return false;
            if (this.DeployTimeoutMinutes != input.DeployTimeoutMinutes || (this.DeployTimeoutMinutes != null && !this.DeployTimeoutMinutes.Equals(input.DeployTimeoutMinutes))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.PredictUrl != null) hashCode = hashCode * 59 + this.PredictUrl.GetHashCode();
                if (this.RuntimeConfig != null) hashCode = hashCode * 59 + this.RuntimeConfig.GetHashCode();
                if (this.UpgradeConfig != null) hashCode = hashCode * 59 + this.UpgradeConfig.GetHashCode();
                if (this.InstanceGroups != null) hashCode = hashCode * 59 + this.InstanceGroups.GetHashCode();
                if (this.LtsStrategy != null) hashCode = hashCode * 59 + this.LtsStrategy.GetHashCode();
                if (this.LtsStatus != null) hashCode = hashCode * 59 + this.LtsStatus.GetHashCode();
                if (this.LtsEventStatus != null) hashCode = hashCode * 59 + this.LtsEventStatus.GetHashCode();
                if (this.LogConfigs != null) hashCode = hashCode * 59 + this.LogConfigs.GetHashCode();
                if (this.DeployTimeoutMinutes != null) hashCode = hashCode * 59 + this.DeployTimeoutMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
