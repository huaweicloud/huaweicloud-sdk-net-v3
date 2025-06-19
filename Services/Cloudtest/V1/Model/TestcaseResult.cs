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
    /// 测试用例结果
    /// </summary>
    public class TestcaseResult 
    {

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("execute_result_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteResultId { get; set; }

        /// <summary>
        /// 测试用例状态
        /// </summary>
        [JsonProperty("execute_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteStatus { get; set; }

        /// <summary>
        /// 失败原因
        /// </summary>
        [JsonProperty("failure_cause", NullValueHandling = NullValueHandling.Ignore)]
        public string FailureCause { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskId { get; set; }

        /// <summary>
        /// 测试计划id
        /// </summary>
        [JsonProperty("plan_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PlanId { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 执行测试用例用户id
        /// </summary>
        [JsonProperty("executor_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorId { get; set; }

        /// <summary>
        /// 执行测试用例用户name
        /// </summary>
        [JsonProperty("executor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutorName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TestcaseResult {\n");
            sb.Append("  executeResultId: ").Append(ExecuteResultId).Append("\n");
            sb.Append("  executeStatus: ").Append(ExecuteStatus).Append("\n");
            sb.Append("  failureCause: ").Append(FailureCause).Append("\n");
            sb.Append("  taskId: ").Append(TaskId).Append("\n");
            sb.Append("  planId: ").Append(PlanId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  executorId: ").Append(ExecutorId).Append("\n");
            sb.Append("  executorName: ").Append(ExecutorName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TestcaseResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TestcaseResult input)
        {
            if (input == null) return false;
            if (this.ExecuteResultId != input.ExecuteResultId || (this.ExecuteResultId != null && !this.ExecuteResultId.Equals(input.ExecuteResultId))) return false;
            if (this.ExecuteStatus != input.ExecuteStatus || (this.ExecuteStatus != null && !this.ExecuteStatus.Equals(input.ExecuteStatus))) return false;
            if (this.FailureCause != input.FailureCause || (this.FailureCause != null && !this.FailureCause.Equals(input.FailureCause))) return false;
            if (this.TaskId != input.TaskId || (this.TaskId != null && !this.TaskId.Equals(input.TaskId))) return false;
            if (this.PlanId != input.PlanId || (this.PlanId != null && !this.PlanId.Equals(input.PlanId))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.ExecutorId != input.ExecutorId || (this.ExecutorId != null && !this.ExecutorId.Equals(input.ExecutorId))) return false;
            if (this.ExecutorName != input.ExecutorName || (this.ExecutorName != null && !this.ExecutorName.Equals(input.ExecutorName))) return false;

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
                if (this.ExecuteResultId != null) hashCode = hashCode * 59 + this.ExecuteResultId.GetHashCode();
                if (this.ExecuteStatus != null) hashCode = hashCode * 59 + this.ExecuteStatus.GetHashCode();
                if (this.FailureCause != null) hashCode = hashCode * 59 + this.FailureCause.GetHashCode();
                if (this.TaskId != null) hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.PlanId != null) hashCode = hashCode * 59 + this.PlanId.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.ExecutorId != null) hashCode = hashCode * 59 + this.ExecutorId.GetHashCode();
                if (this.ExecutorName != null) hashCode = hashCode * 59 + this.ExecutorName.GetHashCode();
                return hashCode;
            }
        }
    }
}
