using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CloudRtc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RtcHistoryQualityTimeValue 
    {

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。格式为YYYY-MM-DD
        /// </summary>
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public string Date { get; set; }

        /// <summary>
        /// 加入房间成功率参数取值，取值为1代表成功率100%
        /// </summary>
        [JsonProperty("join_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? JoinSuccessRate { get; set; }

        /// <summary>
        /// 5s内加入房间成功率参数取值，取值为1代表成功率100%
        /// </summary>
        [JsonProperty("join_success_in5secs_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? JoinSuccessIn5secsRate { get; set; }

        /// <summary>
        /// 视频卡顿率参数取值，取值为1代表卡顿率100%
        /// </summary>
        [JsonProperty("video_freeze_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? VideoFreezeRate { get; set; }

        /// <summary>
        /// 音频卡顿率参数取值，取值为1代表卡顿率100%
        /// </summary>
        [JsonProperty("audio_freeze_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AudioFreezeRate { get; set; }

        /// <summary>
        /// 首帧视频接收耗时，单位毫秒
        /// </summary>
        [JsonProperty("first_video_recv_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstVideoRecvTime { get; set; }

        /// <summary>
        /// 首帧音频接收耗时，单位毫秒
        /// </summary>
        [JsonProperty("first_audio_recv_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? FirstAudioRecvTime { get; set; }

        /// <summary>
        /// 拉流成功率参数取值，取值为1代表成功率100%
        /// </summary>
        [JsonProperty("pull_stream_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? PullStreamSuccessRate { get; set; }

        /// <summary>
        /// 推流成功率参数取值，取值为1代表成功率100%
        /// </summary>
        [JsonProperty("push_stream_success_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? PushStreamSuccessRate { get; set; }

        /// <summary>
        /// 客户端视频上行优质传输率，取值为1代表传输率100%
        /// </summary>
        [JsonProperty("video_upstream_excellent_trans_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? VideoUpstreamExcellentTransRate { get; set; }

        /// <summary>
        /// 客户端音频上行优质传输率，取值为1代表传输率100%
        /// </summary>
        [JsonProperty("audio_upstream_excellent_trans_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AudioUpstreamExcellentTransRate { get; set; }

        /// <summary>
        /// 端到端视频优质传输率，取值为1代表传输率100%
        /// </summary>
        [JsonProperty("video_excellent_trans_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? VideoExcellentTransRate { get; set; }

        /// <summary>
        /// 端到端音频优质传输率，取值为1代表传输率100%
        /// </summary>
        [JsonProperty("audio_excellent_trans_rate", NullValueHandling = NullValueHandling.Ignore)]
        public double? AudioExcellentTransRate { get; set; }

        /// <summary>
        /// 端到端视频网络时延，单位为毫秒，取当天所有用户网络延迟的中位数。
        /// </summary>
        [JsonProperty("video_trans_delay", NullValueHandling = NullValueHandling.Ignore)]
        public double? VideoTransDelay { get; set; }

        /// <summary>
        /// 端到端音频网络时延，单位为毫秒，取当天所有用户网络延迟的中位数。
        /// </summary>
        [JsonProperty("audio_trans_delay", NullValueHandling = NullValueHandling.Ignore)]
        public double? AudioTransDelay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RtcHistoryQualityTimeValue {\n");
            sb.Append("  date: ").Append(Date).Append("\n");
            sb.Append("  joinSuccessRate: ").Append(JoinSuccessRate).Append("\n");
            sb.Append("  joinSuccessIn5secsRate: ").Append(JoinSuccessIn5secsRate).Append("\n");
            sb.Append("  videoFreezeRate: ").Append(VideoFreezeRate).Append("\n");
            sb.Append("  audioFreezeRate: ").Append(AudioFreezeRate).Append("\n");
            sb.Append("  firstVideoRecvTime: ").Append(FirstVideoRecvTime).Append("\n");
            sb.Append("  firstAudioRecvTime: ").Append(FirstAudioRecvTime).Append("\n");
            sb.Append("  pullStreamSuccessRate: ").Append(PullStreamSuccessRate).Append("\n");
            sb.Append("  pushStreamSuccessRate: ").Append(PushStreamSuccessRate).Append("\n");
            sb.Append("  videoUpstreamExcellentTransRate: ").Append(VideoUpstreamExcellentTransRate).Append("\n");
            sb.Append("  audioUpstreamExcellentTransRate: ").Append(AudioUpstreamExcellentTransRate).Append("\n");
            sb.Append("  videoExcellentTransRate: ").Append(VideoExcellentTransRate).Append("\n");
            sb.Append("  audioExcellentTransRate: ").Append(AudioExcellentTransRate).Append("\n");
            sb.Append("  videoTransDelay: ").Append(VideoTransDelay).Append("\n");
            sb.Append("  audioTransDelay: ").Append(AudioTransDelay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RtcHistoryQualityTimeValue);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RtcHistoryQualityTimeValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.JoinSuccessRate == input.JoinSuccessRate ||
                    (this.JoinSuccessRate != null &&
                    this.JoinSuccessRate.Equals(input.JoinSuccessRate))
                ) && 
                (
                    this.JoinSuccessIn5secsRate == input.JoinSuccessIn5secsRate ||
                    (this.JoinSuccessIn5secsRate != null &&
                    this.JoinSuccessIn5secsRate.Equals(input.JoinSuccessIn5secsRate))
                ) && 
                (
                    this.VideoFreezeRate == input.VideoFreezeRate ||
                    (this.VideoFreezeRate != null &&
                    this.VideoFreezeRate.Equals(input.VideoFreezeRate))
                ) && 
                (
                    this.AudioFreezeRate == input.AudioFreezeRate ||
                    (this.AudioFreezeRate != null &&
                    this.AudioFreezeRate.Equals(input.AudioFreezeRate))
                ) && 
                (
                    this.FirstVideoRecvTime == input.FirstVideoRecvTime ||
                    (this.FirstVideoRecvTime != null &&
                    this.FirstVideoRecvTime.Equals(input.FirstVideoRecvTime))
                ) && 
                (
                    this.FirstAudioRecvTime == input.FirstAudioRecvTime ||
                    (this.FirstAudioRecvTime != null &&
                    this.FirstAudioRecvTime.Equals(input.FirstAudioRecvTime))
                ) && 
                (
                    this.PullStreamSuccessRate == input.PullStreamSuccessRate ||
                    (this.PullStreamSuccessRate != null &&
                    this.PullStreamSuccessRate.Equals(input.PullStreamSuccessRate))
                ) && 
                (
                    this.PushStreamSuccessRate == input.PushStreamSuccessRate ||
                    (this.PushStreamSuccessRate != null &&
                    this.PushStreamSuccessRate.Equals(input.PushStreamSuccessRate))
                ) && 
                (
                    this.VideoUpstreamExcellentTransRate == input.VideoUpstreamExcellentTransRate ||
                    (this.VideoUpstreamExcellentTransRate != null &&
                    this.VideoUpstreamExcellentTransRate.Equals(input.VideoUpstreamExcellentTransRate))
                ) && 
                (
                    this.AudioUpstreamExcellentTransRate == input.AudioUpstreamExcellentTransRate ||
                    (this.AudioUpstreamExcellentTransRate != null &&
                    this.AudioUpstreamExcellentTransRate.Equals(input.AudioUpstreamExcellentTransRate))
                ) && 
                (
                    this.VideoExcellentTransRate == input.VideoExcellentTransRate ||
                    (this.VideoExcellentTransRate != null &&
                    this.VideoExcellentTransRate.Equals(input.VideoExcellentTransRate))
                ) && 
                (
                    this.AudioExcellentTransRate == input.AudioExcellentTransRate ||
                    (this.AudioExcellentTransRate != null &&
                    this.AudioExcellentTransRate.Equals(input.AudioExcellentTransRate))
                ) && 
                (
                    this.VideoTransDelay == input.VideoTransDelay ||
                    (this.VideoTransDelay != null &&
                    this.VideoTransDelay.Equals(input.VideoTransDelay))
                ) && 
                (
                    this.AudioTransDelay == input.AudioTransDelay ||
                    (this.AudioTransDelay != null &&
                    this.AudioTransDelay.Equals(input.AudioTransDelay))
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.JoinSuccessRate != null)
                    hashCode = hashCode * 59 + this.JoinSuccessRate.GetHashCode();
                if (this.JoinSuccessIn5secsRate != null)
                    hashCode = hashCode * 59 + this.JoinSuccessIn5secsRate.GetHashCode();
                if (this.VideoFreezeRate != null)
                    hashCode = hashCode * 59 + this.VideoFreezeRate.GetHashCode();
                if (this.AudioFreezeRate != null)
                    hashCode = hashCode * 59 + this.AudioFreezeRate.GetHashCode();
                if (this.FirstVideoRecvTime != null)
                    hashCode = hashCode * 59 + this.FirstVideoRecvTime.GetHashCode();
                if (this.FirstAudioRecvTime != null)
                    hashCode = hashCode * 59 + this.FirstAudioRecvTime.GetHashCode();
                if (this.PullStreamSuccessRate != null)
                    hashCode = hashCode * 59 + this.PullStreamSuccessRate.GetHashCode();
                if (this.PushStreamSuccessRate != null)
                    hashCode = hashCode * 59 + this.PushStreamSuccessRate.GetHashCode();
                if (this.VideoUpstreamExcellentTransRate != null)
                    hashCode = hashCode * 59 + this.VideoUpstreamExcellentTransRate.GetHashCode();
                if (this.AudioUpstreamExcellentTransRate != null)
                    hashCode = hashCode * 59 + this.AudioUpstreamExcellentTransRate.GetHashCode();
                if (this.VideoExcellentTransRate != null)
                    hashCode = hashCode * 59 + this.VideoExcellentTransRate.GetHashCode();
                if (this.AudioExcellentTransRate != null)
                    hashCode = hashCode * 59 + this.AudioExcellentTransRate.GetHashCode();
                if (this.VideoTransDelay != null)
                    hashCode = hashCode * 59 + this.VideoTransDelay.GetHashCode();
                if (this.AudioTransDelay != null)
                    hashCode = hashCode * 59 + this.AudioTransDelay.GetHashCode();
                return hashCode;
            }
        }
    }
}
