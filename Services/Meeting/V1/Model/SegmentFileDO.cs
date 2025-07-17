using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 录制切片文件
    /// </summary>
    public class SegmentFileDO 
    {

        /// <summary>
        /// 会议录制类型，取值范围见数据结构RecordType：AUDIO 纯音频录制，SPEAKER_VIDEO 演讲者视图，SHARE_VIDEO共享屏幕，SPEAKER_SHARE_VIDEO 含演讲者视图的共享屏幕
        /// </summary>
        [JsonProperty("recordType", NullValueHandling = NullValueHandling.Ignore)]
        public string RecordType { get; set; }

        /// <summary>
        /// 录制文件开始时间 
        /// </summary>
        [JsonProperty("beginTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? BeginTime { get; set; }

        /// <summary>
        /// 录制文件结束时间 
        /// </summary>
        [JsonProperty("endTime", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndTime { get; set; }

        /// <summary>
        /// 录制文件时长(秒)
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// 文件大小(字节数)
        /// </summary>
        [JsonProperty("fileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文件hash校验码(SHA256)，64个字符
        /// </summary>
        [JsonProperty("sha256", NullValueHandling = NullValueHandling.Ignore)]
        public string Sha256 { get; set; }

        /// <summary>
        /// 录制文件播放地址，有效期1小时
        /// </summary>
        [JsonProperty("playUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayUrl { get; set; }

        /// <summary>
        /// 录制文件下载地址，有效期1小时
        /// </summary>
        [JsonProperty("downloadUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string DownloadUrl { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SegmentFileDO {\n");
            sb.Append("  recordType: ").Append(RecordType).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  sha256: ").Append(Sha256).Append("\n");
            sb.Append("  playUrl: ").Append(PlayUrl).Append("\n");
            sb.Append("  downloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SegmentFileDO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SegmentFileDO input)
        {
            if (input == null) return false;
            if (this.RecordType != input.RecordType || (this.RecordType != null && !this.RecordType.Equals(input.RecordType))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.Sha256 != input.Sha256 || (this.Sha256 != null && !this.Sha256.Equals(input.Sha256))) return false;
            if (this.PlayUrl != input.PlayUrl || (this.PlayUrl != null && !this.PlayUrl.Equals(input.PlayUrl))) return false;
            if (this.DownloadUrl != input.DownloadUrl || (this.DownloadUrl != null && !this.DownloadUrl.Equals(input.DownloadUrl))) return false;

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
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.Sha256 != null) hashCode = hashCode * 59 + this.Sha256.GetHashCode();
                if (this.PlayUrl != null) hashCode = hashCode * 59 + this.PlayUrl.GetHashCode();
                if (this.DownloadUrl != null) hashCode = hashCode * 59 + this.DownloadUrl.GetHashCode();
                return hashCode;
            }
        }
    }
}
