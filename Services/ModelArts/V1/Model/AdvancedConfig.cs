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
    /// 部署高级配置
    /// </summary>
    public class AdvancedConfig 
    {

        /// <summary>
        /// **参数解释：** 部署超时时间
        /// </summary>
        [JsonProperty("deploy_timeout_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public string DeployTimeoutMinutes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upgrade_config", NullValueHandling = NullValueHandling.Ignore)]
        public UpgradeConfig UpgradeConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("service_secret", NullValueHandling = NullValueHandling.Ignore)]
        public ServiceSecret ServiceSecret { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由开关
        /// </summary>
        [JsonProperty("dynamic_routing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicRoutingEnable { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由策略
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }

        /// <summary>
        /// **参数解释：** EMS加速开关
        /// </summary>
        [JsonProperty("ems_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmsEnable { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由指标采集scheme
        /// </summary>
        [JsonProperty("metric_api_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiScheme { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由指标采集端口
        /// </summary>
        [JsonProperty("metric_api_port", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiPort { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由指标采集地址
        /// </summary>
        [JsonProperty("metric_api_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiPath { get; set; }

        /// <summary>
        /// **参数解释：** 自定义监控采集指标地址
        /// </summary>
        [JsonProperty("custom_metrics_path", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomMetricsPath { get; set; }

        /// <summary>
        /// **参数解释：** 容器端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// **参数解释：** 容器请求协议。当选择WSS与WS时，服务接口会升级为WebSocket。开启WebSocket时，不支持同时设置“服务流量限制”。 **取值范围：** - HTTP：HTTP协议。 - HTTPS：HTTPS协议。 - WSS：WebSocket Secure协议。 - WS：WebSocket协议。 - TCP：传输控制协议。 - NA：不使用任何协议。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdvancedConfig {\n");
            sb.Append("  deployTimeoutMinutes: ").Append(DeployTimeoutMinutes).Append("\n");
            sb.Append("  upgradeConfig: ").Append(UpgradeConfig).Append("\n");
            sb.Append("  serviceSecret: ").Append(ServiceSecret).Append("\n");
            sb.Append("  dynamicRoutingEnable: ").Append(DynamicRoutingEnable).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  emsEnable: ").Append(EmsEnable).Append("\n");
            sb.Append("  metricApiScheme: ").Append(MetricApiScheme).Append("\n");
            sb.Append("  metricApiPort: ").Append(MetricApiPort).Append("\n");
            sb.Append("  metricApiPath: ").Append(MetricApiPath).Append("\n");
            sb.Append("  customMetricsPath: ").Append(CustomMetricsPath).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AdvancedConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AdvancedConfig input)
        {
            if (input == null) return false;
            if (this.DeployTimeoutMinutes != input.DeployTimeoutMinutes || (this.DeployTimeoutMinutes != null && !this.DeployTimeoutMinutes.Equals(input.DeployTimeoutMinutes))) return false;
            if (this.UpgradeConfig != input.UpgradeConfig || (this.UpgradeConfig != null && !this.UpgradeConfig.Equals(input.UpgradeConfig))) return false;
            if (this.ServiceSecret != input.ServiceSecret || (this.ServiceSecret != null && !this.ServiceSecret.Equals(input.ServiceSecret))) return false;
            if (this.DynamicRoutingEnable != input.DynamicRoutingEnable || (this.DynamicRoutingEnable != null && !this.DynamicRoutingEnable.Equals(input.DynamicRoutingEnable))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;
            if (this.EmsEnable != input.EmsEnable || (this.EmsEnable != null && !this.EmsEnable.Equals(input.EmsEnable))) return false;
            if (this.MetricApiScheme != input.MetricApiScheme || (this.MetricApiScheme != null && !this.MetricApiScheme.Equals(input.MetricApiScheme))) return false;
            if (this.MetricApiPort != input.MetricApiPort || (this.MetricApiPort != null && !this.MetricApiPort.Equals(input.MetricApiPort))) return false;
            if (this.MetricApiPath != input.MetricApiPath || (this.MetricApiPath != null && !this.MetricApiPath.Equals(input.MetricApiPath))) return false;
            if (this.CustomMetricsPath != input.CustomMetricsPath || (this.CustomMetricsPath != null && !this.CustomMetricsPath.Equals(input.CustomMetricsPath))) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;

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
                if (this.DeployTimeoutMinutes != null) hashCode = hashCode * 59 + this.DeployTimeoutMinutes.GetHashCode();
                if (this.UpgradeConfig != null) hashCode = hashCode * 59 + this.UpgradeConfig.GetHashCode();
                if (this.ServiceSecret != null) hashCode = hashCode * 59 + this.ServiceSecret.GetHashCode();
                if (this.DynamicRoutingEnable != null) hashCode = hashCode * 59 + this.DynamicRoutingEnable.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.EmsEnable != null) hashCode = hashCode * 59 + this.EmsEnable.GetHashCode();
                if (this.MetricApiScheme != null) hashCode = hashCode * 59 + this.MetricApiScheme.GetHashCode();
                if (this.MetricApiPort != null) hashCode = hashCode * 59 + this.MetricApiPort.GetHashCode();
                if (this.MetricApiPath != null) hashCode = hashCode * 59 + this.MetricApiPath.GetHashCode();
                if (this.CustomMetricsPath != null) hashCode = hashCode * 59 + this.CustomMetricsPath.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                return hashCode;
            }
        }
    }
}
