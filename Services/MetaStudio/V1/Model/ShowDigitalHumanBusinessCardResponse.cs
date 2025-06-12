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
    /// Response Object
    /// </summary>
    public class ShowDigitalHumanBusinessCardResponse : SdkResponse
    {
        /// <summary>
        /// 自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动，需要在资产库中先上传语音资产
        /// </summary>
        /// <value>自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动，需要在资产库中先上传语音资产</value>
        [JsonConverter(typeof(EnumClassConverter<IntroductionTypeEnum>))]
        public class IntroductionTypeEnum
        {
            /// <summary>
            /// Enum TEXT for value: TEXT
            /// </summary>
            public static readonly IntroductionTypeEnum TEXT = new IntroductionTypeEnum("TEXT");

            /// <summary>
            /// Enum AUDIO for value: AUDIO
            /// </summary>
            public static readonly IntroductionTypeEnum AUDIO = new IntroductionTypeEnum("AUDIO");

            private static readonly Dictionary<string, IntroductionTypeEnum> StaticFields =
            new Dictionary<string, IntroductionTypeEnum>()
            {
                { "TEXT", TEXT },
                { "AUDIO", AUDIO },
            };

            private string _value;

            public IntroductionTypeEnum()
            {

            }

            public IntroductionTypeEnum(string value)
            {
                _value = value;
            }

            public static IntroductionTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as IntroductionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IntroductionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IntroductionTypeEnum a, IntroductionTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(IntroductionTypeEnum a, IntroductionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 性别。 * MALE：男性 * FEMALE：女性
        /// </summary>
        /// <value>性别。 * MALE：男性 * FEMALE：女性</value>
        [JsonConverter(typeof(EnumClassConverter<GenderEnum>))]
        public class GenderEnum
        {
            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            public static readonly GenderEnum MALE = new GenderEnum("MALE");

            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            public static readonly GenderEnum FEMALE = new GenderEnum("FEMALE");

            private static readonly Dictionary<string, GenderEnum> StaticFields =
            new Dictionary<string, GenderEnum>()
            {
                { "MALE", MALE },
                { "FEMALE", FEMALE },
            };

            private string _value;

            public GenderEnum()
            {

            }

            public GenderEnum(string value)
            {
                _value = value;
            }

            public static GenderEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as GenderEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(GenderEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(GenderEnum a, GenderEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(GenderEnum a, GenderEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("job_info", NullValueHandling = NullValueHandling.Ignore)]
        public DigitalHumanBusinessCardJobInfo JobInfo { get; set; }

        /// <summary>
        /// 数字人名片模板资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("card_templet_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CardTempletAssetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("card_text_config", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCardTextConfig CardTextConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("card_image_url", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCardImageUrl CardImageUrl { get; set; }

        /// <summary>
        /// 自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音 * AUDIO: 语音驱动，需要在资产库中先上传语音资产
        /// </summary>
        [JsonProperty("introduction_type", NullValueHandling = NullValueHandling.Ignore)]
        public IntroductionTypeEnum IntroductionType { get; set; }
        /// <summary>
        /// 自我介绍文本，用于驱动数字人口型。
        /// </summary>
        [JsonProperty("introduction_text", NullValueHandling = NullValueHandling.Ignore)]
        public string IntroductionText { get; set; }

        /// <summary>
        /// 音色资产ID，可以从资产库中查询。
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }

        /// <summary>
        /// 自我介绍语音资产ID，用于驱动数字人口型。 &gt; * 介绍语音需要作为asset_type&#x3D;AUDIO资产先上传至资产库。 &gt; * 使用时从资产库中查询。
        /// </summary>
        [JsonProperty("introduction_audio_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntroductionAudioAssetId { get; set; }

        /// <summary>
        /// 性别。 * MALE：男性 * FEMALE：女性
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDigitalHumanBusinessCardResponse {\n");
            sb.Append("  jobInfo: ").Append(JobInfo).Append("\n");
            sb.Append("  cardTempletAssetId: ").Append(CardTempletAssetId).Append("\n");
            sb.Append("  cardTextConfig: ").Append(CardTextConfig).Append("\n");
            sb.Append("  cardImageUrl: ").Append(CardImageUrl).Append("\n");
            sb.Append("  introductionType: ").Append(IntroductionType).Append("\n");
            sb.Append("  introductionText: ").Append(IntroductionText).Append("\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  introductionAudioAssetId: ").Append(IntroductionAudioAssetId).Append("\n");
            sb.Append("  gender: ").Append(Gender).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDigitalHumanBusinessCardResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDigitalHumanBusinessCardResponse input)
        {
            if (input == null) return false;
            if (this.JobInfo != input.JobInfo || (this.JobInfo != null && !this.JobInfo.Equals(input.JobInfo))) return false;
            if (this.CardTempletAssetId != input.CardTempletAssetId || (this.CardTempletAssetId != null && !this.CardTempletAssetId.Equals(input.CardTempletAssetId))) return false;
            if (this.CardTextConfig != input.CardTextConfig || (this.CardTextConfig != null && !this.CardTextConfig.Equals(input.CardTextConfig))) return false;
            if (this.CardImageUrl != input.CardImageUrl || (this.CardImageUrl != null && !this.CardImageUrl.Equals(input.CardImageUrl))) return false;
            if (this.IntroductionType != input.IntroductionType) return false;
            if (this.IntroductionText != input.IntroductionText || (this.IntroductionText != null && !this.IntroductionText.Equals(input.IntroductionText))) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.IntroductionAudioAssetId != input.IntroductionAudioAssetId || (this.IntroductionAudioAssetId != null && !this.IntroductionAudioAssetId.Equals(input.IntroductionAudioAssetId))) return false;
            if (this.Gender != input.Gender) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.JobInfo != null) hashCode = hashCode * 59 + this.JobInfo.GetHashCode();
                if (this.CardTempletAssetId != null) hashCode = hashCode * 59 + this.CardTempletAssetId.GetHashCode();
                if (this.CardTextConfig != null) hashCode = hashCode * 59 + this.CardTextConfig.GetHashCode();
                if (this.CardImageUrl != null) hashCode = hashCode * 59 + this.CardImageUrl.GetHashCode();
                hashCode = hashCode * 59 + this.IntroductionType.GetHashCode();
                if (this.IntroductionText != null) hashCode = hashCode * 59 + this.IntroductionText.GetHashCode();
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                if (this.IntroductionAudioAssetId != null) hashCode = hashCode * 59 + this.IntroductionAudioAssetId.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
