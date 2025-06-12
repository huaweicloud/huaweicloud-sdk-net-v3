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
    /// 修改知识库问法请求。
    /// </summary>
    public class KnowledgeQuestionUpdateInfo 
    {

        /// <summary>
        /// 问法ID。
        /// </summary>
        [JsonProperty("question_id", NullValueHandling = NullValueHandling.Ignore)]
        public string QuestionId { get; set; }

        /// <summary>
        /// 问法。
        /// </summary>
        [JsonProperty("question", NullValueHandling = NullValueHandling.Ignore)]
        public string Question { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KnowledgeQuestionUpdateInfo {\n");
            sb.Append("  questionId: ").Append(QuestionId).Append("\n");
            sb.Append("  question: ").Append(Question).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KnowledgeQuestionUpdateInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KnowledgeQuestionUpdateInfo input)
        {
            if (input == null) return false;
            if (this.QuestionId != input.QuestionId || (this.QuestionId != null && !this.QuestionId.Equals(input.QuestionId))) return false;
            if (this.Question != input.Question || (this.Question != null && !this.Question.Equals(input.Question))) return false;

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
                if (this.QuestionId != null) hashCode = hashCode * 59 + this.QuestionId.GetHashCode();
                if (this.Question != null) hashCode = hashCode * 59 + this.Question.GetHashCode();
                return hashCode;
            }
        }
    }
}
