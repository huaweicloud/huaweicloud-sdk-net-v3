using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 附件信息
    /// </summary>
    public class AttachmentInfo 
    {

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("doc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocId { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("file_path", NullValueHandling = NullValueHandling.Ignore)]
        public string FilePath { get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 保存文件名
        /// </summary>
        [JsonProperty("store_file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreFileName { get; set; }

        /// <summary>
        /// 附件类型 0 本地上传  other 关联文档
        /// </summary>
        [JsonProperty("related_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedType { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? FileSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentInfo {\n");
            sb.Append("  docId: ").Append(DocId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  storeFileName: ").Append(StoreFileName).Append("\n");
            sb.Append("  relatedType: ").Append(RelatedType).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentInfo input)
        {
            if (input == null) return false;
            if (this.DocId != input.DocId || (this.DocId != null && !this.DocId.Equals(input.DocId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.StoreFileName != input.StoreFileName || (this.StoreFileName != null && !this.StoreFileName.Equals(input.StoreFileName))) return false;
            if (this.RelatedType != input.RelatedType || (this.RelatedType != null && !this.RelatedType.Equals(input.RelatedType))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;

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
                if (this.DocId != null) hashCode = hashCode * 59 + this.DocId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.StoreFileName != null) hashCode = hashCode * 59 + this.StoreFileName.GetHashCode();
                if (this.RelatedType != null) hashCode = hashCode * 59 + this.RelatedType.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
