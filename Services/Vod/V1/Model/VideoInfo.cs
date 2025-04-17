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
    /// 
    /// </summary>
    public class VideoInfo 
    {
        /// <summary>
        /// 画质&lt;br/&gt; 4K默认分辨率3840*2160，码率8000kbit/s&lt;br/&gt; 2K默认分辨率2560*1440，码率7000kbit/s&lt;br/&gt; FULL_HD默认分辨率1920*1080，码率3000kbit/s&lt;br/&gt; HD默认分辨率1280*720，码率1000kbit/s&lt;br/&gt; SD默认分辨率854*480，码率600kbit/s&lt;br/&gt; FLUENT默认分辨率480*270，码率300kbit/s&lt;br/&gt; 
        /// </summary>
        /// <value>画质&lt;br/&gt; 4K默认分辨率3840*2160，码率8000kbit/s&lt;br/&gt; 2K默认分辨率2560*1440，码率7000kbit/s&lt;br/&gt; FULL_HD默认分辨率1920*1080，码率3000kbit/s&lt;br/&gt; HD默认分辨率1280*720，码率1000kbit/s&lt;br/&gt; SD默认分辨率854*480，码率600kbit/s&lt;br/&gt; FLUENT默认分辨率480*270，码率300kbit/s&lt;br/&gt; </value>
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
                { "2K", _2K },
                { "4K", _4K },
                { "UNKNOW", UNKNOW },
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
        /// 流名，流名仅支持数字、字母、下划线、中划线。 如果流名不填，则点播会按照video_stream_l{index}形式，生成一个流名。 
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }

        /// <summary>
        /// 画质&lt;br/&gt; 4K默认分辨率3840*2160，码率8000kbit/s&lt;br/&gt; 2K默认分辨率2560*1440，码率7000kbit/s&lt;br/&gt; FULL_HD默认分辨率1920*1080，码率3000kbit/s&lt;br/&gt; HD默认分辨率1280*720，码率1000kbit/s&lt;br/&gt; SD默认分辨率854*480，码率600kbit/s&lt;br/&gt; FLUENT默认分辨率480*270，码率300kbit/s&lt;br/&gt; 
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public QualityEnum Quality { get; set; }
        /// <summary>
        /// 视频宽度&lt;br/&gt; 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度&lt;br/&gt; 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 码率,单位：kbit/s&lt;br/&gt; 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 帧率（默认为0，0代表自适应，单位是帧每秒）&lt;br/&gt; 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoInfo {\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
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
            return this.Equals(input as VideoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoInfo input)
        {
            if (input == null) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;
            if (this.Quality != input.Quality) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;

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
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
