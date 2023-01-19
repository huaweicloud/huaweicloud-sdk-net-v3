using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vod.V1.Model
{
    /// <summary>
    /// 转码输出数组。 - HLS或DASH格式：此数组的成员个数为n+1，n为转码输出路数。 - MP4格式：此数组的成员个数为n，n为转码输出路数。
    /// </summary>
    public class Output 
    {
        /// <summary>
        /// 协议类型。  取值如下： - hls - dash - mp4
        /// </summary>
        /// <value>协议类型。  取值如下： - hls - dash - mp4</value>
        [JsonConverter(typeof(EnumClassConverter<PlayTypeEnum>))]
        public class PlayTypeEnum
        {
            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly PlayTypeEnum HLS = new PlayTypeEnum("HLS");

            /// <summary>
            /// Enum DASH for value: DASH
            /// </summary>
            public static readonly PlayTypeEnum DASH = new PlayTypeEnum("DASH");

            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly PlayTypeEnum MP4 = new PlayTypeEnum("MP4");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly PlayTypeEnum MP3 = new PlayTypeEnum("MP3");

            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly PlayTypeEnum AAC = new PlayTypeEnum("AAC");

            private static readonly Dictionary<string, PlayTypeEnum> StaticFields =
            new Dictionary<string, PlayTypeEnum>()
            {
                { "HLS", HLS },
                { "DASH", DASH },
                { "MP4", MP4 },
                { "MP3", MP3 },
                { "AAC", AAC },
            };

            private string _value;

            public PlayTypeEnum()
            {

            }

            public PlayTypeEnum(string value)
            {
                _value = value;
            }

            public static PlayTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PlayTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlayTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlayTypeEnum a, PlayTypeEnum b)
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

            public static bool operator !=(PlayTypeEnum a, PlayTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 清晰度。  取值如下： - FLUENT：流畅 - SD：标清 - HD：高清 - FULL_HD：超清
        /// </summary>
        /// <value>清晰度。  取值如下： - FLUENT：流畅 - SD：标清 - HD：高清 - FULL_HD：超清</value>
        [JsonConverter(typeof(EnumClassConverter<QualityEnum>))]
        public class QualityEnum
        {
            /// <summary>
            /// Enum FLUENT for value: FLUENT
            /// </summary>
            public static readonly QualityEnum FLUENT = new QualityEnum("FLUENT");

            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            public static readonly QualityEnum SD = new QualityEnum("SD");

            /// <summary>
            /// Enum HD for value: HD
            /// </summary>
            public static readonly QualityEnum HD = new QualityEnum("HD");

            /// <summary>
            /// Enum FULL_HD for value: FULL_HD
            /// </summary>
            public static readonly QualityEnum FULL_HD = new QualityEnum("FULL_HD");

            private static readonly Dictionary<string, QualityEnum> StaticFields =
            new Dictionary<string, QualityEnum>()
            {
                { "FLUENT", FLUENT },
                { "SD", SD },
                { "HD", HD },
                { "FULL_HD", FULL_HD },
            };

            private string _value;

            public QualityEnum()
            {

            }

            public QualityEnum(string value)
            {
                _value = value;
            }

            public static QualityEnum FromValue(string value)
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

                if (this.Equals(obj as QualityEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QualityEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QualityEnum a, QualityEnum b)
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

            public static bool operator !=(QualityEnum a, QualityEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 协议类型。  取值如下： - hls - dash - mp4
        /// </summary>
        [JsonProperty("play_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlayTypeEnum PlayType { get; set; }
        /// <summary>
        /// 播放URL。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 标记流是否已被加密。  取值如下： - 0：表示未加密。 - 1：表示已被加密。
        /// </summary>
        [JsonProperty("encrypted", NullValueHandling = NullValueHandling.Ignore)]
        public int? Encrypted { get; set; }

        /// <summary>
        /// 清晰度。  取值如下： - FLUENT：流畅 - SD：标清 - HD：高清 - FULL_HD：超清
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public QualityEnum Quality { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData MetaData { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Output {\n");
            sb.Append("  playType: ").Append(PlayType).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Output);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Output input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlayType == input.PlayType ||
                    (this.PlayType != null &&
                    this.PlayType.Equals(input.PlayType))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Encrypted == input.Encrypted ||
                    (this.Encrypted != null &&
                    this.Encrypted.Equals(input.Encrypted))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
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
                if (this.PlayType != null)
                    hashCode = hashCode * 59 + this.PlayType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Encrypted != null)
                    hashCode = hashCode * 59 + this.Encrypted.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                return hashCode;
            }
        }
    }
}
