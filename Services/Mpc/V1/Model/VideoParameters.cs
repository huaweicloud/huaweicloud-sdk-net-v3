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
    public class VideoParameters 
    {
        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        /// <value>输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 </value>
        [JsonConverter(typeof(EnumClassConverter<OutputPolicyEnum>))]
        public class OutputPolicyEnum
        {
            /// <summary>
            /// Enum TRANSCODE for value: transcode
            /// </summary>
            public static readonly OutputPolicyEnum TRANSCODE = new OutputPolicyEnum("transcode");

            /// <summary>
            /// Enum DISCARD for value: discard
            /// </summary>
            public static readonly OutputPolicyEnum DISCARD = new OutputPolicyEnum("discard");

            /// <summary>
            /// Enum COPY for value: copy
            /// </summary>
            public static readonly OutputPolicyEnum COPY = new OutputPolicyEnum("copy");

            private static readonly Dictionary<string, OutputPolicyEnum> StaticFields =
            new Dictionary<string, OutputPolicyEnum>()
            {
                { "transcode", TRANSCODE },
                { "discard", DISCARD },
                { "copy", COPY },
            };

            private string _value;

            public OutputPolicyEnum()
            {

            }

            public OutputPolicyEnum(string value)
            {
                _value = value;
            }

            public static OutputPolicyEnum FromValue(string value)
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

                if (this.Equals(obj as OutputPolicyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutputPolicyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutputPolicyEnum a, OutputPolicyEnum b)
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

            public static bool operator !=(OutputPolicyEnum a, OutputPolicyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 输出策略。  取值如下： - discard - transcode  &gt;- 当视频参数中的“output_policy”为\&quot;discard\&quot;，且音频参数中的“output_policy”为“transcode”时，表示只输出音频。 &gt;- 当视频参数中的“output_policy”为\&quot;transcode\&quot;，且音频参数中的“output_policy”为“discard”时，表示只输出视频。 &gt;- 同时为\&quot;discard\&quot;时不合法。 &gt;- 同时为“transcode”时，表示输出音视频。 
        /// </summary>
        [JsonProperty("output_policy", NullValueHandling = NullValueHandling.Ignore)]
        public OutputPolicyEnum OutputPolicy { get; set; }
        /// <summary>
        /// 视频编码格式。  取值如下： - 1：VIDEO_CODEC_H264 - 2：VIDEO_CODEC_H265 
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public int? Codec { get; set; }

        /// <summary>
        /// 视频恒定码率控制因子。  取值范围为[0, 51] 
        /// </summary>
        [JsonProperty("crf", NullValueHandling = NullValueHandling.Ignore)]
        public Object Crf { get; set; }

        /// <summary>
        /// 输出最大码率  单位：kbit/s  带crf时使用，参考原片的平均码率进行设置（一般为1.5倍） 
        /// </summary>
        [JsonProperty("max_bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// 输出平均码率。  取值范围：0或[40,30000]之间的整数。  单位：kbit/s  若设置为0，则输出平均码率为自适应值。 
        /// </summary>
        [JsonProperty("bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public int? Bitrate { get; set; }

        /// <summary>
        /// 编码档次  取值如下： - 1：VIDEO_PROFILE_H264_BASE - 2：VIDEO_PROFILE_H264_MAIN - 3：VIDEO_PROFILE_H264_HIGH - 4：VIDEO_PROFILE_H265_MAIN 
        /// </summary>
        [JsonProperty("profile", NullValueHandling = NullValueHandling.Ignore)]
        public int? Profile { get; set; }

        /// <summary>
        /// 编码级别  取值如下： - 1：VIDEO_LEVEL_1_0 - 2：VIDEO_LEVEL_1_1 - 3：VIDEO_LEVEL_1_2 - 4：VIDEO_LEVEL_1_3 - 5：VIDEO_LEVEL_2_0 - 6：VIDEO_LEVEL_2_1 - 7：VIDEO_LEVEL_2_2 - 8：VIDEO_LEVEL_3_0 - 9：VIDEO_LEVEL_3_1 - 10：VIDEO_LEVEL_3_2 - 11：VIDEO_LEVEL_4_0 - 12：VIDEO_LEVEL_4_1 - 13：VIDEO_LEVEL_4_2 - 14：VIDEO_LEVEL_5_0 - 15：VIDEO_LEVEL_5_1 - 16：VIDEO_LEVEL_x_x 
        /// </summary>
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }

        /// <summary>
        /// 编码质量等级  取值如下： - 1：VIDEO_PRESET_HSPEED2 (只用于h.265, h.265 default) - 2：VIDEO_PRESET_HSPEED (只用于h.265) - 3：VIDEO_PRESET_NORMAL (h264/h.265可用，h.264 default) 
        /// </summary>
        [JsonProperty("preset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Preset { get; set; }

        /// <summary>
        /// I帧最大间隔  取值范围：[2，10]。  默认值：5。  单位：秒。 
        /// </summary>
        [JsonProperty("max_iframes_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxIframesInterval { get; set; }

        /// <summary>
        /// 最大B帧间隔。  取值范围： - H264：[0，7]，默认值为4。 - H265：[0，7]，默认值为7。  单位：帧。 
        /// </summary>
        [JsonProperty("bframes_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? BframesCount { get; set; }

        /// <summary>
        /// 帧率。  取值范围：0或[5,60]，0表示自适应。  单位：帧每秒。  &gt; 若设置的帧率不在取值范围内，则自动调整为0，若设置的帧率高于片源帧率，则自动调整为片源帧率。 
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? FrameRate { get; set; }

        /// <summary>
        /// 视频宽度（单位：像素）  - H264：范围[32,4096]，必须为2的倍数 - H265：范围[320,4096]，必须是4的倍数 
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// 视频高度（单位：像素）  - H264：范围[32,2880]，必须为2的倍数 - H265：范围[240,2880] ，必须是4的倍数 
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// 黑边剪裁类型  - 0：不开启黑边剪裁 - 1：开启黑边剪裁，低复杂度算法，针对长视频（&gt;5分钟） - 2：开启黑边剪裁，高复杂度算法，针对短视频（&lt;&#x3D;5分钟） 
        /// </summary>
        [JsonProperty("black_cut", NullValueHandling = NullValueHandling.Ignore)]
        public int? BlackCut { get; set; }

        /// <summary>
        /// 流名称 
        /// </summary>
        [JsonProperty("stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StreamName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoParameters {\n");
            sb.Append("  outputPolicy: ").Append(OutputPolicy).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  crf: ").Append(Crf).Append("\n");
            sb.Append("  maxBitrate: ").Append(MaxBitrate).Append("\n");
            sb.Append("  bitrate: ").Append(Bitrate).Append("\n");
            sb.Append("  profile: ").Append(Profile).Append("\n");
            sb.Append("  level: ").Append(Level).Append("\n");
            sb.Append("  preset: ").Append(Preset).Append("\n");
            sb.Append("  maxIframesInterval: ").Append(MaxIframesInterval).Append("\n");
            sb.Append("  bframesCount: ").Append(BframesCount).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  blackCut: ").Append(BlackCut).Append("\n");
            sb.Append("  streamName: ").Append(StreamName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoParameters);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoParameters input)
        {
            if (input == null) return false;
            if (this.OutputPolicy != input.OutputPolicy) return false;
            if (this.Codec != input.Codec || (this.Codec != null && !this.Codec.Equals(input.Codec))) return false;
            if (this.Crf != input.Crf || (this.Crf != null && !this.Crf.Equals(input.Crf))) return false;
            if (this.MaxBitrate != input.MaxBitrate || (this.MaxBitrate != null && !this.MaxBitrate.Equals(input.MaxBitrate))) return false;
            if (this.Bitrate != input.Bitrate || (this.Bitrate != null && !this.Bitrate.Equals(input.Bitrate))) return false;
            if (this.Profile != input.Profile || (this.Profile != null && !this.Profile.Equals(input.Profile))) return false;
            if (this.Level != input.Level || (this.Level != null && !this.Level.Equals(input.Level))) return false;
            if (this.Preset != input.Preset || (this.Preset != null && !this.Preset.Equals(input.Preset))) return false;
            if (this.MaxIframesInterval != input.MaxIframesInterval || (this.MaxIframesInterval != null && !this.MaxIframesInterval.Equals(input.MaxIframesInterval))) return false;
            if (this.BframesCount != input.BframesCount || (this.BframesCount != null && !this.BframesCount.Equals(input.BframesCount))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.BlackCut != input.BlackCut || (this.BlackCut != null && !this.BlackCut.Equals(input.BlackCut))) return false;
            if (this.StreamName != input.StreamName || (this.StreamName != null && !this.StreamName.Equals(input.StreamName))) return false;

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
                hashCode = hashCode * 59 + this.OutputPolicy.GetHashCode();
                if (this.Codec != null) hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Crf != null) hashCode = hashCode * 59 + this.Crf.GetHashCode();
                if (this.MaxBitrate != null) hashCode = hashCode * 59 + this.MaxBitrate.GetHashCode();
                if (this.Bitrate != null) hashCode = hashCode * 59 + this.Bitrate.GetHashCode();
                if (this.Profile != null) hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.Level != null) hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.Preset != null) hashCode = hashCode * 59 + this.Preset.GetHashCode();
                if (this.MaxIframesInterval != null) hashCode = hashCode * 59 + this.MaxIframesInterval.GetHashCode();
                if (this.BframesCount != null) hashCode = hashCode * 59 + this.BframesCount.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BlackCut != null) hashCode = hashCode * 59 + this.BlackCut.GetHashCode();
                if (this.StreamName != null) hashCode = hashCode * 59 + this.StreamName.GetHashCode();
                return hashCode;
            }
        }
    }
}
