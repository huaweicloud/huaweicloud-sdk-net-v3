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
    /// 音色模型元数据。
    /// </summary>
    public class VoiceModelAssetMeta 
    {
        /// <summary>
        /// **参数解释**： 声音资产类型。 **约束限制**： 不涉及。 **取值范围**： * COMMON：通用情感模型 * CLONE：语音克隆模型
        /// </summary>
        /// <value>**参数解释**： 声音资产类型。 **约束限制**： 不涉及。 **取值范围**： * COMMON：通用情感模型 * CLONE：语音克隆模型</value>
        [JsonConverter(typeof(EnumClassConverter<ModelTypeEnum>))]
        public class ModelTypeEnum
        {
            /// <summary>
            /// Enum COMMON for value: COMMON
            /// </summary>
            public static readonly ModelTypeEnum COMMON = new ModelTypeEnum("COMMON");

            /// <summary>
            /// Enum CLONE for value: CLONE
            /// </summary>
            public static readonly ModelTypeEnum CLONE = new ModelTypeEnum("CLONE");

            private static readonly Dictionary<string, ModelTypeEnum> StaticFields =
            new Dictionary<string, ModelTypeEnum>()
            {
                { "COMMON", COMMON },
                { "CLONE", CLONE },
            };

            private string _value;

            public ModelTypeEnum()
            {

            }

            public ModelTypeEnum(string value)
            {
                _value = value;
            }

            public static ModelTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ModelTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModelTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModelTypeEnum a, ModelTypeEnum b)
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

            public static bool operator !=(ModelTypeEnum a, ModelTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 声音性别。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知性别声音 * MALE：男性声音 * FEMALE：女性声音
        /// </summary>
        /// <value>**参数解释**： 声音性别。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知性别声音 * MALE：男性声音 * FEMALE：女性声音</value>
        [JsonConverter(typeof(EnumClassConverter<SexEnum>))]
        public class SexEnum
        {
            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly SexEnum UNKNOW = new SexEnum("UNKNOW");

            /// <summary>
            /// Enum MALE for value: MALE
            /// </summary>
            public static readonly SexEnum MALE = new SexEnum("MALE");

            /// <summary>
            /// Enum FEMALE for value: FEMALE
            /// </summary>
            public static readonly SexEnum FEMALE = new SexEnum("FEMALE");

            private static readonly Dictionary<string, SexEnum> StaticFields =
            new Dictionary<string, SexEnum>()
            {
                { "UNKNOW", UNKNOW },
                { "MALE", MALE },
                { "FEMALE", FEMALE },
            };

            private string _value;

            public SexEnum()
            {

            }

            public SexEnum(string value)
            {
                _value = value;
            }

            public static SexEnum FromValue(string value)
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

                if (this.Equals(obj as SexEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SexEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SexEnum a, SexEnum b)
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

            public static bool operator !=(SexEnum a, SexEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语
        /// </summary>
        /// <value>**参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly LanguageEnum UNKNOW = new LanguageEnum("UNKNOW");

            /// <summary>
            /// Enum CN for value: CN
            /// </summary>
            public static readonly LanguageEnum CN = new LanguageEnum("CN");

            /// <summary>
            /// Enum EN for value: EN
            /// </summary>
            public static readonly LanguageEnum EN = new LanguageEnum("EN");

            /// <summary>
            /// Enum GER for value: GER
            /// </summary>
            public static readonly LanguageEnum GER = new LanguageEnum("GER");

            /// <summary>
            /// Enum FR for value: fr
            /// </summary>
            public static readonly LanguageEnum FR = new LanguageEnum("fr");

            /// <summary>
            /// Enum KR for value: Kr
            /// </summary>
            public static readonly LanguageEnum KR = new LanguageEnum("Kr");

            /// <summary>
            /// Enum POR for value: por
            /// </summary>
            public static readonly LanguageEnum POR = new LanguageEnum("por");

            /// <summary>
            /// Enum JPN for value: JPN
            /// </summary>
            public static readonly LanguageEnum JPN = new LanguageEnum("JPN");

            /// <summary>
            /// Enum ITA for value: Ita
            /// </summary>
            public static readonly LanguageEnum ITA = new LanguageEnum("Ita");

            /// <summary>
            /// Enum ESP for value: ESP
            /// </summary>
            public static readonly LanguageEnum ESP = new LanguageEnum("ESP");

            /// <summary>
            /// Enum DBH for value: DBH
            /// </summary>
            public static readonly LanguageEnum DBH = new LanguageEnum("DBH");

            /// <summary>
            /// Enum GT for value: GT
            /// </summary>
            public static readonly LanguageEnum GT = new LanguageEnum("GT");

            /// <summary>
            /// Enum GXH for value: GXH
            /// </summary>
            public static readonly LanguageEnum GXH = new LanguageEnum("GXH");

            /// <summary>
            /// Enum HBH for value: HBH
            /// </summary>
            public static readonly LanguageEnum HBH = new LanguageEnum("HBH");

            /// <summary>
            /// Enum SXH for value: SXH
            /// </summary>
            public static readonly LanguageEnum SXH = new LanguageEnum("SXH");

            /// <summary>
            /// Enum SCH for value: SCH
            /// </summary>
            public static readonly LanguageEnum SCH = new LanguageEnum("SCH");

            /// <summary>
            /// Enum YY for value: YY
            /// </summary>
            public static readonly LanguageEnum YY = new LanguageEnum("YY");

            /// <summary>
            /// Enum RUSSIAN for value: Russian
            /// </summary>
            public static readonly LanguageEnum RUSSIAN = new LanguageEnum("Russian");

            /// <summary>
            /// Enum FILIPINO for value: Filipino
            /// </summary>
            public static readonly LanguageEnum FILIPINO = new LanguageEnum("Filipino");

            /// <summary>
            /// Enum DUTCH for value: Dutch
            /// </summary>
            public static readonly LanguageEnum DUTCH = new LanguageEnum("Dutch");

            /// <summary>
            /// Enum INDONESIAN for value: Indonesian
            /// </summary>
            public static readonly LanguageEnum INDONESIAN = new LanguageEnum("Indonesian");

            /// <summary>
            /// Enum VIETNAMESE for value: Vietnamese
            /// </summary>
            public static readonly LanguageEnum VIETNAMESE = new LanguageEnum("Vietnamese");

            /// <summary>
            /// Enum ARABIC for value: Arabic
            /// </summary>
            public static readonly LanguageEnum ARABIC = new LanguageEnum("Arabic");

            /// <summary>
            /// Enum TURKISH for value: Turkish
            /// </summary>
            public static readonly LanguageEnum TURKISH = new LanguageEnum("Turkish");

            /// <summary>
            /// Enum MALAY for value: Malay
            /// </summary>
            public static readonly LanguageEnum MALAY = new LanguageEnum("Malay");

            /// <summary>
            /// Enum THAI for value: Thai
            /// </summary>
            public static readonly LanguageEnum THAI = new LanguageEnum("Thai");

            /// <summary>
            /// Enum FINNISH for value: Finnish
            /// </summary>
            public static readonly LanguageEnum FINNISH = new LanguageEnum("Finnish");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "UNKNOW", UNKNOW },
                { "CN", CN },
                { "EN", EN },
                { "GER", GER },
                { "fr", FR },
                { "Kr", KR },
                { "por", POR },
                { "JPN", JPN },
                { "Ita", ITA },
                { "ESP", ESP },
                { "DBH", DBH },
                { "GT", GT },
                { "GXH", GXH },
                { "HBH", HBH },
                { "SXH", SXH },
                { "SCH", SCH },
                { "YY", YY },
                { "Russian", RUSSIAN },
                { "Filipino", FILIPINO },
                { "Dutch", DUTCH },
                { "Indonesian", INDONESIAN },
                { "Vietnamese", VIETNAMESE },
                { "Arabic", ARABIC },
                { "Turkish", TURKISH },
                { "Malay", MALAY },
                { "Thai", THAI },
                { "Finnish", FINNISH },
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
        /// **参数解释**： 展示顺序。 **约束限制**： 不涉及。
        /// </summary>
        [JsonProperty("order", NullValueHandling = NullValueHandling.Ignore)]
        public int? Order { get; set; }

        /// <summary>
        /// **参数解释**： 声音资产类型。 **约束限制**： 不涉及。 **取值范围**： * COMMON：通用情感模型 * CLONE：语音克隆模型
        /// </summary>
        [JsonProperty("model_type", NullValueHandling = NullValueHandling.Ignore)]
        public ModelTypeEnum ModelType { get; set; }
        /// <summary>
        /// **参数解释**： 声音性别。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知性别声音 * MALE：男性声音 * FEMALE：女性声音
        /// </summary>
        [JsonProperty("sex", NullValueHandling = NullValueHandling.Ignore)]
        public SexEnum Sex { get; set; }
        /// <summary>
        /// **参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// **参数解释**： 声音语言。 **约束限制**： 不涉及。 **取值范围**： * UNKNOW：未知 * CN：中文 * EN：英文 * GER：德语 * fr：法语 * Kr：韩语 * por：葡萄牙语 * JPN：日语 * Ita：意大利语 * ESP：西班牙语 * DBH：东北话 * GT：港台 * GXH：广西话 * HBH：湖北话 * SXH：陕西话 * SCH：四川话 * YY：粤语 * Russian: 俄罗斯语 * Filipino: 菲律宾语 * Dutch: 荷兰语 * Indonesian: 印尼语 * Vietnamese: 越南语 * Arabic: 阿拉伯语 * Turkish: 土耳其语 * Malay: 马来语 * Thai: 泰语 * Finnish: 芬兰语
        /// </summary>
        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public List<VoiceLanguage> Languages { get; set; }

        /// <summary>
        /// **参数解释**： 语速缩放比例。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("speed_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public float? SpeedRatio { get; set; }

        /// <summary>
        /// **参数解释**： 音量缩放比例。 **约束限制**： 不涉及
        /// </summary>
        [JsonProperty("volume_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public float? VolumeRatio { get; set; }

        /// <summary>
        /// **参数解释**： 该音色是否支持实时合成。 **约束限制**： 支持实时合成的音色，可以用于直播和智能交互场景。否则只能用于视频制作。 **取值范围**： * true: 支持实时合成 * false: 不支持实时合成
        /// </summary>
        [JsonProperty("is_realtime_voice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRealtimeVoice { get; set; }

        /// <summary>
        /// 风格参考
        /// </summary>
        [JsonProperty("style", NullValueHandling = NullValueHandling.Ignore)]
        public string Style { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("voice_capability", NullValueHandling = NullValueHandling.Ignore)]
        public VoiceCapability VoiceCapability { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("external_voice_meta", NullValueHandling = NullValueHandling.Ignore)]
        public ExternalVoiceAssetMeta ExternalVoiceMeta { get; set; }

        /// <summary>
        /// 是否支持vc。
        /// </summary>
        [JsonProperty("is_support_vc_process", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportVcProcess { get; set; }

        /// <summary>
        /// 是否支持泰语文本自动分句。
        /// </summary>
        [JsonProperty("is_support_thai_auto_split", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportThaiAutoSplit { get; set; }

        /// <summary>
        /// 是否是Flexus版本声音。
        /// </summary>
        [JsonProperty("is_flexus", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsFlexus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VoiceModelAssetMeta {\n");
            sb.Append("  order: ").Append(Order).Append("\n");
            sb.Append("  modelType: ").Append(ModelType).Append("\n");
            sb.Append("  sex: ").Append(Sex).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  languages: ").Append(Languages).Append("\n");
            sb.Append("  speedRatio: ").Append(SpeedRatio).Append("\n");
            sb.Append("  volumeRatio: ").Append(VolumeRatio).Append("\n");
            sb.Append("  isRealtimeVoice: ").Append(IsRealtimeVoice).Append("\n");
            sb.Append("  style: ").Append(Style).Append("\n");
            sb.Append("  voiceCapability: ").Append(VoiceCapability).Append("\n");
            sb.Append("  externalVoiceMeta: ").Append(ExternalVoiceMeta).Append("\n");
            sb.Append("  isSupportVcProcess: ").Append(IsSupportVcProcess).Append("\n");
            sb.Append("  isSupportThaiAutoSplit: ").Append(IsSupportThaiAutoSplit).Append("\n");
            sb.Append("  isFlexus: ").Append(IsFlexus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VoiceModelAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VoiceModelAssetMeta input)
        {
            if (input == null) return false;
            if (this.Order != input.Order || (this.Order != null && !this.Order.Equals(input.Order))) return false;
            if (this.ModelType != input.ModelType) return false;
            if (this.Sex != input.Sex) return false;
            if (this.Language != input.Language) return false;
            if (this.Languages != input.Languages || (this.Languages != null && input.Languages != null && !this.Languages.SequenceEqual(input.Languages))) return false;
            if (this.SpeedRatio != input.SpeedRatio || (this.SpeedRatio != null && !this.SpeedRatio.Equals(input.SpeedRatio))) return false;
            if (this.VolumeRatio != input.VolumeRatio || (this.VolumeRatio != null && !this.VolumeRatio.Equals(input.VolumeRatio))) return false;
            if (this.IsRealtimeVoice != input.IsRealtimeVoice || (this.IsRealtimeVoice != null && !this.IsRealtimeVoice.Equals(input.IsRealtimeVoice))) return false;
            if (this.Style != input.Style || (this.Style != null && !this.Style.Equals(input.Style))) return false;
            if (this.VoiceCapability != input.VoiceCapability || (this.VoiceCapability != null && !this.VoiceCapability.Equals(input.VoiceCapability))) return false;
            if (this.ExternalVoiceMeta != input.ExternalVoiceMeta || (this.ExternalVoiceMeta != null && !this.ExternalVoiceMeta.Equals(input.ExternalVoiceMeta))) return false;
            if (this.IsSupportVcProcess != input.IsSupportVcProcess || (this.IsSupportVcProcess != null && !this.IsSupportVcProcess.Equals(input.IsSupportVcProcess))) return false;
            if (this.IsSupportThaiAutoSplit != input.IsSupportThaiAutoSplit || (this.IsSupportThaiAutoSplit != null && !this.IsSupportThaiAutoSplit.Equals(input.IsSupportThaiAutoSplit))) return false;
            if (this.IsFlexus != input.IsFlexus || (this.IsFlexus != null && !this.IsFlexus.Equals(input.IsFlexus))) return false;

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
                if (this.Order != null) hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.ModelType.GetHashCode();
                hashCode = hashCode * 59 + this.Sex.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Languages != null) hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.SpeedRatio != null) hashCode = hashCode * 59 + this.SpeedRatio.GetHashCode();
                if (this.VolumeRatio != null) hashCode = hashCode * 59 + this.VolumeRatio.GetHashCode();
                if (this.IsRealtimeVoice != null) hashCode = hashCode * 59 + this.IsRealtimeVoice.GetHashCode();
                if (this.Style != null) hashCode = hashCode * 59 + this.Style.GetHashCode();
                if (this.VoiceCapability != null) hashCode = hashCode * 59 + this.VoiceCapability.GetHashCode();
                if (this.ExternalVoiceMeta != null) hashCode = hashCode * 59 + this.ExternalVoiceMeta.GetHashCode();
                if (this.IsSupportVcProcess != null) hashCode = hashCode * 59 + this.IsSupportVcProcess.GetHashCode();
                if (this.IsSupportThaiAutoSplit != null) hashCode = hashCode * 59 + this.IsSupportThaiAutoSplit.GetHashCode();
                if (this.IsFlexus != null) hashCode = hashCode * 59 + this.IsFlexus.GetHashCode();
                return hashCode;
            }
        }
    }
}
