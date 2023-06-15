using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Live.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class QualityInfo 
    {
        /// <summary>
        /// 是否使用窄带高清转码，模板组里不同模板的PVC选项必须相同。 - on：启用。 - off：不启用。 默认为off 
        /// </summary>
        /// <value>是否使用窄带高清转码，模板组里不同模板的PVC选项必须相同。 - on：启用。 - off：不启用。 默认为off </value>
        [JsonConverter(typeof(EnumClassConverter<PvcEnum>))]
        public class PvcEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly PvcEnum ON = new PvcEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly PvcEnum OFF = new PvcEnum("off");

            private static readonly Dictionary<string, PvcEnum> StaticFields =
            new Dictionary<string, PvcEnum>()
            {
                { "on", ON },
                { "off", OFF },
            };

            private string _value;

            public PvcEnum()
            {

            }

            public PvcEnum(string value)
            {
                _value = value;
            }

            public static PvcEnum FromValue(string value)
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

                if (this.Equals(obj as PvcEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PvcEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PvcEnum a, PvcEnum b)
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

            public static bool operator !=(PvcEnum a, PvcEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 是否启用高清低码，较PVC相比画质增强。 - on：启用。 - off：不启用。 默认为off。 
        /// </summary>
        /// <value>是否启用高清低码，较PVC相比画质增强。 - on：启用。 - off：不启用。 默认为off。 </value>
        [JsonConverter(typeof(EnumClassConverter<HdlbEnum>))]
        public class HdlbEnum
        {
            /// <summary>
            /// Enum ON for value: on
            /// </summary>
            public static readonly HdlbEnum ON = new HdlbEnum("on");

            /// <summary>
            /// Enum OFF for value: off
            /// </summary>
            public static readonly HdlbEnum OFF = new HdlbEnum("off");

            private static readonly Dictionary<string, HdlbEnum> StaticFields =
            new Dictionary<string, HdlbEnum>()
            {
                { "on", ON },
                { "off", OFF },
            };

            private string _value;

            public HdlbEnum()
            {

            }

            public HdlbEnum(string value)
            {
                _value = value;
            }

            public static HdlbEnum FromValue(string value)
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

                if (this.Equals(obj as HdlbEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HdlbEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HdlbEnum a, HdlbEnum b)
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

            public static bool operator !=(HdlbEnum a, HdlbEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 视频编码格式，模板组里不同模板的编码格式必须相同。 - H264：使用H.264。 - H265：使用H.265。 默认为H264。 
        /// </summary>
        /// <value>视频编码格式，模板组里不同模板的编码格式必须相同。 - H264：使用H.264。 - H265：使用H.265。 默认为H264。 </value>
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
        /// 转码输出支持的协议类型。当前只支持RTMP和HLS，且模板组里不同模板的输出协议类型必须相同。 - RTMP - HLS - DASH  默认为RTMP。 
        /// </summary>
        /// <value>转码输出支持的协议类型。当前只支持RTMP和HLS，且模板组里不同模板的输出协议类型必须相同。 - RTMP - HLS - DASH  默认为RTMP。 </value>
        [JsonConverter(typeof(EnumClassConverter<ProtocolEnum>))]
        public class ProtocolEnum
        {
            /// <summary>
            /// Enum RTMP for value: RTMP
            /// </summary>
            public static readonly ProtocolEnum RTMP = new ProtocolEnum("RTMP");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly ProtocolEnum HLS = new ProtocolEnum("HLS");

            /// <summary>
            /// Enum DASH for value: DASH
            /// </summary>
            public static readonly ProtocolEnum DASH = new ProtocolEnum("DASH");

            private static readonly Dictionary<string, ProtocolEnum> StaticFields =
            new Dictionary<string, ProtocolEnum>()
            {
                { "RTMP", RTMP },
                { "HLS", HLS },
                { "DASH", DASH },
            };

            private string _value;

            public ProtocolEnum()
            {

            }

            public ProtocolEnum(string value)
            {
                _value = value;
            }

            public static ProtocolEnum FromValue(string value)
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

                if (this.Equals(obj as ProtocolEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtocolEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ProtocolEnum a, ProtocolEnum b)
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

            public static bool operator !=(ProtocolEnum a, ProtocolEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 模板名称。
        /// </summary>
        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 包含如下取值： - FHD： 超高清，系统缺省名称 - HD： 高清，系统缺省名称 - SD： 标清，系统缺省名称 - LD： 流畅，系统缺省名称 - XXX： 租户自定义名称。用户自定义名称不能与系统缺省名称冲突；多个自定义名称不能重复 
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public string Quality { get; set; }

        /// <summary>
        /// 是否使用窄带高清转码，模板组里不同模板的PVC选项必须相同。 - on：启用。 - off：不启用。 默认为off 
        /// </summary>
        [JsonProperty("PVC", NullValueHandling = NullValueHandling.Ignore)]
        public PvcEnum Pvc { get; set; }
        /// <summary>
        /// 是否启用高清低码，较PVC相比画质增强。 - on：启用。 - off：不启用。 默认为off。 
        /// </summary>
        [JsonProperty("hdlb", NullValueHandling = NullValueHandling.Ignore)]
        public HdlbEnum Hdlb { get; set; }
        /// <summary>
        /// 视频编码格式，模板组里不同模板的编码格式必须相同。 - H264：使用H.264。 - H265：使用H.265。 默认为H264。 
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// 视频宽度（单位：像素） - H264   取值范围：32-3840，必须为2的倍数 。 - H265   取值范围：320-3840 ，必须为4的倍数。 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度（单位：像素） - H264   取值范围：32-2160，必须为2的倍数。 - H265   取值范围：240-2160，必须为4的倍数。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 转码视频的码率（单位：Kbps）。 取值范围：40-30000。 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 转码视频帧率（单位：fps）。 取值范围：0-30，0表示保持帧率不变。 
        /// </summary>
        [JsonProperty("video_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoFrameRate { get; set; }

        /// <summary>
        /// 转码输出支持的协议类型。当前只支持RTMP和HLS，且模板组里不同模板的输出协议类型必须相同。 - RTMP - HLS - DASH  默认为RTMP。 
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// I帧间隔（单位：帧）。  取值范围：0-500。  默认为25。 
        /// </summary>
        [JsonProperty("iFrameInterval", NullValueHandling = NullValueHandling.Ignore)]
        public int? IFrameInterval { get; set; }

        /// <summary>
        /// 按时间设置I帧间隔，与“iFrameInterval”选择一个设置即可。  取值范围：[0,10]  默认值：4 
        /// </summary>
        [JsonProperty("gop", NullValueHandling = NullValueHandling.Ignore)]
        public int? Gop { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QualityInfo {\n");
            sb.Append("  templateName: ").Append(TemplateName).Append("\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  pvc: ").Append(Pvc).Append("\n");
            sb.Append("  hdlb: ").Append(Hdlb).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  videoFrameRate: ").Append(VideoFrameRate).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  iFrameInterval: ").Append(IFrameInterval).Append("\n");
            sb.Append("  gop: ").Append(Gop).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QualityInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QualityInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TemplateName == input.TemplateName ||
                    (this.TemplateName != null &&
                    this.TemplateName.Equals(input.TemplateName))
                ) && 
                (
                    this.Quality == input.Quality ||
                    (this.Quality != null &&
                    this.Quality.Equals(input.Quality))
                ) && 
                (
                    this.Pvc == input.Pvc ||
                    (this.Pvc != null &&
                    this.Pvc.Equals(input.Pvc))
                ) && 
                (
                    this.Hdlb == input.Hdlb ||
                    (this.Hdlb != null &&
                    this.Hdlb.Equals(input.Hdlb))
                ) && 
                (
                    this.Codec == input.Codec ||
                    (this.Codec != null &&
                    this.Codec.Equals(input.Codec))
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
                    this.VideoFrameRate == input.VideoFrameRate ||
                    (this.VideoFrameRate != null &&
                    this.VideoFrameRate.Equals(input.VideoFrameRate))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.IFrameInterval == input.IFrameInterval ||
                    (this.IFrameInterval != null &&
                    this.IFrameInterval.Equals(input.IFrameInterval))
                ) && 
                (
                    this.Gop == input.Gop ||
                    (this.Gop != null &&
                    this.Gop.Equals(input.Gop))
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
                if (this.TemplateName != null)
                    hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Quality != null)
                    hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.Pvc != null)
                    hashCode = hashCode * 59 + this.Pvc.GetHashCode();
                if (this.Hdlb != null)
                    hashCode = hashCode * 59 + this.Hdlb.GetHashCode();
                if (this.Codec != null)
                    hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Bitrate != null)
                    hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.VideoFrameRate != null)
                    hashCode = hashCode * 59 + this.VideoFrameRate.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IFrameInterval != null)
                    hashCode = hashCode * 59 + this.IFrameInterval.GetHashCode();
                if (this.Gop != null)
                    hashCode = hashCode * 59 + this.Gop.GetHashCode();
                return hashCode;
            }
        }
    }
}
