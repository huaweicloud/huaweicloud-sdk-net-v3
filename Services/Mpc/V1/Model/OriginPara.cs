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
    public class OriginPara 
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
        /// 文件格式 
        /// </summary>
        [JsonProperty("file_format", NullValueHandling = NullValueHandling.Ignore)]
        public string FileFormat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public VideoInfo Video { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("audio", NullValueHandling = NullValueHandling.Ignore)]
        public AudioInfo Audio { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OriginPara {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  durationMs: ").Append(DurationMs).Append("\n");
            sb.Append("  fileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  video: ").Append(Video).Append("\n");
            sb.Append("  audio: ").Append(Audio).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OriginPara);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OriginPara input)
        {
            if (input == null) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.DurationMs != input.DurationMs || (this.DurationMs != null && !this.DurationMs.Equals(input.DurationMs))) return false;
            if (this.FileFormat != input.FileFormat || (this.FileFormat != null && !this.FileFormat.Equals(input.FileFormat))) return false;
            if (this.Video != input.Video || (this.Video != null && !this.Video.Equals(input.Video))) return false;
            if (this.Audio != input.Audio || (this.Audio != null && !this.Audio.Equals(input.Audio))) return false;

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
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.DurationMs != null) hashCode = hashCode * 59 + this.DurationMs.GetHashCode();
                if (this.FileFormat != null) hashCode = hashCode * 59 + this.FileFormat.GetHashCode();
                if (this.Video != null) hashCode = hashCode * 59 + this.Video.GetHashCode();
                if (this.Audio != null) hashCode = hashCode * 59 + this.Audio.GetHashCode();
                return hashCode;
            }
        }
    }
}
