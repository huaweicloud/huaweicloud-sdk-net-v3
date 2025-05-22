using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 输出编码扩展
    /// </summary>
    public class EncoderSettingsExpand 
    {

        /// <summary>
        /// 音频输出配置的描述信息
        /// </summary>
        [JsonProperty("audio_descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public List<EncoderSettingsExpandAudioDescriptions> AudioDescriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_descriptions", NullValueHandling = NullValueHandling.Ignore)]
        public VideoDescriptions VideoDescriptions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncoderSettingsExpand {\n");
            sb.Append("  audioDescriptions: ").Append(AudioDescriptions).Append("\n");
            sb.Append("  videoDescriptions: ").Append(VideoDescriptions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EncoderSettingsExpand);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EncoderSettingsExpand input)
        {
            if (input == null) return false;
            if (this.AudioDescriptions != input.AudioDescriptions || (this.AudioDescriptions != null && input.AudioDescriptions != null && !this.AudioDescriptions.SequenceEqual(input.AudioDescriptions))) return false;
            if (this.VideoDescriptions != input.VideoDescriptions || (this.VideoDescriptions != null && !this.VideoDescriptions.Equals(input.VideoDescriptions))) return false;

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
                if (this.AudioDescriptions != null) hashCode = hashCode * 59 + this.AudioDescriptions.GetHashCode();
                if (this.VideoDescriptions != null) hashCode = hashCode * 59 + this.VideoDescriptions.GetHashCode();
                return hashCode;
            }
        }
    }
}
