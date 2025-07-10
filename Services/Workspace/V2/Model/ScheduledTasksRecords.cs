using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 定时任务执行记录。
    /// </summary>
    public class ScheduledTasksRecords 
    {

        /// <summary>
        /// 任务执行记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 执行时间，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 任务类型。START：开机，STOP：关机，REBOOT：重启，HIBERNATE：休眠，REBUILD：重建系统盘。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 执行周期类型。FIXED_TIME：指定时间，DAY：按天，WEEK：按周，MONTH：按月。
        /// </summary>
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledType { get; set; }

        /// <summary>
        /// 触发场景类型。
        /// </summary>
        [JsonProperty("life_cycle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LifeCycleType { get; set; }

        /// <summary>
        /// 本次执行状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 成功桌面个数。
        /// </summary>
        [JsonProperty("success_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SuccessNum { get; set; }

        /// <summary>
        /// 失败桌面个数。
        /// </summary>
        [JsonProperty("failed_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FailedNum { get; set; }

        /// <summary>
        /// 跳过桌面个数。
        /// </summary>
        [JsonProperty("skip_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? SkipNum { get; set; }

        /// <summary>
        /// 时区。
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 执行定时任务的任务id，只有定时执行脚本返回。
        /// </summary>
        [JsonProperty("execute_task_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteTaskId { get; set; }

        /// <summary>
        /// 执行定时任务的对象类型，只有定时执行脚本返回。
        /// </summary>
        [JsonProperty("execute_object_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecuteObjectType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTasksRecords {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  lifeCycleType: ").Append(LifeCycleType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  successNum: ").Append(SuccessNum).Append("\n");
            sb.Append("  failedNum: ").Append(FailedNum).Append("\n");
            sb.Append("  skipNum: ").Append(SkipNum).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  executeTaskId: ").Append(ExecuteTaskId).Append("\n");
            sb.Append("  executeObjectType: ").Append(ExecuteObjectType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledTasksRecords);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledTasksRecords input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ScheduledType != input.ScheduledType || (this.ScheduledType != null && !this.ScheduledType.Equals(input.ScheduledType))) return false;
            if (this.LifeCycleType != input.LifeCycleType || (this.LifeCycleType != null && !this.LifeCycleType.Equals(input.LifeCycleType))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.SuccessNum != input.SuccessNum || (this.SuccessNum != null && !this.SuccessNum.Equals(input.SuccessNum))) return false;
            if (this.FailedNum != input.FailedNum || (this.FailedNum != null && !this.FailedNum.Equals(input.FailedNum))) return false;
            if (this.SkipNum != input.SkipNum || (this.SkipNum != null && !this.SkipNum.Equals(input.SkipNum))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.ExecuteTaskId != input.ExecuteTaskId || (this.ExecuteTaskId != null && !this.ExecuteTaskId.Equals(input.ExecuteTaskId))) return false;
            if (this.ExecuteObjectType != input.ExecuteObjectType || (this.ExecuteObjectType != null && !this.ExecuteObjectType.Equals(input.ExecuteObjectType))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.ScheduledType != null) hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.LifeCycleType != null) hashCode = hashCode * 59 + this.LifeCycleType.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SuccessNum != null) hashCode = hashCode * 59 + this.SuccessNum.GetHashCode();
                if (this.FailedNum != null) hashCode = hashCode * 59 + this.FailedNum.GetHashCode();
                if (this.SkipNum != null) hashCode = hashCode * 59 + this.SkipNum.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.ExecuteTaskId != null) hashCode = hashCode * 59 + this.ExecuteTaskId.GetHashCode();
                if (this.ExecuteObjectType != null) hashCode = hashCode * 59 + this.ExecuteObjectType.GetHashCode();
                return hashCode;
            }
        }
    }
}
