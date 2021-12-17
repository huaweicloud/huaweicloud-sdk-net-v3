using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Sis.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Config 
    {
        /// <summary>
        /// 支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。
        /// </summary>
        /// <value>支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。</value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum PCM16K16BIT for value: pcm16k16bit
            /// </summary>
            public static readonly AudioFormatEnum PCM16K16BIT = new AudioFormatEnum("pcm16k16bit");

            /// <summary>
            /// Enum PCM8K16BIT for value: pcm8k16bit
            /// </summary>
            public static readonly AudioFormatEnum PCM8K16BIT = new AudioFormatEnum("pcm8k16bit");

            /// <summary>
            /// Enum ULAW16K8BIT for value: ulaw16k8bit
            /// </summary>
            public static readonly AudioFormatEnum ULAW16K8BIT = new AudioFormatEnum("ulaw16k8bit");

            /// <summary>
            /// Enum ULAW8K8BIT for value: ulaw8k8bit
            /// </summary>
            public static readonly AudioFormatEnum ULAW8K8BIT = new AudioFormatEnum("ulaw8k8bit");

            /// <summary>
            /// Enum ALAW16K8BIT for value: alaw16k8bit
            /// </summary>
            public static readonly AudioFormatEnum ALAW16K8BIT = new AudioFormatEnum("alaw16k8bit");

            /// <summary>
            /// Enum ALAW8K8BIT for value: alaw8k8bit
            /// </summary>
            public static readonly AudioFormatEnum ALAW8K8BIT = new AudioFormatEnum("alaw8k8bit");

            /// <summary>
            /// Enum MP3 for value: mp3
            /// </summary>
            public static readonly AudioFormatEnum MP3 = new AudioFormatEnum("mp3");

            /// <summary>
            /// Enum AAC for value: aac
            /// </summary>
            public static readonly AudioFormatEnum AAC = new AudioFormatEnum("aac");

            /// <summary>
            /// Enum WAV for value: wav
            /// </summary>
            public static readonly AudioFormatEnum WAV = new AudioFormatEnum("wav");

            /// <summary>
            /// Enum AMR for value: amr
            /// </summary>
            public static readonly AudioFormatEnum AMR = new AudioFormatEnum("amr");

            /// <summary>
            /// Enum AMRWB for value: amrwb
            /// </summary>
            public static readonly AudioFormatEnum AMRWB = new AudioFormatEnum("amrwb");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "pcm16k16bit", PCM16K16BIT },
                { "pcm8k16bit", PCM8K16BIT },
                { "ulaw16k8bit", ULAW16K8BIT },
                { "ulaw8k8bit", ULAW8K8BIT },
                { "alaw16k8bit", ALAW16K8BIT },
                { "alaw8k8bit", ALAW8K8BIT },
                { "mp3", MP3 },
                { "aac", AAC },
                { "wav", WAV },
                { "amr", AMR },
                { "amrwb", AMRWB },
            };

            private string Value;

            public AudioFormatEnum(string value)
            {
                Value = value;
            }

            public static AudioFormatEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AudioFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AudioFormatEnum a, AudioFormatEnum b)
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

            public static bool operator !=(AudioFormatEnum a, AudioFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。
        /// </summary>
        /// <value>所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。</value>
        [JsonConverter(typeof(EnumClassConverter<PropertyEnum>))]
        public class PropertyEnum
        {
            /// <summary>
            /// Enum CHINESE_8K_COMMON for value: chinese_8k_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_8K_COMMON = new PropertyEnum("chinese_8k_common");

            /// <summary>
            /// Enum CHINESE_16K_COMMON for value: chinese_16k_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_COMMON = new PropertyEnum("chinese_16k_common");

            /// <summary>
            /// Enum CHINESE_16K_GENERAL for value: chinese_16k_general
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_GENERAL = new PropertyEnum("chinese_16k_general");

            /// <summary>
            /// Enum SICHUAN_16K_COMMON for value: sichuan_16k_common
            /// </summary>
            public static readonly PropertyEnum SICHUAN_16K_COMMON = new PropertyEnum("sichuan_16k_common");

            /// <summary>
            /// Enum CANTONESE_16K_COMMON for value: cantonese_16k_common
            /// </summary>
            public static readonly PropertyEnum CANTONESE_16K_COMMON = new PropertyEnum("cantonese_16k_common");

            /// <summary>
            /// Enum SHANGHAI_16K_COMMON for value: shanghai_16k_common
            /// </summary>
            public static readonly PropertyEnum SHANGHAI_16K_COMMON = new PropertyEnum("shanghai_16k_common");

            private static readonly Dictionary<string, PropertyEnum> StaticFields =
            new Dictionary<string, PropertyEnum>()
            {
                { "chinese_8k_common", CHINESE_8K_COMMON },
                { "chinese_16k_common", CHINESE_16K_COMMON },
                { "chinese_16k_general", CHINESE_16K_GENERAL },
                { "sichuan_16k_common", SICHUAN_16K_COMMON },
                { "cantonese_16k_common", CANTONESE_16K_COMMON },
                { "shanghai_16k_common", SHANGHAI_16K_COMMON },
            };

            private string Value;

            public PropertyEnum(string value)
            {
                Value = value;
            }

            public static PropertyEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as PropertyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PropertyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PropertyEnum a, PropertyEnum b)
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

            public static bool operator !=(PropertyEnum a, PropertyEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否在识别结果中添加标点，取值为“yes”和“no”，缺省为“no”。
        /// </summary>
        /// <value>表示是否在识别结果中添加标点，取值为“yes”和“no”，缺省为“no”。</value>
        [JsonConverter(typeof(EnumClassConverter<AddPuncEnum>))]
        public class AddPuncEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly AddPuncEnum YES = new AddPuncEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly AddPuncEnum NO = new AddPuncEnum("no");

            private static readonly Dictionary<string, AddPuncEnum> StaticFields =
            new Dictionary<string, AddPuncEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public AddPuncEnum(string value)
            {
                Value = value;
            }

            public static AddPuncEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AddPuncEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddPuncEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AddPuncEnum a, AddPuncEnum b)
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

            public static bool operator !=(AddPuncEnum a, AddPuncEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否将语音中的数字识别为阿拉伯数字，取值为“yes” 和 “no”，缺省为“yes”。
        /// </summary>
        /// <value>表示是否将语音中的数字识别为阿拉伯数字，取值为“yes” 和 “no”，缺省为“yes”。</value>
        [JsonConverter(typeof(EnumClassConverter<DigitNormEnum>))]
        public class DigitNormEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly DigitNormEnum YES = new DigitNormEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly DigitNormEnum NO = new DigitNormEnum("no");

            private static readonly Dictionary<string, DigitNormEnum> StaticFields =
            new Dictionary<string, DigitNormEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public DigitNormEnum(string value)
            {
                Value = value;
            }

            public static DigitNormEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as DigitNormEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DigitNormEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(DigitNormEnum a, DigitNormEnum b)
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

            public static bool operator !=(DigitNormEnum a, DigitNormEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        /// <value>表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。</value>
        [JsonConverter(typeof(EnumClassConverter<NeedWordInfoEnum>))]
        public class NeedWordInfoEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly NeedWordInfoEnum YES = new NeedWordInfoEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly NeedWordInfoEnum NO = new NeedWordInfoEnum("no");

            private static readonly Dictionary<string, NeedWordInfoEnum> StaticFields =
            new Dictionary<string, NeedWordInfoEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public NeedWordInfoEnum(string value)
            {
                Value = value;
            }

            public static NeedWordInfoEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as NeedWordInfoEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(NeedWordInfoEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(NeedWordInfoEnum a, NeedWordInfoEnum b)
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

            public static bool operator !=(NeedWordInfoEnum a, NeedWordInfoEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyEnum Property { get; set; }
        /// <summary>
        /// 表示是否在识别结果中添加标点，取值为“yes”和“no”，缺省为“no”。
        /// </summary>
        [JsonProperty("add_punc", NullValueHandling = NullValueHandling.Ignore)]
        public AddPuncEnum AddPunc { get; set; }
        /// <summary>
        /// 热词表id，不使用则不填写。
        /// </summary>
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// 表示是否将语音中的数字识别为阿拉伯数字，取值为“yes” 和 “no”，缺省为“yes”。
        /// </summary>
        [JsonProperty("digit_norm", NullValueHandling = NullValueHandling.Ignore)]
        public DigitNormEnum DigitNorm { get; set; }
        /// <summary>
        /// 表示是否在识别结果中输出分词结果信息，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        [JsonProperty("need_word_info", NullValueHandling = NullValueHandling.Ignore)]
        public NeedWordInfoEnum NeedWordInfo { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Config {\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  addPunc: ").Append(AddPunc).Append("\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  digitNorm: ").Append(DigitNorm).Append("\n");
            sb.Append("  needWordInfo: ").Append(NeedWordInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Config);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Config input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AudioFormat == input.AudioFormat ||
                    (this.AudioFormat != null &&
                    this.AudioFormat.Equals(input.AudioFormat))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.AddPunc == input.AddPunc ||
                    (this.AddPunc != null &&
                    this.AddPunc.Equals(input.AddPunc))
                ) && 
                (
                    this.VocabularyId == input.VocabularyId ||
                    (this.VocabularyId != null &&
                    this.VocabularyId.Equals(input.VocabularyId))
                ) && 
                (
                    this.DigitNorm == input.DigitNorm ||
                    (this.DigitNorm != null &&
                    this.DigitNorm.Equals(input.DigitNorm))
                ) && 
                (
                    this.NeedWordInfo == input.NeedWordInfo ||
                    (this.NeedWordInfo != null &&
                    this.NeedWordInfo.Equals(input.NeedWordInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AudioFormat != null)
                    hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.AddPunc != null)
                    hashCode = hashCode * 59 + this.AddPunc.GetHashCode();
                if (this.VocabularyId != null)
                    hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.DigitNorm != null)
                    hashCode = hashCode * 59 + this.DigitNorm.GetHashCode();
                if (this.NeedWordInfo != null)
                    hashCode = hashCode * 59 + this.NeedWordInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
