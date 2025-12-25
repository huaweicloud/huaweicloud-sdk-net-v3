using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CreateDocumentResponse : SdkResponse
    {

        /// <summary>
        /// 文档ID。
        /// </summary>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }

        /// <summary>
        /// 知识库ID。
        /// </summary>
        [JsonProperty("knowledge_library_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnowledgeLibraryId { get; set; }

        /// <summary>
        /// 文档名称。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文档大小，单位字节
        /// </summary>
        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        /// <summary>
        /// 文档类型。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 分段类型 * 1: 自动分段 * 2: 手动分段
        /// </summary>
        [JsonProperty("split_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? SplitType { get; set; }

        /// <summary>
        /// 分段长度。
        /// </summary>
        [JsonProperty("chunk_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? ChunkSize { get; set; }

        /// <summary>
        /// 分段策略，如果添加多个策略用逗号隔开。 取值示例： - title：用标题把一段话分割为多个段落。 - separator：用分隔符把一段话分割为多个段落。
        /// </summary>
        [JsonProperty("chunk_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ChunkType { get; set; }

        /// <summary>
        /// 分隔符
        /// </summary>
        [JsonProperty("separators", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Separators { get; set; }

        /// <summary>
        /// 文档创建时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 文档更新时间。格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("document_task_info", NullValueHandling = NullValueHandling.Ignore)]
        public DocumentTaskInfo DocumentTaskInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDocumentResponse {\n");
            sb.Append("  documentId: ").Append(DocumentId).Append("\n");
            sb.Append("  knowledgeLibraryId: ").Append(KnowledgeLibraryId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileSize: ").Append(FileSize).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  splitType: ").Append(SplitType).Append("\n");
            sb.Append("  chunkSize: ").Append(ChunkSize).Append("\n");
            sb.Append("  chunkType: ").Append(ChunkType).Append("\n");
            sb.Append("  separators: ").Append(Separators).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  documentTaskInfo: ").Append(DocumentTaskInfo).Append("\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateDocumentResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateDocumentResponse input)
        {
            if (input == null) return false;
            if (this.DocumentId != input.DocumentId || (this.DocumentId != null && !this.DocumentId.Equals(input.DocumentId))) return false;
            if (this.KnowledgeLibraryId != input.KnowledgeLibraryId || (this.KnowledgeLibraryId != null && !this.KnowledgeLibraryId.Equals(input.KnowledgeLibraryId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileSize != input.FileSize || (this.FileSize != null && !this.FileSize.Equals(input.FileSize))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.SplitType != input.SplitType || (this.SplitType != null && !this.SplitType.Equals(input.SplitType))) return false;
            if (this.ChunkSize != input.ChunkSize || (this.ChunkSize != null && !this.ChunkSize.Equals(input.ChunkSize))) return false;
            if (this.ChunkType != input.ChunkType || (this.ChunkType != null && !this.ChunkType.Equals(input.ChunkType))) return false;
            if (this.Separators != input.Separators || (this.Separators != null && input.Separators != null && !this.Separators.SequenceEqual(input.Separators))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.DocumentTaskInfo != input.DocumentTaskInfo || (this.DocumentTaskInfo != null && !this.DocumentTaskInfo.Equals(input.DocumentTaskInfo))) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;

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
                if (this.DocumentId != null) hashCode = hashCode * 59 + this.DocumentId.GetHashCode();
                if (this.KnowledgeLibraryId != null) hashCode = hashCode * 59 + this.KnowledgeLibraryId.GetHashCode();
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileSize != null) hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.SplitType != null) hashCode = hashCode * 59 + this.SplitType.GetHashCode();
                if (this.ChunkSize != null) hashCode = hashCode * 59 + this.ChunkSize.GetHashCode();
                if (this.ChunkType != null) hashCode = hashCode * 59 + this.ChunkType.GetHashCode();
                if (this.Separators != null) hashCode = hashCode * 59 + this.Separators.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.DocumentTaskInfo != null) hashCode = hashCode * 59 + this.DocumentTaskInfo.GetHashCode();
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
