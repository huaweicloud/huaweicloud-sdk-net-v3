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
    /// 音频元数据，自动提取获得。
    /// </summary>
    public class AudioAssetMeta 
    {

        /// <summary>
        /// **参数解释**： 时长,单位秒。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释**： 音频编码格式。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// **参数解释**： 音频平均码率,单位kbps。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioBitRate { get; set; }

        /// <summary>
        /// **参数解释**： 音频声道数。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// **参数解释**： 采样率,HZ。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sample { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioAssetMeta {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  audioBitRate: ").Append(AudioBitRate).Append("\n");
            sb.Append("  audioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioAssetMeta input)
        {
            if (input == null) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.AudioCodec != input.AudioCodec || (this.AudioCodec != null && !this.AudioCodec.Equals(input.AudioCodec))) return false;
            if (this.AudioBitRate != input.AudioBitRate || (this.AudioBitRate != null && !this.AudioBitRate.Equals(input.AudioBitRate))) return false;
            if (this.AudioChannels != input.AudioChannels || (this.AudioChannels != null && !this.AudioChannels.Equals(input.AudioChannels))) return false;
            if (this.Sample != input.Sample || (this.Sample != null && !this.Sample.Equals(input.Sample))) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;

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
                if (this.AudioCodec != null) hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.AudioBitRate != null) hashCode = hashCode * 59 + this.AudioBitRate.GetHashCode();
                if (this.AudioChannels != null) hashCode = hashCode * 59 + this.AudioChannels.GetHashCode();
                if (this.Sample != null) hashCode = hashCode * 59 + this.Sample.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
