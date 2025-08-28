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
    /// 创建知识库请求。
    /// </summary>
    public class CreateKnowledgeLibraryReq 
    {

        /// <summary>
        /// 知识库名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public LanguageEnum Language { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("knowledge_type", NullValueHandling = NullValueHandling.Ignore)]
        public KnowledgeTypeEnum KnowledgeType { get; set; }
        /// <summary>
        /// 知识库召回数
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
            sb.Append("class CreateKnowledgeLibraryReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  knowledgeType: ").Append(KnowledgeType).Append("\n");
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
            return this.Equals(input as CreateKnowledgeLibraryReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateKnowledgeLibraryReq input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Language != input.Language) return false;
            if (this.KnowledgeType != input.KnowledgeType) return false;
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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Language.GetHashCode();
                hashCode = hashCode * 59 + this.KnowledgeType.GetHashCode();
                if (this.Topk != null) hashCode = hashCode * 59 + this.Topk.GetHashCode();
                if (this.Score != null) hashCode = hashCode * 59 + this.Score.GetHashCode();
                return hashCode;
            }
        }
    }
}
