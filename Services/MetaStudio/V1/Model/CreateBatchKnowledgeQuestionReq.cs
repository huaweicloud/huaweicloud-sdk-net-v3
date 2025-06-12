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
    /// 批量创建知识库问法请求。
    /// </summary>
    public class CreateBatchKnowledgeQuestionReq 
    {

        /// <summary>
        /// 意图ID。
        /// </summary>
        [JsonProperty("intent_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IntentId { get; set; }

        /// <summary>
        /// 问法列表
        /// </summary>
        [JsonProperty("question_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<KnowledgeQuestionCreateInfo> QuestionList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateBatchKnowledgeQuestionReq {\n");
            sb.Append("  intentId: ").Append(IntentId).Append("\n");
            sb.Append("  questionList: ").Append(QuestionList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateBatchKnowledgeQuestionReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateBatchKnowledgeQuestionReq input)
        {
            if (input == null) return false;
            if (this.IntentId != input.IntentId || (this.IntentId != null && !this.IntentId.Equals(input.IntentId))) return false;
            if (this.QuestionList != input.QuestionList || (this.QuestionList != null && input.QuestionList != null && !this.QuestionList.SequenceEqual(input.QuestionList))) return false;

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
                if (this.IntentId != null) hashCode = hashCode * 59 + this.IntentId.GetHashCode();
                if (this.QuestionList != null) hashCode = hashCode * 59 + this.QuestionList.GetHashCode();
                return hashCode;
            }
        }
    }
}
