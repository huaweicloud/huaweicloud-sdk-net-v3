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
    /// Request Object
    /// </summary>
    public class RecognizeFlashAsrRequest 
    {
        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串： chinese_8k_common chinese_16k_common
        /// </summary>
        /// <value>所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串： chinese_8k_common chinese_16k_common</value>
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

            private static readonly Dictionary<string, PropertyEnum> StaticFields =
            new Dictionary<string, PropertyEnum>()
            {
                { "chinese_8k_common", CHINESE_8K_COMMON },
                { "chinese_16k_common", CHINESE_16K_COMMON },
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
        /// 音频格式，audio_format取值范围： wav,mp3,m4a,aac,opus
        /// </summary>
        /// <value>音频格式，audio_format取值范围： wav,mp3,m4a,aac,opus</value>
        [JsonConverter(typeof(EnumClassConverter<AudioFormatEnum>))]
        public class AudioFormatEnum
        {
            /// <summary>
            /// Enum WAV for value: wav
            /// </summary>
            public static readonly AudioFormatEnum WAV = new AudioFormatEnum("wav");

            /// <summary>
            /// Enum MP3 for value: mp3
            /// </summary>
            public static readonly AudioFormatEnum MP3 = new AudioFormatEnum("mp3");

            /// <summary>
            /// Enum M4A for value: m4a
            /// </summary>
            public static readonly AudioFormatEnum M4A = new AudioFormatEnum("m4a");

            /// <summary>
            /// Enum AAC for value: aac
            /// </summary>
            public static readonly AudioFormatEnum AAC = new AudioFormatEnum("aac");

            /// <summary>
            /// Enum OPUS for value: opus
            /// </summary>
            public static readonly AudioFormatEnum OPUS = new AudioFormatEnum("opus");

            private static readonly Dictionary<string, AudioFormatEnum> StaticFields =
            new Dictionary<string, AudioFormatEnum>()
            {
                { "wav", WAV },
                { "mp3", MP3 },
                { "m4a", M4A },
                { "aac", AAC },
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
        /// 是否加标点， 可以为 yes, 默认no
        /// </summary>
        /// <value>是否加标点， 可以为 yes, 默认no</value>
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
        /// 是否将音频中的数字使用阿拉伯数字的形式呈现，取值为yes，no，默认为yes
        /// </summary>
        /// <value>是否将音频中的数字使用阿拉伯数字的形式呈现，取值为yes，no，默认为yes</value>
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
        /// 表示是否在识别结果中输出分词结果信息，取值为yes，no，默认no
        /// </summary>
        /// <value>表示是否在识别结果中输出分词结果信息，取值为yes，no，默认no</value>
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
        /// 表示是否在识别中只识别首个声道的音频数据，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        /// <value>表示是否在识别中只识别首个声道的音频数据，取值为“yes”和“no”，默认为“no”。</value>
        [JsonConverter(typeof(EnumClassConverter<FirstChannelOnlyEnum>))]
        public class FirstChannelOnlyEnum
        {
            /// <summary>
            /// Enum YES for value: yes
            /// </summary>
            public static readonly FirstChannelOnlyEnum YES = new FirstChannelOnlyEnum("yes");

            /// <summary>
            /// Enum NO for value: no
            /// </summary>
            public static readonly FirstChannelOnlyEnum NO = new FirstChannelOnlyEnum("no");

            private static readonly Dictionary<string, FirstChannelOnlyEnum> StaticFields =
            new Dictionary<string, FirstChannelOnlyEnum>()
            {
                { "yes", YES },
                { "no", NO },
            };

            private string Value;

            public FirstChannelOnlyEnum(string value)
            {
                Value = value;
            }

            public static FirstChannelOnlyEnum FromValue(string value)
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

                if (this.Equals(obj as FirstChannelOnlyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FirstChannelOnlyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(FirstChannelOnlyEnum a, FirstChannelOnlyEnum b)
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

            public static bool operator !=(FirstChannelOnlyEnum a, FirstChannelOnlyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串： chinese_8k_common chinese_16k_common
        /// </summary>
        [SDKProperty("property", IsQuery = true)]
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyEnum Property { get; set; }
        /// <summary>
        /// 音频格式，audio_format取值范围： wav,mp3,m4a,aac,opus
        /// </summary>
        [SDKProperty("audio_format", IsQuery = true)]
        [JsonProperty("audio_format", NullValueHandling = NullValueHandling.Ignore)]
        public AudioFormatEnum AudioFormat { get; set; }
        /// <summary>
        /// 是否加标点， 可以为 yes, 默认no
        /// </summary>
        [SDKProperty("add_punc", IsQuery = true)]
        [JsonProperty("add_punc", NullValueHandling = NullValueHandling.Ignore)]
        public AddPuncEnum AddPunc { get; set; }
        /// <summary>
        /// 是否将音频中的数字使用阿拉伯数字的形式呈现，取值为yes，no，默认为yes
        /// </summary>
        [SDKProperty("digit_norm", IsQuery = true)]
        [JsonProperty("digit_norm", NullValueHandling = NullValueHandling.Ignore)]
        public DigitNormEnum DigitNorm { get; set; }
        /// <summary>
        /// 表示是否在识别结果中输出分词结果信息，取值为yes，no，默认no
        /// </summary>
        [SDKProperty("need_word_info", IsQuery = true)]
        [JsonProperty("need_word_info", NullValueHandling = NullValueHandling.Ignore)]
        public NeedWordInfoEnum NeedWordInfo { get; set; }
        /// <summary>
        /// 热词表id
        /// </summary>
        [SDKProperty("vocabulary_id", IsQuery = true)]
        [JsonProperty("vocabulary_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VocabularyId { get; set; }

        /// <summary>
        /// obs桶名
        /// </summary>
        [SDKProperty("obs_bucket_name", IsQuery = true)]
        [JsonProperty("obs_bucket_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsBucketName { get; set; }

        /// <summary>
        /// obs对象key，经过urlencode编码，长度不超过1024个字符
        /// </summary>
        [SDKProperty("obs_object_key", IsQuery = true)]
        [JsonProperty("obs_object_key", NullValueHandling = NullValueHandling.Ignore)]
        public string ObsObjectKey { get; set; }

        /// <summary>
        /// 表示是否在识别中只识别首个声道的音频数据，取值为“yes”和“no”，默认为“no”。
        /// </summary>
        [SDKProperty("first_channel_only", IsQuery = true)]
        [JsonProperty("first_channel_only", NullValueHandling = NullValueHandling.Ignore)]
        public FirstChannelOnlyEnum FirstChannelOnly { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecognizeFlashAsrRequest {\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("  audioFormat: ").Append(AudioFormat).Append("\n");
            sb.Append("  addPunc: ").Append(AddPunc).Append("\n");
            sb.Append("  digitNorm: ").Append(DigitNorm).Append("\n");
            sb.Append("  needWordInfo: ").Append(NeedWordInfo).Append("\n");
            sb.Append("  vocabularyId: ").Append(VocabularyId).Append("\n");
            sb.Append("  obsBucketName: ").Append(ObsBucketName).Append("\n");
            sb.Append("  obsObjectKey: ").Append(ObsObjectKey).Append("\n");
            sb.Append("  firstChannelOnly: ").Append(FirstChannelOnly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecognizeFlashAsrRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecognizeFlashAsrRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
                ) && 
                (
                    this.AudioFormat == input.AudioFormat ||
                    (this.AudioFormat != null &&
                    this.AudioFormat.Equals(input.AudioFormat))
                ) && 
                (
                    this.AddPunc == input.AddPunc ||
                    (this.AddPunc != null &&
                    this.AddPunc.Equals(input.AddPunc))
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
                ) && 
                (
                    this.VocabularyId == input.VocabularyId ||
                    (this.VocabularyId != null &&
                    this.VocabularyId.Equals(input.VocabularyId))
                ) && 
                (
                    this.ObsBucketName == input.ObsBucketName ||
                    (this.ObsBucketName != null &&
                    this.ObsBucketName.Equals(input.ObsBucketName))
                ) && 
                (
                    this.ObsObjectKey == input.ObsObjectKey ||
                    (this.ObsObjectKey != null &&
                    this.ObsObjectKey.Equals(input.ObsObjectKey))
                ) && 
                (
                    this.FirstChannelOnly == input.FirstChannelOnly ||
                    (this.FirstChannelOnly != null &&
                    this.FirstChannelOnly.Equals(input.FirstChannelOnly))
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
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                if (this.AudioFormat != null)
                    hashCode = hashCode * 59 + this.AudioFormat.GetHashCode();
                if (this.AddPunc != null)
                    hashCode = hashCode * 59 + this.AddPunc.GetHashCode();
                if (this.DigitNorm != null)
                    hashCode = hashCode * 59 + this.DigitNorm.GetHashCode();
                if (this.NeedWordInfo != null)
                    hashCode = hashCode * 59 + this.NeedWordInfo.GetHashCode();
                if (this.VocabularyId != null)
                    hashCode = hashCode * 59 + this.VocabularyId.GetHashCode();
                if (this.ObsBucketName != null)
                    hashCode = hashCode * 59 + this.ObsBucketName.GetHashCode();
                if (this.ObsObjectKey != null)
                    hashCode = hashCode * 59 + this.ObsObjectKey.GetHashCode();
                if (this.FirstChannelOnly != null)
                    hashCode = hashCode * 59 + this.FirstChannelOnly.GetHashCode();
                return hashCode;
            }
        }
    }
}
