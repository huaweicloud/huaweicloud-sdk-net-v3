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
    public class VodEditingSetting 
    {
        /// <summary>
        /// 输出封装格式，HLS、MP4（默认MP4）、MP3、MOV、FLV、AVI。 不支持将视频文件输出成音频封装格式。 
        /// </summary>
        /// <value>输出封装格式，HLS、MP4（默认MP4）、MP3、MOV、FLV、AVI。 不支持将视频文件输出成音频封装格式。 </value>
        [JsonConverter(typeof(EnumClassConverter<FormatEnum>))]
        public class FormatEnum
        {
            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly FormatEnum MP4 = new FormatEnum("MP4");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly FormatEnum HLS = new FormatEnum("HLS");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly FormatEnum MP3 = new FormatEnum("MP3");

            /// <summary>
            /// Enum MOV for value: MOV
            /// </summary>
            public static readonly FormatEnum MOV = new FormatEnum("MOV");

            /// <summary>
            /// Enum AVI for value: AVI
            /// </summary>
            public static readonly FormatEnum AVI = new FormatEnum("AVI");

            /// <summary>
            /// Enum FLV for value: FLV
            /// </summary>
            public static readonly FormatEnum FLV = new FormatEnum("FLV");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "MP4", MP4 },
                { "HLS", HLS },
                { "MP3", MP3 },
                { "MOV", MOV },
                { "AVI", AVI },
                { "FLV", FLV },
            };

            private string _value;

            public FormatEnum()
            {

            }

            public FormatEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FormatEnum a, FormatEnum b)
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 输出参考基准，可选，默认为NONE  - NONE 输出分辨率按输入的第一个片源为主，码率按输出分辨率自适应 - MAX_BITRATE 按码率最大的输入片源参数为基准 - MAX_RESOLUTION 按分辨率最大的输入片源参数为基准 
        /// </summary>
        /// <value>输出参考基准，可选，默认为NONE  - NONE 输出分辨率按输入的第一个片源为主，码率按输出分辨率自适应 - MAX_BITRATE 按码率最大的输入片源参数为基准 - MAX_RESOLUTION 按分辨率最大的输入片源参数为基准 </value>
        [JsonConverter(typeof(EnumClassConverter<ReferenceEnum>))]
        public class ReferenceEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly ReferenceEnum NONE = new ReferenceEnum("NONE");

            /// <summary>
            /// Enum MAX_BITRATE for value: MAX_BITRATE
            /// </summary>
            public static readonly ReferenceEnum MAX_BITRATE = new ReferenceEnum("MAX_BITRATE");

            /// <summary>
            /// Enum MAX_RESOLUTION for value: MAX_RESOLUTION
            /// </summary>
            public static readonly ReferenceEnum MAX_RESOLUTION = new ReferenceEnum("MAX_RESOLUTION");

            private static readonly Dictionary<string, ReferenceEnum> StaticFields =
            new Dictionary<string, ReferenceEnum>()
            {
                { "NONE", NONE },
                { "MAX_BITRATE", MAX_BITRATE },
                { "MAX_RESOLUTION", MAX_RESOLUTION },
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
        /// 分辨率自适应策略, 选值：true, false（默认true） 输入为true时，width表示长边，height表示短边 输入为false时，width表示宽度，height表示长度 
        /// </summary>
        [JsonProperty("resolution_adaptation", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResolutionAdaptation { get; set; }

        /// <summary>
        /// 分辨率上采样开关, 选值：true, false（默认false），若为false则按照原片源输出，分辨率不会上浮。 
        /// </summary>
        [JsonProperty("resolution_upsample", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResolutionUpsample { get; set; }

        /// <summary>
        /// 输出封装格式，HLS、MP4（默认MP4）、MP3、MOV、FLV、AVI。 不支持将视频文件输出成音频封装格式。 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 输出宽或长边，整型，输入小数向下取整，默认0，按源  - 当width、height均为0，则分辨率取片源分辨率； - 当width为0，height非0，则width按片源分辨率比例缩放； - 当width非0，height为0，则height按片源分辨率比例缩放； - 当width、height均非0，则分辨率按用户指定。 - 当视频编码为H.264时，则width最小值为32，最大值为4096。 - 当视频编码为H.265，则width最小值为160，最大值为4096。 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 输出高或短边，整型，输入小数向下取整，默认0，按源  - 当Width、Height均为0，则分辨率取片源分辨率； - 当Width为0，Height非0，则Width按片源分辨率比例缩放； - 当Width非0，Height为0，则Height按片源分辨率比例缩放； - 当Width、Height 均非0，则分辨率按用户指定。 - 当视频编码为H.264时，则height最小值为32，最大值为2880。 - 当视频编码为H.265，则height最小值为160，最大值为2880。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 输出参考基准，可选，默认为NONE  - NONE 输出分辨率按输入的第一个片源为主，码率按输出分辨率自适应 - MAX_BITRATE 按码率最大的输入片源参数为基准 - MAX_RESOLUTION 按分辨率最大的输入片源参数为基准 
        /// </summary>
        [JsonProperty("reference", NullValueHandling = NullValueHandling.Ignore)]
        public ReferenceEnum Reference { get; set; }
        /// <summary>
        /// 视频编码格式。 取值如下： - 1：VIDEO_CODEC_H264 - 2：VIDEO_CODEC_H265 
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoCodec { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VodEditingSetting {\n");
            sb.Append("  resolutionAdaptation: ").Append(ResolutionAdaptation).Append("\n");
            sb.Append("  resolutionUpsample: ").Append(ResolutionUpsample).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  reference: ").Append(Reference).Append("\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VodEditingSetting);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VodEditingSetting input)
        {
            if (input == null) return false;
            if (this.ResolutionAdaptation != input.ResolutionAdaptation || (this.ResolutionAdaptation != null && !this.ResolutionAdaptation.Equals(input.ResolutionAdaptation))) return false;
            if (this.ResolutionUpsample != input.ResolutionUpsample || (this.ResolutionUpsample != null && !this.ResolutionUpsample.Equals(input.ResolutionUpsample))) return false;
            if (this.Format != input.Format) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Reference != input.Reference) return false;
            if (this.VideoCodec != input.VideoCodec || (this.VideoCodec != null && !this.VideoCodec.Equals(input.VideoCodec))) return false;

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
                if (this.ResolutionAdaptation != null) hashCode = hashCode * 59 + this.ResolutionAdaptation.GetHashCode();
                if (this.ResolutionUpsample != null) hashCode = hashCode * 59 + this.ResolutionUpsample.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.VideoCodec != null) hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                return hashCode;
            }
        }
    }
}
