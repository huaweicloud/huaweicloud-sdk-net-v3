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
    /// 音色资产支持的能力集。 &gt; 音色能力集只允许查询，不允许设置
    /// </summary>
    public class VoiceCapability 
    {

        /// <summary>
        /// **参数解释**： 该声音是否支持英文音标。 **约束限制**： 不涉及 **取值范围**： * true: 支持英文音标 * false: 不支持英文音标
        /// </summary>
        [JsonProperty("is_support_phoneme_en", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportPhonemeEn { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持中文多音字。 **约束限制**： 不涉及 **取值范围**： * true: 支持中文多音字 * false: 不支持中文多音字
        /// </summary>
        [JsonProperty("is_support_phoneme", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportPhoneme { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持停顿。 **约束限制**： 不涉及 **取值范围**： * true: 支持停顿 * false: 不支持停顿
        /// </summary>
        [JsonProperty("is_support_break_time", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportBreakTime { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持韵律。 **约束限制**： 不涉及 **取值范围**： * true: 支持韵律 * false: 不支持韵律
        /// </summary>
        [JsonProperty("is_support_break_strength", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportBreakStrength { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持全局语速。 **约束限制**： 不涉及 **取值范围**： * true: 支持全局语速 * false: 不支持全局语速
        /// </summary>
        [JsonProperty("is_support_speed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportSpeed { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持局部语速。 **约束限制**： 不涉及 **取值范围**： * true: 支持局部语速 * false: 不支持局部语速
        /// </summary>
        [JsonProperty("is_support_prosody", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportProsody { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持SSML的say-as标签。 **约束限制**： 不涉及 **取值范围**： * true: 支持SSML的say-as标签 * false: 不支持SSML的say-as标签
        /// </summary>
        [JsonProperty("is_support_ssml_say_as", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportSsmlSayAs { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持SSML的sub标签。 **约束限制**： 不涉及 **取值范围**： * true: 支持SSML的sub标签 * false: 不支持SSML的sub标签
        /// </summary>
        [JsonProperty("is_support_ssml_sub", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportSsmlSub { get; set; }

        /// <summary>
        /// **参数解释**： 该声音是否支持连读。 **约束限制**： 不涉及 **取值范围**： * true: 支持连读 * false: 不支持连读
        /// </summary>
        [JsonProperty("is_support_word", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportWord { get; set; }

        /// <summary>
        /// 是否支持缓存。
        /// </summary>
        [JsonProperty("is_support_voice_cache", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportVoiceCache { get; set; }

        /// <summary>
        /// **参数解释**： 合成率。 **约束限制**： 不涉及 **取值范围**： * 0-50
        /// </summary>
        [JsonProperty("conversion_rate", NullValueHandling = NullValueHandling.Ignore)]
        public float? ConversionRate { get; set; }

        /// <summary>
        /// **参数解释**： 英语的合成率。 **约束限制**： 不涉及 **取值范围**： * 0-50
        /// </summary>
        [JsonProperty("conversion_rate_en", NullValueHandling = NullValueHandling.Ignore)]
        public float? ConversionRateEn { get; set; }

        /// <summary>
        /// 是否支持生成STR字幕文件。
        /// </summary>
        [JsonProperty("is_support_srt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportSrt { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceCapability {\n");
            sb.Append("  isSupportPhonemeEn: ").Append(IsSupportPhonemeEn).Append("\n");
            sb.Append("  isSupportPhoneme: ").Append(IsSupportPhoneme).Append("\n");
            sb.Append("  isSupportBreakTime: ").Append(IsSupportBreakTime).Append("\n");
            sb.Append("  isSupportBreakStrength: ").Append(IsSupportBreakStrength).Append("\n");
            sb.Append("  isSupportSpeed: ").Append(IsSupportSpeed).Append("\n");
            sb.Append("  isSupportProsody: ").Append(IsSupportProsody).Append("\n");
            sb.Append("  isSupportSsmlSayAs: ").Append(IsSupportSsmlSayAs).Append("\n");
            sb.Append("  isSupportSsmlSub: ").Append(IsSupportSsmlSub).Append("\n");
            sb.Append("  isSupportWord: ").Append(IsSupportWord).Append("\n");
            sb.Append("  isSupportVoiceCache: ").Append(IsSupportVoiceCache).Append("\n");
            sb.Append("  conversionRate: ").Append(ConversionRate).Append("\n");
            sb.Append("  conversionRateEn: ").Append(ConversionRateEn).Append("\n");
            sb.Append("  isSupportSrt: ").Append(IsSupportSrt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceCapability);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceCapability input)
        {
            if (input == null) return false;
            if (this.IsSupportPhonemeEn != input.IsSupportPhonemeEn || (this.IsSupportPhonemeEn != null && !this.IsSupportPhonemeEn.Equals(input.IsSupportPhonemeEn))) return false;
            if (this.IsSupportPhoneme != input.IsSupportPhoneme || (this.IsSupportPhoneme != null && !this.IsSupportPhoneme.Equals(input.IsSupportPhoneme))) return false;
            if (this.IsSupportBreakTime != input.IsSupportBreakTime || (this.IsSupportBreakTime != null && !this.IsSupportBreakTime.Equals(input.IsSupportBreakTime))) return false;
            if (this.IsSupportBreakStrength != input.IsSupportBreakStrength || (this.IsSupportBreakStrength != null && !this.IsSupportBreakStrength.Equals(input.IsSupportBreakStrength))) return false;
            if (this.IsSupportSpeed != input.IsSupportSpeed || (this.IsSupportSpeed != null && !this.IsSupportSpeed.Equals(input.IsSupportSpeed))) return false;
            if (this.IsSupportProsody != input.IsSupportProsody || (this.IsSupportProsody != null && !this.IsSupportProsody.Equals(input.IsSupportProsody))) return false;
            if (this.IsSupportSsmlSayAs != input.IsSupportSsmlSayAs || (this.IsSupportSsmlSayAs != null && !this.IsSupportSsmlSayAs.Equals(input.IsSupportSsmlSayAs))) return false;
            if (this.IsSupportSsmlSub != input.IsSupportSsmlSub || (this.IsSupportSsmlSub != null && !this.IsSupportSsmlSub.Equals(input.IsSupportSsmlSub))) return false;
            if (this.IsSupportWord != input.IsSupportWord || (this.IsSupportWord != null && !this.IsSupportWord.Equals(input.IsSupportWord))) return false;
            if (this.IsSupportVoiceCache != input.IsSupportVoiceCache || (this.IsSupportVoiceCache != null && !this.IsSupportVoiceCache.Equals(input.IsSupportVoiceCache))) return false;
            if (this.ConversionRate != input.ConversionRate || (this.ConversionRate != null && !this.ConversionRate.Equals(input.ConversionRate))) return false;
            if (this.ConversionRateEn != input.ConversionRateEn || (this.ConversionRateEn != null && !this.ConversionRateEn.Equals(input.ConversionRateEn))) return false;
            if (this.IsSupportSrt != input.IsSupportSrt || (this.IsSupportSrt != null && !this.IsSupportSrt.Equals(input.IsSupportSrt))) return false;

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
                if (this.IsSupportPhonemeEn != null) hashCode = hashCode * 59 + this.IsSupportPhonemeEn.GetHashCode();
                if (this.IsSupportPhoneme != null) hashCode = hashCode * 59 + this.IsSupportPhoneme.GetHashCode();
                if (this.IsSupportBreakTime != null) hashCode = hashCode * 59 + this.IsSupportBreakTime.GetHashCode();
                if (this.IsSupportBreakStrength != null) hashCode = hashCode * 59 + this.IsSupportBreakStrength.GetHashCode();
                if (this.IsSupportSpeed != null) hashCode = hashCode * 59 + this.IsSupportSpeed.GetHashCode();
                if (this.IsSupportProsody != null) hashCode = hashCode * 59 + this.IsSupportProsody.GetHashCode();
                if (this.IsSupportSsmlSayAs != null) hashCode = hashCode * 59 + this.IsSupportSsmlSayAs.GetHashCode();
                if (this.IsSupportSsmlSub != null) hashCode = hashCode * 59 + this.IsSupportSsmlSub.GetHashCode();
                if (this.IsSupportWord != null) hashCode = hashCode * 59 + this.IsSupportWord.GetHashCode();
                if (this.IsSupportVoiceCache != null) hashCode = hashCode * 59 + this.IsSupportVoiceCache.GetHashCode();
                if (this.ConversionRate != null) hashCode = hashCode * 59 + this.ConversionRate.GetHashCode();
                if (this.ConversionRateEn != null) hashCode = hashCode * 59 + this.ConversionRateEn.GetHashCode();
                if (this.IsSupportSrt != null) hashCode = hashCode * 59 + this.IsSupportSrt.GetHashCode();
                return hashCode;
            }
        }
    }
}
