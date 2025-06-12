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
    /// 语音配置参数
    /// </summary>
    public class ChatVoiceConfig 
    {
        /// <summary>
        /// 语言类型。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
        /// </summary>
        /// <value>语言类型。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            public static readonly LanguageEnum CN = new LanguageEnum("CN");

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            public static readonly LanguageEnum EN = new LanguageEnum("EN");

            /// <summary>
            /// Enum ESP for value: ESP
            /// </summary>
            public static readonly LanguageEnum ESP = new LanguageEnum("ESP");

            /// <summary>
            /// Enum POR for value: por
            /// </summary>
            public static readonly LanguageEnum POR = new LanguageEnum("por");

            /// <summary>
            /// Enum ARABIC for value: Arabic
            /// </summary>
            public static readonly LanguageEnum ARABIC = new LanguageEnum("Arabic");

            /// <summary>
            /// Enum THAI for value: Thai
            /// </summary>
            public static readonly LanguageEnum THAI = new LanguageEnum("Thai");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "CN", CN },
                { "EN", EN },
                { "ESP", ESP },
                { "por", POR },
                { "Arabic", ARABIC },
                { "Thai", THAI },
            };

            private string _value;

            public LanguageEnum()
            {

            }

            public LanguageEnum(string value)
            {
                _value = value;
            }

            public static LanguageEnum FromValue(string value)
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

                if (this.Equals(obj as LanguageEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LanguageEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LanguageEnum a, LanguageEnum b)
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

            public static bool operator !=(LanguageEnum a, LanguageEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语音合成特征字符串
        /// </summary>
        [JsonProperty("voice_asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VoiceAssetId { get; set; }

        /// <summary>
        /// 语速。默认值100，最小值50，最大值200。 &gt; 当取值为“100”时，表示一个成年人正常的语速，约为250字/分钟。
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public int? Speed { get; set; }

        /// <summary>
        /// 音高。默认值100，最小值50，最大值200。
        /// </summary>
        [JsonProperty("pitch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Pitch { get; set; }

        /// <summary>
        /// 音量。默认值140，最小值90，最大值240。
        /// </summary>
        [JsonProperty("volume", NullValueHandling = NullValueHandling.Ignore)]
        public int? Volume { get; set; }

        /// <summary>
        /// 第三方TTS供应商类型。 * XIMALAYA：喜马拉雅TTS * HUAWEI_EI：EI TTS * MOBVOI：出门问问TTS
        /// </summary>
        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider { get; set; }

        /// <summary>
        /// 语言类型。默认值CN。 * CN：简体中文。 * EN：英语。 * ESP：西班牙语（仅海外站点支持） * por：葡萄牙语（仅海外站点支持） * Arabic：阿拉伯语（仅海外站点支持） * Thai：泰语（仅海外站点支持）
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatVoiceConfig {\n");
            sb.Append("  voiceAssetId: ").Append(VoiceAssetId).Append("\n");
            sb.Append("  speed: ").Append(Speed).Append("\n");
            sb.Append("  pitch: ").Append(Pitch).Append("\n");
            sb.Append("  volume: ").Append(Volume).Append("\n");
            sb.Append("  provider: ").Append(Provider).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ChatVoiceConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ChatVoiceConfig input)
        {
            if (input == null) return false;
            if (this.VoiceAssetId != input.VoiceAssetId || (this.VoiceAssetId != null && !this.VoiceAssetId.Equals(input.VoiceAssetId))) return false;
            if (this.Speed != input.Speed || (this.Speed != null && !this.Speed.Equals(input.Speed))) return false;
            if (this.Pitch != input.Pitch || (this.Pitch != null && !this.Pitch.Equals(input.Pitch))) return false;
            if (this.Volume != input.Volume || (this.Volume != null && !this.Volume.Equals(input.Volume))) return false;
            if (this.Provider != input.Provider || (this.Provider != null && !this.Provider.Equals(input.Provider))) return false;
            if (this.Language != input.Language) return false;

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
                if (this.VoiceAssetId != null) hashCode = hashCode * 59 + this.VoiceAssetId.GetHashCode();
                if (this.Speed != null) hashCode = hashCode * 59 + this.Speed.GetHashCode();
                if (this.Pitch != null) hashCode = hashCode * 59 + this.Pitch.GetHashCode();
                if (this.Volume != null) hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Provider != null) hashCode = hashCode * 59 + this.Provider.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                return hashCode;
            }
        }
    }
}
