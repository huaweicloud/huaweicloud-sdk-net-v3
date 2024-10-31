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
    public class ShowLimitTaskResponse : SdkResponse
    {

        /// <summary>
        /// 限流任务名传。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务限流类型。
        /// </summary>
        [JsonProperty("limit_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LimitType { get; set; }

        /// <summary>
        /// 并发数。
        /// </summary>
        [JsonProperty("parallel_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ParallelSize { get; set; }

        /// <summary>
        /// 限流任务开始时间,格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 限流任务结束时间,格式为yyyy-mm-ddThh:mm:ssZ，当前时间指UTC时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 限流任务已执行时间，单位秒。
        /// </summary>
        [JsonProperty("task_running_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaskRunningTime { get; set; }

        /// <summary>
        /// 限流任务拦截次数。
        /// </summary>
        [JsonProperty("limit_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? LimitCount { get; set; }

        /// <summary>
        /// 规则名。
        /// </summary>
        [JsonProperty("rule_name", NullValueHandling = NullValueHandling.Ignore)]
        public string RuleName { get; set; }

        /// <summary>
        /// 内存利用率，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("memory_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? MemoryUtilization { get; set; }

        /// <summary>
        /// cpu利用率，仅当任务类型为SESSION_ACTIVE_MAX_COUNT时，返回该值且与请求参数相同。
        /// </summary>
        [JsonProperty("cpu_utilization", NullValueHandling = NullValueHandling.Ignore)]
        public int? CpuUtilization { get; set; }

        /// <summary>
        /// 限流任务列表
        /// </summary>
        [JsonProperty("limit_task_rule_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<LimitTaskRuleInfoOption> LimitTaskRuleInfoList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowLimitTaskResponse {\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  limitType: ").Append(LimitType).Append("\n");
            sb.Append("  parallelSize: ").Append(ParallelSize).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  taskRunningTime: ").Append(TaskRunningTime).Append("\n");
            sb.Append("  limitCount: ").Append(LimitCount).Append("\n");
            sb.Append("  ruleName: ").Append(RuleName).Append("\n");
            sb.Append("  memoryUtilization: ").Append(MemoryUtilization).Append("\n");
            sb.Append("  cpuUtilization: ").Append(CpuUtilization).Append("\n");
            sb.Append("  limitTaskRuleInfoList: ").Append(LimitTaskRuleInfoList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowLimitTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowLimitTaskResponse input)
        {
            if (input == null) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.LimitType != input.LimitType || (this.LimitType != null && !this.LimitType.Equals(input.LimitType))) return false;
            if (this.ParallelSize != input.ParallelSize || (this.ParallelSize != null && !this.ParallelSize.Equals(input.ParallelSize))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.TaskRunningTime != input.TaskRunningTime || (this.TaskRunningTime != null && !this.TaskRunningTime.Equals(input.TaskRunningTime))) return false;
            if (this.LimitCount != input.LimitCount || (this.LimitCount != null && !this.LimitCount.Equals(input.LimitCount))) return false;
            if (this.RuleName != input.RuleName || (this.RuleName != null && !this.RuleName.Equals(input.RuleName))) return false;
            if (this.MemoryUtilization != input.MemoryUtilization || (this.MemoryUtilization != null && !this.MemoryUtilization.Equals(input.MemoryUtilization))) return false;
            if (this.CpuUtilization != input.CpuUtilization || (this.CpuUtilization != null && !this.CpuUtilization.Equals(input.CpuUtilization))) return false;
            if (this.LimitTaskRuleInfoList != input.LimitTaskRuleInfoList || (this.LimitTaskRuleInfoList != null && input.LimitTaskRuleInfoList != null && !this.LimitTaskRuleInfoList.SequenceEqual(input.LimitTaskRuleInfoList))) return false;

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
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.LimitType != null) hashCode = hashCode * 59 + this.LimitType.GetHashCode();
                if (this.ParallelSize != null) hashCode = hashCode * 59 + this.ParallelSize.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.TaskRunningTime != null) hashCode = hashCode * 59 + this.TaskRunningTime.GetHashCode();
                if (this.LimitCount != null) hashCode = hashCode * 59 + this.LimitCount.GetHashCode();
                if (this.RuleName != null) hashCode = hashCode * 59 + this.RuleName.GetHashCode();
                if (this.MemoryUtilization != null) hashCode = hashCode * 59 + this.MemoryUtilization.GetHashCode();
                if (this.CpuUtilization != null) hashCode = hashCode * 59 + this.CpuUtilization.GetHashCode();
                if (this.LimitTaskRuleInfoList != null) hashCode = hashCode * 59 + this.LimitTaskRuleInfoList.GetHashCode();
                return hashCode;
            }
        }
    }
}
