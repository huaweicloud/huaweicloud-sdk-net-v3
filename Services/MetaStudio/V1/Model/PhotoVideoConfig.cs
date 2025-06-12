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
    /// 视频输出配置。照片数字人支持该输出配置查询，不支持修改。
    /// </summary>
    public class PhotoVideoConfig 
    {
        /// <summary>
        /// 视频编码格式及视频文件格式。 * H264：h264编码，输出mp4文件
        /// </summary>
        /// <value>视频编码格式及视频文件格式。 * H264：h264编码，输出mp4文件</value>
        [JsonConverter(typeof(EnumClassConverter<CodecEnum>))]
        public class CodecEnum
        {
            /// <summary>
            /// Enum H264 for value: H264
            /// </summary>
            public static readonly CodecEnum H264 = new CodecEnum("H264");

            private static readonly Dictionary<string, CodecEnum> StaticFields =
            new Dictionary<string, CodecEnum>()
            {
                { "H264", H264 },
            };

            private string _value;

            public CodecEnum()
            {

            }

            public CodecEnum(string value)
            {
                _value = value;
            }

            public static CodecEnum FromValue(string value)
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

                if (this.Equals(obj as CodecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CodecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CodecEnum a, CodecEnum b)
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

            public static bool operator !=(CodecEnum a, CodecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 帧率。  单位：FPS。
        /// </summary>
        /// <value>帧率。  单位：FPS。</value>
        [JsonConverter(typeof(EnumClassConverter<FrameRateEnum>))]
        public class FrameRateEnum
        {
            /// <summary>
            /// Enum _24 for value: 24
            /// </summary>
            public static readonly FrameRateEnum _24 = new FrameRateEnum("24");

            /// <summary>
            /// Enum _25 for value: 25
            /// </summary>
            public static readonly FrameRateEnum _25 = new FrameRateEnum("25");

            /// <summary>
            /// Enum _30 for value: 30
            /// </summary>
            public static readonly FrameRateEnum _30 = new FrameRateEnum("30");

            private static readonly Dictionary<string, FrameRateEnum> StaticFields =
            new Dictionary<string, FrameRateEnum>()
            {
                { "24", _24 },
                { "25", _25 },
                { "30", _30 },
            };

            private string _value;

            public FrameRateEnum()
            {

            }

            public FrameRateEnum(string value)
            {
                _value = value;
            }

            public static FrameRateEnum FromValue(string value)
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

                if (this.Equals(obj as FrameRateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FrameRateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FrameRateEnum a, FrameRateEnum b)
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

            public static bool operator !=(FrameRateEnum a, FrameRateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 视频编码格式及视频文件格式。 * H264：h264编码，输出mp4文件
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// **参数解释**： 输出平均码率。  单位：kbps。  最小值40，最大值30000。
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 帧率。  单位：FPS。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public FrameRateEnum FrameRate { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhotoVideoConfig {\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
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
            return this.Equals(input as PhotoVideoConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PhotoVideoConfig input)
        {
            if (input == null) return false;
            if (this.Codec != input.Codec) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.FrameRate != input.FrameRate) return false;

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
                hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
