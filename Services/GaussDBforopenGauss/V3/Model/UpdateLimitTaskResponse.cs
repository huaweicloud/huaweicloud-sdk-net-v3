using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateLimitTaskResponse : SdkResponse
    {

        /// <summary>
        /// 限流任务ID。
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// CN节点数据库组,每个数据库字符串以逗号形式隔开，仅当任务类型为SQL_TYPE时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("databases", NullValueHandling = NullValueHandling.Ignore)]
        public string Databases { get; set; }

        /// <summary>
        /// 限流任务名，与请求参数相同。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 关键词，仅当任务类型为SQL_TYPE时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("key_words", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyWords { get; set; }

        /// <summary>
        /// 并发数，与请求参数相同。
        /// </summary>
        [JsonProperty("parallel_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelSize { get; set; }

        /// <summary>
        /// 限流任务开始时间，格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间，SQL范围返回该值。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 限流任务结束时间，格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间，SQL范围返回该值。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// cpu利用率，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且只保留正整数。
        /// </summary>
        [JsonProperty("cpu_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUtilization { get; set; }

        /// <summary>
        /// 内存利用率，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且只保留正整数。
        /// </summary>
        [JsonProperty("memory_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUtilization { get; set; }

        /// <summary>
        /// 规则名。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 工作流ID。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLimitTaskResponse {\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  databases: ").Append(Databases).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  keyWords: ").Append(KeyWords).Append("\n");
            sb.Append("  parallelSize: ").Append(ParallelSize).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  cpuUtilization: ").Append(CpuUtilization).Append("\n");
            sb.Append("  memoryUtilization: ").Append(MemoryUtilization).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLimitTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLimitTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.Databases != input.Databases || (this.Databases != null && !this.Databases.Equals(input.Databases))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.KeyWords != input.KeyWords || (this.KeyWords != null && !this.KeyWords.Equals(input.KeyWords))) return false;
            if (this.ParallelSize != input.ParallelSize || (this.ParallelSize != null && !this.ParallelSize.Equals(input.ParallelSize))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.CpuUtilization != input.CpuUtilization || (this.CpuUtilization != null && !this.CpuUtilization.Equals(input.CpuUtilization))) return false;
            if (this.MemoryUtilization != input.MemoryUtilization || (this.MemoryUtilization != null && !this.MemoryUtilization.Equals(input.MemoryUtilization))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Databases != null) hashCode = hashCode * 59 + this.Databases.GetHashCode();
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.KeyWords != null) hashCode = hashCode * 59 + this.KeyWords.GetHashCode();
                if (this.ParallelSize != null) hashCode = hashCode * 59 + this.ParallelSize.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.CpuUtilization != null) hashCode = hashCode * 59 + this.CpuUtilization.GetHashCode();
                if (this.MemoryUtilization != null) hashCode = hashCode * 59 + this.MemoryUtilization.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
