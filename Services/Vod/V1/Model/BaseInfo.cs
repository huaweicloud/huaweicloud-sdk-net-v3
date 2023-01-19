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
    /// 媒资基本信息。
    /// </summary>
    public class BaseInfo 
    {

        /// <summary>
        /// 媒资标题。  长度不超过128个字节，UTF8编码。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 媒资文件名。
        /// </summary>
        [JsonProperty("video_name", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoName { get; set; }

        /// <summary>
        /// 媒资描述。  长度不超过1024个字节。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 媒资分类id。
        /// </summary>
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? CategoryId { get; set; }

        /// <summary>
        /// 媒资分类名称。
        /// </summary>
        [JsonProperty("category_name", NullValueHandling = NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// 媒资创建时间。  格式为yyyymmddhhmmss。必须是与时区无关的UTC时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 媒资最近修改时间。  格式为yyyymmddhhmmss。必须是与时区无关的UTC时间。
        /// </summary>
        [JsonProperty("last_modified", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModified { get; set; }

        /// <summary>
        /// 音视频文件类型。  取值如下： - 视频文件：MP4、TS、MOV、MXF、MPG、FLV、WMV、AVI、M4V、F4V、MPEG、3GP、ASF、MKV。 - 音频文件：MP3、OGG、WAV、WMA、APE、FLAC、AAC、AC3、MMF、AMR、M4A、M4R、WV、MP2。
        /// </summary>
        [JsonProperty("video_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoType { get; set; }

        /// <summary>
        /// 媒资标签。  单个标签不超过16个字节，最多不超过16个标签。  多个用逗号分隔，UTF8编码。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("meta_data", NullValueHandling = NullValueHandling.Ignore)]
        public MetaData MetaData { get; set; }

        /// <summary>
        /// 原始视频文件的访问地址。
        /// </summary>
        [JsonProperty("video_url", NullValueHandling = NullValueHandling.Ignore)]
        public string VideoUrl { get; set; }

        /// <summary>
        /// 原视频文件的OBS临时访问地址,仅媒资详情接口生效
        /// </summary>
        [JsonProperty("sign_url", NullValueHandling = NullValueHandling.Ignore)]
        public string SignUrl { get; set; }

        /// <summary>
        /// 封面信息。
        /// </summary>
        [JsonProperty("cover_info_array", NullValueHandling = NullValueHandling.Ignore)]
        public List<CoverInfo> CoverInfoArray { get; set; }

        /// <summary>
        /// 字幕信息数组
        /// </summary>
        [JsonProperty("subtitle_info", NullValueHandling = NullValueHandling.Ignore)]
        public List<SubtitleInfo> SubtitleInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("source_path", NullValueHandling = NullValueHandling.Ignore)]
        public FileAddr SourcePath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("output_path", NullValueHandling = NullValueHandling.Ignore)]
        public FileAddr OutputPath { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseInfo {\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  videoName: ").Append(VideoName).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  categoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  categoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastModified: ").Append(LastModified).Append("\n");
            sb.Append("  videoType: ").Append(VideoType).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  metaData: ").Append(MetaData).Append("\n");
            sb.Append("  videoUrl: ").Append(VideoUrl).Append("\n");
            sb.Append("  signUrl: ").Append(SignUrl).Append("\n");
            sb.Append("  coverInfoArray: ").Append(CoverInfoArray).Append("\n");
            sb.Append("  subtitleInfo: ").Append(SubtitleInfo).Append("\n");
            sb.Append("  sourcePath: ").Append(SourcePath).Append("\n");
            sb.Append("  outputPath: ").Append(OutputPath).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseInfo input)
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
                    this.VideoName == input.VideoName ||
                    (this.VideoName != null &&
                    this.VideoName.Equals(input.VideoName))
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
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.VideoType == input.VideoType ||
                    (this.VideoType != null &&
                    this.VideoType.Equals(input.VideoType))
                ) && 
                (
                    this.Tags == input.Tags ||
                    (this.Tags != null &&
                    this.Tags.Equals(input.Tags))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
                ) && 
                (
                    this.VideoUrl == input.VideoUrl ||
                    (this.VideoUrl != null &&
                    this.VideoUrl.Equals(input.VideoUrl))
                ) && 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
                ) && 
                (
                    this.CoverInfoArray == input.CoverInfoArray ||
                    this.CoverInfoArray != null &&
                    input.CoverInfoArray != null &&
                    this.CoverInfoArray.SequenceEqual(input.CoverInfoArray)
                ) && 
                (
                    this.SubtitleInfo == input.SubtitleInfo ||
                    this.SubtitleInfo != null &&
                    input.SubtitleInfo != null &&
                    this.SubtitleInfo.SequenceEqual(input.SubtitleInfo)
                ) && 
                (
                    this.SourcePath == input.SourcePath ||
                    (this.SourcePath != null &&
                    this.SourcePath.Equals(input.SourcePath))
                ) && 
                (
                    this.OutputPath == input.OutputPath ||
                    (this.OutputPath != null &&
                    this.OutputPath.Equals(input.OutputPath))
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
                if (this.VideoName != null)
                    hashCode = hashCode * 59 + this.VideoName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.VideoType != null)
                    hashCode = hashCode * 59 + this.VideoType.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
                if (this.VideoUrl != null)
                    hashCode = hashCode * 59 + this.VideoUrl.GetHashCode();
                if (this.SignUrl != null)
                    hashCode = hashCode * 59 + this.SignUrl.GetHashCode();
                if (this.CoverInfoArray != null)
                    hashCode = hashCode * 59 + this.CoverInfoArray.GetHashCode();
                if (this.SubtitleInfo != null)
                    hashCode = hashCode * 59 + this.SubtitleInfo.GetHashCode();
                if (this.SourcePath != null)
                    hashCode = hashCode * 59 + this.SourcePath.GetHashCode();
                if (this.OutputPath != null)
                    hashCode = hashCode * 59 + this.OutputPath.GetHashCode();
                return hashCode;
            }
        }
    }
}
