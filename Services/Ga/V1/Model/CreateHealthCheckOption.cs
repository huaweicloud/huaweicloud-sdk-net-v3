using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ga.V1.Model
{
    /// <summary>
    /// 创建健康检查的详细信息。
    /// </summary>
    public class CreateHealthCheckOption 
    {

        /// <summary>
        /// 终端节点组ID。
        /// </summary>
        [JsonProperty("endpoint_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EndpointGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public HealthCheckProtocol Protocol { get; set; }
        /// <summary>
        /// 健康检查的端口。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 健康检查的时间间隔，单位为秒。
        /// </summary>
        [JsonProperty("interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; }

        /// <summary>
        /// 健康检查的超时时间，单位为秒。建议该值小于interval的值。
        /// </summary>
        [JsonProperty("timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeout { get; set; }

        /// <summary>
        /// 最大重试次数。将终端节点的状态从“健康”设置为“不健康”或从“不健康”设置为“健康”所需的连续健康检查次数。
        /// </summary>
        [JsonProperty("max_retries", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxRetries { get; set; }

        /// <summary>
        /// 是否开启健康检查。
        /// </summary>
        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateHealthCheckOption {\n");
            sb.Append("  endpointGroupId: ").Append(EndpointGroupId).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  interval: ").Append(Interval).Append("\n");
            sb.Append("  timeout: ").Append(Timeout).Append("\n");
            sb.Append("  maxRetries: ").Append(MaxRetries).Append("\n");
            sb.Append("  enabled: ").Append(Enabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateHealthCheckOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateHealthCheckOption input)
        {
            if (input == null) return false;
            if (this.EndpointGroupId != input.EndpointGroupId || (this.EndpointGroupId != null && !this.EndpointGroupId.Equals(input.EndpointGroupId))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.Port != input.Port || (this.Port != null && !this.Port.Equals(input.Port))) return false;
            if (this.Interval != input.Interval || (this.Interval != null && !this.Interval.Equals(input.Interval))) return false;
            if (this.Timeout != input.Timeout || (this.Timeout != null && !this.Timeout.Equals(input.Timeout))) return false;
            if (this.MaxRetries != input.MaxRetries || (this.MaxRetries != null && !this.MaxRetries.Equals(input.MaxRetries))) return false;
            if (this.Enabled != input.Enabled || (this.Enabled != null && !this.Enabled.Equals(input.Enabled))) return false;

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
                if (this.EndpointGroupId != null) hashCode = hashCode * 59 + this.EndpointGroupId.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Port != null) hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Interval != null) hashCode = hashCode * 59 + this.Interval.GetHashCode();
                if (this.Timeout != null) hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                if (this.MaxRetries != null) hashCode = hashCode * 59 + this.MaxRetries.GetHashCode();
                if (this.Enabled != null) hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }
    }
}
