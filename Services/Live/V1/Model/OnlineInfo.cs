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
    public class OnlineInfo 
    {
        /// <summary>
        /// 视频编码方式 - H264 - H265 
        /// </summary>
        /// <value>视频编码方式 - H264 - H265 </value>
        [JsonConverter(typeof(EnumClassConverter<VideoCodecEnum>))]
        public class VideoCodecEnum
        {
            /// <summary>
            /// Enum H264 for value: H264
            /// </summary>
            public static readonly VideoCodecEnum H264 = new VideoCodecEnum("H264");

            /// <summary>
            /// Enum H265 for value: H265
            /// </summary>
            public static readonly VideoCodecEnum H265 = new VideoCodecEnum("H265");

            private static readonly Dictionary<string, VideoCodecEnum> StaticFields =
            new Dictionary<string, VideoCodecEnum>()
            {
                { "H264", H264 },
                { "H265", H265 },
            };

            private string _value;

            public VideoCodecEnum()
            {

            }

            public VideoCodecEnum(string value)
            {
                _value = value;
            }

            public static VideoCodecEnum FromValue(string value)
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

                if (this.Equals(obj as VideoCodecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoCodecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoCodecEnum a, VideoCodecEnum b)
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

            public static bool operator !=(VideoCodecEnum a, VideoCodecEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 音频编码方式 - AAC 
        /// </summary>
        /// <value>音频编码方式 - AAC </value>
        [JsonConverter(typeof(EnumClassConverter<AudioCodecEnum>))]
        public class AudioCodecEnum
        {
            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly AudioCodecEnum AAC = new AudioCodecEnum("AAC");

            private static readonly Dictionary<string, AudioCodecEnum> StaticFields =
            new Dictionary<string, AudioCodecEnum>()
            {
                { "AAC", AAC },
            };

            private string _value;

            public AudioCodecEnum()
            {

            }

            public AudioCodecEnum(string value)
            {
                _value = value;
            }

            public static AudioCodecEnum FromValue(string value)
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

                if (this.Equals(obj as AudioCodecEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AudioCodecEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AudioCodecEnum a, AudioCodecEnum b)
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

            public static bool operator !=(AudioCodecEnum a, AudioCodecEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("publish_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PublishDomain { get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("app", NullValueHandling = NullValueHandling.Ignore)]
        public string App { get; set; }

        /// <summary>
        /// 流名
        /// </summary>
        [JsonProperty("stream", NullValueHandling = NullValueHandling.Ignore)]
        public string Stream { get; set; }

        /// <summary>
        /// 视频编码方式 - H264 - H265 
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCodecEnum VideoCodec { get; set; }
        /// <summary>
        /// 音频编码方式 - AAC 
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public AudioCodecEnum AudioCodec { get; set; }
        /// <summary>
        /// 视频帧率
        /// </summary>
        [JsonProperty("video_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoFrameRate { get; set; }

        /// <summary>
        /// 音频帧率
        /// </summary>
        [JsonProperty("audio_frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? AudioFrameRate { get; set; }

        /// <summary>
        /// 视频码率
        /// </summary>
        [JsonProperty("video_bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoBitrate { get; set; }

        /// <summary>
        /// 音频码率
        /// </summary>
        [JsonProperty("audio_bitrate", NullValueHandling = NullValueHandling.Ignore)]
        public long? AudioBitrate { get; set; }

        /// <summary>
        /// 视频分辨率
        /// </summary>
        [JsonProperty("resolution", NullValueHandling = NullValueHandling.Ignore)]
        public string Resolution { get; set; }

        /// <summary>
        /// 推流设备的ip
        /// </summary>
        [JsonProperty("client_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// 开始推流时刻 UTC格式 2006-01-02T15:04:05Z
        /// </summary>
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnlineInfo {\n");
            sb.Append("  publishDomain: ").Append(PublishDomain).Append("\n");
            sb.Append("  app: ").Append(App).Append("\n");
            sb.Append("  stream: ").Append(Stream).Append("\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  videoFrameRate: ").Append(VideoFrameRate).Append("\n");
            sb.Append("  audioFrameRate: ").Append(AudioFrameRate).Append("\n");
            sb.Append("  videoBitrate: ").Append(VideoBitrate).Append("\n");
            sb.Append("  audioBitrate: ").Append(AudioBitrate).Append("\n");
            sb.Append("  resolution: ").Append(Resolution).Append("\n");
            sb.Append("  clientIp: ").Append(ClientIp).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OnlineInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OnlineInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PublishDomain == input.PublishDomain ||
                    (this.PublishDomain != null &&
                    this.PublishDomain.Equals(input.PublishDomain))
                ) && 
                (
                    this.App == input.App ||
                    (this.App != null &&
                    this.App.Equals(input.App))
                ) && 
                (
                    this.Stream == input.Stream ||
                    (this.Stream != null &&
                    this.Stream.Equals(input.Stream))
                ) && 
                (
                    this.VideoCodec == input.VideoCodec ||
                    (this.VideoCodec != null &&
                    this.VideoCodec.Equals(input.VideoCodec))
                ) && 
                (
                    this.AudioCodec == input.AudioCodec ||
                    (this.AudioCodec != null &&
                    this.AudioCodec.Equals(input.AudioCodec))
                ) && 
                (
                    this.VideoFrameRate == input.VideoFrameRate ||
                    (this.VideoFrameRate != null &&
                    this.VideoFrameRate.Equals(input.VideoFrameRate))
                ) && 
                (
                    this.AudioFrameRate == input.AudioFrameRate ||
                    (this.AudioFrameRate != null &&
                    this.AudioFrameRate.Equals(input.AudioFrameRate))
                ) && 
                (
                    this.VideoBitrate == input.VideoBitrate ||
                    (this.VideoBitrate != null &&
                    this.VideoBitrate.Equals(input.VideoBitrate))
                ) && 
                (
                    this.AudioBitrate == input.AudioBitrate ||
                    (this.AudioBitrate != null &&
                    this.AudioBitrate.Equals(input.AudioBitrate))
                ) && 
                (
                    this.Resolution == input.Resolution ||
                    (this.Resolution != null &&
                    this.Resolution.Equals(input.Resolution))
                ) && 
                (
                    this.ClientIp == input.ClientIp ||
                    (this.ClientIp != null &&
                    this.ClientIp.Equals(input.ClientIp))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.PublishDomain != null)
                    hashCode = hashCode * 59 + this.PublishDomain.GetHashCode();
                if (this.App != null)
                    hashCode = hashCode * 59 + this.App.GetHashCode();
                if (this.Stream != null)
                    hashCode = hashCode * 59 + this.Stream.GetHashCode();
                if (this.VideoCodec != null)
                    hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                if (this.AudioCodec != null)
                    hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.VideoFrameRate != null)
                    hashCode = hashCode * 59 + this.VideoFrameRate.GetHashCode();
                if (this.AudioFrameRate != null)
                    hashCode = hashCode * 59 + this.AudioFrameRate.GetHashCode();
                if (this.VideoBitrate != null)
                    hashCode = hashCode * 59 + this.VideoBitrate.GetHashCode();
                if (this.AudioBitrate != null)
                    hashCode = hashCode * 59 + this.AudioBitrate.GetHashCode();
                if (this.Resolution != null)
                    hashCode = hashCode * 59 + this.Resolution.GetHashCode();
                if (this.ClientIp != null)
                    hashCode = hashCode * 59 + this.ClientIp.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
