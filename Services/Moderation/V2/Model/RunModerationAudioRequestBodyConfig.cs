using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Moderation.V2.Model
{
    /// <summary>
    /// 语音文件配置信息
    /// </summary>
    public class RunModerationAudioRequestBodyConfig 
    {
        /// <summary>
        /// 支持的语音格式
        /// </summary>
        /// <value>支持的语音格式</value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum PCM16K16BIT for value: pcm16k16bit
            /// </summary>
            public static readonly FormatEnum PCM16K16BIT = new FormatEnum("pcm16k16bit");

            /// <summary>
            /// Enum PCM8K16BIT for value: pcm8k16bit
            /// </summary>
            public static readonly FormatEnum PCM8K16BIT = new FormatEnum("pcm8k16bit");

            /// <summary>
            /// Enum ULAW16K8BIT for value: ulaw16k8bit
            /// </summary>
            public static readonly FormatEnum ULAW16K8BIT = new FormatEnum("ulaw16k8bit");

            /// <summary>
            /// Enum ULAW8K8BIT for value: ulaw8k8bit
            /// </summary>
            public static readonly FormatEnum ULAW8K8BIT = new FormatEnum("ulaw8k8bit");

            /// <summary>
            /// Enum ALAW16K8BIT for value: alaw16k8bit
            /// </summary>
            public static readonly FormatEnum ALAW16K8BIT = new FormatEnum("alaw16k8bit");

            /// <summary>
            /// Enum ALAW8K8BIT for value: alaw8k8bit
            /// </summary>
            public static readonly FormatEnum ALAW8K8BIT = new FormatEnum("alaw8k8bit");

            /// <summary>
            /// Enum MP3 for value: mp3
            /// </summary>
            public static readonly FormatEnum MP3 = new FormatEnum("mp3");

            /// <summary>
            /// Enum AAC for value: aac
            /// </summary>
            public static readonly FormatEnum AAC = new FormatEnum("aac");

            /// <summary>
            /// Enum WAV for value: wav
            /// </summary>
            public static readonly FormatEnum WAV = new FormatEnum("wav");

            /// <summary>
            /// Enum AMR for value: amr
            /// </summary>
            public static readonly FormatEnum AMR = new FormatEnum("amr");

            /// <summary>
            /// Enum AMRWB for value: amrwb
            /// </summary>
            public static readonly FormatEnum AMRWB = new FormatEnum("amrwb");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
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

            public FormatEnum(string value)
            {
                Value = value;
            }

            public static FormatEnum FromValue(string value)
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

                if (this.Equals(obj as FormatEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FormatEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(FormatEnum a, FormatEnum b)
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串：   chinese_8k_common   chinese_16k_common 
        /// </summary>
        /// <value>所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串：   chinese_8k_common   chinese_16k_common </value>
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
        /// 支持的语音格式
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 所使用的模型特征串。通常是 “语种_采样率_领域”的形式。 采样率需要与音频采样率保持一致。 当前支持如下模型特征串：   chinese_8k_common   chinese_16k_common 
        /// </summary>
        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public PropertyEnum Property { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunModerationAudioRequestBodyConfig {\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  property: ").Append(Property).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RunModerationAudioRequestBodyConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RunModerationAudioRequestBodyConfig input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Property == input.Property ||
                    (this.Property != null &&
                    this.Property.Equals(input.Property))
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
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Property != null)
                    hashCode = hashCode * 59 + this.Property.GetHashCode();
                return hashCode;
            }
        }
    }
}
