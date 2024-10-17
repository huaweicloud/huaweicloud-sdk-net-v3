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
    public class UploadAssetReq 
    {
        /// <summary>
        /// 视频文件类型。 取值为MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV
        /// </summary>
        /// <value>视频文件类型。 取值为MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV</value>
        [JsonConverter(typeof(EnumClassConverter<VideoTypeEnum>))]
        public class VideoTypeEnum
        {
            /// <summary>
            /// Enum MP4 for value: MP4
            /// </summary>
            public static readonly VideoTypeEnum MP4 = new VideoTypeEnum("MP4");

            /// <summary>
            /// Enum TS for value: TS
            /// </summary>
            public static readonly VideoTypeEnum TS = new VideoTypeEnum("TS");

            /// <summary>
            /// Enum MOV for value: MOV
            /// </summary>
            public static readonly VideoTypeEnum MOV = new VideoTypeEnum("MOV");

            /// <summary>
            /// Enum MXF for value: MXF
            /// </summary>
            public static readonly VideoTypeEnum MXF = new VideoTypeEnum("MXF");

            /// <summary>
            /// Enum MPG for value: MPG
            /// </summary>
            public static readonly VideoTypeEnum MPG = new VideoTypeEnum("MPG");

            /// <summary>
            /// Enum FLV for value: FLV
            /// </summary>
            public static readonly VideoTypeEnum FLV = new VideoTypeEnum("FLV");

            /// <summary>
            /// Enum WMV for value: WMV
            /// </summary>
            public static readonly VideoTypeEnum WMV = new VideoTypeEnum("WMV");

            /// <summary>
            /// Enum HLS for value: HLS
            /// </summary>
            public static readonly VideoTypeEnum HLS = new VideoTypeEnum("HLS");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly VideoTypeEnum MP3 = new VideoTypeEnum("MP3");

            /// <summary>
            /// Enum WMA for value: WMA
            /// </summary>
            public static readonly VideoTypeEnum WMA = new VideoTypeEnum("WMA");

            /// <summary>
            /// Enum APE for value: APE
            /// </summary>
            public static readonly VideoTypeEnum APE = new VideoTypeEnum("APE");

            /// <summary>
            /// Enum FLAC for value: FLAC
            /// </summary>
            public static readonly VideoTypeEnum FLAC = new VideoTypeEnum("FLAC");

            /// <summary>
            /// Enum AAC for value: AAC
            /// </summary>
            public static readonly VideoTypeEnum AAC = new VideoTypeEnum("AAC");

            /// <summary>
            /// Enum AC3 for value: AC3
            /// </summary>
            public static readonly VideoTypeEnum AC3 = new VideoTypeEnum("AC3");

            /// <summary>
            /// Enum MMF for value: MMF
            /// </summary>
            public static readonly VideoTypeEnum MMF = new VideoTypeEnum("MMF");

            /// <summary>
            /// Enum AMR for value: AMR
            /// </summary>
            public static readonly VideoTypeEnum AMR = new VideoTypeEnum("AMR");

            /// <summary>
            /// Enum M4A for value: M4A
            /// </summary>
            public static readonly VideoTypeEnum M4A = new VideoTypeEnum("M4A");

            /// <summary>
            /// Enum M4R for value: M4R
            /// </summary>
            public static readonly VideoTypeEnum M4R = new VideoTypeEnum("M4R");

            /// <summary>
            /// Enum OGG for value: OGG
            /// </summary>
            public static readonly VideoTypeEnum OGG = new VideoTypeEnum("OGG");

            /// <summary>
            /// Enum WAV for value: WAV
            /// </summary>
            public static readonly VideoTypeEnum WAV = new VideoTypeEnum("WAV");

            /// <summary>
            /// Enum WV for value: WV
            /// </summary>
            public static readonly VideoTypeEnum WV = new VideoTypeEnum("WV");

            /// <summary>
            /// Enum MP2 for value: MP2
            /// </summary>
            public static readonly VideoTypeEnum MP2 = new VideoTypeEnum("MP2");

            /// <summary>
            /// Enum AVI for value: AVI
            /// </summary>
            public static readonly VideoTypeEnum AVI = new VideoTypeEnum("AVI");

            /// <summary>
            /// Enum F4V for value: F4V
            /// </summary>
            public static readonly VideoTypeEnum F4V = new VideoTypeEnum("F4V");

            /// <summary>
            /// Enum M4V for value: M4V
            /// </summary>
            public static readonly VideoTypeEnum M4V = new VideoTypeEnum("M4V");

            /// <summary>
            /// Enum MPEG for value: MPEG
            /// </summary>
            public static readonly VideoTypeEnum MPEG = new VideoTypeEnum("MPEG");

            /// <summary>
            /// Enum UNKNOW for value: UNKNOW
            /// </summary>
            public static readonly VideoTypeEnum UNKNOW = new VideoTypeEnum("UNKNOW");

            private static readonly Dictionary<string, VideoTypeEnum> StaticFields =
            new Dictionary<string, VideoTypeEnum>()
            {
                { "MP4", MP4 },
                { "TS", TS },
                { "MOV", MOV },
                { "MXF", MXF },
                { "MPG", MPG },
                { "FLV", FLV },
                { "WMV", WMV },
                { "HLS", HLS },
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
                { "UNKNOW", UNKNOW },
            };

            private string _value;

            public VideoTypeEnum()
            {

            }

            public VideoTypeEnum(string value)
            {
                _value = value;
            }

            public static VideoTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VideoTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VideoTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VideoTypeEnum a, VideoTypeEnum b)
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

            public static bool operator !=(VideoTypeEnum a, VideoTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 封面图片格式类型。  取值如下： - JPG - PNG
        /// </summary>
        /// <value>封面图片格式类型。  取值如下： - JPG - PNG</value>
        [JsonConverter(typeof(EnumClassConverter<CoverTypeEnum>))]
        public class CoverTypeEnum
        {
            /// <summary>
            /// Enum JPG for value: JPG
            /// </summary>
            public static readonly CoverTypeEnum JPG = new CoverTypeEnum("JPG");

            /// <summary>
            /// Enum PNG for value: PNG
            /// </summary>
            public static readonly CoverTypeEnum PNG = new CoverTypeEnum("PNG");

            private static readonly Dictionary<string, CoverTypeEnum> StaticFields =
            new Dictionary<string, CoverTypeEnum>()
            {
                { "JPG", JPG },
                { "PNG", PNG },
            };

            private string _value;

            public CoverTypeEnum()
            {

            }

            public CoverTypeEnum(string value)
            {
                _value = value;
            }

            public static CoverTypeEnum FromValue(string value)
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

                if (this.Equals(obj as CoverTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CoverTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(CoverTypeEnum a, CoverTypeEnum b)
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

            public static bool operator !=(CoverTypeEnum a, CoverTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资ID。
        /// </summary>
        [JsonProperty("asset_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AssetId { get; set; }

        /// <summary>
        /// 视频文件MD5值。  建议参考[媒资上传和更新](https://support.huaweicloud.com/api-vod/vod_04_0212.html)生成对应的MD5值。
        /// </summary>
        [JsonProperty("video_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoMd5 { get; set; }

        /// <summary>
        /// 视频文件名。  文件名后缀为可选。
        /// </summary>
        [JsonProperty("video_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoName { get; set; }

        /// <summary>
        /// 视频文件类型。 取值为MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTypeEnum VideoType { get; set; }
        /// <summary>
        /// 封面ID。  取值范围：[0,7]。  当前只支持一张封面，只能设置为0。
        /// </summary>
        [JsonProperty("cover_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CoverId { get; set; }

        /// <summary>
        /// 封面图片格式类型。  取值如下： - JPG - PNG
        /// </summary>
        [JsonProperty("cover_type", NullValueHandling = NullValueHandling.Ignore)]
        public CoverTypeEnum CoverType { get; set; }
        /// <summary>
        /// 封面文件的MD5值。
        /// </summary>
        [JsonProperty("cover_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverMd5 { get; set; }

        /// <summary>
        /// 字幕文件信息
        /// </summary>
        [JsonProperty("subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subtitle> Subtitles { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadAssetReq {\n");
            sb.Append("  assetId: ").Append(AssetId).Append("\n");
            sb.Append("  videoMd5: ").Append(VideoMd5).Append("\n");
            sb.Append("  videoName: ").Append(VideoName).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  coverId: ").Append(CoverId).Append("\n");
            sb.Append("  coverType: ").Append(CoverType).Append("\n");
            sb.Append("  coverMd5: ").Append(CoverMd5).Append("\n");
            sb.Append("  subtitles: ").Append(Subtitles).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadAssetReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadAssetReq input)
        {
            if (input == null) return false;
            if (this.AssetId != input.AssetId || (this.AssetId != null && !this.AssetId.Equals(input.AssetId))) return false;
            if (this.VideoMd5 != input.VideoMd5 || (this.VideoMd5 != null && !this.VideoMd5.Equals(input.VideoMd5))) return false;
            if (this.VideoName != input.VideoName || (this.VideoName != null && !this.VideoName.Equals(input.VideoName))) return false;
            if (this.VideoType != input.VideoType) return false;
            if (this.CoverId != input.CoverId || (this.CoverId != null && !this.CoverId.Equals(input.CoverId))) return false;
            if (this.CoverType != input.CoverType) return false;
            if (this.CoverMd5 != input.CoverMd5 || (this.CoverMd5 != null && !this.CoverMd5.Equals(input.CoverMd5))) return false;
            if (this.Subtitles != input.Subtitles || (this.Subtitles != null && input.Subtitles != null && !this.Subtitles.SequenceEqual(input.Subtitles))) return false;

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
                if (this.AssetId != null) hashCode = hashCode * 59 + this.AssetId.GetHashCode();
                if (this.VideoMd5 != null) hashCode = hashCode * 59 + this.VideoMd5.GetHashCode();
                if (this.VideoName != null) hashCode = hashCode * 59 + this.VideoName.GetHashCode();
                hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                if (this.CoverId != null) hashCode = hashCode * 59 + this.CoverId.GetHashCode();
                hashCode = hashCode * 59 + this.CoverType.GetHashCode();
                if (this.CoverMd5 != null) hashCode = hashCode * 59 + this.CoverMd5.GetHashCode();
                if (this.Subtitles != null) hashCode = hashCode * 59 + this.Subtitles.GetHashCode();
                return hashCode;
            }
        }
    }
}
