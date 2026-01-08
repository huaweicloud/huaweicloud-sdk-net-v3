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
    /// 
    /// </summary>
    public class RecordAuditRule 
    {

        /// <summary>
        /// 录制类型。取值为： whole：表示全程录屏。 interval：表示间隔录屏。 userOperations：表示用户操作录屏。 sessionMonitoring：监听会话生命周期录屏。
        /// </summary>
        [JsonProperty("record_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// 间隔录制开始时间，仅录制类型为interval时有效 \&quot;hh:mm\&quot;。
        /// </summary>
        [JsonProperty("interval_record_start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string IntervalRecordStartTime { get; set; }

        /// <summary>
        /// 间隔录制结束时间，仅录制类型为interval时有效格式 \&quot;hh:mm\&quot;。
        /// </summary>
        [JsonProperty("interval_record_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string IntervalRecordEndTime { get; set; }

        /// <summary>
        /// 操作触发类型，仅录制类型为userOperations时有效。取值为： input：表示用户输入内容即启动录屏。 filecopy：表示用户拷贝文件即启动录屏。
        /// </summary>
        [JsonProperty("op_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OpType { get; set; }

        /// <summary>
        /// 是否开启音频录制开关。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("audio_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AudioRecord { get; set; }

        /// <summary>
        /// 录制帧率。取值为：2/5/10/15。
        /// </summary>
        [JsonProperty("fps", NullValueHandling = NullValueHandling.Ignore)]
        public string Fps { get; set; }

        /// <summary>
        /// 录制视频单文件时长（分钟）。取值为：10/20/30/60。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public string Duration { get; set; }

        /// <summary>
        /// 分辨率设置。取值为：720P/1080P/original。
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string Resolution { get; set; }

        /// <summary>
        /// 是否启动关键事件审计。取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("event_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EventEnable { get; set; }

        /// <summary>
        /// 文件后缀，多个用\&quot;|\&quot;分隔。
        /// </summary>
        [JsonProperty("file_suffix", NullValueHandling = NullValueHandling.Ignore)]
        public string FileSuffix { get; set; }

        /// <summary>
        /// 注册表路径，多个用\&quot;|\&quot;分隔。
        /// </summary>
        [JsonProperty("regit_paths", NullValueHandling = NullValueHandling.Ignore)]
        public string RegitPaths { get; set; }

        /// <summary>
        /// 应用过滤类型，black（黑名单）或者white（白名单）二选一。
        /// </summary>
        [JsonProperty("app_filter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AppFilterType { get; set; }

        /// <summary>
        /// APP开启/关闭白名单，仅监控配置的白名单应用列表。
        /// </summary>
        [JsonProperty("app_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public string AppWhiteList { get; set; }

        /// <summary>
        /// APP开启/关闭黑名单，忽略黑名单里面的应用列表。
        /// </summary>
        [JsonProperty("app_black_list", NullValueHandling = NullValueHandling.Ignore)]
        public string AppBlackList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecordAuditRule {\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  intervalRecordStartTime: ").Append(IntervalRecordStartTime).Append("\n");
            sb.Append("  intervalRecordEndTime: ").Append(IntervalRecordEndTime).Append("\n");
            sb.Append("  opType: ").Append(OpType).Append("\n");
            sb.Append("  audioRecord: ").Append(AudioRecord).Append("\n");
            sb.Append("  fps: ").Append(Fps).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  eventEnable: ").Append(EventEnable).Append("\n");
            sb.Append("  fileSuffix: ").Append(FileSuffix).Append("\n");
            sb.Append("  regitPaths: ").Append(RegitPaths).Append("\n");
            sb.Append("  appFilterType: ").Append(AppFilterType).Append("\n");
            sb.Append("  appWhiteList: ").Append(AppWhiteList).Append("\n");
            sb.Append("  appBlackList: ").Append(AppBlackList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordAuditRule);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecordAuditRule input)
        {
            if (input == null) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;
            if (this.IntervalRecordStartTime != input.IntervalRecordStartTime || (this.IntervalRecordStartTime != null && !this.IntervalRecordStartTime.Equals(input.IntervalRecordStartTime))) return false;
            if (this.IntervalRecordEndTime != input.IntervalRecordEndTime || (this.IntervalRecordEndTime != null && !this.IntervalRecordEndTime.Equals(input.IntervalRecordEndTime))) return false;
            if (this.OpType != input.OpType || (this.OpType != null && !this.OpType.Equals(input.OpType))) return false;
            if (this.AudioRecord != input.AudioRecord || (this.AudioRecord != null && !this.AudioRecord.Equals(input.AudioRecord))) return false;
            if (this.Fps != input.Fps || (this.Fps != null && !this.Fps.Equals(input.Fps))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.Resolution != input.Resolution || (this.Resolution != null && !this.Resolution.Equals(input.Resolution))) return false;
            if (this.EventEnable != input.EventEnable || (this.EventEnable != null && !this.EventEnable.Equals(input.EventEnable))) return false;
            if (this.FileSuffix != input.FileSuffix || (this.FileSuffix != null && !this.FileSuffix.Equals(input.FileSuffix))) return false;
            if (this.RegitPaths != input.RegitPaths || (this.RegitPaths != null && !this.RegitPaths.Equals(input.RegitPaths))) return false;
            if (this.AppFilterType != input.AppFilterType || (this.AppFilterType != null && !this.AppFilterType.Equals(input.AppFilterType))) return false;
            if (this.AppWhiteList != input.AppWhiteList || (this.AppWhiteList != null && !this.AppWhiteList.Equals(input.AppWhiteList))) return false;
            if (this.AppBlackList != input.AppBlackList || (this.AppBlackList != null && !this.AppBlackList.Equals(input.AppBlackList))) return false;

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
                if (this.RecordType != null) hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                if (this.IntervalRecordStartTime != null) hashCode = hashCode * 59 + this.IntervalRecordStartTime.GetHashCode();
                if (this.IntervalRecordEndTime != null) hashCode = hashCode * 59 + this.IntervalRecordEndTime.GetHashCode();
                if (this.OpType != null) hashCode = hashCode * 59 + this.OpType.GetHashCode();
                if (this.AudioRecord != null) hashCode = hashCode * 59 + this.AudioRecord.GetHashCode();
                if (this.Fps != null) hashCode = hashCode * 59 + this.Fps.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Resolution != null) hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.EventEnable != null) hashCode = hashCode * 59 + this.EventEnable.GetHashCode();
                if (this.FileSuffix != null) hashCode = hashCode * 59 + this.FileSuffix.GetHashCode();
                if (this.RegitPaths != null) hashCode = hashCode * 59 + this.RegitPaths.GetHashCode();
                if (this.AppFilterType != null) hashCode = hashCode * 59 + this.AppFilterType.GetHashCode();
                if (this.AppWhiteList != null) hashCode = hashCode * 59 + this.AppWhiteList.GetHashCode();
                if (this.AppBlackList != null) hashCode = hashCode * 59 + this.AppBlackList.GetHashCode();
                return hashCode;
            }
        }
    }
}
