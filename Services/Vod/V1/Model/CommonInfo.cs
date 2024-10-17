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
    public class CommonInfo 
    {
        /// <summary>
        /// 视频编码格式&lt;br/&gt; 
        /// </summary>
        /// <value>视频编码格式&lt;br/&gt; </value>
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
        /// 音频编码格式&lt;br/&gt; AAC：AAC格式 (default)&lt;br/&gt; HEAAC1：HEAAC1格式&lt;br/&gt; HEAAC2：HEAAC2格式&lt;br/&gt; MP3：MP3格式&lt;br/&gt; 
        /// </summary>
        /// <value>音频编码格式&lt;br/&gt; AAC：AAC格式 (default)&lt;br/&gt; HEAAC1：HEAAC1格式&lt;br/&gt; HEAAC2：HEAAC2格式&lt;br/&gt; MP3：MP3格式&lt;br/&gt; </value>
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
        /// 格式&lt;br/&gt; 
        /// </summary>
        /// <value>格式&lt;br/&gt; </value>
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
            /// Enum DASH for value: DASH
            /// </summary>
            public static readonly FormatEnum DASH = new FormatEnum("DASH");

            /// <summary>
            /// Enum DASH_HLS for value: DASH_HLS
            /// </summary>
            public static readonly FormatEnum DASH_HLS = new FormatEnum("DASH_HLS");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly FormatEnum MP3 = new FormatEnum("MP3");

            /// <summary>
            /// Enum ADTS for value: ADTS
            /// </summary>
            public static readonly FormatEnum ADTS = new FormatEnum("ADTS");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly FormatEnum UNKNOW = new FormatEnum("UNKNOW");

            private static readonly Dictionary<string, FormatEnum> StaticFields =
            new Dictionary<string, FormatEnum>()
            {
                { "MP4", MP4 },
                { "HLS", HLS },
                { "DASH", DASH },
                { "DASH_HLS", DASH_HLS },
                { "MP3", MP3 },
                { "ADTS", ADTS },
                { "UNKNOW", UNKNOW },
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

            public static bool operator !=(FormatEnum a, FormatEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// SHORT：短边自适应&lt;br/&gt; LONG：长边自适应&lt;br/&gt; NONE：宽高自适应&lt;br/&gt; 
        /// </summary>
        /// <value>SHORT：短边自适应&lt;br/&gt; LONG：长边自适应&lt;br/&gt; NONE：宽高自适应&lt;br/&gt; </value>
        [JsonConverter(typeof(EnumClassConverter<AdaptationEnum>))]
        public class AdaptationEnum
        {
            /// <summary>
            /// Enum SHORT for value: SHORT
            /// </summary>
            public static readonly AdaptationEnum SHORT = new AdaptationEnum("SHORT");

            /// <summary>
            /// Enum LONG for value: LONG
            /// </summary>
            public static readonly AdaptationEnum LONG = new AdaptationEnum("LONG");

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            public static readonly AdaptationEnum NONE = new AdaptationEnum("NONE");

            private static readonly Dictionary<string, AdaptationEnum> StaticFields =
            new Dictionary<string, AdaptationEnum>()
            {
                { "SHORT", SHORT },
                { "LONG", LONG },
                { "NONE", NONE },
            };

            private string _value;

            public AdaptationEnum()
            {

            }

            public AdaptationEnum(string value)
            {
                _value = value;
            }

            public static AdaptationEnum FromValue(string value)
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

                if (this.Equals(obj as AdaptationEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AdaptationEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AdaptationEnum a, AdaptationEnum b)
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

            public static bool operator !=(AdaptationEnum a, AdaptationEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// pvc开关&lt;br/&gt; 
        /// </summary>
        [JsonProperty("pvc", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pvc { get; set; }

        /// <summary>
        /// 视频编码格式&lt;br/&gt; 
        /// </summary>
        [JsonProperty("video_codec", NullValueHandling = NullValueHandling.Ignore)]
        public VideoCodecEnum VideoCodec { get; set; }
        /// <summary>
        /// 音频编码格式&lt;br/&gt; AAC：AAC格式 (default)&lt;br/&gt; HEAAC1：HEAAC1格式&lt;br/&gt; HEAAC2：HEAAC2格式&lt;br/&gt; MP3：MP3格式&lt;br/&gt; 
        /// </summary>
        [JsonProperty("audio_codec", NullValueHandling = NullValueHandling.Ignore)]
        public AudioCodecEnum AudioCodec { get; set; }
        /// <summary>
        /// 黑边剪裁类型&lt;br/&gt; 
        /// </summary>
        [JsonProperty("is_black_cut", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBlackCut { get; set; }

        /// <summary>
        /// 格式&lt;br/&gt; 
        /// </summary>
        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// 分片时长(默认为5秒)&lt;br/&gt; 
        /// </summary>
        [JsonProperty("hls_interval", NullValueHandling = NullValueHandling.Ignore)]
        public int? HlsInterval { get; set; }

        /// <summary>
        /// 上采样&lt;br/&gt; 
        /// </summary>
        [JsonProperty("upsample", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Upsample { get; set; }

        /// <summary>
        /// SHORT：短边自适应&lt;br/&gt; LONG：长边自适应&lt;br/&gt; NONE：宽高自适应&lt;br/&gt; 
        /// </summary>
        [JsonProperty("adaptation", NullValueHandling = NullValueHandling.Ignore)]
        public AdaptationEnum Adaptation { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonInfo {\n");
            sb.Append("  pvc: ").Append(Pvc).Append("\n");
            sb.Append("  videoCodec: ").Append(VideoCodec).Append("\n");
            sb.Append("  audioCodec: ").Append(AudioCodec).Append("\n");
            sb.Append("  isBlackCut: ").Append(IsBlackCut).Append("\n");
            sb.Append("  format: ").Append(Format).Append("\n");
            sb.Append("  hlsInterval: ").Append(HlsInterval).Append("\n");
            sb.Append("  upsample: ").Append(Upsample).Append("\n");
            sb.Append("  adaptation: ").Append(Adaptation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CommonInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CommonInfo input)
        {
            if (input == null) return false;
            if (this.Pvc != input.Pvc || (this.Pvc != null && !this.Pvc.Equals(input.Pvc))) return false;
            if (this.VideoCodec != input.VideoCodec) return false;
            if (this.AudioCodec != input.AudioCodec) return false;
            if (this.IsBlackCut != input.IsBlackCut || (this.IsBlackCut != null && !this.IsBlackCut.Equals(input.IsBlackCut))) return false;
            if (this.Format != input.Format) return false;
            if (this.HlsInterval != input.HlsInterval || (this.HlsInterval != null && !this.HlsInterval.Equals(input.HlsInterval))) return false;
            if (this.Upsample != input.Upsample || (this.Upsample != null && !this.Upsample.Equals(input.Upsample))) return false;
            if (this.Adaptation != input.Adaptation) return false;

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
                if (this.Pvc != null) hashCode = hashCode * 59 + this.Pvc.GetHashCode();
                hashCode = hashCode * 59 + this.VideoCodec.GetHashCode();
                hashCode = hashCode * 59 + this.AudioCodec.GetHashCode();
                if (this.IsBlackCut != null) hashCode = hashCode * 59 + this.IsBlackCut.GetHashCode();
                hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.HlsInterval != null) hashCode = hashCode * 59 + this.HlsInterval.GetHashCode();
                if (this.Upsample != null) hashCode = hashCode * 59 + this.Upsample.GetHashCode();
                hashCode = hashCode * 59 + this.Adaptation.GetHashCode();
                return hashCode;
            }
        }
    }
}
