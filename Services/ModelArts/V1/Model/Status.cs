using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 训练作业状态信息。创建作业无需填写。
    /// </summary>
    public class Status 
    {

        /// <summary>
        /// 训练作业一级状态。可选值如下： - Creating：创建中 - Pending：等待中 - Running：运行中 - Failed：运行失败 - Completed：已完成 - Terminating：停止中 - Terminated：已停止 - Abnormal：异常
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 训练作业二级状态为内部详细状态，可能会增加、修改、删除，不建议依赖。可选值如下： - Creating：创建中 - Queuing：排队中 - Running：运行中 - Failed：运行失败 - Completed：已完成 - Terminating：停止中 - Terminated：已停止 - CreateFailed：创建失败 - TerminatedFailed：停止失败 - Unknown：未知状态 - Lost：异常
        /// </summary>
        [JsonProperty("secondary_phase", NullValueHandling = NullValueHandling.Ignore)]
        public string SecondaryPhase { get; set; }

        /// <summary>
        /// 训练作业运行时长，单位为毫秒。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// 训练作业运行时节点数变化指标。
        /// </summary>
        [JsonProperty("node_count_metrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<List<int?>> NodeCountMetrics { get; set; }

        /// <summary>
        /// 训练作业子任务名称。
        /// </summary>
        [JsonProperty("tasks", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tasks { get; set; }

        /// <summary>
        /// 训练作业开始时间，格式为时间戳。
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartTime { get; set; }

        /// <summary>
        /// 训练在子任务状态信息。
        /// </summary>
        [JsonProperty("task_statuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<TaskStatuses> TaskStatuses { get; set; }

        /// <summary>
        /// 训练作业运行及故障恢复记录。
        /// </summary>
        [JsonProperty("running_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<RunningRecord> RunningRecords { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Status {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  secondaryPhase: ").Append(SecondaryPhase).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  nodeCountMetrics: ").Append(NodeCountMetrics).Append("\n");
            sb.Append("  tasks: ").Append(Tasks).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  taskStatuses: ").Append(TaskStatuses).Append("\n");
            sb.Append("  runningRecords: ").Append(RunningRecords).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Status);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Status input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.SecondaryPhase != input.SecondaryPhase || (this.SecondaryPhase != null && !this.SecondaryPhase.Equals(input.SecondaryPhase))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.NodeCountMetrics != input.NodeCountMetrics || (this.NodeCountMetrics != null && input.NodeCountMetrics != null && !this.NodeCountMetrics.SequenceEqual(input.NodeCountMetrics))) return false;
            if (this.Tasks != input.Tasks || (this.Tasks != null && input.Tasks != null && !this.Tasks.SequenceEqual(input.Tasks))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.TaskStatuses != input.TaskStatuses || (this.TaskStatuses != null && input.TaskStatuses != null && !this.TaskStatuses.SequenceEqual(input.TaskStatuses))) return false;
            if (this.RunningRecords != input.RunningRecords || (this.RunningRecords != null && input.RunningRecords != null && !this.RunningRecords.SequenceEqual(input.RunningRecords))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.SecondaryPhase != null) hashCode = hashCode * 59 + this.SecondaryPhase.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.NodeCountMetrics != null) hashCode = hashCode * 59 + this.NodeCountMetrics.GetHashCode();
                if (this.Tasks != null) hashCode = hashCode * 59 + this.Tasks.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.TaskStatuses != null) hashCode = hashCode * 59 + this.TaskStatuses.GetHashCode();
                if (this.RunningRecords != null) hashCode = hashCode * 59 + this.RunningRecords.GetHashCode();
                return hashCode;
            }
        }
    }
}
