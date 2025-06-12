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
    /// 文本转语音试听请求。
    /// </summary>
    public class CreateTtsAuditionRequestBody 
    {

        /// <summary>
        /// 待合成文本。
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// 发送给tts的待合成文本。
        /// </summary>
        [JsonProperty("tts_text", NullValueHandling = NullValueHandling.Ignore)]
        public string TtsText { get; set; }

        /// <summary>
        /// 音色ID，获取方式详见[获取音色ID](metastudio_02_0054.xml)。
        /// </summary>
        [JsonProperty("emotion", NullValueHandling = NullValueHandling.Ignore)]
        public string Emotion { get; set; }

        /// <summary>
        /// 语速。 * 当取值为“100”时，表示一个成年人正常的语速，约为250字/分钟。 * 50表示0.5倍语速，100表示正常语速，200表示2倍语速。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 音高。
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量。
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }

        /// <summary>
        /// 业务场景，多个入口调用试听接口时的业务场景
        /// </summary>
        [JsonProperty("business_type", NullValueHandling = NullValueHandling.Ignore)]
        public string BusinessType { get; set; }

        /// <summary>
        /// 风格情感
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }

        /// <summary>
        /// 声道。（单声道|双声道） 默认值1，最小值1，最大值2。
        /// </summary>
        [JsonProperty("channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? Channels { get; set; }

        /// <summary>
        /// 是否应用当前租户的读法配置
        /// </summary>
        [JsonProperty("is_vocabulary_config_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVocabularyConfigEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTtsAuditionRequestBody {\n");
            sb.Append("  text: ").Append(Text).Append("\n");
            sb.Append("  ttsText: ").Append(TtsText).Append("\n");
            sb.Append("  emotion: ").Append(Emotion).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  businessType: ").Append(BusinessType).Append("\n");
            sb.Append("  style: ").Append(Style).Append("\n");
            sb.Append("  channels: ").Append(Channels).Append("\n");
            sb.Append("  isVocabularyConfigEnable: ").Append(IsVocabularyConfigEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateTtsAuditionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateTtsAuditionRequestBody input)
        {
            if (input == null) return false;
            if (this.Text != input.Text || (this.Text != null && !this.Text.Equals(input.Text))) return false;
            if (this.TtsText != input.TtsText || (this.TtsText != null && !this.TtsText.Equals(input.TtsText))) return false;
            if (this.Emotion != input.Emotion || (this.Emotion != null && !this.Emotion.Equals(input.Emotion))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.BusinessType != input.BusinessType || (this.BusinessType != null && !this.BusinessType.Equals(input.BusinessType))) return false;
            if (this.Style != input.Style || (this.Style != null && !this.Style.Equals(input.Style))) return false;
            if (this.Channels != input.Channels || (this.Channels != null && !this.Channels.Equals(input.Channels))) return false;
            if (this.IsVocabularyConfigEnable != input.IsVocabularyConfigEnable || (this.IsVocabularyConfigEnable != null && !this.IsVocabularyConfigEnable.Equals(input.IsVocabularyConfigEnable))) return false;

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
                if (this.Text != null) hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.TtsText != null) hashCode = hashCode * 59 + this.TtsText.GetHashCode();
                if (this.Emotion != null) hashCode = hashCode * 59 + this.Emotion.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.BusinessType != null) hashCode = hashCode * 59 + this.BusinessType.GetHashCode();
                if (this.Style != null) hashCode = hashCode * 59 + this.Style.GetHashCode();
                if (this.Channels != null) hashCode = hashCode * 59 + this.Channels.GetHashCode();
                if (this.IsVocabularyConfigEnable != null) hashCode = hashCode * 59 + this.IsVocabularyConfigEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
