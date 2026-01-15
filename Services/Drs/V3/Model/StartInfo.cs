using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V3.Model
{
    /// <summary>
    /// 启动任务请求体。
    /// </summary>
    public class StartInfo 
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 是否支持只初始化任务。仅支持白名单用户使用，需要提交工单申请才能使用。
        /// </summary>
        [JsonProperty("is_only_init_task", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnlyInitTask { get; set; }

        /// <summary>
        /// 是否在任务结束时自动创建对比任务，不填默认设置为true。
        /// </summary>
        [JsonProperty("is_auto_create_compare", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoCreateCompare { get; set; }

        /// <summary>
        /// 任务启动时间，时间戳格式精确到毫秒，例如：1679966489593，取值为空代表立即启动。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartInfo {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  isOnlyInitTask: ").Append(IsOnlyInitTask).Append("\n");
            sb.Append("  isAutoCreateCompare: ").Append(IsAutoCreateCompare).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as StartInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(StartInfo input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.IsOnlyInitTask != input.IsOnlyInitTask || (this.IsOnlyInitTask != null && !this.IsOnlyInitTask.Equals(input.IsOnlyInitTask))) return false;
            if (this.IsAutoCreateCompare != input.IsAutoCreateCompare || (this.IsAutoCreateCompare != null && !this.IsAutoCreateCompare.Equals(input.IsAutoCreateCompare))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.IsOnlyInitTask != null) hashCode = hashCode * 59 + this.IsOnlyInitTask.GetHashCode();
                if (this.IsAutoCreateCompare != null) hashCode = hashCode * 59 + this.IsAutoCreateCompare.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
