using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateFASReq 
    {

        /// <summary>
        /// 语音驱动音频文件下载URL，格式为AAC或者MP3
        /// </summary>
        [JsonProperty("audio_file_download_url", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioFileDownloadUrl { get; set; }

        /// <summary>
        /// 期望的输出帧率
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 情绪： 0：平静（默认） 1：开心 2：哀伤 3：愤怒
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public int? Emotion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFASReq {\n");
            sb.Append("  audioFileDownloadUrl: ").Append(AudioFileDownloadUrl).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  emotion: ").Append(Emotion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFASReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateFASReq input)
        {
            if (input == null) return false;
            if (this.AudioFileDownloadUrl != input.AudioFileDownloadUrl || (this.AudioFileDownloadUrl != null && !this.AudioFileDownloadUrl.Equals(input.AudioFileDownloadUrl))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.Emotion != input.Emotion || (this.Emotion != null && !this.Emotion.Equals(input.Emotion))) return false;

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
                if (this.AudioFileDownloadUrl != null) hashCode = hashCode * 59 + this.AudioFileDownloadUrl.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Emotion != null) hashCode = hashCode * 59 + this.Emotion.GetHashCode();
                return hashCode;
            }
        }
    }
}
