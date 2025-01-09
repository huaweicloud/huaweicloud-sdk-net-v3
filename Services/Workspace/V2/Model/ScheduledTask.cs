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
    /// 定时任务信息。
    /// </summary>
    public class ScheduledTask 
    {

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 任务名称。
        /// </summary>
        [JsonProperty("task_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务类型。START：开机，STOP：关机，REBOOT：重启，HIBERNATE：休眠，REBUILD：重建系统盘，EXECUTE_SCRIPT：执行脚本，CREATE_SNAPSHOT：创建快照。
        /// </summary>
        [JsonProperty("task_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskType { get; set; }

        /// <summary>
        /// 执行周期。FIXED_TIME：指定时间，DAY：按天，WEEK：按周，MONTH：按月。
        /// </summary>
        [JsonProperty("scheduled_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduledType { get; set; }

        /// <summary>
        /// 触发场景类型。
        /// </summary>
        [JsonProperty("life_cycle_type", NullValueHandling = NullValueHandling.Ignore)]
        public string LifeCycleType { get; set; }

        /// <summary>
        /// 最近一次执行状态。SUCCESS：成功，SKIP：跳过，FAIL：失败。
        /// </summary>
        [JsonProperty("last_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LastStatus { get; set; }

        /// <summary>
        /// 下一次执行时间。格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("next_execution_time", NullValueHandling = NullValueHandling.Ignore)]
        public string NextExecutionTime { get; set; }

        /// <summary>
        /// 是否启用。
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }

        /// <summary>
        /// 描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 优先级。触发式任务使用。
        /// </summary>
        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority { get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("time_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }

        /// <summary>
        /// 触发式任务触发后，等待时长。
        /// </summary>
        [JsonProperty("wait_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? WaitTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduledTask {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  taskName: ").Append(TaskName).Append("\n");
            sb.Append("  taskType: ").Append(TaskType).Append("\n");
            sb.Append("  scheduledType: ").Append(ScheduledType).Append("\n");
            sb.Append("  lifeCycleType: ").Append(LifeCycleType).Append("\n");
            sb.Append("  lastStatus: ").Append(LastStatus).Append("\n");
            sb.Append("  nextExecutionTime: ").Append(NextExecutionTime).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  priority: ").Append(Priority).Append("\n");
            sb.Append("  timeZone: ").Append(TimeZone).Append("\n");
            sb.Append("  waitTime: ").Append(WaitTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScheduledTask);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScheduledTask input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.TaskName != input.TaskName || (this.TaskName != null && !this.TaskName.Equals(input.TaskName))) return false;
            if (this.TaskType != input.TaskType || (this.TaskType != null && !this.TaskType.Equals(input.TaskType))) return false;
            if (this.ScheduledType != input.ScheduledType || (this.ScheduledType != null && !this.ScheduledType.Equals(input.ScheduledType))) return false;
            if (this.LifeCycleType != input.LifeCycleType || (this.LifeCycleType != null && !this.LifeCycleType.Equals(input.LifeCycleType))) return false;
            if (this.LastStatus != input.LastStatus || (this.LastStatus != null && !this.LastStatus.Equals(input.LastStatus))) return false;
            if (this.NextExecutionTime != input.NextExecutionTime || (this.NextExecutionTime != null && !this.NextExecutionTime.Equals(input.NextExecutionTime))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.Priority != input.Priority || (this.Priority != null && !this.Priority.Equals(input.Priority))) return false;
            if (this.TimeZone != input.TimeZone || (this.TimeZone != null && !this.TimeZone.Equals(input.TimeZone))) return false;
            if (this.WaitTime != input.WaitTime || (this.WaitTime != null && !this.WaitTime.Equals(input.WaitTime))) return false;

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
                if (this.TaskName != null) hashCode = hashCode * 59 + this.TaskName.GetHashCode();
                if (this.TaskType != null) hashCode = hashCode * 59 + this.TaskType.GetHashCode();
                if (this.ScheduledType != null) hashCode = hashCode * 59 + this.ScheduledType.GetHashCode();
                if (this.LifeCycleType != null) hashCode = hashCode * 59 + this.LifeCycleType.GetHashCode();
                if (this.LastStatus != null) hashCode = hashCode * 59 + this.LastStatus.GetHashCode();
                if (this.NextExecutionTime != null) hashCode = hashCode * 59 + this.NextExecutionTime.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Priority != null) hashCode = hashCode * 59 + this.Priority.GetHashCode();
                if (this.TimeZone != null) hashCode = hashCode * 59 + this.TimeZone.GetHashCode();
                if (this.WaitTime != null) hashCode = hashCode * 59 + this.WaitTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
