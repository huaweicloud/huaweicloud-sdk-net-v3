using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Mpc.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EditVideoInfo 
    {
        /// <summary>
        /// 剪辑输出视频参数的参照物。取值如下： - MAX，以输入片源中最大分辨率的视频参数作为输出参照。 - MIN，以输入片源中最小分辨率的视频参数作为输出参照。 - CUSTOM，自定义视频输出参数，使用该参数时，所有视频参数必填。- SHORT_HEIGHT_SHORT_WIDTH，当edit_type为MIX时，只能使用该值。
        /// </summary>
        /// <value>剪辑输出视频参数的参照物。取值如下： - MAX，以输入片源中最大分辨率的视频参数作为输出参照。 - MIN，以输入片源中最小分辨率的视频参数作为输出参照。 - CUSTOM，自定义视频输出参数，使用该参数时，所有视频参数必填。- SHORT_HEIGHT_SHORT_WIDTH，当edit_type为MIX时，只能使用该值。</value>
        [JsonConverter(typeof(EnumClassConverter<ReferenceEnum>))]
        public class ReferenceEnum
        {
            /// <summary>
            /// Enum MAX for value: MAX
            /// </summary>
            public static readonly ReferenceEnum MAX = new ReferenceEnum("MAX");

            /// <summary>
            /// Enum MIN for value: MIN
            /// </summary>
            public static readonly ReferenceEnum MIN = new ReferenceEnum("MIN");

            /// <summary>
            /// Enum CUSTOM for value: CUSTOM
            /// </summary>
            public static readonly ReferenceEnum CUSTOM = new ReferenceEnum("CUSTOM");

            /// <summary>
            /// Enum SHORT_HEIGHT_SHORT_WIDTH for value: SHORT_HEIGHT_SHORT_WIDTH
            /// </summary>
            public static readonly ReferenceEnum SHORT_HEIGHT_SHORT_WIDTH = new ReferenceEnum("SHORT_HEIGHT_SHORT_WIDTH");

            private static readonly Dictionary<string, ReferenceEnum> StaticFields =
            new Dictionary<string, ReferenceEnum>()
            {
                { "MAX", MAX },
                { "MIN", MIN },
                { "CUSTOM", CUSTOM },
                { "SHORT_HEIGHT_SHORT_WIDTH", SHORT_HEIGHT_SHORT_WIDTH },
            };

            private string _value;

            public ReferenceEnum()
            {

            }

            public ReferenceEnum(string value)
            {
                _value = value;
            }

            public static ReferenceEnum FromValue(string value)
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

                if (this.Equals(obj as ReferenceEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ReferenceEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ReferenceEnum a, ReferenceEnum b)
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

            public static bool operator !=(ReferenceEnum a, ReferenceEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 视频频编码格式。
        /// </summary>
        /// <value>视频频编码格式。</value>
        [JsonConverter(typeof(EnumClassConverter<CodecEnum>))]
        public class CodecEnum
        {
            /// <summary>
            /// Enum H264 for value: H264
            /// </summary>
            public static readonly CodecEnum H264 = new CodecEnum("H264");

            /// <summary>
            /// Enum H265 for value: H265
            /// </summary>
            public static readonly CodecEnum H265 = new CodecEnum("H265");

            private static readonly Dictionary<string, CodecEnum> StaticFields =
            new Dictionary<string, CodecEnum>()
            {
                { "H264", H264 },
                { "H265", H265 },
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

            public static bool operator !=(CodecEnum a, CodecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 剪辑输出视频参数的参照物。取值如下： - MAX，以输入片源中最大分辨率的视频参数作为输出参照。 - MIN，以输入片源中最小分辨率的视频参数作为输出参照。 - CUSTOM，自定义视频输出参数，使用该参数时，所有视频参数必填。- SHORT_HEIGHT_SHORT_WIDTH，当edit_type为MIX时，只能使用该值。
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public ReferenceEnum Reference { get; set; }
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
        /// 视频频编码格式。
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// 视频码率，单位: bit/s 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 帧率。 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditVideoInfo {\n");
            sb.Append("  reference: ").Append(Reference).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
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
            return this.Equals(input as EditVideoInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EditVideoInfo input)
        {
            if (input == null) return false;
            if (this.Reference != input.Reference) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Codec != input.Codec) return false;
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
                hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                return hashCode;
            }
        }
    }
}
