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
    /// 
    /// </summary>
    public class HistoryRecord1 
    {

        /// <summary>
        /// 构建记录id- -唯一key
        /// </summary>
        [JsonProperty("record_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordId { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 构建编号
        /// </summary>
        [JsonProperty("build_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? BuildNumber { get; set; }

        /// <summary>
        /// 构建开始时间
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 构建结束时间
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 构建结果
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public string Result { get; set; }

        /// <summary>
        /// 代码分支
        /// </summary>
        [JsonProperty("branch", NullValueHandling = NullValueHandling.Ignore)]
        public string Branch { get; set; }

        /// <summary>
        /// 代码提交的commit id
        /// </summary>
        [JsonProperty("commit_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitId { get; set; }

        /// <summary>
        /// 代码提交时用户输入的提交信息，只有使用codehub仓库时有值
        /// </summary>
        [JsonProperty("commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public string CommitMessage { get; set; }

        /// <summary>
        /// 执行构建任务的用户的用户名
        /// </summary>
        [JsonProperty("executor", NullValueHandling = NullValueHandling.Ignore)]
        public string Executor { get; set; }

        /// <summary>
        /// 触发方式，可选值：手工触发，定时触发，代码更新触发，流水线触发
        /// </summary>
        [JsonProperty("trigger_type", NullValueHandling = NullValueHandling.Ignore)]
        public string TriggerType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryRecord1 {\n");
            sb.Append("  recordId: ").Append(RecordId).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  buildNumber: ").Append(BuildNumber).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  branch: ").Append(Branch).Append("\n");
            sb.Append("  commitId: ").Append(CommitId).Append("\n");
            sb.Append("  commitMessage: ").Append(CommitMessage).Append("\n");
            sb.Append("  executor: ").Append(Executor).Append("\n");
            sb.Append("  triggerType: ").Append(TriggerType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HistoryRecord1);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HistoryRecord1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordId == input.RecordId ||
                    (this.RecordId != null &&
                    this.RecordId.Equals(input.RecordId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.BuildNumber == input.BuildNumber ||
                    (this.BuildNumber != null &&
                    this.BuildNumber.Equals(input.BuildNumber))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.Branch == input.Branch ||
                    (this.Branch != null &&
                    this.Branch.Equals(input.Branch))
                ) && 
                (
                    this.CommitId == input.CommitId ||
                    (this.CommitId != null &&
                    this.CommitId.Equals(input.CommitId))
                ) && 
                (
                    this.CommitMessage == input.CommitMessage ||
                    (this.CommitMessage != null &&
                    this.CommitMessage.Equals(input.CommitMessage))
                ) && 
                (
                    this.Executor == input.Executor ||
                    (this.Executor != null &&
                    this.Executor.Equals(input.Executor))
                ) && 
                (
                    this.TriggerType == input.TriggerType ||
                    (this.TriggerType != null &&
                    this.TriggerType.Equals(input.TriggerType))
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
                if (this.RecordId != null)
                    hashCode = hashCode * 59 + this.RecordId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.BuildNumber != null)
                    hashCode = hashCode * 59 + this.BuildNumber.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
                if (this.CommitId != null)
                    hashCode = hashCode * 59 + this.CommitId.GetHashCode();
                if (this.CommitMessage != null)
                    hashCode = hashCode * 59 + this.CommitMessage.GetHashCode();
                if (this.Executor != null)
                    hashCode = hashCode * 59 + this.Executor.GetHashCode();
                if (this.TriggerType != null)
                    hashCode = hashCode * 59 + this.TriggerType.GetHashCode();
                return hashCode;
            }
        }
    }
}
