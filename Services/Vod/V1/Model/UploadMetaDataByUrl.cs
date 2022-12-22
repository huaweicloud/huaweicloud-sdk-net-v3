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
    public class UploadMetaDataByUrl 
    {
        /// <summary>
        /// 上传音视频文件的格式。  取值如下： - 视频文件：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV、M3U8 - 音频文件：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2  若上传格式为音频文件，则不支持转码、添加水印和字幕。
        /// </summary>
        /// <value>上传音视频文件的格式。  取值如下： - 视频文件：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV、M3U8 - 音频文件：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2  若上传格式为音频文件，则不支持转码、添加水印和字幕。</value>
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
            /// Enum AVI for value: AVI
            /// </summary>
            public static readonly VideoTypeEnum AVI = new VideoTypeEnum("AVI");

            /// <summary>
            /// Enum M4V for value: M4V
            /// </summary>
            public static readonly VideoTypeEnum M4V = new VideoTypeEnum("M4V");

            /// <summary>
            /// Enum F4V for value: F4V
            /// </summary>
            public static readonly VideoTypeEnum F4V = new VideoTypeEnum("F4V");

            /// <summary>
            /// Enum MPEG for value: MPEG
            /// </summary>
            public static readonly VideoTypeEnum MPEG = new VideoTypeEnum("MPEG");

            /// <summary>
            /// Enum _3GP for value: 3GP
            /// </summary>
            public static readonly VideoTypeEnum _3GP = new VideoTypeEnum("3GP");

            /// <summary>
            /// Enum ASF for value: ASF
            /// </summary>
            public static readonly VideoTypeEnum ASF = new VideoTypeEnum("ASF");

            /// <summary>
            /// Enum MKV for value: MKV
            /// </summary>
            public static readonly VideoTypeEnum MKV = new VideoTypeEnum("MKV");

            /// <summary>
            /// Enum MP3 for value: MP3
            /// </summary>
            public static readonly VideoTypeEnum MP3 = new VideoTypeEnum("MP3");

            /// <summary>
            /// Enum OGG for value: OGG
            /// </summary>
            public static readonly VideoTypeEnum OGG = new VideoTypeEnum("OGG");

            /// <summary>
            /// Enum WAV for value: WAV
            /// </summary>
            public static readonly VideoTypeEnum WAV = new VideoTypeEnum("WAV");

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
            /// Enum WV for value: WV
            /// </summary>
            public static readonly VideoTypeEnum WV = new VideoTypeEnum("WV");

            /// <summary>
            /// Enum MP2 for value: MP2
            /// </summary>
            public static readonly VideoTypeEnum MP2 = new VideoTypeEnum("MP2");

            /// <summary>
            /// Enum M3U8 for value: M3U8
            /// </summary>
            public static readonly VideoTypeEnum M3U8 = new VideoTypeEnum("M3U8");

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
                { "AVI", AVI },
                { "M4V", M4V },
                { "F4V", F4V },
                { "MPEG", MPEG },
                { "3GP", _3GP },
                { "ASF", ASF },
                { "MKV", MKV },
                { "MP3", MP3 },
                { "OGG", OGG },
                { "WAV", WAV },
                { "WMA", WMA },
                { "APE", APE },
                { "FLAC", FLAC },
                { "AAC", AAC },
                { "AC3", AC3 },
                { "MMF", MMF },
                { "AMR", AMR },
                { "M4A", M4A },
                { "M4R", M4R },
                { "WV", WV },
                { "MP2", MP2 },
                { "M3U8", M3U8 },
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
        /// 上传音视频文件的格式。  取值如下： - 视频文件：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV、M3U8 - 音频文件：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2  若上传格式为音频文件，则不支持转码、添加水印和字幕。
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public VideoTypeEnum VideoType { get; set; }
        /// <summary>
        /// 媒资标题，长度不超过128个字节，UTF-8编码。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 音视频源文件URL。   &gt; URL必须以扩展名结尾，暂只支持http和https协议。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        /// <summary>
        /// 视频描述，长度不超过1024个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 媒资分类ID。  您可以调用[创建媒资分类](https://support.huaweicloud.com/api-vod/vod_04_0028.html)接口或在点播控制台的[分类设置](https://support.huaweicloud.com/usermanual-vod/vod010006.html)中创建对应的媒资分类，并获取分类ID。  &gt; 若不设置或者设置为-1，则上传的音视频归类到系统预置的“其它”分类中。
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 视频标签。  单个标签不超过16个字节，最多不超过16个标签。  多个用逗号分隔，UTF8编码。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 是否自动发布。  取值如下： - 0：表示不自动发布。 - 1：表示自动发布。  默认值：0。
        /// </summary>
        [JsonProperty("auto_publish", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoPublish { get; set; }

        /// <summary>
        /// 转码模板组名称。  若不为空，则使用指定的转码模板对上传的音视频进行转码，您可以在视频点播控制台配置转码模板，具体请参见[转码设置](https://support.huaweicloud.com/usermanual-vod/vod_01_0072.html)。  &gt;若同时设置了“**template_group_name**”和“**workflow_name**”字段，则“**template_group_name**”字段生效。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 是否自动加密。  取值如下： - 0：表示不加密。 - 1：表示需要加密。  默认值：0。若设置为需要加密，则必须配置转码模板，且转码的输出格式是HLS。
        /// </summary>
        [JsonProperty("auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoEncrypt { get; set; }

        /// <summary>
        /// 是否自动预热到CDN。  取值如下： - 0：表示不自动预热。 - 1：表示自动预热。  默认值：0。
        /// </summary>
        [JsonProperty("auto_preheat", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoPreheat { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("thumbnail", NullValueHandling = NullValueHandling.Ignore)]
        public Thumbnail Thumbnail { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("review", NullValueHandling = NullValueHandling.Ignore)]
        public Review Review { get; set; }

        /// <summary>
        /// 工作流名称。  若不为空，则使用指定的工作流对上传的音视频进行处理，您可以在视频点播控制台配置工作流，具体请参见[工作流设置](https://support.huaweicloud.com/usermanual-vod/vod010041.html)。
        /// </summary>
        [JsonProperty("workflow_name", NullValueHandling = NullValueHandling.Ignore)]
        public string WorkflowName { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UploadMetaDataByUrl {\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  autoPublish: ").Append(AutoPublish).Append("\n");
            sb.Append("  templateGroupName: ").Append(TemplateGroupName).Append("\n");
            sb.Append("  autoEncrypt: ").Append(AutoEncrypt).Append("\n");
            sb.Append("  autoPreheat: ").Append(AutoPreheat).Append("\n");
            sb.Append("  thumbnail: ").Append(Thumbnail).Append("\n");
            sb.Append("  review: ").Append(Review).Append("\n");
            sb.Append("  workflowName: ").Append(WorkflowName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UploadMetaDataByUrl);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UploadMetaDataByUrl input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VideoType == input.VideoType ||
                    (this.VideoType != null &&
                    this.VideoType.Equals(input.VideoType))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.AutoPublish == input.AutoPublish ||
                    (this.AutoPublish != null &&
                    this.AutoPublish.Equals(input.AutoPublish))
                ) && 
                (
                    this.TemplateGroupName == input.TemplateGroupName ||
                    (this.TemplateGroupName != null &&
                    this.TemplateGroupName.Equals(input.TemplateGroupName))
                ) && 
                (
                    this.AutoEncrypt == input.AutoEncrypt ||
                    (this.AutoEncrypt != null &&
                    this.AutoEncrypt.Equals(input.AutoEncrypt))
                ) && 
                (
                    this.AutoPreheat == input.AutoPreheat ||
                    (this.AutoPreheat != null &&
                    this.AutoPreheat.Equals(input.AutoPreheat))
                ) && 
                (
                    this.Thumbnail == input.Thumbnail ||
                    (this.Thumbnail != null &&
                    this.Thumbnail.Equals(input.Thumbnail))
                ) && 
                (
                    this.Review == input.Review ||
                    (this.Review != null &&
                    this.Review.Equals(input.Review))
                ) && 
                (
                    this.WorkflowName == input.WorkflowName ||
                    (this.WorkflowName != null &&
                    this.WorkflowName.Equals(input.WorkflowName))
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
                if (this.VideoType != null)
                    hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.AutoPublish != null)
                    hashCode = hashCode * 59 + this.AutoPublish.GetHashCode();
                if (this.TemplateGroupName != null)
                    hashCode = hashCode * 59 + this.TemplateGroupName.GetHashCode();
                if (this.AutoEncrypt != null)
                    hashCode = hashCode * 59 + this.AutoEncrypt.GetHashCode();
                if (this.AutoPreheat != null)
                    hashCode = hashCode * 59 + this.AutoPreheat.GetHashCode();
                if (this.Thumbnail != null)
                    hashCode = hashCode * 59 + this.Thumbnail.GetHashCode();
                if (this.Review != null)
                    hashCode = hashCode * 59 + this.Review.GetHashCode();
                if (this.WorkflowName != null)
                    hashCode = hashCode * 59 + this.WorkflowName.GetHashCode();
                return hashCode;
            }
        }
    }
}
