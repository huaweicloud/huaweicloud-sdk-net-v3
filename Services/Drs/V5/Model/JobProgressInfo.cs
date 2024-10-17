using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 任务进度信息。
    /// </summary>
    public class JobProgressInfo 
    {

        /// <summary>
        /// 迁移对比百分比。
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public string Progress { get; set; }

        /// <summary>
        /// 增量迁移时延（单位：s）。
        /// </summary>
        [JsonProperty("incr_trans_delay", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrTransDelay { get; set; }

        /// <summary>
        /// 增量迁移时延（单位：ms）。
        /// </summary>
        [JsonProperty("incr_trans_delay_millis", NullValueHandling = NullValueHandling.Ignore)]
        public string IncrTransDelayMillis { get; set; }

        /// <summary>
        /// 迁移模式。
        /// </summary>
        [JsonProperty("task_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskMode { get; set; }

        /// <summary>
        /// 迁移状态。
        /// </summary>
        [JsonProperty("transfer_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferStatus { get; set; }

        /// <summary>
        /// 迁移时间。
        /// </summary>
        [JsonProperty("process_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ProcessTime { get; set; }

        /// <summary>
        /// 预计剩余时间。
        /// </summary>
        [JsonProperty("remaining_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingTime { get; set; }

        /// <summary>
        /// 全量迁移进度详情。
        /// </summary>
        [JsonProperty("progress_map", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, ProgressCompleteInfo> ProgressMap { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobProgressInfo {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  incrTransDelay: ").Append(IncrTransDelay).Append("\n");
            sb.Append("  incrTransDelayMillis: ").Append(IncrTransDelayMillis).Append("\n");
            sb.Append("  taskMode: ").Append(TaskMode).Append("\n");
            sb.Append("  transferStatus: ").Append(TransferStatus).Append("\n");
            sb.Append("  processTime: ").Append(ProcessTime).Append("\n");
            sb.Append("  remainingTime: ").Append(RemainingTime).Append("\n");
            sb.Append("  progressMap: ").Append(ProgressMap).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as JobProgressInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(JobProgressInfo input)
        {
            if (input == null) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.IncrTransDelay != input.IncrTransDelay || (this.IncrTransDelay != null && !this.IncrTransDelay.Equals(input.IncrTransDelay))) return false;
            if (this.IncrTransDelayMillis != input.IncrTransDelayMillis || (this.IncrTransDelayMillis != null && !this.IncrTransDelayMillis.Equals(input.IncrTransDelayMillis))) return false;
            if (this.TaskMode != input.TaskMode || (this.TaskMode != null && !this.TaskMode.Equals(input.TaskMode))) return false;
            if (this.TransferStatus != input.TransferStatus || (this.TransferStatus != null && !this.TransferStatus.Equals(input.TransferStatus))) return false;
            if (this.ProcessTime != input.ProcessTime || (this.ProcessTime != null && !this.ProcessTime.Equals(input.ProcessTime))) return false;
            if (this.RemainingTime != input.RemainingTime || (this.RemainingTime != null && !this.RemainingTime.Equals(input.RemainingTime))) return false;
            if (this.ProgressMap != input.ProgressMap || (this.ProgressMap != null && input.ProgressMap != null && !this.ProgressMap.SequenceEqual(input.ProgressMap))) return false;

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
                if (this.Progress != null) hashCode = hashCode * 59 + this.Progress.GetHashCode();
                if (this.IncrTransDelay != null) hashCode = hashCode * 59 + this.IncrTransDelay.GetHashCode();
                if (this.IncrTransDelayMillis != null) hashCode = hashCode * 59 + this.IncrTransDelayMillis.GetHashCode();
                if (this.TaskMode != null) hashCode = hashCode * 59 + this.TaskMode.GetHashCode();
                if (this.TransferStatus != null) hashCode = hashCode * 59 + this.TransferStatus.GetHashCode();
                if (this.ProcessTime != null) hashCode = hashCode * 59 + this.ProcessTime.GetHashCode();
                if (this.RemainingTime != null) hashCode = hashCode * 59 + this.RemainingTime.GetHashCode();
                if (this.ProgressMap != null) hashCode = hashCode * 59 + this.ProgressMap.GetHashCode();
                return hashCode;
            }
        }
    }
}
