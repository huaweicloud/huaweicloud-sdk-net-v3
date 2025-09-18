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
    /// 知识库基本信息。
    /// </summary>
    public class KnowledgeLibraryInfo 
    {

        /// <summary>
        /// 知识库ID。
        /// </summary>
        [JsonProperty("knowledge_library_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KnowledgeLibraryId { get; set; }

        /// <summary>
        /// 知识库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum? Language { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("knowledge_type", NullValueHandling = NullValueHandling.Ignore)]
        public KnowledgeTypeEnum? KnowledgeType { get; set; }

        /// <summary>
        /// 知识库大小(文档库为文档数量)
        /// </summary>
        [JsonProperty("knowledge_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? KnowledgeSize { get; set; }

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
        /// 创建时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 更新时间，格式遵循：RFC 3339 如\&quot;2021-01-10T08:43:17Z\&quot;。
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeLibraryInfo {\n");
            sb.Append("  knowledgeLibraryId: ").Append(KnowledgeLibraryId).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  knowledgeType: ").Append(KnowledgeType).Append("\n");
            sb.Append("  knowledgeSize: ").Append(KnowledgeSize).Append("\n");
            sb.Append("  topk: ").Append(Topk).Append("\n");
            sb.Append("  score: ").Append(Score).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KnowledgeLibraryInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KnowledgeLibraryInfo input)
        {
            if (input == null) return false;
            if (this.KnowledgeLibraryId != input.KnowledgeLibraryId || (this.KnowledgeLibraryId != null && !this.KnowledgeLibraryId.Equals(input.KnowledgeLibraryId))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.KnowledgeType != input.KnowledgeType || (this.KnowledgeType != null && !this.KnowledgeType.Equals(input.KnowledgeType))) return false;
            if (this.KnowledgeSize != input.KnowledgeSize || (this.KnowledgeSize != null && !this.KnowledgeSize.Equals(input.KnowledgeSize))) return false;
            if (this.Topk != input.Topk || (this.Topk != null && !this.Topk.Equals(input.Topk))) return false;
            if (this.Score != input.Score || (this.Score != null && !this.Score.Equals(input.Score))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.KnowledgeType != null) hashCode = hashCode * 59 + this.KnowledgeType.GetHashCode();
                if (this.KnowledgeSize != null) hashCode = hashCode * 59 + this.KnowledgeSize.GetHashCode();
                if (this.Topk != null) hashCode = hashCode * 59 + this.Topk.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
