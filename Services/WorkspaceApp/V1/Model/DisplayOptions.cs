using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// 显示级别共同控制的选项。
    /// </summary>
    public class DisplayOptions 
    {
        /// <summary>
        /// 无损压缩模式。取值为： Basic Compression：表示初级压缩。 Deep Compression：表示深度压缩。
        /// </summary>
        /// <value>无损压缩模式。取值为： Basic Compression：表示初级压缩。 Deep Compression：表示深度压缩。</value>
        [JsonConverter(typeof(EnumClassConverter<LosslessCompressionModeEnum>))]
        public class LosslessCompressionModeEnum
        {
            /// <summary>
            /// Enum BASIC_COMPRESSION for value: Basic Compression
            /// </summary>
            public static readonly LosslessCompressionModeEnum BASIC_COMPRESSION = new LosslessCompressionModeEnum("Basic Compression");

            /// <summary>
            /// Enum DEEP_COMPRESSION for value: Deep Compression
            /// </summary>
            public static readonly LosslessCompressionModeEnum DEEP_COMPRESSION = new LosslessCompressionModeEnum("Deep Compression");

            private static readonly Dictionary<string, LosslessCompressionModeEnum> StaticFields =
            new Dictionary<string, LosslessCompressionModeEnum>()
            {
                { "Basic Compression", BASIC_COMPRESSION },
                { "Deep Compression", DEEP_COMPRESSION },
            };

            private string _value;

            public LosslessCompressionModeEnum()
            {

            }

            public LosslessCompressionModeEnum(string value)
            {
                _value = value;
            }

            public static LosslessCompressionModeEnum FromValue(string value)
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

                if (this.Equals(obj as LosslessCompressionModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(LosslessCompressionModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(LosslessCompressionModeEnum a, LosslessCompressionModeEnum b)
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

            public static bool operator !=(LosslessCompressionModeEnum a, LosslessCompressionModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 质量或带宽优先。取值为： Quality First：表示初级压缩。 Bandwidth First：表示深度压缩。
        /// </summary>
        /// <value>质量或带宽优先。取值为： Quality First：表示初级压缩。 Bandwidth First：表示深度压缩。</value>
        [JsonConverter(typeof(EnumClassConverter<QualityBandwidthFirstEnum>))]
        public class QualityBandwidthFirstEnum
        {
            /// <summary>
            /// Enum QUALITY_FIRST for value: Quality First
            /// </summary>
            public static readonly QualityBandwidthFirstEnum QUALITY_FIRST = new QualityBandwidthFirstEnum("Quality First");

            /// <summary>
            /// Enum BANDWIDTH_FIRST for value: Bandwidth First
            /// </summary>
            public static readonly QualityBandwidthFirstEnum BANDWIDTH_FIRST = new QualityBandwidthFirstEnum("Bandwidth First");

            private static readonly Dictionary<string, QualityBandwidthFirstEnum> StaticFields =
            new Dictionary<string, QualityBandwidthFirstEnum>()
            {
                { "Quality First", QUALITY_FIRST },
                { "Bandwidth First", BANDWIDTH_FIRST },
            };

            private string _value;

            public QualityBandwidthFirstEnum()
            {

            }

            public QualityBandwidthFirstEnum(string value)
            {
                _value = value;
            }

            public static QualityBandwidthFirstEnum FromValue(string value)
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

                if (this.Equals(obj as QualityBandwidthFirstEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(QualityBandwidthFirstEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(QualityBandwidthFirstEnum a, QualityBandwidthFirstEnum b)
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

            public static bool operator !=(QualityBandwidthFirstEnum a, QualityBandwidthFirstEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 编码预置。取值为： 预置1：Preset 1。 预置2：Preset 2。 预置3：Preset 3。 预置4：Preset 4。 预置5：Preset 5。 预置6：Preset 6。 预置7：Preset 7。
        /// </summary>
        /// <value>编码预置。取值为： 预置1：Preset 1。 预置2：Preset 2。 预置3：Preset 3。 预置4：Preset 4。 预置5：Preset 5。 预置6：Preset 6。 预置7：Preset 7。</value>
        [JsonConverter(typeof(EnumClassConverter<EncodingPresetEnum>))]
        public class EncodingPresetEnum
        {
            /// <summary>
            /// Enum PRESET_1 for value: Preset 1
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_1 = new EncodingPresetEnum("Preset 1");

            /// <summary>
            /// Enum PRESET_2 for value: Preset 2
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_2 = new EncodingPresetEnum("Preset 2");

            /// <summary>
            /// Enum PRESET_3 for value: Preset 3
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_3 = new EncodingPresetEnum("Preset 3");

            /// <summary>
            /// Enum PRESET_4 for value: Preset 4
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_4 = new EncodingPresetEnum("Preset 4");

            /// <summary>
            /// Enum PRESET_5 for value: Preset 5
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_5 = new EncodingPresetEnum("Preset 5");

            /// <summary>
            /// Enum PRESET_6 for value: Preset 6
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_6 = new EncodingPresetEnum("Preset 6");

            /// <summary>
            /// Enum PRESET_7 for value: Preset 7
            /// </summary>
            public static readonly EncodingPresetEnum PRESET_7 = new EncodingPresetEnum("Preset 7");

            private static readonly Dictionary<string, EncodingPresetEnum> StaticFields =
            new Dictionary<string, EncodingPresetEnum>()
            {
                { "Preset 1", PRESET_1 },
                { "Preset 2", PRESET_2 },
                { "Preset 3", PRESET_3 },
                { "Preset 4", PRESET_4 },
                { "Preset 5", PRESET_5 },
                { "Preset 6", PRESET_6 },
                { "Preset 7", PRESET_7 },
            };

            private string _value;

            public EncodingPresetEnum()
            {

            }

            public EncodingPresetEnum(string value)
            {
                _value = value;
            }

            public static EncodingPresetEnum FromValue(string value)
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

                if (this.Equals(obj as EncodingPresetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EncodingPresetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EncodingPresetEnum a, EncodingPresetEnum b)
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

            public static bool operator !=(EncodingPresetEnum a, EncodingPresetEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 带宽（Kbps）。取值范围为[256-25000]。默认：20000。
        /// </summary>
        [JsonProperty("display_bandwidth", NullValueHandling = NullValueHandling.Ignore)]
        public int? DisplayBandwidth { get; set; }

        /// <summary>
        /// 帧率（fps）。取值范围为[1-60]。默认：25。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 视频帧率（fps）。取值范围为[1-60]。默认：30。
        /// </summary>
        [JsonProperty("video_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoFrameRate { get; set; }

        /// <summary>
        /// 图像缓存最低容量（MB）。取值范围[0-300]，默认：200。
        /// </summary>
        [JsonProperty("min_image_cache", NullValueHandling = NullValueHandling.Ignore)]
        public int? MinImageCache { get; set; }

        /// <summary>
        /// 有损压缩识别阈值。取值范围为[0-255]。默认：60。
        /// </summary>
        [JsonProperty("smoothing_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? SmoothingFactor { get; set; }

        /// <summary>
        /// 无损压缩模式。取值为： Basic Compression：表示初级压缩。 Deep Compression：表示深度压缩。
        /// </summary>
        [JsonProperty("lossless_compression_mode", NullValueHandling = NullValueHandling.Ignore)]
        public LosslessCompressionModeEnum LosslessCompressionMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deep_compression_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayOptionsDeepCompressionOptions DeepCompressionOptions { get; set; }

        /// <summary>
        /// 有损压缩质量。取值范围为[20-100]。默认：85。
        /// </summary>
        [JsonProperty("lossy_compression_quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? LossyCompressionQuality { get; set; }

        /// <summary>
        /// 办公场景色彩增强：取值为： false：表示关闭。 true：表示开启。
        /// </summary>
        [JsonProperty("color_enhancement_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ColorEnhancementEnable { get; set; }

        /// <summary>
        /// 质量或带宽优先。取值为： Quality First：表示初级压缩。 Bandwidth First：表示深度压缩。
        /// </summary>
        [JsonProperty("quality_bandwidth_first", NullValueHandling = NullValueHandling.Ignore)]
        public QualityBandwidthFirstEnum QualityBandwidthFirst { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_bit_rate_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayOptionsVideoBitRateOptions VideoBitRateOptions { get; set; }

        /// <summary>
        /// 视频峰值码率（Kbps）。取值范围为[256-100000]。默认：18000。
        /// </summary>
        [JsonProperty("peak_video_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeakVideoBitRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("video_quality_options", NullValueHandling = NullValueHandling.Ignore)]
        public DisplayOptionsVideoQualityOptions VideoQualityOptions { get; set; }

        /// <summary>
        /// GOP大小。取值范围为[0-65535]。默认：100。
        /// </summary>
        [JsonProperty("gop_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? GopSize { get; set; }

        /// <summary>
        /// 编码预置。取值为： 预置1：Preset 1。 预置2：Preset 2。 预置3：Preset 3。 预置4：Preset 4。 预置5：Preset 5。 预置6：Preset 6。 预置7：Preset 7。
        /// </summary>
        [JsonProperty("encoding_preset", NullValueHandling = NullValueHandling.Ignore)]
        public EncodingPresetEnum EncodingPreset { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayOptions {\n");
            sb.Append("  displayBandwidth: ").Append(DisplayBandwidth).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  videoFrameRate: ").Append(VideoFrameRate).Append("\n");
            sb.Append("  minImageCache: ").Append(MinImageCache).Append("\n");
            sb.Append("  smoothingFactor: ").Append(SmoothingFactor).Append("\n");
            sb.Append("  losslessCompressionMode: ").Append(LosslessCompressionMode).Append("\n");
            sb.Append("  deepCompressionOptions: ").Append(DeepCompressionOptions).Append("\n");
            sb.Append("  lossyCompressionQuality: ").Append(LossyCompressionQuality).Append("\n");
            sb.Append("  colorEnhancementEnable: ").Append(ColorEnhancementEnable).Append("\n");
            sb.Append("  qualityBandwidthFirst: ").Append(QualityBandwidthFirst).Append("\n");
            sb.Append("  videoBitRateOptions: ").Append(VideoBitRateOptions).Append("\n");
            sb.Append("  peakVideoBitRate: ").Append(PeakVideoBitRate).Append("\n");
            sb.Append("  videoQualityOptions: ").Append(VideoQualityOptions).Append("\n");
            sb.Append("  gopSize: ").Append(GopSize).Append("\n");
            sb.Append("  encodingPreset: ").Append(EncodingPreset).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisplayOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisplayOptions input)
        {
            if (input == null) return false;
            if (this.DisplayBandwidth != input.DisplayBandwidth || (this.DisplayBandwidth != null && !this.DisplayBandwidth.Equals(input.DisplayBandwidth))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.VideoFrameRate != input.VideoFrameRate || (this.VideoFrameRate != null && !this.VideoFrameRate.Equals(input.VideoFrameRate))) return false;
            if (this.MinImageCache != input.MinImageCache || (this.MinImageCache != null && !this.MinImageCache.Equals(input.MinImageCache))) return false;
            if (this.SmoothingFactor != input.SmoothingFactor || (this.SmoothingFactor != null && !this.SmoothingFactor.Equals(input.SmoothingFactor))) return false;
            if (this.LosslessCompressionMode != input.LosslessCompressionMode) return false;
            if (this.DeepCompressionOptions != input.DeepCompressionOptions || (this.DeepCompressionOptions != null && !this.DeepCompressionOptions.Equals(input.DeepCompressionOptions))) return false;
            if (this.LossyCompressionQuality != input.LossyCompressionQuality || (this.LossyCompressionQuality != null && !this.LossyCompressionQuality.Equals(input.LossyCompressionQuality))) return false;
            if (this.ColorEnhancementEnable != input.ColorEnhancementEnable || (this.ColorEnhancementEnable != null && !this.ColorEnhancementEnable.Equals(input.ColorEnhancementEnable))) return false;
            if (this.QualityBandwidthFirst != input.QualityBandwidthFirst) return false;
            if (this.VideoBitRateOptions != input.VideoBitRateOptions || (this.VideoBitRateOptions != null && !this.VideoBitRateOptions.Equals(input.VideoBitRateOptions))) return false;
            if (this.PeakVideoBitRate != input.PeakVideoBitRate || (this.PeakVideoBitRate != null && !this.PeakVideoBitRate.Equals(input.PeakVideoBitRate))) return false;
            if (this.VideoQualityOptions != input.VideoQualityOptions || (this.VideoQualityOptions != null && !this.VideoQualityOptions.Equals(input.VideoQualityOptions))) return false;
            if (this.GopSize != input.GopSize || (this.GopSize != null && !this.GopSize.Equals(input.GopSize))) return false;
            if (this.EncodingPreset != input.EncodingPreset) return false;

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
                if (this.DisplayBandwidth != null) hashCode = hashCode * 59 + this.DisplayBandwidth.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.VideoFrameRate != null) hashCode = hashCode * 59 + this.VideoFrameRate.GetHashCode();
                if (this.MinImageCache != null) hashCode = hashCode * 59 + this.MinImageCache.GetHashCode();
                if (this.SmoothingFactor != null) hashCode = hashCode * 59 + this.SmoothingFactor.GetHashCode();
                hashCode = hashCode * 59 + this.LosslessCompressionMode.GetHashCode();
                if (this.DeepCompressionOptions != null) hashCode = hashCode * 59 + this.DeepCompressionOptions.GetHashCode();
                if (this.LossyCompressionQuality != null) hashCode = hashCode * 59 + this.LossyCompressionQuality.GetHashCode();
                if (this.ColorEnhancementEnable != null) hashCode = hashCode * 59 + this.ColorEnhancementEnable.GetHashCode();
                hashCode = hashCode * 59 + this.QualityBandwidthFirst.GetHashCode();
                if (this.VideoBitRateOptions != null) hashCode = hashCode * 59 + this.VideoBitRateOptions.GetHashCode();
                if (this.PeakVideoBitRate != null) hashCode = hashCode * 59 + this.PeakVideoBitRate.GetHashCode();
                if (this.VideoQualityOptions != null) hashCode = hashCode * 59 + this.VideoQualityOptions.GetHashCode();
                if (this.GopSize != null) hashCode = hashCode * 59 + this.GopSize.GetHashCode();
                hashCode = hashCode * 59 + this.EncodingPreset.GetHashCode();
                return hashCode;
            }
        }
    }
}
