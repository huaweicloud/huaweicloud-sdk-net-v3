using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// **参数解释：** 创建域名时同步配置的配置项，创建域名后可通过\&quot;修改域名全量配置\&quot;接口再次调整 **约束限制：** 不涉及
    /// </summary>
    public class CreateDomainConfigs 
    {

        /// <summary>
        /// **参数解释：** 将源站返回的错误状态码缓存到CDN节点，用户再次请求时由CDN直接响应给用户错误码 **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("error_code_cache", NullValueHandling = NullValueHandling.Ignore)]
        public List<ErrorCodeCache> ErrorCodeCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ip_filter", NullValueHandling = NullValueHandling.Ignore)]
        public IpFilter IpFilter { get; set; }

        /// <summary>
        /// **参数解释：** 设置用量封顶阈值，当实际用量大于阈值时停用域名，有效预防流量盗刷或恶意攻击带来的高额账单。  &gt; 由于监控数据存在时延，域名将在用量达到阈值后的10分钟左右被停用  **约束限制：** 不涉及
        /// </summary>
        [JsonProperty("flow_limit_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public List<FlowLimitStrategy> FlowLimitStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bandwidth_alarm_strategy", NullValueHandling = NullValueHandling.Ignore)]
        public BandwidthAlarmStrategy BandwidthAlarmStrategy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainConfigs {\n");
            sb.Append("  errorCodeCache: ").Append(ErrorCodeCache).Append("\n");
            sb.Append("  ipFilter: ").Append(IpFilter).Append("\n");
            sb.Append("  flowLimitStrategy: ").Append(FlowLimitStrategy).Append("\n");
            sb.Append("  bandwidthAlarmStrategy: ").Append(BandwidthAlarmStrategy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDomainConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDomainConfigs input)
        {
            if (input == null) return false;
            if (this.ErrorCodeCache != input.ErrorCodeCache || (this.ErrorCodeCache != null && input.ErrorCodeCache != null && !this.ErrorCodeCache.SequenceEqual(input.ErrorCodeCache))) return false;
            if (this.IpFilter != input.IpFilter || (this.IpFilter != null && !this.IpFilter.Equals(input.IpFilter))) return false;
            if (this.FlowLimitStrategy != input.FlowLimitStrategy || (this.FlowLimitStrategy != null && input.FlowLimitStrategy != null && !this.FlowLimitStrategy.SequenceEqual(input.FlowLimitStrategy))) return false;
            if (this.BandwidthAlarmStrategy != input.BandwidthAlarmStrategy || (this.BandwidthAlarmStrategy != null && !this.BandwidthAlarmStrategy.Equals(input.BandwidthAlarmStrategy))) return false;

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
                if (this.ErrorCodeCache != null) hashCode = hashCode * 59 + this.ErrorCodeCache.GetHashCode();
                if (this.IpFilter != null) hashCode = hashCode * 59 + this.IpFilter.GetHashCode();
                if (this.FlowLimitStrategy != null) hashCode = hashCode * 59 + this.FlowLimitStrategy.GetHashCode();
                if (this.BandwidthAlarmStrategy != null) hashCode = hashCode * 59 + this.BandwidthAlarmStrategy.GetHashCode();
                return hashCode;
            }
        }
    }
}
