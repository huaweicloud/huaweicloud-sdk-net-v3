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
    /// 视频的元数据信息。  经过视频解析后产生，包括封装格式、大小、分辨率、码率、帧率。
    /// </summary>
    public class MetaData 
    {
        /// <summary>
        /// 视频封装格式。  取值如下： - MP4 - TS - MOV - MXF - MPG - FLV - WMV - MP3 - WMA - APE - FLAC - AAC - AC3 - MMF - AMR - M4A - M4R - OGG - WAV - WV - MP2 - AVI - F4V - M4V - MPEG - HLS - DASH
        /// </summary>
        /// <value>视频封装格式。  取值如下： - MP4 - TS - MOV - MXF - MPG - FLV - WMV - MP3 - WMA - APE - FLAC - AAC - AC3 - MMF - AMR - M4A - M4R - OGG - WAV - WV - MP2 - AVI - F4V - M4V - MPEG - HLS - DASH</value>
        [JsonConverter(typeof(EnumClassConverter<PackTypeEnum>))]
        public class PackTypeEnum
        {
            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly PackTypeEnum MP4 = new PackTypeEnum("MP4");

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            public static readonly PackTypeEnum TS = new PackTypeEnum("TS");

            /// <summary>
            /// Enum MOV for value: MOV
            /// </summary>
            public static readonly PackTypeEnum MOV = new PackTypeEnum("MOV");

            /// <summary>
            /// Enum MXF for value: MXF
            /// </summary>
            public static readonly PackTypeEnum MXF = new PackTypeEnum("MXF");

            /// <summary>
            /// Enum MPG for value: MPG
            /// </summary>
            public static readonly PackTypeEnum MPG = new PackTypeEnum("MPG");

            /// <summary>
            /// Enum FLV for value: FLV
            /// </summary>
            public static readonly PackTypeEnum FLV = new PackTypeEnum("FLV");

            /// <summary>
            /// Enum WMV for value: WMV
            /// </summary>
            public static readonly PackTypeEnum WMV = new PackTypeEnum("WMV");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly PackTypeEnum MP3 = new PackTypeEnum("MP3");

            /// <summary>
            /// Enum WMA for value: WMA
            /// </summary>
            public static readonly PackTypeEnum WMA = new PackTypeEnum("WMA");

            /// <summary>
            /// Enum APE for value: APE
            /// </summary>
            public static readonly PackTypeEnum APE = new PackTypeEnum("APE");

            /// <summary>
            /// Enum FLAC for value: FLAC
            /// </summary>
            public static readonly PackTypeEnum FLAC = new PackTypeEnum("FLAC");

            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly PackTypeEnum AAC = new PackTypeEnum("AAC");

            /// <summary>
            /// Enum AC3 for value: AC3
            /// </summary>
            public static readonly PackTypeEnum AC3 = new PackTypeEnum("AC3");

            /// <summary>
            /// Enum MMF for value: MMF
            /// </summary>
            public static readonly PackTypeEnum MMF = new PackTypeEnum("MMF");

            /// <summary>
            /// Enum AMR for value: AMR
            /// </summary>
            public static readonly PackTypeEnum AMR = new PackTypeEnum("AMR");

            /// <summary>
            /// Enum M4A for value: M4A
            /// </summary>
            public static readonly PackTypeEnum M4A = new PackTypeEnum("M4A");

            /// <summary>
            /// Enum M4R for value: M4R
            /// </summary>
            public static readonly PackTypeEnum M4R = new PackTypeEnum("M4R");

            /// <summary>
            /// Enum OGG for value: OGG
            /// </summary>
            public static readonly PackTypeEnum OGG = new PackTypeEnum("OGG");

            /// <summary>
            /// Enum WAV for value: WAV
            /// </summary>
            public static readonly PackTypeEnum WAV = new PackTypeEnum("WAV");

            /// <summary>
            /// Enum WV for value: WV
            /// </summary>
            public static readonly PackTypeEnum WV = new PackTypeEnum("WV");

            /// <summary>
            /// Enum MP2 for value: MP2
            /// </summary>
            public static readonly PackTypeEnum MP2 = new PackTypeEnum("MP2");

            /// <summary>
            /// Enum AVI for value: AVI
            /// </summary>
            public static readonly PackTypeEnum AVI = new PackTypeEnum("AVI");

            /// <summary>
            /// Enum F4V for value: F4V
            /// </summary>
            public static readonly PackTypeEnum F4V = new PackTypeEnum("F4V");

            /// <summary>
            /// Enum M4V for value: M4V
            /// </summary>
            public static readonly PackTypeEnum M4V = new PackTypeEnum("M4V");

            /// <summary>
            /// Enum MPEG for value: MPEG
            /// </summary>
            public static readonly PackTypeEnum MPEG = new PackTypeEnum("MPEG");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly PackTypeEnum HLS = new PackTypeEnum("HLS");

            /// <summary>
            /// Enum DASH for value: DASH
            /// </summary>
            public static readonly PackTypeEnum DASH = new PackTypeEnum("DASH");

            private static readonly Dictionary<string, PackTypeEnum> StaticFields =
            new Dictionary<string, PackTypeEnum>()
            {
                { "MP4", MP4 },
                { "TS", TS },
                { "MOV", MOV },
                { "MXF", MXF },
                { "MPG", MPG },
                { "FLV", FLV },
                { "WMV", WMV },
                { "MP3", MP3 },
                { "WMA", WMA },
                { "APE", APE },
                { "FLAC", FLAC },
                { "AAC", AAC },
                { "AC3", AC3 },
                { "MMF", MMF },
                { "AMR", AMR },
                { "M4A", M4A },
                { "M4R", M4R },
                { "OGG", OGG },
                { "WAV", WAV },
                { "WV", WV },
                { "MP2", MP2 },
                { "AVI", AVI },
                { "F4V", F4V },
                { "M4V", M4V },
                { "MPEG", MPEG },
                { "HLS", HLS },
                { "DASH", DASH },
            };

            private string _value;

            public PackTypeEnum()
            {

            }

            public PackTypeEnum(string value)
            {
                _value = value;
            }

            public static PackTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PackTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PackTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PackTypeEnum a, PackTypeEnum b)
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

            public static bool operator !=(PackTypeEnum a, PackTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack
        /// </summary>
        /// <value>视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack</value>
        [JsonConverter(typeof(EnumClassConverter<CodecEnum>))]
        public class CodecEnum
        {
            /// <summary>
            /// Enum MPEG_2 for value: MPEG-2
            /// </summary>
            public static readonly CodecEnum MPEG_2 = new CodecEnum("MPEG-2");

            /// <summary>
            /// Enum MPEG_4 for value: MPEG-4
            /// </summary>
            public static readonly CodecEnum MPEG_4 = new CodecEnum("MPEG-4");

            /// <summary>
            /// Enum H_264 for value: H.264
            /// </summary>
            public static readonly CodecEnum H_264 = new CodecEnum("H.264");

            /// <summary>
            /// Enum H_265 for value: H.265
            /// </summary>
            public static readonly CodecEnum H_265 = new CodecEnum("H.265");

            /// <summary>
            /// Enum WMV for value: WMV
            /// </summary>
            public static readonly CodecEnum WMV = new CodecEnum("WMV");

            /// <summary>
            /// Enum VORBIS for value: Vorbis
            /// </summary>
            public static readonly CodecEnum VORBIS = new CodecEnum("Vorbis");

            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly CodecEnum AAC = new CodecEnum("AAC");

            /// <summary>
            /// Enum EAC_3 for value: EAC-3
            /// </summary>
            public static readonly CodecEnum EAC_3 = new CodecEnum("EAC-3");

            /// <summary>
            /// Enum AC_3 for value: AC-3
            /// </summary>
            public static readonly CodecEnum AC_3 = new CodecEnum("AC-3");

            /// <summary>
            /// Enum AMR for value: AMR
            /// </summary>
            public static readonly CodecEnum AMR = new CodecEnum("AMR");

            /// <summary>
            /// Enum APE for value: APE
            /// </summary>
            public static readonly CodecEnum APE = new CodecEnum("APE");

            /// <summary>
            /// Enum FLAC for value: FLAC
            /// </summary>
            public static readonly CodecEnum FLAC = new CodecEnum("FLAC");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly CodecEnum MP3 = new CodecEnum("MP3");

            /// <summary>
            /// Enum MP2 for value: MP2
            /// </summary>
            public static readonly CodecEnum MP2 = new CodecEnum("MP2");

            /// <summary>
            /// Enum WMA for value: WMA
            /// </summary>
            public static readonly CodecEnum WMA = new CodecEnum("WMA");

            /// <summary>
            /// Enum PCM for value: PCM
            /// </summary>
            public static readonly CodecEnum PCM = new CodecEnum("PCM");

            /// <summary>
            /// Enum ADPCM for value: ADPCM
            /// </summary>
            public static readonly CodecEnum ADPCM = new CodecEnum("ADPCM");

            /// <summary>
            /// Enum WAVPACK for value: WavPack
            /// </summary>
            public static readonly CodecEnum WAVPACK = new CodecEnum("WavPack");

            /// <summary>
            /// Enum HEAAC for value: HEAAC
            /// </summary>
            public static readonly CodecEnum HEAAC = new CodecEnum("HEAAC");

            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            public static readonly CodecEnum UNKNOWN = new CodecEnum("UNKNOWN");

            private static readonly Dictionary<string, CodecEnum> StaticFields =
            new Dictionary<string, CodecEnum>()
            {
                { "MPEG-2", MPEG_2 },
                { "MPEG-4", MPEG_4 },
                { "H.264", H_264 },
                { "H.265", H_265 },
                { "WMV", WMV },
                { "Vorbis", VORBIS },
                { "AAC", AAC },
                { "EAC-3", EAC_3 },
                { "AC-3", AC_3 },
                { "AMR", AMR },
                { "APE", APE },
                { "FLAC", FLAC },
                { "MP3", MP3 },
                { "MP2", MP2 },
                { "WMA", WMA },
                { "PCM", PCM },
                { "ADPCM", ADPCM },
                { "WavPack", WAVPACK },
                { "HEAAC", HEAAC },
                { "UNKNOWN", UNKNOWN },
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
        /// 视频封装格式。  取值如下： - MP4 - TS - MOV - MXF - MPG - FLV - WMV - MP3 - WMA - APE - FLAC - AAC - AC3 - MMF - AMR - M4A - M4R - OGG - WAV - WV - MP2 - AVI - F4V - M4V - MPEG - HLS - DASH
        /// </summary>
        [JsonProperty("pack_type", NullValueHandling = NullValueHandling.Ignore)]
        public PackTypeEnum PackType { get; set; }
        /// <summary>
        /// 视频编码格式。  取值如下： - MPEG-2 - MPEG-4 - H.264 - H.265 - WMV - Vorbis - AAC - AC-3 - AMR - APE - FLAC - MP3 - MP2 - WMA - PCM - ADPCM - WavPack
        /// </summary>
        [JsonProperty("codec", NullValueHandling = NullValueHandling.Ignore)]
        public CodecEnum Codec { get; set; }
        /// <summary>
        /// 视频时长。  若视频的原时长为非整数，则该字段值为原时长的向下取整。 若视频的原时长小于1，则该字段值为1。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        /// <summary>
        /// 视频文件大小。  单位：字节。
        /// </summary>
        [JsonProperty("video_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? VideoSize { get; set; }

        /// <summary>
        /// 视频宽度（单位：像素）。 - 编码为H.264的取值范围：[32,3840]之间2的倍数。 - 编码为H.265的取值范围：[320,3840]之间4的倍数。
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }

        /// <summary>
        /// 视频高度（单位：像素）。该字段会逐渐废弃，请使用height字段。 - 编码为H.264的取值范围：[32,2160]之间2的倍数 。 - 编码为H.265的取值范围：[240,2160]之间4的倍数。
        /// </summary>
        [JsonProperty("hight", NullValueHandling = NullValueHandling.Ignore)]
        public long? Hight { get; set; }

        /// <summary>
        /// 视频高度（单位：像素）。 - 编码为H.264的取值范围：[32,2160]之间2的倍数 。 - 编码为H.265的取值范围：[240,2160]之间4的倍数。
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        /// <summary>
        /// 视频平均码率。
        /// </summary>
        [JsonProperty("bit_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? BitRate { get; set; }

        /// <summary>
        /// 帧率（单位：帧每秒）。  取值如下： - FRAMERATE_AUTO &#x3D; 1, - FRAMERATE_10 &#x3D; 2, - FRAMERATE_15 &#x3D; 3, - FRAMERATE_2397 &#x3D; 4, // 23.97 fps - FRAMERATE_24 &#x3D; 5, - FRAMERATE_25 &#x3D; 6, - FRAMERATE_2997 &#x3D; 7, // 29.97 fps - FRAMERATE_30 &#x3D; 8, - FRAMERATE_50 &#x3D; 9, - FRAMERATE_60 &#x3D; 10  默认值：1。  单位：帧每秒。
        /// </summary>
        [JsonProperty("frame_rate", NullValueHandling = NullValueHandling.Ignore)]
        public long? FrameRate { get; set; }

        /// <summary>
        /// 清晰度。  取值如下： - FULL_HD：超高清 - HD：高清 - SD：标清 - FLUENT：流畅 - AD：自适应 - 2K - 4K
        /// </summary>
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public string Quality { get; set; }

        /// <summary>
        /// 音频的声道数。
        /// </summary>
        [JsonProperty("audio_channels", NullValueHandling = NullValueHandling.Ignore)]
        public int? AudioChannels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetaData {\n");
            sb.Append("  packType: ").Append(PackType).Append("\n");
            sb.Append("  codec: ").Append(Codec).Append("\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("  videoSize: ").Append(VideoSize).Append("\n");
            sb.Append("  width: ").Append(Width).Append("\n");
            sb.Append("  hight: ").Append(Hight).Append("\n");
            sb.Append("  height: ").Append(Height).Append("\n");
            sb.Append("  bitRate: ").Append(BitRate).Append("\n");
            sb.Append("  frameRate: ").Append(FrameRate).Append("\n");
            sb.Append("  quality: ").Append(Quality).Append("\n");
            sb.Append("  audioChannels: ").Append(AudioChannels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MetaData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MetaData input)
        {
            if (input == null) return false;
            if (this.PackType != input.PackType) return false;
            if (this.Codec != input.Codec) return false;
            if (this.Duration != input.Duration || (this.Duration != null && !this.Duration.Equals(input.Duration))) return false;
            if (this.VideoSize != input.VideoSize || (this.VideoSize != null && !this.VideoSize.Equals(input.VideoSize))) return false;
            if (this.Width != input.Width || (this.Width != null && !this.Width.Equals(input.Width))) return false;
            if (this.Hight != input.Hight || (this.Hight != null && !this.Hight.Equals(input.Hight))) return false;
            if (this.Height != input.Height || (this.Height != null && !this.Height.Equals(input.Height))) return false;
            if (this.BitRate != input.BitRate || (this.BitRate != null && !this.BitRate.Equals(input.BitRate))) return false;
            if (this.FrameRate != input.FrameRate || (this.FrameRate != null && !this.FrameRate.Equals(input.FrameRate))) return false;
            if (this.Quality != input.Quality || (this.Quality != null && !this.Quality.Equals(input.Quality))) return false;
            if (this.AudioChannels != input.AudioChannels || (this.AudioChannels != null && !this.AudioChannels.Equals(input.AudioChannels))) return false;

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
                hashCode = hashCode * 59 + this.PackType.GetHashCode();
                hashCode = hashCode * 59 + this.Codec.GetHashCode();
                if (this.Duration != null) hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.VideoSize != null) hashCode = hashCode * 59 + this.VideoSize.GetHashCode();
                if (this.Width != null) hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Hight != null) hashCode = hashCode * 59 + this.Hight.GetHashCode();
                if (this.Height != null) hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.BitRate != null) hashCode = hashCode * 59 + this.BitRate.GetHashCode();
                if (this.FrameRate != null) hashCode = hashCode * 59 + this.FrameRate.GetHashCode();
                if (this.Quality != null) hashCode = hashCode * 59 + this.Quality.GetHashCode();
                if (this.AudioChannels != null) hashCode = hashCode * 59 + this.AudioChannels.GetHashCode();
                return hashCode;
            }
        }
    }
}
