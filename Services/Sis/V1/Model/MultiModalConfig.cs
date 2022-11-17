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
    /// 多模态评测的配置
    /// </summary>
    public class MultiModalConfig 
    {
        /// <summary>
        /// 视频的封装格式。不填写此字段，则默认为auto。注意不论何种格式，均要求帧率在25fps以上，清晰度在240*240以上。   auto  自动判断，系统会自动判断视频封装格式。  avi  avi封装格式。  mp4  mp4封装格式。  webm  webm封装格式。  mkv  mkv封装格式。  flv  flv封装格式。 
        /// </summary>
        /// <value>视频的封装格式。不填写此字段，则默认为auto。注意不论何种格式，均要求帧率在25fps以上，清晰度在240*240以上。   auto  自动判断，系统会自动判断视频封装格式。  avi  avi封装格式。  mp4  mp4封装格式。  webm  webm封装格式。  mkv  mkv封装格式。  flv  flv封装格式。 </value>
        [JsonConverter(typeof(EnumClassConverter<VideoFormatEnum>))]
        public class VideoFormatEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly VideoFormatEnum AUTO = new VideoFormatEnum("auto");

            /// <summary>
            /// Enum AVI for value: avi
            /// </summary>
            public static readonly VideoFormatEnum AVI = new VideoFormatEnum("avi");

            /// <summary>
            /// Enum MP4 for value: mp4
            /// </summary>
            public static readonly VideoFormatEnum MP4 = new VideoFormatEnum("mp4");

            /// <summary>
            /// Enum WEBM for value: webm
            /// </summary>
            public static readonly VideoFormatEnum WEBM = new VideoFormatEnum("webm");

            /// <summary>
            /// Enum MKV for value: mkv
            /// </summary>
            public static readonly VideoFormatEnum MKV = new VideoFormatEnum("mkv");

            /// <summary>
            /// Enum FLV for value: flv
            /// </summary>
            public static readonly VideoFormatEnum FLV = new VideoFormatEnum("flv");

            private static readonly Dictionary<string, VideoFormatEnum> StaticFields =
            new Dictionary<string, VideoFormatEnum>()
            {
                { "auto", AUTO },
                { "avi", AVI },
                { "mp4", MP4 },
                { "webm", WEBM },
                { "mkv", MKV },
                { "flv", FLV },
            };

            private string Value;

            public VideoFormatEnum(string value)
            {
                Value = value;
            }

            public static VideoFormatEnum FromValue(string value)
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

                if (this.Equals(obj as VideoFormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoFormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(VideoFormatEnum a, VideoFormatEnum b)
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

            public static bool operator !=(VideoFormatEnum a, VideoFormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 评测语言和口音。  en_gb 英语-英式口音。
        /// </summary>
        /// <value>评测语言和口音。  en_gb 英语-英式口音。</value>
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
        /// 评测模式。  word 单词模式。  sentence 句子模式。
        /// </summary>
        /// <value>评测模式。  word 单词模式。  sentence 句子模式。</value>
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
        /// 视频的封装格式。不填写此字段，则默认为auto。注意不论何种格式，均要求帧率在25fps以上，清晰度在240*240以上。   auto  自动判断，系统会自动判断视频封装格式。  avi  avi封装格式。  mp4  mp4封装格式。  webm  webm封装格式。  mkv  mkv封装格式。  flv  flv封装格式。 
        /// </summary>
        [JsonProperty("video_format", NullValueHandling = NullValueHandling.Ignore)]
        public VideoFormatEnum VideoFormat { get; set; }
        /// <summary>
        /// 评测语言和口音。  en_gb 英语-英式口音。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 评测模式。  word 单词模式。  sentence 句子模式。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiModalConfig {\n");
            sb.Append("  videoFormat: ").Append(VideoFormat).Append("\n");
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
            return this.Equals(input as MultiModalConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MultiModalConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoFormat == input.VideoFormat ||
                    (this.VideoFormat != null &&
                    this.VideoFormat.Equals(input.VideoFormat))
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
                if (this.VideoFormat != null)
                    hashCode = hashCode * 59 + this.VideoFormat.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
