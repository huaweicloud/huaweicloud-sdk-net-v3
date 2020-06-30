using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskPolicy 
    {

        /// <summary>
        /// 批量任务指定执行时间，取值范围为7天内，不传入此参数表示立即执行，格式：yyyyMMdd&#39;T&#39;HHmmss&#39;Z&#39;，如20151212T121212Z。
        /// </summary>
        [JsonProperty("schedule_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 批量任务子任务自动重试次数，如果传入retry_interval参数，则需传入该参数，最大支持重试5次。
        /// </summary>
        [JsonProperty("retry_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryCount { get; set; }

        /// <summary>
        /// 批量任务子任务失败后，自动重试时间间隔，单位：分钟，最大1440(24小时)，不传入此参数表示不重试，如果传入retry_count参数则需要传入该参数。
        /// </summary>
        [JsonProperty("retry_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? RetryInterval { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskPolicy {\n");
            sb.Append("  scheduleTime: ").Append(ScheduleTime).Append("\n");
            sb.Append("  retryCount: ").Append(RetryCount).Append("\n");
            sb.Append("  retryInterval: ").Append(RetryInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskPolicy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScheduleTime == input.ScheduleTime ||
                    (this.ScheduleTime != null &&
                    this.ScheduleTime.Equals(input.ScheduleTime))
                ) && 
                (
                    this.RetryCount == input.RetryCount ||
                    (this.RetryCount != null &&
                    this.RetryCount.Equals(input.RetryCount))
                ) && 
                (
                    this.RetryInterval == input.RetryInterval ||
                    (this.RetryInterval != null &&
                    this.RetryInterval.Equals(input.RetryInterval))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ScheduleTime != null)
                    hashCode = hashCode * 59 + this.ScheduleTime.GetHashCode();
                if (this.RetryCount != null)
                    hashCode = hashCode * 59 + this.RetryCount.GetHashCode();
                if (this.RetryInterval != null)
                    hashCode = hashCode * 59 + this.RetryInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
