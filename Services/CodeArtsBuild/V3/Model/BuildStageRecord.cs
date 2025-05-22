using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 构建步骤
    /// </summary>
    public class BuildStageRecord 
    {

        /// <summary>
        /// 步骤编号
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 步骤状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("status_code", NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 日志状态
        /// </summary>
        [JsonProperty("log_status", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStatus { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 构建下发时间
        /// </summary>
        [JsonProperty("schedule_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// 构建排队耗时
        /// </summary>
        [JsonProperty("queued_time", NullValueHandling = NullValueHandling.Ignore)]
        public string QueuedTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("finish_time", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishTime { get; set; }

        /// <summary>
        /// 构建时长
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 子任务构建耗时
        /// </summary>
        [JsonProperty("build_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildDuration { get; set; }

        /// <summary>
        /// 等待时间
        /// </summary>
        [JsonProperty("pending_duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingDuration { get; set; }

        /// <summary>
        /// 构建记录ID
        /// </summary>
        [JsonProperty("build_record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BuildRecordId { get; set; }

        /// <summary>
        /// 八爪鱼任务ID
        /// </summary>
        [JsonProperty("execution_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// 步骤名称
        /// </summary>
        [JsonProperty("execution_stage_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ExecutionStageName { get; set; }

        /// <summary>
        /// 步骤名称
        /// </summary>
        [JsonProperty("display_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DisplayName { get; set; }

        /// <summary>
        /// 节点ID
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? NodeId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("sequence", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildStageRecord {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  statusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  logStatus: ").Append(LogStatus).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  scheduleTime: ").Append(ScheduleTime).Append("\n");
            sb.Append("  queuedTime: ").Append(QueuedTime).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  finishTime: ").Append(FinishTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  buildDuration: ").Append(BuildDuration).Append("\n");
            sb.Append("  pendingDuration: ").Append(PendingDuration).Append("\n");
            sb.Append("  buildRecordId: ").Append(BuildRecordId).Append("\n");
            sb.Append("  executionId: ").Append(ExecutionId).Append("\n");
            sb.Append("  executionStageName: ").Append(ExecutionStageName).Append("\n");
            sb.Append("  displayName: ").Append(DisplayName).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  sequence: ").Append(Sequence).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BuildStageRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BuildStageRecord input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.StatusCode != input.StatusCode || (this.StatusCode != null && !this.StatusCode.Equals(input.StatusCode))) return false;
            if (this.LogStatus != input.LogStatus || (this.LogStatus != null && !this.LogStatus.Equals(input.LogStatus))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ScheduleTime != input.ScheduleTime || (this.ScheduleTime != null && !this.ScheduleTime.Equals(input.ScheduleTime))) return false;
            if (this.QueuedTime != input.QueuedTime || (this.QueuedTime != null && !this.QueuedTime.Equals(input.QueuedTime))) return false;
            if (this.StartTime != input.StartTime || (this.StartTime != null && !this.StartTime.Equals(input.StartTime))) return false;
            if (this.FinishTime != input.FinishTime || (this.FinishTime != null && !this.FinishTime.Equals(input.FinishTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.BuildDuration != input.BuildDuration || (this.BuildDuration != null && !this.BuildDuration.Equals(input.BuildDuration))) return false;
            if (this.PendingDuration != input.PendingDuration || (this.PendingDuration != null && !this.PendingDuration.Equals(input.PendingDuration))) return false;
            if (this.BuildRecordId != input.BuildRecordId || (this.BuildRecordId != null && !this.BuildRecordId.Equals(input.BuildRecordId))) return false;
            if (this.ExecutionId != input.ExecutionId || (this.ExecutionId != null && !this.ExecutionId.Equals(input.ExecutionId))) return false;
            if (this.ExecutionStageName != input.ExecutionStageName || (this.ExecutionStageName != null && !this.ExecutionStageName.Equals(input.ExecutionStageName))) return false;
            if (this.DisplayName != input.DisplayName || (this.DisplayName != null && !this.DisplayName.Equals(input.DisplayName))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.Sequence != input.Sequence || (this.Sequence != null && !this.Sequence.Equals(input.Sequence))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null) hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.LogStatus != null) hashCode = hashCode * 59 + this.LogStatus.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ScheduleTime != null) hashCode = hashCode * 59 + this.ScheduleTime.GetHashCode();
                if (this.QueuedTime != null) hashCode = hashCode * 59 + this.QueuedTime.GetHashCode();
                if (this.StartTime != null) hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.FinishTime != null) hashCode = hashCode * 59 + this.FinishTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.BuildDuration != null) hashCode = hashCode * 59 + this.BuildDuration.GetHashCode();
                if (this.PendingDuration != null) hashCode = hashCode * 59 + this.PendingDuration.GetHashCode();
                if (this.BuildRecordId != null) hashCode = hashCode * 59 + this.BuildRecordId.GetHashCode();
                if (this.ExecutionId != null) hashCode = hashCode * 59 + this.ExecutionId.GetHashCode();
                if (this.ExecutionStageName != null) hashCode = hashCode * 59 + this.ExecutionStageName.GetHashCode();
                if (this.DisplayName != null) hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.Sequence != null) hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                return hashCode;
            }
        }
    }
}
