using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMeetingFileResponse : SdkResponse
    {

        /// <summary>
        /// 会议纪要文件码。
        /// </summary>
        [JsonProperty("fileCode", NullValueHandling = NullValueHandling.Ignore)]
        public string FileCode { get; set; }

        /// <summary>
        /// 文件主题。
        /// </summary>
        [JsonProperty("topic", NullValueHandling = NullValueHandling.Ignore)]
        public string Topic { get; set; }

        /// <summary>
        /// 文件Id。
        /// </summary>
        [JsonProperty("fileId", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// 文件名。
        /// </summary>
        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件大小，单位字节。
        /// </summary>
        [JsonProperty("fileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 缩略图文件Id。
        /// </summary>
        [JsonProperty("thumbnailFileId", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailFileId { get; set; }

        /// <summary>
        /// 缩略图文件名。
        /// </summary>
        [JsonProperty("thumbnailFileName", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailFileName { get; set; }

        /// <summary>
        /// 缩略图文件大小，单位字节。
        /// </summary>
        [JsonProperty("thumbnailFileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? ThumbnailFileSize { get; set; }

        /// <summary>
        /// pdf文件Id。
        /// </summary>
        [JsonProperty("pdfFileId", NullValueHandling = NullValueHandling.Ignore)]
        public string PdfFileId { get; set; }

        /// <summary>
        /// pdf文件名。
        /// </summary>
        [JsonProperty("pdfFileName", NullValueHandling = NullValueHandling.Ignore)]
        public string PdfFileName { get; set; }

        /// <summary>
        /// pdf文件大小，单位字节。
        /// </summary>
        [JsonProperty("pdfFileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? PdfFileSize { get; set; }

        /// <summary>
        /// 文件url。
        /// </summary>
        [JsonProperty("fileUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUrl { get; set; }

        /// <summary>
        /// 缩略图文件url。
        /// </summary>
        [JsonProperty("thumbnailUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// pdf文件url。
        /// </summary>
        [JsonProperty("pdfUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 文件创建时间戳。
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreationTimestamp { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMeetingFileResponse {\n");
            sb.Append("  fileCode: ").Append(FileCode).Append("\n");
            sb.Append("  topic: ").Append(Topic).Append("\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  thumbnailFileId: ").Append(ThumbnailFileId).Append("\n");
            sb.Append("  thumbnailFileName: ").Append(ThumbnailFileName).Append("\n");
            sb.Append("  thumbnailFileSize: ").Append(ThumbnailFileSize).Append("\n");
            sb.Append("  pdfFileId: ").Append(PdfFileId).Append("\n");
            sb.Append("  pdfFileName: ").Append(PdfFileName).Append("\n");
            sb.Append("  pdfFileSize: ").Append(PdfFileSize).Append("\n");
            sb.Append("  fileUrl: ").Append(FileUrl).Append("\n");
            sb.Append("  thumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  pdfUrl: ").Append(PdfUrl).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMeetingFileResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMeetingFileResponse input)
        {
            if (input == null) return false;
            if (this.FileCode != input.FileCode || (this.FileCode != null && !this.FileCode.Equals(input.FileCode))) return false;
            if (this.Topic != input.Topic || (this.Topic != null && !this.Topic.Equals(input.Topic))) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.ThumbnailFileId != input.ThumbnailFileId || (this.ThumbnailFileId != null && !this.ThumbnailFileId.Equals(input.ThumbnailFileId))) return false;
            if (this.ThumbnailFileName != input.ThumbnailFileName || (this.ThumbnailFileName != null && !this.ThumbnailFileName.Equals(input.ThumbnailFileName))) return false;
            if (this.ThumbnailFileSize != input.ThumbnailFileSize || (this.ThumbnailFileSize != null && !this.ThumbnailFileSize.Equals(input.ThumbnailFileSize))) return false;
            if (this.PdfFileId != input.PdfFileId || (this.PdfFileId != null && !this.PdfFileId.Equals(input.PdfFileId))) return false;
            if (this.PdfFileName != input.PdfFileName || (this.PdfFileName != null && !this.PdfFileName.Equals(input.PdfFileName))) return false;
            if (this.PdfFileSize != input.PdfFileSize || (this.PdfFileSize != null && !this.PdfFileSize.Equals(input.PdfFileSize))) return false;
            if (this.FileUrl != input.FileUrl || (this.FileUrl != null && !this.FileUrl.Equals(input.FileUrl))) return false;
            if (this.ThumbnailUrl != input.ThumbnailUrl || (this.ThumbnailUrl != null && !this.ThumbnailUrl.Equals(input.ThumbnailUrl))) return false;
            if (this.PdfUrl != input.PdfUrl || (this.PdfUrl != null && !this.PdfUrl.Equals(input.PdfUrl))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;

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
                if (this.FileCode != null) hashCode = hashCode * 59 + this.FileCode.GetHashCode();
                if (this.Topic != null) hashCode = hashCode * 59 + this.Topic.GetHashCode();
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.ThumbnailFileId != null) hashCode = hashCode * 59 + this.ThumbnailFileId.GetHashCode();
                if (this.ThumbnailFileName != null) hashCode = hashCode * 59 + this.ThumbnailFileName.GetHashCode();
                if (this.ThumbnailFileSize != null) hashCode = hashCode * 59 + this.ThumbnailFileSize.GetHashCode();
                if (this.PdfFileId != null) hashCode = hashCode * 59 + this.PdfFileId.GetHashCode();
                if (this.PdfFileName != null) hashCode = hashCode * 59 + this.PdfFileName.GetHashCode();
                if (this.PdfFileSize != null) hashCode = hashCode * 59 + this.PdfFileSize.GetHashCode();
                if (this.FileUrl != null) hashCode = hashCode * 59 + this.FileUrl.GetHashCode();
                if (this.ThumbnailUrl != null) hashCode = hashCode * 59 + this.ThumbnailUrl.GetHashCode();
                if (this.PdfUrl != null) hashCode = hashCode * 59 + this.PdfUrl.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                return hashCode;
            }
        }
    }
}
