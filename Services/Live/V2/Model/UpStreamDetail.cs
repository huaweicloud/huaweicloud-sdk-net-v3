using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpStreamDetail 
    {

        /// <summary>
        /// 采样时间。日期格式按照ISO8601表示法，并使用UTC时间。 格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("time", NullValueHandling = NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// 帧率，单位为fps
        /// </summary>
        [JsonProperty("fps", NullValueHandling = NullValueHandling.Ignore)]
        public long? Fps { get; set; }

        /// <summary>
        /// 码率，单位为Kbps
        /// </summary>
        [JsonProperty("rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rate { get; set; }

        /// <summary>
        /// 时延 单位ms
        /// </summary>
        [JsonProperty("delay", NullValueHandling = NullValueHandling.Ignore)]
        public long? Delay { get; set; }

        /// <summary>
        /// 最近一次gop的时长 单位ms
        /// </summary>
        [JsonProperty("gop_duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? GopDuration { get; set; }

        /// <summary>
        /// 视频DTS 单位ms
        /// </summary>
        [JsonProperty("last_video_pts", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastVideoPts { get; set; }

        /// <summary>
        /// 音频DTS 单位ms
        /// </summary>
        [JsonProperty("last_audio_pts", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastAudioPts { get; set; }

        /// <summary>
        /// 音视频DTS差值 单位ms
        /// </summary>
        [JsonProperty("last_video_audio_pts_diff", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastVideoAudioPtsDiff { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpStreamDetail {\n");
            sb.Append("  time: ").Append(Time).Append("\n");
            sb.Append("  fps: ").Append(Fps).Append("\n");
            sb.Append("  rate: ").Append(Rate).Append("\n");
            sb.Append("  delay: ").Append(Delay).Append("\n");
            sb.Append("  gopDuration: ").Append(GopDuration).Append("\n");
            sb.Append("  lastVideoPts: ").Append(LastVideoPts).Append("\n");
            sb.Append("  lastAudioPts: ").Append(LastAudioPts).Append("\n");
            sb.Append("  lastVideoAudioPtsDiff: ").Append(LastVideoAudioPtsDiff).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpStreamDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpStreamDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Fps == input.Fps ||
                    (this.Fps != null &&
                    this.Fps.Equals(input.Fps))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.Delay == input.Delay ||
                    (this.Delay != null &&
                    this.Delay.Equals(input.Delay))
                ) && 
                (
                    this.GopDuration == input.GopDuration ||
                    (this.GopDuration != null &&
                    this.GopDuration.Equals(input.GopDuration))
                ) && 
                (
                    this.LastVideoPts == input.LastVideoPts ||
                    (this.LastVideoPts != null &&
                    this.LastVideoPts.Equals(input.LastVideoPts))
                ) && 
                (
                    this.LastAudioPts == input.LastAudioPts ||
                    (this.LastAudioPts != null &&
                    this.LastAudioPts.Equals(input.LastAudioPts))
                ) && 
                (
                    this.LastVideoAudioPtsDiff == input.LastVideoAudioPtsDiff ||
                    (this.LastVideoAudioPtsDiff != null &&
                    this.LastVideoAudioPtsDiff.Equals(input.LastVideoAudioPtsDiff))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Fps != null)
                    hashCode = hashCode * 59 + this.Fps.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                if (this.Delay != null)
                    hashCode = hashCode * 59 + this.Delay.GetHashCode();
                if (this.GopDuration != null)
                    hashCode = hashCode * 59 + this.GopDuration.GetHashCode();
                if (this.LastVideoPts != null)
                    hashCode = hashCode * 59 + this.LastVideoPts.GetHashCode();
                if (this.LastAudioPts != null)
                    hashCode = hashCode * 59 + this.LastAudioPts.GetHashCode();
                if (this.LastVideoAudioPtsDiff != null)
                    hashCode = hashCode * 59 + this.LastVideoAudioPtsDiff.GetHashCode();
                return hashCode;
            }
        }
    }
}
