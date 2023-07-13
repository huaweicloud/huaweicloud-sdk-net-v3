using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class SourceInfo 
    {

        /// <summary>
        /// 片源时长，单位：秒
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// 片源时长，单位：毫秒
        /// </summary>
        [JsonProperty("duration_ms", NullValueHandling = NullValueHandling.Ignore)]
        public long? DurationMs { get; set; }

        /// <summary>
        /// 片源格式
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public string Format { get; set; }

        /// <summary>
        /// 片源大小
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_info", NullValueHandling = NullValueHandling.Ignore)]
        public VideoInfo VideoInfo { get; set; }

        /// <summary>
        /// 音频信息
        /// </summary>
        [JsonProperty("audio_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<AudioInfo> AudioInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SourceInfo {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  durationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  videoInfo: ").Append(VideoInfo).Append("\n");
            sb.Append("  audioInfo: ").Append(AudioInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SourceInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.DurationMs == input.DurationMs ||
                    (this.DurationMs != null &&
                    this.DurationMs.Equals(input.DurationMs))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.VideoInfo == input.VideoInfo ||
                    (this.VideoInfo != null &&
                    this.VideoInfo.Equals(input.VideoInfo))
                ) && 
                (
                    this.AudioInfo == input.AudioInfo ||
                    this.AudioInfo != null &&
                    input.AudioInfo != null &&
                    this.AudioInfo.SequenceEqual(input.AudioInfo)
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationMs != null)
                    hashCode = hashCode * 59 + this.DurationMs.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.VideoInfo != null)
                    hashCode = hashCode * 59 + this.VideoInfo.GetHashCode();
                if (this.AudioInfo != null)
                    hashCode = hashCode * 59 + this.AudioInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
