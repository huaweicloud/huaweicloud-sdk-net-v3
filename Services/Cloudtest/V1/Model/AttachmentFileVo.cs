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
    /// 实际的数据类型：单个对象，集合 或 NULL
    /// </summary>
    public class AttachmentFileVo 
    {

        /// <summary>
        /// 附件Uri
        /// </summary>
        [JsonProperty("uri", NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public string Path { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

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
        /// 文档名
        /// </summary>
        [JsonProperty("doc_name", NullValueHandling = NullValueHandling.Ignore)]
        public string DocName { get; set; }

        /// <summary>
        /// 保存文件名
        /// </summary>
        [JsonProperty("store_name", NullValueHandling = NullValueHandling.Ignore)]
        public string StoreName { get; set; }

        /// <summary>
        /// 文档id
        /// </summary>
        [JsonProperty("doc_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DocId { get; set; }

        /// <summary>
        /// 文档大小
        /// </summary>
        [JsonProperty("doc_size", NullValueHandling = NullValueHandling.Ignore)]
        public string DocSize { get; set; }

        /// <summary>
        /// 相关类型
        /// </summary>
        [JsonProperty("related_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelatedType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentFileVo {\n");
            sb.Append("  uri: ").Append(Uri).Append("\n");
            sb.Append("  path: ").Append(Path).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  filePath: ").Append(FilePath).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  docName: ").Append(DocName).Append("\n");
            sb.Append("  storeName: ").Append(StoreName).Append("\n");
            sb.Append("  docId: ").Append(DocId).Append("\n");
            sb.Append("  docSize: ").Append(DocSize).Append("\n");
            sb.Append("  relatedType: ").Append(RelatedType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AttachmentFileVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AttachmentFileVo input)
        {
            if (input == null) return false;
            if (this.Uri != input.Uri || (this.Uri != null && !this.Uri.Equals(input.Uri))) return false;
            if (this.Path != input.Path || (this.Path != null && !this.Path.Equals(input.Path))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.FilePath != input.FilePath || (this.FilePath != null && !this.FilePath.Equals(input.FilePath))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.DocName != input.DocName || (this.DocName != null && !this.DocName.Equals(input.DocName))) return false;
            if (this.StoreName != input.StoreName || (this.StoreName != null && !this.StoreName.Equals(input.StoreName))) return false;
            if (this.DocId != input.DocId || (this.DocId != null && !this.DocId.Equals(input.DocId))) return false;
            if (this.DocSize != input.DocSize || (this.DocSize != null && !this.DocSize.Equals(input.DocSize))) return false;
            if (this.RelatedType != input.RelatedType || (this.RelatedType != null && !this.RelatedType.Equals(input.RelatedType))) return false;

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
                if (this.Uri != null) hashCode = hashCode * 59 + this.Uri.GetHashCode();
                if (this.Path != null) hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.FilePath != null) hashCode = hashCode * 59 + this.FilePath.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.DocName != null) hashCode = hashCode * 59 + this.DocName.GetHashCode();
                if (this.StoreName != null) hashCode = hashCode * 59 + this.StoreName.GetHashCode();
                if (this.DocId != null) hashCode = hashCode * 59 + this.DocId.GetHashCode();
                if (this.DocSize != null) hashCode = hashCode * 59 + this.DocSize.GetHashCode();
                if (this.RelatedType != null) hashCode = hashCode * 59 + this.RelatedType.GetHashCode();
                return hashCode;
            }
        }
    }
}
