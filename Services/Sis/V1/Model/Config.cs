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
        /// 支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。  auto 由引擎自动判断音频数据的格式并解码，支持自动判断wav，mp3，amr/amrwb，aac，m4a，wma格式
        /// </summary>
        /// <value>支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。  auto 由引擎自动判断音频数据的格式并解码，支持自动判断wav，mp3，amr/amrwb，aac，m4a，wma格式</value>
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

            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly AudioFormatEnum AUTO = new AudioFormatEnum("auto");

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
                { "auto", AUTO },
            };

            private string _value;

            public AudioFormatEnum()
            {

            }

            public AudioFormatEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioFormatEnum a, AudioFormatEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  chinese_16k_travel 支持采样率为16k的中文普通话语音识别，采用新一代端到端识别算法，并针对网约车质检场景进行了优化。格式仅支持pcm16k16bit、mp3、wav和aac，区域支持cn-east-3和cn-north-4（强烈推荐使用）。  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。  english_8k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。  english_16k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。
        /// </summary>
        /// <value>所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  chinese_16k_travel 支持采样率为16k的中文普通话语音识别，采用新一代端到端识别算法，并针对网约车质检场景进行了优化。格式仅支持pcm16k16bit、mp3、wav和aac，区域支持cn-east-3和cn-north-4（强烈推荐使用）。  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。  english_8k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。  english_16k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。</value>
        [JsonConverter(typeof(EnumClassConverter<PropertyEnum>))]
        public class PropertyEnum
        {
            /// <summary>
            /// Enum CHINESE_16K_GENERAL for value: chinese_16k_general
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_GENERAL = new PropertyEnum("chinese_16k_general");

            /// <summary>
            /// Enum CHINESE_16K_TRAVEL for value: chinese_16k_travel
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_TRAVEL = new PropertyEnum("chinese_16k_travel");

            /// <summary>
            /// Enum CHINESE_8K_COMMON for value: chinese_8k_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_8K_COMMON = new PropertyEnum("chinese_8k_common");

            /// <summary>
            /// Enum CHINESE_16K_COMMON for value: chinese_16k_common
            /// </summary>
            public static readonly PropertyEnum CHINESE_16K_COMMON = new PropertyEnum("chinese_16k_common");

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

            /// <summary>
            /// Enum ENGLISH_8K_COMMON for value: english_8k_common
            /// </summary>
            public static readonly PropertyEnum ENGLISH_8K_COMMON = new PropertyEnum("english_8k_common");

            /// <summary>
            /// Enum ENGLISH_16K_COMMON for value: english_16k_common
            /// </summary>
            public static readonly PropertyEnum ENGLISH_16K_COMMON = new PropertyEnum("english_16k_common");

            private static readonly Dictionary<string, PropertyEnum> StaticFields =
            new Dictionary<string, PropertyEnum>()
            {
                { "chinese_16k_general", CHINESE_16K_GENERAL },
                { "chinese_16k_travel", CHINESE_16K_TRAVEL },
                { "chinese_8k_common", CHINESE_8K_COMMON },
                { "chinese_16k_common", CHINESE_16K_COMMON },
                { "sichuan_16k_common", SICHUAN_16K_COMMON },
                { "cantonese_16k_common", CANTONESE_16K_COMMON },
                { "shanghai_16k_common", SHANGHAI_16K_COMMON },
                { "english_8k_common", ENGLISH_8K_COMMON },
                { "english_16k_common", ENGLISH_16K_COMMON },
            };

            private string _value;

            public PropertyEnum()
            {

            }

            public PropertyEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PropertyEnum a, PropertyEnum b)
            {
                if (ReferenceEquals(a, b))
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

            private string _value;

            public AddPuncEnum()
            {

            }

            public AddPuncEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AddPuncEnum a, AddPuncEnum b)
            {
                if (ReferenceEquals(a, b))
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

            private string _value;

            public DigitNormEnum()
            {

            }

            public DigitNormEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DigitNormEnum a, DigitNormEnum b)
            {
                if (ReferenceEquals(a, b))
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

            private string _value;

            public NeedWordInfoEnum()
            {

            }

            public NeedWordInfoEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(NeedWordInfoEnum a, NeedWordInfoEnum b)
            {
                if (ReferenceEquals(a, b))
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
        /// 表示是否开启普英方自动识别，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        /// <value>表示是否开启普英方自动识别，取值为“yes”和“no”，默认为“no”。</value>
        [JsonConverter(typeof(EnumClassConverter<AutoLanguageDetectEnum>))]
        public class AutoLanguageDetectEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly AutoLanguageDetectEnum YES = new AutoLanguageDetectEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly AutoLanguageDetectEnum NO = new AutoLanguageDetectEnum("no");

            private static readonly Dictionary<string, AutoLanguageDetectEnum> StaticFields =
            new Dictionary<string, AutoLanguageDetectEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string _value;

            public AutoLanguageDetectEnum()
            {

            }

            public AutoLanguageDetectEnum(string value)
            {
                _value = value;
            }

            public static AutoLanguageDetectEnum FromValue(string value)
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

                if (this.Equals(obj as AutoLanguageDetectEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoLanguageDetectEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AutoLanguageDetectEnum a, AutoLanguageDetectEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AutoLanguageDetectEnum a, AutoLanguageDetectEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 支持语音的格式。  audio_format取值范围：  pcm16k16bit  16k16bit单通道录音数据。  pcm8k16bit   8k16bit单通道录音数据。  ulaw16k8bit  16k8bit ulaw 单通道录音数据。  ulaw8k8bit   8k8bit ulaw 单通道录音数据。  alaw16k8bit  16k8bit alaw 单通道录音数据。  alaw8k8bit   8k8bit alaw 单通道录音数据。  mp3  mp3格式音频。目前仅支持单通道的音频。  aac  aac格式音频。目前仅支持单通道的音频。  wav  带wav封装头的格式，从封装头中自动确定格式，目前仅支持8k/16k采样率、单通道、pcm, alaw, ulaw三种编码格式  amr  AMR窄带(8k) 压缩录音数据。  amrwb  AMR 宽带(16k) 压缩录音数据。  auto 由引擎自动判断音频数据的格式并解码，支持自动判断wav，mp3，amr/amrwb，aac，m4a，wma格式
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。  采样率需要与音频采样率保持一致。  当前支持如下模型特征串：  chinese_16k_general  支持采样率为16k的中文普通话语音识别，同时可识别一些简单的方言。格式仅支持pcm16k16bit、mp3、wav，区域仅支持cn-north-4。  chinese_16k_travel 支持采样率为16k的中文普通话语音识别，采用新一代端到端识别算法，并针对网约车质检场景进行了优化。格式仅支持pcm16k16bit、mp3、wav和aac，区域支持cn-east-3和cn-north-4（强烈推荐使用）。  chinese_8k_common  支持采样率为8k的中文普通话语音识别。  chinese_16k_common  支持采样率为16k的中文普通话语音识别。  sichuan_16k_common  支持采样率为16k的中文普通话与四川话方言识别。区域仅支持cn-north-4。  cantonese_16k_common  支持采样率为16k的粤语方言识别。区域仅支持cn-north-4。  shanghai_16k_common  支持采样率为16k的上海话方言识别，区域仅支持cn-north-4。  english_8k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。  english_16k_common  支持采样率为16k的英文识别，区域仅支持cn-east-3，格式仅支持wav。
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
        /// 表示是否开启普英方自动识别，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        [JsonProperty("auto_language_detect", NullValueHandling = NullValueHandling.Ignore)]
        public AutoLanguageDetectEnum AutoLanguageDetect { get; set; }


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
            sb.Append("  autoLanguageDetect: ").Append(AutoLanguageDetect).Append("\n");
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
            if (input == null) return false;
            if (this.AudioFormat != input.AudioFormat) return false;
            if (this.Property != input.Property) return false;
            if (this.AddPunc != input.AddPunc) return false;
            if (this.VocabularyId != input.VocabularyId || (this.VocabularyId != null && !this.VocabularyId.Equals(input.VocabularyId))) return false;
            if (this.DigitNorm != input.DigitNorm) return false;
            if (this.NeedWordInfo != input.NeedWordInfo) return false;
            if (this.AutoLanguageDetect != input.AutoLanguageDetect) return false;

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
                hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                hashCode = hashCode * 59 + this.Property.GetHashCode();
                hashCode = hashCode * 59 + this.AddPunc.GetHashCode();
                if (this.VocabularyId != null) hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                hashCode = hashCode * 59 + this.DigitNorm.GetHashCode();
                hashCode = hashCode * 59 + this.NeedWordInfo.GetHashCode();
                hashCode = hashCode * 59 + this.AutoLanguageDetect.GetHashCode();
                return hashCode;
            }
        }
    }
}
