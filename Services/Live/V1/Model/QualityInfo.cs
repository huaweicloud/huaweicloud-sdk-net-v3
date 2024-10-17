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
        /// 是否使用窄带高清转码。默认值：off。  注意：该字段已不再维护，建议使用hdlb。  包含如下取值： - off：不启用。 - on：启用。 
        /// </summary>
        /// <value>是否使用窄带高清转码。默认值：off。  注意：该字段已不再维护，建议使用hdlb。  包含如下取值： - off：不启用。 - on：启用。 </value>
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
        /// 是否启用高清低码，较PVC相比画质增强。默认值：off。  提示：使用hdlb字段开启高清低码时，PVC字段不生效。  包含如下取值： - off：不开启高清低码； - on：开启高清低码。 
        /// </summary>
        /// <value>是否启用高清低码，较PVC相比画质增强。默认值：off。  提示：使用hdlb字段开启高清低码时，PVC字段不生效。  包含如下取值： - off：不开启高清低码； - on：开启高清低码。 </value>
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
        /// 视频编码格式。默认为H264。 - H264：使用H.264。 - H265：使用H.265。 
        /// </summary>
        /// <value>视频编码格式。默认为H264。 - H264：使用H.264。 - H265：使用H.265。 </value>
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
        /// 转码输出支持的协议类型。默认为RTMP。当前只支持RTMP。  包含如下取值： - RTMP 
        /// </summary>
        /// <value>转码输出支持的协议类型。默认为RTMP。当前只支持RTMP。  包含如下取值： - RTMP </value>
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
        /// 自适应码率参数，默认值：off。  包含如下取值： - off：关闭码率自适应，目标码率按设定的码率输出； - minimum：目标码率按设定码率和源文件码率最小值输出（即码率不上扬）； - adaptive：目标码率按源文件码率自适应输出。 
        /// </summary>
        /// <value>自适应码率参数，默认值：off。  包含如下取值： - off：关闭码率自适应，目标码率按设定的码率输出； - minimum：目标码率按设定码率和源文件码率最小值输出（即码率不上扬）； - adaptive：目标码率按源文件码率自适应输出。 </value>
        [JsonConverter(typeof(EnumClassConverter<BitrateAdaptiveEnum>))]
        public class BitrateAdaptiveEnum
        {
            /// <summary>
            /// Enum MINIMUM for value: minimum
            /// </summary>
            public static readonly BitrateAdaptiveEnum MINIMUM = new BitrateAdaptiveEnum("minimum");

            /// <summary>
            /// Enum ADAPTIVE for value: adaptive
            /// </summary>
            public static readonly BitrateAdaptiveEnum ADAPTIVE = new BitrateAdaptiveEnum("adaptive");

            private static readonly Dictionary<string, BitrateAdaptiveEnum> StaticFields =
            new Dictionary<string, BitrateAdaptiveEnum>()
            {
                { "minimum", MINIMUM },
                { "adaptive", ADAPTIVE },
            };

            private string _value;

            public BitrateAdaptiveEnum()
            {

            }

            public BitrateAdaptiveEnum(string value)
            {
                _value = value;
            }

            public static BitrateAdaptiveEnum FromValue(string value)
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

                if (this.Equals(obj as BitrateAdaptiveEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BitrateAdaptiveEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BitrateAdaptiveEnum a, BitrateAdaptiveEnum b)
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

            public static bool operator !=(BitrateAdaptiveEnum a, BitrateAdaptiveEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 编码输出I帧策略，默认值：auto。  包含如下取值： - auto：I帧按设置的gop时长输出； - strictSync：编码输出I帧完全和源保持一致（源是I帧则编码输出I帧，源不是I帧则编码非I帧），设置该参数后gop时长设置无效。 
        /// </summary>
        /// <value>编码输出I帧策略，默认值：auto。  包含如下取值： - auto：I帧按设置的gop时长输出； - strictSync：编码输出I帧完全和源保持一致（源是I帧则编码输出I帧，源不是I帧则编码非I帧），设置该参数后gop时长设置无效。 </value>
        [JsonConverter(typeof(EnumClassConverter<IFramePolicyEnum>))]
        public class IFramePolicyEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly IFramePolicyEnum AUTO = new IFramePolicyEnum("auto");

            /// <summary>
            /// Enum STRICTSYNC for value: strictSync
            /// </summary>
            public static readonly IFramePolicyEnum STRICTSYNC = new IFramePolicyEnum("strictSync");

            private static readonly Dictionary<string, IFramePolicyEnum> StaticFields =
            new Dictionary<string, IFramePolicyEnum>()
            {
                { "auto", AUTO },
                { "strictSync", STRICTSYNC },
            };

            private string _value;

            public IFramePolicyEnum()
            {

            }

            public IFramePolicyEnum(string value)
            {
                _value = value;
            }

            public static IFramePolicyEnum FromValue(string value)
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

                if (this.Equals(obj as IFramePolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IFramePolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IFramePolicyEnum a, IFramePolicyEnum b)
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

            public static bool operator !=(IFramePolicyEnum a, IFramePolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 自定义模板名称。 - 若需要自定义模板名称，请将quality参数设置为userdefine； - 多个自定义模板名称之间不能重复； - 自定义模板名称不能与其他模板的quality参数重复； - 若quality不为userdefine，请勿填写此字段。 
        /// </summary>
        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        /// <summary>
        /// 包含如下取值： - lud： 超高清，系统缺省名称； - lhd： 高清，系统缺省名称； - lsd： 标清，系统缺省名称； - lld： 流畅，系统缺省名称； - userdefine： 视频质量自定义。填写userdefine时，templateName字段不能为空。 
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public string Quality { get; set; }

        /// <summary>
        /// 是否使用窄带高清转码。默认值：off。  注意：该字段已不再维护，建议使用hdlb。  包含如下取值： - off：不启用。 - on：启用。 
        /// </summary>
        [JsonProperty("PVC", NullValueHandling = NullValueHandling.Ignore)]
        public PvcEnum Pvc { get; set; }
        /// <summary>
        /// 是否启用高清低码，较PVC相比画质增强。默认值：off。  提示：使用hdlb字段开启高清低码时，PVC字段不生效。  包含如下取值： - off：不开启高清低码； - on：开启高清低码。 
        /// </summary>
        [JsonProperty("hdlb", NullValueHandling = NullValueHandling.Ignore)]
        public HdlbEnum Hdlb { get; set; }
        /// <summary>
        /// 视频编码格式。默认为H264。 - H264：使用H.264。 - H265：使用H.265。 
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// 视频长边（横屏的宽，竖屏的高）  单位：像素；默认值：0 - H264 建议取值范围：32-3840，必须为2的倍数 。 - H265 建议取值范围：320-3840 ，必须为2的倍数。  注意：width和height全为0，则输出分辨率和源一致；width和height只有一个为0， 则分辨率按非0项的比例缩放。 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频短边（横屏的高，竖屏的宽）  单位：像素；默认值：0 - H264 建议取值范围：32-2160，必须为2的倍数。 - H265 建议取值范围：240-2160，必须为2的倍数。  注意：width和height全为0，则输出分辨率和源一致；width和height只有一个为0， 则分辨率按非0项的比例缩放。 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 转码视频的码率  单位：Kbps  取值范围：40-30000 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 转码视频帧率  单位：fps  默认值：0  取值范围：0-60，0表示保持帧率不变。 
        /// </summary>
        [JsonProperty("video_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoFrameRate { get; set; }

        /// <summary>
        /// 转码输出支持的协议类型。默认为RTMP。当前只支持RTMP。  包含如下取值： - RTMP 
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public ProtocolEnum Protocol { get; set; }
        /// <summary>
        /// 最大I帧间隔  单位：帧数  取值范围：[0, 500]，默认值：50  注意：若希望通过iFrameInterval设置i帧间隔，请将gop设为0，或不传gop参数。 
        /// </summary>
        [JsonProperty("iFrameInterval", NullValueHandling = NullValueHandling.Ignore)]
        public int? IFrameInterval { get; set; }

        /// <summary>
        /// 按时间设置I帧间隔  单位：秒  取值范围：[0,10]，默认值：2  注意：gop不为0时，则以gop设置i帧间隔，iFrameInterval字段不生效。 
        /// </summary>
        [JsonProperty("gop", NullValueHandling = NullValueHandling.Ignore)]
        public int? Gop { get; set; }

        /// <summary>
        /// 自适应码率参数，默认值：off。  包含如下取值： - off：关闭码率自适应，目标码率按设定的码率输出； - minimum：目标码率按设定码率和源文件码率最小值输出（即码率不上扬）； - adaptive：目标码率按源文件码率自适应输出。 
        /// </summary>
        [JsonProperty("bitrate_adaptive", NullValueHandling = NullValueHandling.Ignore)]
        public BitrateAdaptiveEnum BitrateAdaptive { get; set; }
        /// <summary>
        /// 编码输出I帧策略，默认值：auto。  包含如下取值： - auto：I帧按设置的gop时长输出； - strictSync：编码输出I帧完全和源保持一致（源是I帧则编码输出I帧，源不是I帧则编码非I帧），设置该参数后gop时长设置无效。 
        /// </summary>
        [JsonProperty("i_frame_policy", NullValueHandling = NullValueHandling.Ignore)]
        public IFramePolicyEnum IFramePolicy { get; set; }


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
            sb.Append("  bitrateAdaptive: ").Append(BitrateAdaptive).Append("\n");
            sb.Append("  iFramePolicy: ").Append(IFramePolicy).Append("\n");
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
            if (input == null) return false;
            if (this.TemplateName != input.TemplateName || (this.TemplateName != null && !this.TemplateName.Equals(input.TemplateName))) return false;
            if (this.Quality != input.Quality || (this.Quality != null && !this.Quality.Equals(input.Quality))) return false;
            if (this.Pvc != input.Pvc) return false;
            if (this.Hdlb != input.Hdlb) return false;
            if (this.Codec != input.Codec) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.VideoFrameRate != input.VideoFrameRate || (this.VideoFrameRate != null && !this.VideoFrameRate.Equals(input.VideoFrameRate))) return false;
            if (this.Protocol != input.Protocol) return false;
            if (this.IFrameInterval != input.IFrameInterval || (this.IFrameInterval != null && !this.IFrameInterval.Equals(input.IFrameInterval))) return false;
            if (this.Gop != input.Gop || (this.Gop != null && !this.Gop.Equals(input.Gop))) return false;
            if (this.BitrateAdaptive != input.BitrateAdaptive) return false;
            if (this.IFramePolicy != input.IFramePolicy) return false;

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
                if (this.TemplateName != null) hashCode = hashCode * 59 + this.TemplateName.GetHashCode();
                if (this.Quality != null) hashCode = hashCode * 59 + this.Quality.GetHashCode();
                hashCode = hashCode * 59 + this.Pvc.GetHashCode();
                hashCode = hashCode * 59 + this.Hdlb.GetHashCode();
                hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.VideoFrameRate != null) hashCode = hashCode * 59 + this.VideoFrameRate.GetHashCode();
                hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.IFrameInterval != null) hashCode = hashCode * 59 + this.IFrameInterval.GetHashCode();
                if (this.Gop != null) hashCode = hashCode * 59 + this.Gop.GetHashCode();
                hashCode = hashCode * 59 + this.BitrateAdaptive.GetHashCode();
                hashCode = hashCode * 59 + this.IFramePolicy.GetHashCode();
                return hashCode;
            }
        }
    }
}
