using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 模板音频信息
    /// </summary>
    public class AudioTemplateInfo 
    {

        /// <summary>
        /// 音频采样率(有效值范围) - 1：AUDIO_SAMPLE_AUTO - 2：AUDIO_SAMPLE_22050 - 3：AUDIO_SAMPLE_32000 - 4：AUDIO_SAMPLE_44100 - 5：AUDIO_SAMPLE_48000 - 6：AUDIO_SAMPLE_96000  默认值为1。
        /// </summary>
        [JsonProperty("sample_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? SampleRate { get; set; }

        /// <summary>
        /// 音频码率（单位：Kbps）。
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 声道数(有效值范围) - 1：AUDIO_CHANNELS_1 - 2：AUDIO_CHANNELS_2
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioTemplateInfo {\n");
            sb.Append("  sampleRate: ").Append(SampleRate).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioTemplateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioTemplateInfo input)
        {
            if (input == null) return false;
            if (this.SampleRate != input.SampleRate || (this.SampleRate != null && !this.SampleRate.Equals(input.SampleRate))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Channels != input.Channels || (this.Channels != null && !this.Channels.Equals(input.Channels))) return false;

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
                if (this.SampleRate != null) hashCode = hashCode * 59 + this.SampleRate.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Channels != null) hashCode = hashCode * 59 + this.Channels.GetHashCode();
                return hashCode;
            }
        }
    }
}
