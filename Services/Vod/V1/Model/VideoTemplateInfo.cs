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
    /// 模板视频信息
    /// </summary>
    public class VideoTemplateInfo 
    {
        /// <summary>
        /// 画质。
        /// </summary>
        /// <value>画质。</value>
        [JsonConverter(typeof(EnumClassConverter<QualityEnum>))]
        public class QualityEnum
        {
            /// <summary>
            /// Enum FULL_HD for value: FULL_HD
            /// </summary>
            public static readonly QualityEnum FULL_HD = new QualityEnum("FULL_HD");

            /// <summary>
            /// Enum HD for value: HD
            /// </summary>
            public static readonly QualityEnum HD = new QualityEnum("HD");

            /// <summary>
            /// Enum SD for value: SD
            /// </summary>
            public static readonly QualityEnum SD = new QualityEnum("SD");

            /// <summary>
            /// Enum FLUENT for value: FLUENT
            /// </summary>
            public static readonly QualityEnum FLUENT = new QualityEnum("FLUENT");

            /// <summary>
            /// Enum AD for value: AD
            /// </summary>
            public static readonly QualityEnum AD = new QualityEnum("AD");

            /// <summary>
            /// Enum _2K for value: 2K
            /// </summary>
            public static readonly QualityEnum _2K = new QualityEnum("2K");

            /// <summary>
            /// Enum _4K for value: 4K
            /// </summary>
            public static readonly QualityEnum _4K = new QualityEnum("4K");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly QualityEnum UNKNOW = new QualityEnum("UNKNOW");

            private static readonly Dictionary<string, QualityEnum> StaticFields =
            new Dictionary<string, QualityEnum>()
            {
                { "FULL_HD", FULL_HD },
                { "HD", HD },
                { "SD", SD },
                { "FLUENT", FLUENT },
                { "AD", AD },
                { "2K", _2K },
                { "4K", _4K },
                { "UNKNOW", UNKNOW },
            };

            private string Value;

            public QualityEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 画质。
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public QualityEnum Quality { get; set; }
        /// <summary>
        /// 视频宽度。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 码率。
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 帧率（默认为1，1代表自适应，单位是帧每秒）。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoTemplateInfo {\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoTemplateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoTemplateInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Bitrate == input.Bitrate ||
                    (this.Bitrate != null &&
                    this.Bitrate.Equals(input.Bitrate))
                ) && 
                (
                    this.FrameRate == input.FrameRate ||
                    (this.FrameRate != null &&
                    this.FrameRate.Equals(input.FrameRate))
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
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Bitrate != null)
                    hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.FrameRate != null)
                    hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
