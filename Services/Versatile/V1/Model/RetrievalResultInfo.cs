using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Versatile.V1.Model
{
    /// <summary>
    /// 检索结果。
    /// </summary>
    public class RetrievalResultInfo 
    {

        /// <summary>
        /// **参数解释**： 文件ID（或FAQ ID）。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        /// <summary>
        /// **参数解释**： 文档标题（如果是FAQ，返回QUESTION）。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// **参数解释**： 分片ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("chunk_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ChunkId { get; set; }

        /// <summary>
        /// **参数解释**： 文本内容（如果是FAQ，返回ANSWER）。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// **参数解释**： 相似度。  **取值范围**： [0.0, 1.0]，包含两端。
        /// </summary>
        [JsonProperty("similarity", NullValueHandling = NullValueHandling.Ignore)]
        public float? Similarity { get; set; }

        /// <summary>
        /// **参数解释**： 知识库ID。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("knowledge_base_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// **参数解释**： 检索到的图片列表（需知识库支持），与content中的图片占位符{KI|N}保持一一对应关系，N为图片索引值，从0开始。  **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("image_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ImageIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetrievalResultInfo {\n");
            sb.Append("  fileId: ").Append(FileId).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  chunkId: ").Append(ChunkId).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  similarity: ").Append(Similarity).Append("\n");
            sb.Append("  knowledgeBaseId: ").Append(KnowledgeBaseId).Append("\n");
            sb.Append("  imageIds: ").Append(ImageIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RetrievalResultInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RetrievalResultInfo input)
        {
            if (input == null) return false;
            if (this.FileId != input.FileId || (this.FileId != null && !this.FileId.Equals(input.FileId))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.ChunkId != input.ChunkId || (this.ChunkId != null && !this.ChunkId.Equals(input.ChunkId))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Similarity != input.Similarity || (this.Similarity != null && !this.Similarity.Equals(input.Similarity))) return false;
            if (this.KnowledgeBaseId != input.KnowledgeBaseId || (this.KnowledgeBaseId != null && !this.KnowledgeBaseId.Equals(input.KnowledgeBaseId))) return false;
            if (this.ImageIds != input.ImageIds || (this.ImageIds != null && input.ImageIds != null && !this.ImageIds.SequenceEqual(input.ImageIds))) return false;

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
                if (this.FileId != null) hashCode = hashCode * 59 + this.FileId.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.ChunkId != null) hashCode = hashCode * 59 + this.ChunkId.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Similarity != null) hashCode = hashCode * 59 + this.Similarity.GetHashCode();
                if (this.KnowledgeBaseId != null) hashCode = hashCode * 59 + this.KnowledgeBaseId.GetHashCode();
                if (this.ImageIds != null) hashCode = hashCode * 59 + this.ImageIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
