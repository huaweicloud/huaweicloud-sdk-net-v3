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
    /// 知识库召回测试请求。
    /// </summary>
    public class RecallKnowledgeLibraryRequestBody 
    {

        /// <summary>
        /// 知识库名称。
        /// </summary>
        [JsonProperty("knowledge_library_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnowledgeLibraryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("knowledge_type", NullValueHandling = NullValueHandling.Ignore)]
        public KnowledgeTypeEnum KnowledgeType { get; set; }
        /// <summary>
        /// 知识库召回请求文本
        /// </summary>
        [JsonProperty("query", NullValueHandling = NullValueHandling.Ignore)]
        public string Query { get; set; }

        /// <summary>
        /// 文档库召回topk
        /// </summary>
        [JsonProperty("topk", NullValueHandling = NullValueHandling.Ignore)]
        public int? Topk { get; set; }

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
            sb.Append("class RecallKnowledgeLibraryRequestBody {\n");
            sb.Append("  knowledgeLibraryId: ").Append(KnowledgeLibraryId).Append("\n");
            sb.Append("  knowledgeType: ").Append(KnowledgeType).Append("\n");
            sb.Append("  query: ").Append(Query).Append("\n");
            sb.Append("  topk: ").Append(Topk).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecallKnowledgeLibraryRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecallKnowledgeLibraryRequestBody input)
        {
            if (input == null) return false;
            if (this.KnowledgeLibraryId != input.KnowledgeLibraryId || (this.KnowledgeLibraryId != null && !this.KnowledgeLibraryId.Equals(input.KnowledgeLibraryId))) return false;
            if (this.KnowledgeType != input.KnowledgeType) return false;
            if (this.Query != input.Query || (this.Query != null && !this.Query.Equals(input.Query))) return false;
            if (this.Topk != input.Topk || (this.Topk != null && !this.Topk.Equals(input.Topk))) return false;
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
                if (this.KnowledgeLibraryId != null) hashCode = hashCode * 59 + this.KnowledgeLibraryId.GetHashCode();
                hashCode = hashCode * 59 + this.KnowledgeType.GetHashCode();
                if (this.Query != null) hashCode = hashCode * 59 + this.Query.GetHashCode();
                if (this.Topk != null) hashCode = hashCode * 59 + this.Topk.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }
    }
}
