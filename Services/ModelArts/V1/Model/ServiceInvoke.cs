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
    /// **参数解释：** 服务调用时的相关配置。 **约束限制：** 不涉及。
    /// </summary>
    public class ServiceInvoke 
    {

        /// <summary>
        /// **参数解释：** 服务端口号。 **约束限制：**  不涉及。  **取值范围：** [1, 65535]。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 参数解释： 服务请求协议。当选择WSS与WS时，服务接口会升级为WebSocket。开启WebSocket时，不支持同时设置“服务流量限制”。 约束限制： 异步服务仅支持HTTPS, HTTP。 取值范围： HTTP：HTTP协议。 HTTPS：HTTPS协议。 WSS：WebSocket Secure协议。 WS：WebSocket协议。 默认取值： 不涉及。
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public string Protocol { get; set; }

        /// <summary>
        /// **参数解释：** 认证类型。 **约束限制：** 不涉及。 **取值范围：** - TOKEN：IAM Token认证。 - API_KEY：API Key认证。 - NONE：无认证。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// **参数解释：** 外网访问。 不涉及。 **约束限制：** 不涉及。 **取值范围：** - TRUE：要外网访问。 - FALSE：无需内网审批。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("internet_access_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InternetAccessEnable { get; set; }

        /// <summary>
        /// **参数解释：** 内网审批。 **约束限制：** 不涉及。 **取值范围：** - TRUE：要内网审批。 - FALSE：无需内网审批。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("intranet_approval_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntranetApprovalEnable { get; set; }

        /// <summary>
        /// **参数解释：** 动态路由开关。 **约束限制：** 不涉及。 **取值范围：** - TRUE：开启动态路由。 - FALSE：不开启动态路由。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("dynamic_routing_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicRoutingEnable { get; set; }

        /// <summary>
        /// **参数解释：** 智能路由策略。 **约束限制：** 不涉及。 **取值范围：** - ROUND_ROBIN：轮询。 - ORIGIN_IP_HASH：源IP哈希。 - MIN_CONN：最小连接数。 - MIN_FIRST_TOKEN_TIME：最小首token时延。 - COMPOSITE： 综合负载。 - SLO_BASED：SLO优先级。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("strategy", NullValueHandling = NullValueHandling.Ignore)]
        public string Strategy { get; set; }

        /// <summary>
        /// **参数解释：** 指标接口服务请求协议。 **约束限制：** 不涉及。 **取值范围：** - HTTP：HTTP协议。 - HTTPS：HTTPS协议。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("metric_api_scheme", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiScheme { get; set; }

        /// <summary>
        /// **参数解释：** 指标接口端口号。 **约束限制：** 不涉及。 **取值范围：** [1, 65535]。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("metric_api_port", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiPort { get; set; }

        /// <summary>
        /// **参数解释：** 指标接口path。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("metric_api_path", NullValueHandling = NullValueHandling.Ignore)]
        public string MetricApiPath { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启EMS加速。 **约束限制：** 不涉及。 **取值范围：** - TRUE：开启EMS加速。 - FALSE：不开启EMS加速。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("ems_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmsEnable { get; set; }

        /// <summary>
        /// **参数解释：** proxy支持请求重调度开关。 **约束限制：** 不涉及。 **取值范围：** - true：开启proxy支持请求重调度。 - false：不开启proxy支持请求重调度。 **默认取值：** false
        /// </summary>
        [JsonProperty("request_retry_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequestRetryEnable { get; set; }

        /// <summary>
        /// **参数解释：** proxy支持请求重调度的重试次数 **约束限制：**  不涉及。  **取值范围：** [1, 10]。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("request_retry_cnt_max", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestRetryCntMax { get; set; }

        /// <summary>
        /// **参数解释：** proxy支持请求重调度的重试间隔，单位ms **约束限制：**  不涉及。  **取值范围：** [1, 10000]。 **默认取值：**  不涉及。
        /// </summary>
        [JsonProperty("request_retry_interval_ms", NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestRetryIntervalMs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("fuse_configs", NullValueHandling = NullValueHandling.Ignore)]
        public FuseConfig FuseConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceInvoke {\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  internetAccessEnable: ").Append(InternetAccessEnable).Append("\n");
            sb.Append("  intranetApprovalEnable: ").Append(IntranetApprovalEnable).Append("\n");
            sb.Append("  dynamicRoutingEnable: ").Append(DynamicRoutingEnable).Append("\n");
            sb.Append("  strategy: ").Append(Strategy).Append("\n");
            sb.Append("  metricApiScheme: ").Append(MetricApiScheme).Append("\n");
            sb.Append("  metricApiPort: ").Append(MetricApiPort).Append("\n");
            sb.Append("  metricApiPath: ").Append(MetricApiPath).Append("\n");
            sb.Append("  emsEnable: ").Append(EmsEnable).Append("\n");
            sb.Append("  requestRetryEnable: ").Append(RequestRetryEnable).Append("\n");
            sb.Append("  requestRetryCntMax: ").Append(RequestRetryCntMax).Append("\n");
            sb.Append("  requestRetryIntervalMs: ").Append(RequestRetryIntervalMs).Append("\n");
            sb.Append("  fuseConfigs: ").Append(FuseConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceInvoke);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceInvoke input)
        {
            if (input == null) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Protocol != input.Protocol || (this.Protocol != null && !this.Protocol.Equals(input.Protocol))) return false;
            if (this.AuthType != input.AuthType || (this.AuthType != null && !this.AuthType.Equals(input.AuthType))) return false;
            if (this.InternetAccessEnable != input.InternetAccessEnable || (this.InternetAccessEnable != null && !this.InternetAccessEnable.Equals(input.InternetAccessEnable))) return false;
            if (this.IntranetApprovalEnable != input.IntranetApprovalEnable || (this.IntranetApprovalEnable != null && !this.IntranetApprovalEnable.Equals(input.IntranetApprovalEnable))) return false;
            if (this.DynamicRoutingEnable != input.DynamicRoutingEnable || (this.DynamicRoutingEnable != null && !this.DynamicRoutingEnable.Equals(input.DynamicRoutingEnable))) return false;
            if (this.Strategy != input.Strategy || (this.Strategy != null && !this.Strategy.Equals(input.Strategy))) return false;
            if (this.MetricApiScheme != input.MetricApiScheme || (this.MetricApiScheme != null && !this.MetricApiScheme.Equals(input.MetricApiScheme))) return false;
            if (this.MetricApiPort != input.MetricApiPort || (this.MetricApiPort != null && !this.MetricApiPort.Equals(input.MetricApiPort))) return false;
            if (this.MetricApiPath != input.MetricApiPath || (this.MetricApiPath != null && !this.MetricApiPath.Equals(input.MetricApiPath))) return false;
            if (this.EmsEnable != input.EmsEnable || (this.EmsEnable != null && !this.EmsEnable.Equals(input.EmsEnable))) return false;
            if (this.RequestRetryEnable != input.RequestRetryEnable || (this.RequestRetryEnable != null && !this.RequestRetryEnable.Equals(input.RequestRetryEnable))) return false;
            if (this.RequestRetryCntMax != input.RequestRetryCntMax || (this.RequestRetryCntMax != null && !this.RequestRetryCntMax.Equals(input.RequestRetryCntMax))) return false;
            if (this.RequestRetryIntervalMs != input.RequestRetryIntervalMs || (this.RequestRetryIntervalMs != null && !this.RequestRetryIntervalMs.Equals(input.RequestRetryIntervalMs))) return false;
            if (this.FuseConfigs != input.FuseConfigs || (this.FuseConfigs != null && !this.FuseConfigs.Equals(input.FuseConfigs))) return false;

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
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Protocol != null) hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.AuthType != null) hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.InternetAccessEnable != null) hashCode = hashCode * 59 + this.InternetAccessEnable.GetHashCode();
                if (this.IntranetApprovalEnable != null) hashCode = hashCode * 59 + this.IntranetApprovalEnable.GetHashCode();
                if (this.DynamicRoutingEnable != null) hashCode = hashCode * 59 + this.DynamicRoutingEnable.GetHashCode();
                if (this.Strategy != null) hashCode = hashCode * 59 + this.Strategy.GetHashCode();
                if (this.MetricApiScheme != null) hashCode = hashCode * 59 + this.MetricApiScheme.GetHashCode();
                if (this.MetricApiPort != null) hashCode = hashCode * 59 + this.MetricApiPort.GetHashCode();
                if (this.MetricApiPath != null) hashCode = hashCode * 59 + this.MetricApiPath.GetHashCode();
                if (this.EmsEnable != null) hashCode = hashCode * 59 + this.EmsEnable.GetHashCode();
                if (this.RequestRetryEnable != null) hashCode = hashCode * 59 + this.RequestRetryEnable.GetHashCode();
                if (this.RequestRetryCntMax != null) hashCode = hashCode * 59 + this.RequestRetryCntMax.GetHashCode();
                if (this.RequestRetryIntervalMs != null) hashCode = hashCode * 59 + this.RequestRetryIntervalMs.GetHashCode();
                if (this.FuseConfigs != null) hashCode = hashCode * 59 + this.FuseConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
