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
    /// 视频输出配置。
    /// </summary>
    public class VideoConfig 
    {
        /// <summary>
        /// **参数解释**： 输出视频的剪辑方式。 **约束限制**： 不涉及。 **取值范围**： * RESIZE：视频缩放。 * CROP：视频裁剪。
        /// </summary>
        /// <value>**参数解释**： 输出视频的剪辑方式。 **约束限制**： 不涉及。 **取值范围**： * RESIZE：视频缩放。 * CROP：视频裁剪。</value>
        [JsonConverter(typeof(EnumClassConverter<ClipModeEnum>))]
        public class ClipModeEnum
        {
            /// <summary>
            /// Enum RESIZE for value: RESIZE
            /// </summary>
            public static readonly ClipModeEnum RESIZE = new ClipModeEnum("RESIZE");

            /// <summary>
            /// Enum CROP for value: CROP
            /// </summary>
            public static readonly ClipModeEnum CROP = new ClipModeEnum("CROP");

            private static readonly Dictionary<string, ClipModeEnum> StaticFields =
            new Dictionary<string, ClipModeEnum>()
            {
                { "RESIZE", RESIZE },
                { "CROP", CROP },
            };

            private string _value;

            public ClipModeEnum()
            {

            }

            public ClipModeEnum(string value)
            {
                _value = value;
            }

            public static ClipModeEnum FromValue(string value)
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

                if (this.Equals(obj as ClipModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ClipModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ClipModeEnum a, ClipModeEnum b)
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

            public static bool operator !=(ClipModeEnum a, ClipModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 视频编码格式及视频文件格式。 **约束限制**： 仅分身数字人视频制作支持VP8和QTRLE编码。QTRLE编码时文本驱动字符数限制小于1500字，音频驱动音频长度小于5分钟。 QTRLE编码需要先申请开通白名单后才能使用  **取值范围**： * H264：h264编码，输出mp4文件。 * VP8：vp8编码，输出webm文件。 * QTRLE：qtrle ，输出mov文件。  **默认取值**： H264
        /// </summary>
        /// <value>**参数解释**： 视频编码格式及视频文件格式。 **约束限制**： 仅分身数字人视频制作支持VP8和QTRLE编码。QTRLE编码时文本驱动字符数限制小于1500字，音频驱动音频长度小于5分钟。 QTRLE编码需要先申请开通白名单后才能使用  **取值范围**： * H264：h264编码，输出mp4文件。 * VP8：vp8编码，输出webm文件。 * QTRLE：qtrle ，输出mov文件。  **默认取值**： H264</value>
        [JsonConverter(typeof(EnumClassConverter<CodecEnum>))]
        public class CodecEnum
        {
            /// <summary>
            /// Enum H264 for value: H264
            /// </summary>
            public static readonly CodecEnum H264 = new CodecEnum("H264");

            /// <summary>
            /// Enum VP8 for value: VP8
            /// </summary>
            public static readonly CodecEnum VP8 = new CodecEnum("VP8");

            /// <summary>
            /// Enum VP9 for value: VP9
            /// </summary>
            public static readonly CodecEnum VP9 = new CodecEnum("VP9");

            /// <summary>
            /// Enum QTRLE for value: QTRLE
            /// </summary>
            public static readonly CodecEnum QTRLE = new CodecEnum("QTRLE");

            private static readonly Dictionary<string, CodecEnum> StaticFields =
            new Dictionary<string, CodecEnum>()
            {
                { "H264", H264 },
                { "VP8", VP8 },
                { "VP9", VP9 },
                { "QTRLE", QTRLE },
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
        /// **参数解释**： 帧率。单位：FPS。 **约束限制**： 分身数字人视频固定25FPS。
        /// </summary>
        /// <value>**参数解释**： 帧率。单位：FPS。 **约束限制**： 分身数字人视频固定25FPS。</value>
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

            public static bool operator !=(FrameRateEnum a, FrameRateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 输出视频的剪辑方式。 **约束限制**： 不涉及。 **取值范围**： * RESIZE：视频缩放。 * CROP：视频裁剪。
        /// </summary>
        [JsonProperty("clip_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ClipModeEnum ClipMode { get; set; }
        /// <summary>
        /// **参数解释**： 视频编码格式及视频文件格式。 **约束限制**： 仅分身数字人视频制作支持VP8和QTRLE编码。QTRLE编码时文本驱动字符数限制小于1500字，音频驱动音频长度小于5分钟。 QTRLE编码需要先申请开通白名单后才能使用  **取值范围**： * H264：h264编码，输出mp4文件。 * VP8：vp8编码，输出webm文件。 * QTRLE：qtrle ，输出mov文件。  **默认取值**： H264
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// **参数解释**： 输出平均码率。单位：kbps。 **约束限制**： * 分身数字人视频制作采用质量优先，可能会超过设置的码率。 * 分身数字人直播码率范围[1000, 8000]。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// **参数解释**： 视频宽度。单位：像素。 **约束限制**： * clip_mode&#x3D;RESIZE时，当前支持1920x1080、1080x1920、1280x720、720x1280、3840x2160、2160x3840六种分辨率。4K分辨率视频需要分身数字人模型支持4K的情况下才能使用。 * clip_mode&#x3D;CROP，裁剪后视频，（dx,dy）为原点，保留视频像宽度为width。 * 分身数字人直播和智能交互目前只支持1080x1920、1920x1080。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// **参数解释**： 视频高度。  单位：像素。 **约束限制**： * clip_mode&#x3D;RESIZE时，当前支持1920x1080、1080x1920、1280x720、720x1280、3840x2160、2160x3840六种分辨率分辨率。 * clip_mode&#x3D;CROP，裁剪后视频，（dx,dy）为原点，保留视频像高度为height。 * 分身数字人直播和智能交互目前只支持1080x1920、1920x1080。  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// **参数解释**： 帧率。单位：FPS。 **约束限制**： 分身数字人视频固定25FPS。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public FrameRateEnum FrameRate { get; set; }
        /// <summary>
        /// **参数解释**： 输出的视频是否带字幕。 **约束限制**： 分身数字人直播暂时不支持字幕。  **取值范围**： * true: 打开字幕 * false: 关闭字幕
        /// </summary>
        [JsonProperty("is_subtitle_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSubtitleEnable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subtitle_config", NullValueHandling = NullValueHandling.Ignore)]
        public SubtitleConfig SubtitleConfig { get; set; }

        /// <summary>
        /// **参数解释**： 裁剪视频左上角像素点横坐标。 &gt; 以模特分辨率为画布大小，比如1920*1080分辨率的模特，dx最小值是0，最大值是1920。  **约束限制**： clip_mode&#x3D; CROP时生效。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("dx", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dx { get; set; }

        /// <summary>
        /// **参数解释**： 裁剪视频左上角像素点纵坐标。 &gt; 以模特分辨率为画布大小，比如1920*1080分辨率的模特，dy最小值是0，最大值是1080  **约束限制**： clip_mode&#x3D; CROP时生效。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("dy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Dy { get; set; }

        /// <summary>
        /// **参数解释**： 视频是否开启超分。 **约束限制**： 仅分身数字人视频制作支持。 **取值范围** * true: 开启 * false: 不开启
        /// </summary>
        [JsonProperty("is_enable_super_resolution", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnableSuperResolution { get; set; }

        /// <summary>
        /// **参数解释**： 视频结束帧是否跟起始帧相同。需要多个数字人视频无缝拼接时设置成true。 **约束限制**： 仅分身数字人视频制作支持，当视频制作时插入动作标签后此设置将失效。 **取值范围** * true: 开启 * false: 不开启
        /// </summary>
        [JsonProperty("is_end_at_first_frame", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEndAtFirstFrame { get; set; }

        /// <summary>
        /// 视频文件上传的外部URL。  &gt; * 需要先申请开通白名单后，才允许将视频上传到外部URL。
        /// </summary>
        [JsonProperty("output_external_url", NullValueHandling = NullValueHandling.Ignore)]
        public string OutputExternalUrl { get; set; }

        /// <summary>
        /// **参数解释**： 是否应用当前租户的读法配置 **约束限制**： 仅分身数字人视频制作支持。 **取值范围** * true: 开启 * false: 不开启
        /// </summary>
        [JsonProperty("is_vocabulary_config_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVocabularyConfigEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoConfig {\n");
            sb.Append("  clipMode: ").Append(ClipMode).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  isSubtitleEnable: ").Append(IsSubtitleEnable).Append("\n");
            sb.Append("  subtitleConfig: ").Append(SubtitleConfig).Append("\n");
            sb.Append("  dx: ").Append(Dx).Append("\n");
            sb.Append("  dy: ").Append(Dy).Append("\n");
            sb.Append("  isEnableSuperResolution: ").Append(IsEnableSuperResolution).Append("\n");
            sb.Append("  isEndAtFirstFrame: ").Append(IsEndAtFirstFrame).Append("\n");
            sb.Append("  outputExternalUrl: ").Append(OutputExternalUrl).Append("\n");
            sb.Append("  isVocabularyConfigEnable: ").Append(IsVocabularyConfigEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoConfig input)
        {
            if (input == null) return false;
            if (this.ClipMode != input.ClipMode) return false;
            if (this.Codec != input.Codec) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.FrameRate != input.FrameRate) return false;
            if (this.IsSubtitleEnable != input.IsSubtitleEnable || (this.IsSubtitleEnable != null && !this.IsSubtitleEnable.Equals(input.IsSubtitleEnable))) return false;
            if (this.SubtitleConfig != input.SubtitleConfig || (this.SubtitleConfig != null && !this.SubtitleConfig.Equals(input.SubtitleConfig))) return false;
            if (this.Dx != input.Dx || (this.Dx != null && !this.Dx.Equals(input.Dx))) return false;
            if (this.Dy != input.Dy || (this.Dy != null && !this.Dy.Equals(input.Dy))) return false;
            if (this.IsEnableSuperResolution != input.IsEnableSuperResolution || (this.IsEnableSuperResolution != null && !this.IsEnableSuperResolution.Equals(input.IsEnableSuperResolution))) return false;
            if (this.IsEndAtFirstFrame != input.IsEndAtFirstFrame || (this.IsEndAtFirstFrame != null && !this.IsEndAtFirstFrame.Equals(input.IsEndAtFirstFrame))) return false;
            if (this.OutputExternalUrl != input.OutputExternalUrl || (this.OutputExternalUrl != null && !this.OutputExternalUrl.Equals(input.OutputExternalUrl))) return false;
            if (this.IsVocabularyConfigEnable != input.IsVocabularyConfigEnable || (this.IsVocabularyConfigEnable != null && !this.IsVocabularyConfigEnable.Equals(input.IsVocabularyConfigEnable))) return false;

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
                hashCode = hashCode * 59 + this.ClipMode.GetHashCode();
                hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.IsSubtitleEnable != null) hashCode = hashCode * 59 + this.IsSubtitleEnable.GetHashCode();
                if (this.SubtitleConfig != null) hashCode = hashCode * 59 + this.SubtitleConfig.GetHashCode();
                if (this.Dx != null) hashCode = hashCode * 59 + this.Dx.GetHashCode();
                if (this.Dy != null) hashCode = hashCode * 59 + this.Dy.GetHashCode();
                if (this.IsEnableSuperResolution != null) hashCode = hashCode * 59 + this.IsEnableSuperResolution.GetHashCode();
                if (this.IsEndAtFirstFrame != null) hashCode = hashCode * 59 + this.IsEndAtFirstFrame.GetHashCode();
                if (this.OutputExternalUrl != null) hashCode = hashCode * 59 + this.OutputExternalUrl.GetHashCode();
                if (this.IsVocabularyConfigEnable != null) hashCode = hashCode * 59 + this.IsVocabularyConfigEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
