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
    /// Response Object
    /// </summary>
    public class ShowReplayProgressResponse : SdkResponse
    {

        /// <summary>
        /// 回放进度的百分数
        /// </summary>
        [JsonProperty("progress", NullValueHandling = NullValueHandling.Ignore)]
        public long? Progress { get; set; }

        /// <summary>
        /// 需要解析的总数
        /// </summary>
        [JsonProperty("parse_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ParseCount { get; set; }

        /// <summary>
        /// 回放的总数
        /// </summary>
        [JsonProperty("replay_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? ReplayCount { get; set; }

        /// <summary>
        /// 迁移模式
        /// </summary>
        [JsonProperty("task_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string TaskMode { get; set; }

        /// <summary>
        /// 迁移时间
        /// </summary>
        [JsonProperty("process_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? ProcessTime { get; set; }

        /// <summary>
        /// 迁移状态
        /// </summary>
        [JsonProperty("transfer_status", NullValueHandling = NullValueHandling.Ignore)]
        public string TransferStatus { get; set; }

        /// <summary>
        /// 回放最大时间
        /// </summary>
        [JsonProperty("max_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxTime { get; set; }

        /// <summary>
        /// 回放最小时间
        /// </summary>
        [JsonProperty("min_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinTime { get; set; }

        /// <summary>
        /// 回放当前时间
        /// </summary>
        [JsonProperty("now_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? NowTime { get; set; }

        /// <summary>
        /// 回放报告最小时间
        /// </summary>
        [JsonProperty("min_export_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MinExportTime { get; set; }

        /// <summary>
        /// 回放报告最大时间
        /// </summary>
        [JsonProperty("max_export_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? MaxExportTime { get; set; }

        /// <summary>
        /// 正在回放的sql列表
        /// </summary>
        [JsonProperty("replay_sql_now_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ReplaySqlNowInfo> ReplaySqlNowList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowReplayProgressResponse {\n");
            sb.Append("  progress: ").Append(Progress).Append("\n");
            sb.Append("  parseCount: ").Append(ParseCount).Append("\n");
            sb.Append("  replayCount: ").Append(ReplayCount).Append("\n");
            sb.Append("  taskMode: ").Append(TaskMode).Append("\n");
            sb.Append("  processTime: ").Append(ProcessTime).Append("\n");
            sb.Append("  transferStatus: ").Append(TransferStatus).Append("\n");
            sb.Append("  maxTime: ").Append(MaxTime).Append("\n");
            sb.Append("  minTime: ").Append(MinTime).Append("\n");
            sb.Append("  nowTime: ").Append(NowTime).Append("\n");
            sb.Append("  minExportTime: ").Append(MinExportTime).Append("\n");
            sb.Append("  maxExportTime: ").Append(MaxExportTime).Append("\n");
            sb.Append("  replaySqlNowList: ").Append(ReplaySqlNowList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowReplayProgressResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowReplayProgressResponse input)
        {
            if (input == null) return false;
            if (this.Progress != input.Progress || (this.Progress != null && !this.Progress.Equals(input.Progress))) return false;
            if (this.ParseCount != input.ParseCount || (this.ParseCount != null && !this.ParseCount.Equals(input.ParseCount))) return false;
            if (this.ReplayCount != input.ReplayCount || (this.ReplayCount != null && !this.ReplayCount.Equals(input.ReplayCount))) return false;
            if (this.TaskMode != input.TaskMode || (this.TaskMode != null && !this.TaskMode.Equals(input.TaskMode))) return false;
            if (this.ProcessTime != input.ProcessTime || (this.ProcessTime != null && !this.ProcessTime.Equals(input.ProcessTime))) return false;
            if (this.TransferStatus != input.TransferStatus || (this.TransferStatus != null && !this.TransferStatus.Equals(input.TransferStatus))) return false;
            if (this.MaxTime != input.MaxTime || (this.MaxTime != null && !this.MaxTime.Equals(input.MaxTime))) return false;
            if (this.MinTime != input.MinTime || (this.MinTime != null && !this.MinTime.Equals(input.MinTime))) return false;
            if (this.NowTime != input.NowTime || (this.NowTime != null && !this.NowTime.Equals(input.NowTime))) return false;
            if (this.MinExportTime != input.MinExportTime || (this.MinExportTime != null && !this.MinExportTime.Equals(input.MinExportTime))) return false;
            if (this.MaxExportTime != input.MaxExportTime || (this.MaxExportTime != null && !this.MaxExportTime.Equals(input.MaxExportTime))) return false;
            if (this.ReplaySqlNowList != input.ReplaySqlNowList || (this.ReplaySqlNowList != null && input.ReplaySqlNowList != null && !this.ReplaySqlNowList.SequenceEqual(input.ReplaySqlNowList))) return false;

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
                if (this.ParseCount != null) hashCode = hashCode * 59 + this.ParseCount.GetHashCode();
                if (this.ReplayCount != null) hashCode = hashCode * 59 + this.ReplayCount.GetHashCode();
                if (this.TaskMode != null) hashCode = hashCode * 59 + this.TaskMode.GetHashCode();
                if (this.ProcessTime != null) hashCode = hashCode * 59 + this.ProcessTime.GetHashCode();
                if (this.TransferStatus != null) hashCode = hashCode * 59 + this.TransferStatus.GetHashCode();
                if (this.MaxTime != null) hashCode = hashCode * 59 + this.MaxTime.GetHashCode();
                if (this.MinTime != null) hashCode = hashCode * 59 + this.MinTime.GetHashCode();
                if (this.NowTime != null) hashCode = hashCode * 59 + this.NowTime.GetHashCode();
                if (this.MinExportTime != null) hashCode = hashCode * 59 + this.MinExportTime.GetHashCode();
                if (this.MaxExportTime != null) hashCode = hashCode * 59 + this.MaxExportTime.GetHashCode();
                if (this.ReplaySqlNowList != null) hashCode = hashCode * 59 + this.ReplaySqlNowList.GetHashCode();
                return hashCode;
            }
        }
    }
}
