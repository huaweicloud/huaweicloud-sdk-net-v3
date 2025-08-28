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
    /// 知识库召回测试响应。
    /// </summary>
    public class RecallKnowledgeLibraryInfo 
    {

        /// <summary>
        /// 文档ID。
        /// </summary>
        [JsonProperty("document_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DocumentId { get; set; }

        /// <summary>
        /// 文档名称。
        /// </summary>
        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        /// <summary>
        /// 文档类型。
        /// </summary>
        [JsonProperty("file_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FileType { get; set; }

        /// <summary>
        /// 问答对ID。
        /// </summary>
        [JsonProperty("question_answer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionAnswerId { get; set; }

        /// <summary>
        /// 召回文本
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 知识库召回得分
        /// </summary>
        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecallKnowledgeLibraryInfo {\n");
            sb.Append("  documentId: ").Append(DocumentId).Append("\n");
            sb.Append("  fileName: ").Append(FileName).Append("\n");
            sb.Append("  fileType: ").Append(FileType).Append("\n");
            sb.Append("  questionAnswerId: ").Append(QuestionAnswerId).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecallKnowledgeLibraryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecallKnowledgeLibraryInfo input)
        {
            if (input == null) return false;
            if (this.DocumentId != input.DocumentId || (this.DocumentId != null && !this.DocumentId.Equals(input.DocumentId))) return false;
            if (this.FileName != input.FileName || (this.FileName != null && !this.FileName.Equals(input.FileName))) return false;
            if (this.FileType != input.FileType || (this.FileType != null && !this.FileType.Equals(input.FileType))) return false;
            if (this.QuestionAnswerId != input.QuestionAnswerId || (this.QuestionAnswerId != null && !this.QuestionAnswerId.Equals(input.QuestionAnswerId))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;

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
                if (this.FileName != null) hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.FileType != null) hashCode = hashCode * 59 + this.FileType.GetHashCode();
                if (this.QuestionAnswerId != null) hashCode = hashCode * 59 + this.QuestionAnswerId.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }
    }
}
