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
    /// 视频元数据，自动提取获得。
    /// </summary>
    public class VideoAssetMeta 
    {
        /// <summary>
        /// **参数解释**： 横向画面或纵向画面。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 横向画面或纵向画面。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum HORIZONTAL for value: Horizontal
            /// </summary>
            public static readonly ModeEnum HORIZONTAL = new ModeEnum("Horizontal");

            /// <summary>
            /// Enum VERTICAL for value: Vertical
            /// </summary>
            public static readonly ModeEnum VERTICAL = new ModeEnum("Vertical");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Horizontal", HORIZONTAL },
                { "Vertical", VERTICAL },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**： 视频转码状态。 **约束限制**： 用户无需填写，系统自行填写。 **取值范围**： * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功  **默认取值**： 不涉及
        /// </summary>
        /// <value>**参数解释**： 视频转码状态。 **约束限制**： 用户无需填写，系统自行填写。 **取值范围**： * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功  **默认取值**： 不涉及</value>
        [JsonConverter(typeof(EnumClassConverter<VideoTranscodingStatusEnum>))]
        public class VideoTranscodingStatusEnum
        {
            /// <summary>
            /// Enum WAITING for value: WAITING
            /// </summary>
            public static readonly VideoTranscodingStatusEnum WAITING = new VideoTranscodingStatusEnum("WAITING");

            /// <summary>
            /// Enum TRANSCODING for value: TRANSCODING
            /// </summary>
            public static readonly VideoTranscodingStatusEnum TRANSCODING = new VideoTranscodingStatusEnum("TRANSCODING");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly VideoTranscodingStatusEnum FAILED = new VideoTranscodingStatusEnum("FAILED");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly VideoTranscodingStatusEnum SUCCEEDED = new VideoTranscodingStatusEnum("SUCCEEDED");

            private static readonly Dictionary<string, VideoTranscodingStatusEnum> StaticFields =
            new Dictionary<string, VideoTranscodingStatusEnum>()
            {
                { "WAITING", WAITING },
                { "TRANSCODING", TRANSCODING },
                { "FAILED", FAILED },
                { "SUCCEEDED", SUCCEEDED },
            };

            private string _value;

            public VideoTranscodingStatusEnum()
            {

            }

            public VideoTranscodingStatusEnum(string value)
            {
                _value = value;
            }

            public static VideoTranscodingStatusEnum FromValue(string value)
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

                if (this.Equals(obj as VideoTranscodingStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoTranscodingStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoTranscodingStatusEnum a, VideoTranscodingStatusEnum b)
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

            public static bool operator !=(VideoTranscodingStatusEnum a, VideoTranscodingStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 视频编码格式。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoCodec { get; set; }

        /// <summary>
        /// **参数解释**： 视频画面宽度。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// **参数解释**： 视频画面高度。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// **参数解释**： 视频帧率。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string FrameRate { get; set; }

        /// <summary>
        /// **参数解释**： 视频平均码率,单位kbps。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("video_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? VideoBitRate { get; set; }

        /// <summary>
        /// **参数解释**： 时长,单位秒。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        /// <summary>
        /// **参数解释**： 音频编码格式。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： 字符长度0-32位。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public string AudioCodec { get; set; }

        /// <summary>
        /// **参数解释**： 音频平均码率,单位kbps。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioBitRate { get; set; }

        /// <summary>
        /// **参数解释**： 音频声道数。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("audio_channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioChannels { get; set; }

        /// <summary>
        /// **参数解释**： 采样率,HZ。 **约束限制**： 用户无需填写，系统自行提取。 **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("sample", NullValueHandling = NullValueHandling.Ignore)]
        public int? Sample { get; set; }

        /// <summary>
        /// **参数解释**： 横向画面或纵向画面。 **约束限制**： 用户无需填写，系统自行提取。 **取值范围**： * Horizontal：横向 * Vertical：纵向  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// **参数解释**： 视频转码状态。 **约束限制**： 用户无需填写，系统自行填写。 **取值范围**： * WAITING：等待 * TRANSCODING：转码中 * FAILED：失败 * SUCCEEDED：成功  **默认取值**： 不涉及
        /// </summary>
        [JsonProperty("video_transcoding_status", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTranscodingStatusEnum VideoTranscodingStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("error_info", NullValueHandling = NullValueHandling.Ignore)]
        public ErrorResponse ErrorInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VideoAssetMeta {\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  videoBitRate: ").Append(VideoBitRate).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  audioBitRate: ").Append(AudioBitRate).Append("\n");
            sb.Append("  audioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("  sample: ").Append(Sample).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  videoTranscodingStatus: ").Append(VideoTranscodingStatus).Append("\n");
            sb.Append("  errorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VideoAssetMeta);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VideoAssetMeta input)
        {
            if (input == null) return false;
            if (this.VideoCodec != input.VideoCodec || (this.VideoCodec != null && !this.VideoCodec.Equals(input.VideoCodec))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.VideoBitRate != input.VideoBitRate || (this.VideoBitRate != null && !this.VideoBitRate.Equals(input.VideoBitRate))) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.AudioCodec != input.AudioCodec || (this.AudioCodec != null && !this.AudioCodec.Equals(input.AudioCodec))) return false;
            if (this.AudioBitRate != input.AudioBitRate || (this.AudioBitRate != null && !this.AudioBitRate.Equals(input.AudioBitRate))) return false;
            if (this.AudioChannels != input.AudioChannels || (this.AudioChannels != null && !this.AudioChannels.Equals(input.AudioChannels))) return false;
            if (this.Sample != input.Sample || (this.Sample != null && !this.Sample.Equals(input.Sample))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.VideoTranscodingStatus != input.VideoTranscodingStatus) return false;
            if (this.ErrorInfo != input.ErrorInfo || (this.ErrorInfo != null && !this.ErrorInfo.Equals(input.ErrorInfo))) return false;

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
                if (this.VideoCodec != null) hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.VideoBitRate != null) hashCode = hashCode * 59 + this.VideoBitRate.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.AudioCodec != null) hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.AudioBitRate != null) hashCode = hashCode * 59 + this.AudioBitRate.GetHashCode();
                if (this.AudioChannels != null) hashCode = hashCode * 59 + this.AudioChannels.GetHashCode();
                if (this.Sample != null) hashCode = hashCode * 59 + this.Sample.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                hashCode = hashCode * 59 + this.VideoTranscodingStatus.GetHashCode();
                if (this.ErrorInfo != null) hashCode = hashCode * 59 + this.ErrorInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
