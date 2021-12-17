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
    public class AudioConfig 
    {
        /// <summary>
        /// 语音的格式。不填写此字段，则默认为auto。注意音频不论何种格式，均要求采样率在16000Hz以上。  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw编码格式）、MP3、M4A、ogg-opus、AMR等格式。推荐使用此取值。  wav  wav格式。  aac  aac格式。  mp3  mp3格式。  amr  amr格式。  m4a  m4a格式。  opus  ogg-opus格式。 
        /// </summary>
        /// <value>语音的格式。不填写此字段，则默认为auto。注意音频不论何种格式，均要求采样率在16000Hz以上。  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw编码格式）、MP3、M4A、ogg-opus、AMR等格式。推荐使用此取值。  wav  wav格式。  aac  aac格式。  mp3  mp3格式。  amr  amr格式。  m4a  m4a格式。  opus  ogg-opus格式。 </value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly AudioFormatEnum AUTO = new AudioFormatEnum("auto");

            /// <summary>
            /// Enum WAV for value: wav
            /// </summary>
            public static readonly AudioFormatEnum WAV = new AudioFormatEnum("wav");

            /// <summary>
            /// Enum AAC for value: aac
            /// </summary>
            public static readonly AudioFormatEnum AAC = new AudioFormatEnum("aac");

            /// <summary>
            /// Enum MP3 for value: mp3
            /// </summary>
            public static readonly AudioFormatEnum MP3 = new AudioFormatEnum("mp3");

            /// <summary>
            /// Enum AMR for value: amr
            /// </summary>
            public static readonly AudioFormatEnum AMR = new AudioFormatEnum("amr");

            /// <summary>
            /// Enum M4A for value: m4a
            /// </summary>
            public static readonly AudioFormatEnum M4A = new AudioFormatEnum("m4a");

            /// <summary>
            /// Enum OPUS for value: opus
            /// </summary>
            public static readonly AudioFormatEnum OPUS = new AudioFormatEnum("opus");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "auto", AUTO },
                { "wav", WAV },
                { "aac", AAC },
                { "mp3", MP3 },
                { "amr", AMR },
                { "m4a", M4A },
                { "opus", OPUS },
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
        /// 评测语言  en_gb  英语-英式口音。
        /// </summary>
        /// <value>评测语言  en_gb  英语-英式口音。</value>
        [JsonConverter(typeof(EnumClassConverter<LanguageEnum>))]
        public class LanguageEnum
        {
            /// <summary>
            /// Enum EN_GB for value: en_gb
            /// </summary>
            public static readonly LanguageEnum EN_GB = new LanguageEnum("en_gb");

            private static readonly Dictionary<string, LanguageEnum> StaticFields =
            new Dictionary<string, LanguageEnum>()
            {
                { "en_gb", EN_GB },
            };

            private string Value;

            public LanguageEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 评测模式  word 单词模式  sentence 句子模式
        /// </summary>
        /// <value>评测模式  word 单词模式  sentence 句子模式</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum WORD for value: word
            /// </summary>
            public static readonly ModeEnum WORD = new ModeEnum("word");

            /// <summary>
            /// Enum SENTENCE for value: sentence
            /// </summary>
            public static readonly ModeEnum SENTENCE = new ModeEnum("sentence");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "word", WORD },
                { "sentence", SENTENCE },
            };

            private string Value;

            public ModeEnum(string value)
            {
                Value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 语音的格式。不填写此字段，则默认为auto。注意音频不论何种格式，均要求采样率在16000Hz以上。  auto  自动判断，系统会自动判断并支持WAV（内部支持pcm/ulaw/alaw编码格式）、MP3、M4A、ogg-opus、AMR等格式。推荐使用此取值。  wav  wav格式。  aac  aac格式。  mp3  mp3格式。  amr  amr格式。  m4a  m4a格式。  opus  ogg-opus格式。 
        /// </summary>
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 评测语言  en_gb  英语-英式口音。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 评测模式  word 单词模式  sentence 句子模式
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AudioConfig {\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AudioConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AudioConfig input)
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
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
