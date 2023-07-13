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
    /// 模板信息。
    /// </summary>
    public class Common 
    {
        /// <summary>
        /// pvc开关。
        /// </summary>
        /// <value>pvc开关。</value>
        [JsonConverter(typeof(EnumClassConverter<PvcEnum>))]
        public class PvcEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly PvcEnum _0 = new PvcEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly PvcEnum _1 = new PvcEnum("1");

            /// <summary>
            /// Enum _2 for value: 2
            /// </summary>
            public static readonly PvcEnum _2 = new PvcEnum("2");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly PvcEnum UNKNOW = new PvcEnum("UNKNOW");

            private static readonly Dictionary<string, PvcEnum> StaticFields =
            new Dictionary<string, PvcEnum>()
            {
                { "0", _0 },
                { "1", _1 },
                { "2", _2 },
                { "UNKNOW", UNKNOW },
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
        /// 视频编码格式。
        /// </summary>
        /// <value>视频编码格式。</value>
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

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly VideoCodecEnum UNKNOW = new VideoCodecEnum("UNKNOW");

            private static readonly Dictionary<string, VideoCodecEnum> StaticFields =
            new Dictionary<string, VideoCodecEnum>()
            {
                { "H264", H264 },
                { "H265", H265 },
                { "UNKNOW", UNKNOW },
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
        /// 音频编码格式(有效值范围) - 1：AUDIO_CODECTYPE_AAC - 2：AUDIO_CODECTYPE_HEAAC1 - 3：AUDIO_CODECTYPE_HEAAC2 - 4：AUDIO_CODECTYPE_MP3  默认值为1。
        /// </summary>
        /// <value>音频编码格式(有效值范围) - 1：AUDIO_CODECTYPE_AAC - 2：AUDIO_CODECTYPE_HEAAC1 - 3：AUDIO_CODECTYPE_HEAAC2 - 4：AUDIO_CODECTYPE_MP3  默认值为1。</value>
        [JsonConverter(typeof(EnumClassConverter<AudioCodecEnum>))]
        public class AudioCodecEnum
        {
            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly AudioCodecEnum AAC = new AudioCodecEnum("AAC");

            /// <summary>
            /// Enum HEAAC1 for value: HEAAC1
            /// </summary>
            public static readonly AudioCodecEnum HEAAC1 = new AudioCodecEnum("HEAAC1");

            /// <summary>
            /// Enum HEAAC2 for value: HEAAC2
            /// </summary>
            public static readonly AudioCodecEnum HEAAC2 = new AudioCodecEnum("HEAAC2");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly AudioCodecEnum MP3 = new AudioCodecEnum("MP3");

            private static readonly Dictionary<string, AudioCodecEnum> StaticFields =
            new Dictionary<string, AudioCodecEnum>()
            {
                { "AAC", AAC },
                { "HEAAC1", HEAAC1 },
                { "HEAAC2", HEAAC2 },
                { "MP3", MP3 },
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
        /// pvc开关。
        /// </summary>
        [JsonProperty("pvc", NullValueHandling = NullValueHandling.Ignore)]
        public PvcEnum Pvc { get; set; }
        /// <summary>
        /// pvc版本。
        /// </summary>
        [JsonProperty("pvc_version", NullValueHandling = NullValueHandling.Ignore)]
        public string PvcVersion { get; set; }

        /// <summary>
        /// 视频编码格式。
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCodecEnum VideoCodec { get; set; }
        /// <summary>
        /// 音频编码格式(有效值范围) - 1：AUDIO_CODECTYPE_AAC - 2：AUDIO_CODECTYPE_HEAAC1 - 3：AUDIO_CODECTYPE_HEAAC2 - 4：AUDIO_CODECTYPE_MP3  默认值为1。
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public AudioCodecEnum AudioCodec { get; set; }
        /// <summary>
        /// 分片时长(默认为5秒)。
        /// </summary>
        [JsonProperty("hls_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInterval { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Common {\n");
            sb.Append("  pvc: ").Append(Pvc).Append("\n");
            sb.Append("  pvcVersion: ").Append(PvcVersion).Append("\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  hlsInterval: ").Append(HlsInterval).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Common);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Common input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pvc == input.Pvc ||
                    (this.Pvc != null &&
                    this.Pvc.Equals(input.Pvc))
                ) && 
                (
                    this.PvcVersion == input.PvcVersion ||
                    (this.PvcVersion != null &&
                    this.PvcVersion.Equals(input.PvcVersion))
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
                    this.HlsInterval == input.HlsInterval ||
                    (this.HlsInterval != null &&
                    this.HlsInterval.Equals(input.HlsInterval))
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
                if (this.Pvc != null)
                    hashCode = hashCode * 59 + this.Pvc.GetHashCode();
                if (this.PvcVersion != null)
                    hashCode = hashCode * 59 + this.PvcVersion.GetHashCode();
                if (this.VideoCodec != null)
                    hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                if (this.AudioCodec != null)
                    hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.HlsInterval != null)
                    hashCode = hashCode * 59 + this.HlsInterval.GetHashCode();
                return hashCode;
            }
        }
    }
}
