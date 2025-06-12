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
    /// 数字人名片制作创建请求。
    /// </summary>
    public class CreateDigitalHumanBusinessCardReq 
    {
        /// <summary>
        /// 数字人名片类型。 * 2D_DIGITAL_HUMAN_CARD：分身数字人名片。
        /// </summary>
        /// <value>数字人名片类型。 * 2D_DIGITAL_HUMAN_CARD：分身数字人名片。</value>
        [JsonConverter(typeof(EnumClassConverter<BusinessCardTypeEnum>))]
        public class BusinessCardTypeEnum
        {
            /// <summary>
            /// Enum _2D_DIGITAL_HUMAN_CARD for value: 2D_DIGITAL_HUMAN_CARD
            /// </summary>
            public static readonly BusinessCardTypeEnum _2D_DIGITAL_HUMAN_CARD = new BusinessCardTypeEnum("2D_DIGITAL_HUMAN_CARD");

            private static readonly Dictionary<string, BusinessCardTypeEnum> StaticFields =
            new Dictionary<string, BusinessCardTypeEnum>()
            {
                { "2D_DIGITAL_HUMAN_CARD", _2D_DIGITAL_HUMAN_CARD },
            };

            private string _value;

            public BusinessCardTypeEnum()
            {

            }

            public BusinessCardTypeEnum(string value)
            {
                _value = value;
            }

            public static BusinessCardTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BusinessCardTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BusinessCardTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BusinessCardTypeEnum a, BusinessCardTypeEnum b)
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

            public static bool operator !=(BusinessCardTypeEnum a, BusinessCardTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音。文本驱动需要填写introduction_text和voice_asset_id参数。 * AUDIO: 语音驱动，需要在资产库中先上传语音资产。语音驱动需要填写introduction_audio_asset_id参数。
        /// </summary>
        /// <value>自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音。文本驱动需要填写introduction_text和voice_asset_id参数。 * AUDIO: 语音驱动，需要在资产库中先上传语音资产。语音驱动需要填写introduction_audio_asset_id参数。</value>
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
        /// 数字人名片类型。 * 2D_DIGITAL_HUMAN_CARD：分身数字人名片。
        /// </summary>
        [JsonProperty("business_card_type", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCardTypeEnum BusinessCardType { get; set; }
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
        [JsonProperty("card_image_config", NullValueHandling = NullValueHandling.Ignore)]
        public BusinessCardImageConfig CardImageConfig { get; set; }

        /// <summary>
        /// 自我介绍驱动方式。 * TEXT: 文本驱动，即通过TTS合成语音。文本驱动需要填写introduction_text和voice_asset_id参数。 * AUDIO: 语音驱动，需要在资产库中先上传语音资产。语音驱动需要填写introduction_audio_asset_id参数。
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
        /// 输出名片视频资产名称。默认取card_name的值
        /// </summary>
        [JsonProperty("video_asset_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoAssetName { get; set; }

        /// <summary>
        /// 性别。 * MALE：男性 * FEMALE：女性
        /// </summary>
        [JsonProperty("gender", NullValueHandling = NullValueHandling.Ignore)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review_config", NullValueHandling = NullValueHandling.Ignore)]
        public ReviewConfig ReviewConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("callback_config", NullValueHandling = NullValueHandling.Ignore)]
        public CallBackConfig CallbackConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDigitalHumanBusinessCardReq {\n");
            sb.Append("  businessCardType: ").Append(BusinessCardType).Append("\n");
            sb.Append("  cardTempletAssetId: ").Append(CardTempletAssetId).Append("\n");
            sb.Append("  cardTextConfig: ").Append(CardTextConfig).Append("\n");
            sb.Append("  cardImageConfig: ").Append(CardImageConfig).Append("\n");
            sb.Append("  introductionType: ").Append(IntroductionType).Append("\n");
            sb.Append("  introductionText: ").Append(IntroductionText).Append("\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  introductionAudioAssetId: ").Append(IntroductionAudioAssetId).Append("\n");
            sb.Append("  videoAssetName: ").Append(VideoAssetName).Append("\n");
            sb.Append("  gender: ").Append(Gender).Append("\n");
            sb.Append("  reviewConfig: ").Append(ReviewConfig).Append("\n");
            sb.Append("  callbackConfig: ").Append(CallbackConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDigitalHumanBusinessCardReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDigitalHumanBusinessCardReq input)
        {
            if (input == null) return false;
            if (this.BusinessCardType != input.BusinessCardType) return false;
            if (this.CardTempletAssetId != input.CardTempletAssetId || (this.CardTempletAssetId != null && !this.CardTempletAssetId.Equals(input.CardTempletAssetId))) return false;
            if (this.CardTextConfig != input.CardTextConfig || (this.CardTextConfig != null && !this.CardTextConfig.Equals(input.CardTextConfig))) return false;
            if (this.CardImageConfig != input.CardImageConfig || (this.CardImageConfig != null && !this.CardImageConfig.Equals(input.CardImageConfig))) return false;
            if (this.IntroductionType != input.IntroductionType) return false;
            if (this.IntroductionText != input.IntroductionText || (this.IntroductionText != null && !this.IntroductionText.Equals(input.IntroductionText))) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.IntroductionAudioAssetId != input.IntroductionAudioAssetId || (this.IntroductionAudioAssetId != null && !this.IntroductionAudioAssetId.Equals(input.IntroductionAudioAssetId))) return false;
            if (this.VideoAssetName != input.VideoAssetName || (this.VideoAssetName != null && !this.VideoAssetName.Equals(input.VideoAssetName))) return false;
            if (this.Gender != input.Gender) return false;
            if (this.ReviewConfig != input.ReviewConfig || (this.ReviewConfig != null && !this.ReviewConfig.Equals(input.ReviewConfig))) return false;
            if (this.CallbackConfig != input.CallbackConfig || (this.CallbackConfig != null && !this.CallbackConfig.Equals(input.CallbackConfig))) return false;

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
                hashCode = hashCode * 59 + this.BusinessCardType.GetHashCode();
                if (this.CardTempletAssetId != null) hashCode = hashCode * 59 + this.CardTempletAssetId.GetHashCode();
                if (this.CardTextConfig != null) hashCode = hashCode * 59 + this.CardTextConfig.GetHashCode();
                if (this.CardImageConfig != null) hashCode = hashCode * 59 + this.CardImageConfig.GetHashCode();
                hashCode = hashCode * 59 + this.IntroductionType.GetHashCode();
                if (this.IntroductionText != null) hashCode = hashCode * 59 + this.IntroductionText.GetHashCode();
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                if (this.IntroductionAudioAssetId != null) hashCode = hashCode * 59 + this.IntroductionAudioAssetId.GetHashCode();
                if (this.VideoAssetName != null) hashCode = hashCode * 59 + this.VideoAssetName.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.ReviewConfig != null) hashCode = hashCode * 59 + this.ReviewConfig.GetHashCode();
                if (this.CallbackConfig != null) hashCode = hashCode * 59 + this.CallbackConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
