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
    public class CreateAssetByFileUploadReq 
    {
        /// <summary>
        /// 封面图片文件类型。  取值如下： - JPG - PNG  上传后的封面名称是固定的，后缀名为封面类型缩写。例如cover0.jpg，cover1.png 若不指定类型，则封面文件无后缀名。  &gt; 如果设置了图片格式，则不会执行首帧截图作为封面动作，需自行上传封面。
        /// </summary>
        /// <value>封面图片文件类型。  取值如下： - JPG - PNG  上传后的封面名称是固定的，后缀名为封面类型缩写。例如cover0.jpg，cover1.png 若不指定类型，则封面文件无后缀名。  &gt; 如果设置了图片格式，则不会执行首帧截图作为封面动作，需自行上传封面。</value>
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

            private string Value;

            public CoverTypeEnum(string value)
            {
                Value = value;
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 是否自动发布。  取值如下： - 0：表示不自动发布。 - 1：表示自动发布。  默认值：0。
        /// </summary>
        /// <value>是否自动发布。  取值如下： - 0：表示不自动发布。 - 1：表示自动发布。  默认值：0。</value>
        [JsonConverter(typeof(EnumClassConverter<AutoPublishEnum>))]
        public class AutoPublishEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AutoPublishEnum NUMBER_0 = new AutoPublishEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AutoPublishEnum NUMBER_1 = new AutoPublishEnum(1);

            private static readonly Dictionary<int?, AutoPublishEnum> StaticFields =
            new Dictionary<int?, AutoPublishEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? Value;

            public AutoPublishEnum(int? value)
            {
                Value = value;
            }

            public static AutoPublishEnum FromValue(int? value)
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

            public int? GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as AutoPublishEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AutoPublishEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(AutoPublishEnum a, AutoPublishEnum b)
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

            public static bool operator !=(AutoPublishEnum a, AutoPublishEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 媒资标题，长度不超过128个字节，UTF-8编码。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 视频描述，长度不超过1024个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 音视频文件名，长度不超过128个字节。  文件名后缀可选。
        /// </summary>
        [JsonProperty("video_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoName { get; set; }

        /// <summary>
        /// 上传音视频文件的格式。  取值如下： - 视频文件：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV、HLS - 音频文件：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2  若上传格式为音频文件，则不支持转码、添加水印和字幕。
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoType { get; set; }

        /// <summary>
        /// 媒资分类ID。  您可以调用[创建媒资分类](https://support.huaweicloud.com/api-vod/vod_04_0028.html)接口或在点播控制台的[分类设置](https://support.huaweicloud.com/usermanual-vod/vod010006.html)中创建对应的媒资分类，并获取分类ID。  &gt; 若不设置或者设置为-1，则上传的音视频归类到系统预置的“其它”分类中。
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 视频文件MD5值。  建议参考[媒资上传和更新](https://support.huaweicloud.com/api-vod/vod_04_0212.html)生成对应的MD5值。
        /// </summary>
        [JsonProperty("video_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoMd5 { get; set; }

        /// <summary>
        /// 封面图片文件类型。  取值如下： - JPG - PNG  上传后的封面名称是固定的，后缀名为封面类型缩写。例如cover0.jpg，cover1.png 若不指定类型，则封面文件无后缀名。  &gt; 如果设置了图片格式，则不会执行首帧截图作为封面动作，需自行上传封面。
        /// </summary>
        [JsonProperty("cover_type", NullValueHandling = NullValueHandling.Ignore)]
        public CoverTypeEnum CoverType { get; set; }
        /// <summary>
        /// 封面文件MD5值
        /// </summary>
        [JsonProperty("cover_md5", NullValueHandling = NullValueHandling.Ignore)]
        public string CoverMd5 { get; set; }

        /// <summary>
        /// 字幕文件信息
        /// </summary>
        [JsonProperty("subtitles", NullValueHandling = NullValueHandling.Ignore)]
        public List<Subtitle> Subtitles { get; set; }

        /// <summary>
        /// 视频标签。  单个标签不超过16个字节，最多不超过16个标签。  多个用逗号分隔，UTF8编码。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 是否自动发布。  取值如下： - 0：表示不自动发布。 - 1：表示自动发布。  默认值：0。
        /// </summary>
        [JsonProperty("auto_publish", NullValueHandling = NullValueHandling.Ignore)]
        public AutoPublishEnum AutoPublish { get; set; }
        /// <summary>
        /// 转码模板组名称。  若不为空，则使用指定的转码模板对上传的音视频进行转码，您可以在视频点播控制台配置转码模板，具体请参见[转码设置](https://support.huaweicloud.com/usermanual-vod/vod_01_0072.html)。  &gt; 若同时设置了“**template_group_name**”和“**workflow_name**”字段，则“**template_group_name**”字段生效。
        /// </summary>
        [JsonProperty("template_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateGroupName { get; set; }

        /// <summary>
        /// 是否自动加密。  取值如下： - 0：表示不加密。 - 1：表示需要加密。  默认值：0。  加密与转码必须要一起进行，当需要加密时，转码参数不能为空，且转码输出格式必须要为HLS。
        /// </summary>
        [JsonProperty("auto_encrypt", NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoEncrypt { get; set; }

        /// <summary>
        /// 是否自动预热到CDN。  取值如下： - 0：表示不自动预热。 - 1：表示自动预热。  默认值：0。
        /// </summary>
        [JsonProperty("auto_preheat", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoPreheat { get; set; }

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
            sb.Append("class CreateAssetByFileUploadReq {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  videoName: ").Append(VideoName).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  videoMd5: ").Append(VideoMd5).Append("\n");
            sb.Append("  coverType: ").Append(CoverType).Append("\n");
            sb.Append("  coverMd5: ").Append(CoverMd5).Append("\n");
            sb.Append("  subtitles: ").Append(Subtitles).Append("\n");
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
            return this.Equals(input as CreateAssetByFileUploadReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateAssetByFileUploadReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.VideoName == input.VideoName ||
                    (this.VideoName != null &&
                    this.VideoName.Equals(input.VideoName))
                ) && 
                (
                    this.VideoType == input.VideoType ||
                    (this.VideoType != null &&
                    this.VideoType.Equals(input.VideoType))
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.VideoMd5 == input.VideoMd5 ||
                    (this.VideoMd5 != null &&
                    this.VideoMd5.Equals(input.VideoMd5))
                ) && 
                (
                    this.CoverType == input.CoverType ||
                    (this.CoverType != null &&
                    this.CoverType.Equals(input.CoverType))
                ) && 
                (
                    this.CoverMd5 == input.CoverMd5 ||
                    (this.CoverMd5 != null &&
                    this.CoverMd5.Equals(input.CoverMd5))
                ) && 
                (
                    this.Subtitles == input.Subtitles ||
                    this.Subtitles != null &&
                    input.Subtitles != null &&
                    this.Subtitles.SequenceEqual(input.Subtitles)
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.VideoName != null)
                    hashCode = hashCode * 59 + this.VideoName.GetHashCode();
                if (this.VideoType != null)
                    hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.VideoMd5 != null)
                    hashCode = hashCode * 59 + this.VideoMd5.GetHashCode();
                if (this.CoverType != null)
                    hashCode = hashCode * 59 + this.CoverType.GetHashCode();
                if (this.CoverMd5 != null)
                    hashCode = hashCode * 59 + this.CoverMd5.GetHashCode();
                if (this.Subtitles != null)
                    hashCode = hashCode * 59 + this.Subtitles.GetHashCode();
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
