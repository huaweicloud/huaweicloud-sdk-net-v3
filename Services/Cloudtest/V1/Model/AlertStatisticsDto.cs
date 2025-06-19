using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AlertStatisticsDto 
    {

        /// <summary>
        /// 阻塞告警次数
        /// </summary>
        [JsonProperty("block_alert_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlockAlertCount { get; set; }

        /// <summary>
        /// 异常告警次数
        /// </summary>
        [JsonProperty("exception_alert_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExceptionAlertCount { get; set; }

        /// <summary>
        /// 失败告警次数
        /// </summary>
        [JsonProperty("fail_alert_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailAlertCount { get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("service_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 统计时间
        /// </summary>
        [JsonProperty("statistics_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StatisticsTime { get; set; }

        /// <summary>
        /// 超时告警次数
        /// </summary>
        [JsonProperty("timeout_alert_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TimeoutAlertCount { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AlertStatisticsDto {\n");
            sb.Append("  blockAlertCount: ").Append(BlockAlertCount).Append("\n");
            sb.Append("  exceptionAlertCount: ").Append(ExceptionAlertCount).Append("\n");
            sb.Append("  failAlertCount: ").Append(FailAlertCount).Append("\n");
            sb.Append("  serviceId: ").Append(ServiceId).Append("\n");
            sb.Append("  statisticsTime: ").Append(StatisticsTime).Append("\n");
            sb.Append("  timeoutAlertCount: ").Append(TimeoutAlertCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AlertStatisticsDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AlertStatisticsDto input)
        {
            if (input == null) return false;
            if (this.BlockAlertCount != input.BlockAlertCount || (this.BlockAlertCount != null && !this.BlockAlertCount.Equals(input.BlockAlertCount))) return false;
            if (this.ExceptionAlertCount != input.ExceptionAlertCount || (this.ExceptionAlertCount != null && !this.ExceptionAlertCount.Equals(input.ExceptionAlertCount))) return false;
            if (this.FailAlertCount != input.FailAlertCount || (this.FailAlertCount != null && !this.FailAlertCount.Equals(input.FailAlertCount))) return false;
            if (this.ServiceId != input.ServiceId || (this.ServiceId != null && !this.ServiceId.Equals(input.ServiceId))) return false;
            if (this.StatisticsTime != input.StatisticsTime || (this.StatisticsTime != null && !this.StatisticsTime.Equals(input.StatisticsTime))) return false;
            if (this.TimeoutAlertCount != input.TimeoutAlertCount || (this.TimeoutAlertCount != null && !this.TimeoutAlertCount.Equals(input.TimeoutAlertCount))) return false;

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
                if (this.BlockAlertCount != null) hashCode = hashCode * 59 + this.BlockAlertCount.GetHashCode();
                if (this.ExceptionAlertCount != null) hashCode = hashCode * 59 + this.ExceptionAlertCount.GetHashCode();
                if (this.FailAlertCount != null) hashCode = hashCode * 59 + this.FailAlertCount.GetHashCode();
                if (this.ServiceId != null) hashCode = hashCode * 59 + this.ServiceId.GetHashCode();
                if (this.StatisticsTime != null) hashCode = hashCode * 59 + this.StatisticsTime.GetHashCode();
                if (this.TimeoutAlertCount != null) hashCode = hashCode * 59 + this.TimeoutAlertCount.GetHashCode();
                return hashCode;
            }
        }
    }
}
